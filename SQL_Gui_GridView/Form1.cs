using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace SQL_Gui_GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // hardcore OOP Programming ;-)
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open predefined SQL Connection
            if (Configuration.Connection.State == ConnectionState.Closed)
            {
                Configuration.Connection.Open();
            }

            // Build SQL Command
            string SqlString = "EXEC AddArtikel '" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' ;";

            // New Instance for SQL Commands
            SqlCommand cmd = new SqlCommand(SqlString, Configuration.Connection);

            // Fire it on the Server
            try
            {
                cmd.ExecuteNonQuery(); // Exception needed
            }
            catch (Exception a)
            {
                Console.WriteLine(a.ToString());
            }

            // Refresh the GridView
            this.artikelTableAdapter.Fill(this.de2_projekt_lagerverwaltungDataSet.Artikel);

            // Close the SQL Connection
            Configuration.Connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "de2_projekt_lagerverwaltungDataSet3.Artikel". Sie können sie bei Bedarf verschieben oder entfernen.
            try
            {
                this.artikelTableAdapter.Fill(this.de2_projekt_lagerverwaltungDataSet.Artikel);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.ToString());
            }
        }

        private void ThreadLoader()
        {
            ThreadStart threadDelegate;
            threadDelegate = new ThreadStart(status_checker);
            Thread status = new Thread(threadDelegate);
            status.Start();
        }

        private void status_checker()
        {
            while (true)
            {
                try
                {
                    Configuration.Connection.Open();
                    this.button3.BackColor = System.Drawing.Color.Green;
                }
                catch (Exception l)
                {
                    Console.WriteLine(l.ToString());
                    this.button3.BackColor = System.Drawing.Color.Red;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
