using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form3 : Form
    {
        private string cid;

        public Form3()
        {
            InitializeComponent();
        }


        public void setCid(String cid)
        {
            this.cid = cid;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://101.200.159.209/workshop/car.html");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.GetElementById("cid").SetAttribute("value",cid);
        }
    }
}
