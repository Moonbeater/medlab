using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net;
using System.Windows;

namespace MedLabAnalizatorDLL
{
    public class DBConnection
    {
        static string connectionstring = "Database = medlab; Datasource = localhost; userid = root; password = qwerty; charset = utf8";

        static public MySqlConnection myconnection;

        static public MySqlCommand mycommand;

        static public MySqlDataAdapter msDataAdapter;

        static public bool Connect()
        {
            try
            {
                myconnection = new MySqlConnection(connectionstring);
                myconnection.Open();

                mycommand = new MySqlCommand();
                mycommand.Connection = myconnection;
                msDataAdapter = new MySqlDataAdapter(mycommand);
                return true;
            }
            catch
            {
                //MessageBox.Show("Ошибка при подключении к БД", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        static public void Disconnect()
        {
            myconnection.Close();
        }
    }
}
