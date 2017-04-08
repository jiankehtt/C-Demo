using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using RfidApiLib;  // 修改，去掉这个引用，同时在解决方案的引用栏中删除这个库的引用。

namespace Demo
{
    public partial class Form1 : Form
    {
        DesktopRfidApi.RfidApi Api = new DesktopRfidApi.RfidApi();
        //RfidApi Api = new RfidApi();
        public byte IsoReading = 0;
        public byte EpcReading = 0;
        public int TagCnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cCommPort.SelectedIndex = 0;
            cBaudrate.SelectedIndex = 0;
            bRs232Con.Enabled = true;
            bRs232Discon.Enabled = false;
            

            bEpcId.Enabled = false;
            bEpcRead.Enabled = false;
            bEpcWrite.Enabled = false;
            bEpcKill.Enabled = false;
            bEpcInit.Enabled = false;

            cEpcTimes.SelectedIndex = 0;

            cEpcMembank.SelectedIndex = 1;
            int nLoop = 0;
            for (nLoop = 0; nLoop < 256; nLoop++)
                cEpcWordptr.Items.Add(Convert.ToString(nLoop));
            cEpcWordptr.SelectedIndex = 2;
            for (nLoop = 1; nLoop < 14; nLoop++)
                cEpcWordcnt.Items.Add(Convert.ToString(nLoop));
            cEpcWordcnt.SelectedIndex = 5;
        }

        private void bRs232Con_Click(object sender, EventArgs e)
        {
            int status;
            byte v1 = 0;
            byte v2 = 0;
            string s = "";
            for(int i = 0; i < 10; i++)
            {
                status = Api.OpenCommPort(cCommPort.SelectedItem.ToString());
                //status = Api.OpenCommPort("COM9");
                if (status != 0)
                {
                    lInfo.Items.Add("Open Comm Port Failed!");
                    continue;
                }
                status = Api.GetFirmwareVersion(ref v1,ref v2);
                if (status != 0)
                {
                    lInfo.Items.Add("Can not connect with the reader!");
                    Api.CloseCommPort();
                    continue;
                }
                lInfo.Items.Add("Connect the reader success!");
                s = string.Format("The reader's firmware version is:V{0:d2}.{1:d2}", v1, v2);
                lInfo.Items.Add(s);
                 break;
          }

    
            bRs232Con.Enabled = false;
            bRs232Discon.Enabled = true;

            bEpcId.Enabled = true;
            bEpcRead.Enabled = true;
            bEpcWrite.Enabled = true;
            bEpcInit.Enabled = true;
            bEpcKill.Enabled = false;
 

        }

        private void bRs232Discon_Click(object sender, EventArgs e)
        {
            Api.CloseCommPort();
            bRs232Con.Enabled = true;
            bRs232Discon.Enabled = false;
        

            bEpcId.Enabled = false;
            bEpcRead.Enabled = false;
            bEpcWrite.Enabled = false;
            bEpcKill.Enabled = false;
            bEpcInit.Enabled = false;
        }

     


  

   

     
       

        private void bEpcRead_Click(object sender, EventArgs e)
        {
            int membank;
            int wordptr;
            int wordcnt;
            int status = 0;
            byte[] value = new byte[16];

            string s = "The data is:";
            string s1 = "";

            membank = cEpcMembank.SelectedIndex;
            wordptr = cEpcWordptr.SelectedIndex;
            wordcnt = cEpcWordcnt.SelectedIndex + 1;

            status = Api.EpcRead((byte)membank, (byte)wordptr, (byte)wordcnt, ref value);

            if (status != 0)
            {
                lInfo.Items.Add("Read failed!");
                return;
            }
            else
            {
                for (int i = 0; i < wordcnt * 2; i++)
                {
                    s1 = string.Format("{0:X2}", value[i]);
                    s += s1;
                }
                lInfo.Items.Add("Read success!");
                lInfo.Items.Add(s);
            }
        }

       

        private void bEpcInit_Click(object sender, EventArgs e)
        {
            int status;

            status = Api.EpcInitEpc(96);

            if (status == 0)
            {
                lInfo.Items.Add("Init tag success!");
            }
            else
            {
                lInfo.Items.Add("Init tag failed!");
            }
        }

        private void bEpcWrite_Click(object sender, EventArgs e)
        {
            ushort[] value = new ushort[16];
            int i = 0;
            byte membank;
            byte wordptr;
            byte wordcnt;
            int status;
            string hexValues;

            membank = (byte)(cEpcMembank.SelectedIndex);
            wordptr = (byte)(cEpcWordptr.SelectedIndex);
            wordcnt = (byte)(cEpcWordcnt.SelectedIndex+1);

            hexValues = tEpcData.Text;
            string[] hexValuesSplit = hexValues.Split(' ');
        //    try
            {
                foreach (String hex in hexValuesSplit)
                {
                    // Convert the number expressed in base-16 to an integer.
                    if (hex != "")
                    {
                        int x = Convert.ToInt32(hex, 16);
                        value[i++] = (ushort)x;
                    }
                }
            }
            //catch (Exception)
            //{
            //    lInfo.Items.Add("Please input data needed");
            //    return;

            //}
            if (i != wordcnt)
            {
                lInfo.Items.Add("Please input data needed");
                return;
            }
            for(byte j = 0; j < wordcnt; j++)
            {
                status = Api.EpcWrite(membank,(byte)(wordptr+j),value[j]);
                if (status != 0)
                {
                    lInfo.Items.Add("Write failed!");
                    return;
                }
            }
            lInfo.Items.Add("Write success!");
        }

       

        private void tEpcData_TextChanged(object sender, EventArgs e)
        {
            if (((tEpcData.Text.Length - 4) % 5) == 0)
            {
                tEpcData.Text += " ";
                tEpcData.Select(tEpcData.Text.Length, 0);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int membank;
            int wordptr;
            int wordcnt;
            int status = 0;
            byte[] value = new byte[16];


            membank = cEpcMembank.SelectedIndex;
            wordptr = cEpcWordptr.SelectedIndex;
            wordcnt = cEpcWordcnt.SelectedIndex + 1;

            status = Api.EpcRead((byte)membank, (byte)wordptr, (byte)wordcnt, ref value);

            if (status != 0)
            {
                lInfo.Items.Add("Read failed!");
                return;
            }

            string cid = "";
            string s1 = "";
            for (int i = 0; i < wordcnt * 2; i++)
            {
                s1 = string.Format("{0:X2}", value[i]);
                cid += s1;
            }
              
            Form3 form = new Form3();
            form.setCid(cid);
            form.Show();
        }
    }
}