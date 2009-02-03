using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SQL_Gui_GridView
{
    static class Configuration
    {
        static string ip = Form2.ip;
        static string user = Form2.usr;
        static string password = Form2.pw;
        // ConnectionString from .udl file
        public static string ConnectionString = @"Persist Security Info=False;User ID=" + user + ";Initial Catalog=de2_projekt_lagerverwaltung;Data Source="+ ip +";Password="+ password +";";
        
        // SQL Connection Instance
        public static SqlConnection Connection = new SqlConnection(ConnectionString);
    }
}
