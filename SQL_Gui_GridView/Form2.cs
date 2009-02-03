using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Gui_GridView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string ip;
        public static string usr;
        public static string pw;
        private void ip_textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void user_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pw_textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void server_button1_Click(object sender, EventArgs e)
        {
            ip = this.ip_textBox1.Text;
            usr = this.user_textBox2.Text;
            pw = this.pw_textBox3.Text;
            this.Close();
        }
    }
}
