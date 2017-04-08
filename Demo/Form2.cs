

namespace Demo
{
    using System;
    using System.Windows.Forms;
    using MySQLDriverCS;//引入mysql  .net驱动程序  

        public partial class Form2 : Form
        {
            public Form2()
            {
                InitializeComponent();
            }


        private void button1_Click_1(object sender, EventArgs e)
        {  //连接数据库
                DB db = new DB();
                db.closeConn();

        }
    }

    class DB
        {
            MySQLConnection conn = null;
            //构造函数，设置数据库连接 设置数据库编码 
            public DB()
            {
                conn = new MySQLConnection(new MySQLConnectionString("101.200.159.209:3306", "workshop", "hu", "123456").AsString);//构造连接字符串，连接数据库  
                conn.Open();//打开连接  
                MySQLCommand command = new MySQLCommand("SET NAMES utf-8", conn);
                command.ExecuteNonQuery();

            }

           

            public void closeConn()
            {
                if (this.conn != null)
                {
                    conn.Close();
                }
            }


        }

}
