using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SQL_Gui_GridView
{
    static class Configuration
    {
        // ConnectionString from .udl file
        public static string ConnectionString = @"Persist Security Info=False;User ID=sa;Initial Catalog=de2_projekt_lagerverwaltung;Data Source=wg-server;Password=sa;";
        
        // SQL Connection Instance
        public static SqlConnection Connection = new SqlConnection(ConnectionString);
    }
}
