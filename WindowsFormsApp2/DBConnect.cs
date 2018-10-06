using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class DBConnect
    {
        string server, database, uid, password;
        MySqlConnection connection;
        public DBConnect()
        {
            server = "localhost";
            database = "test";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
            }
            return false;
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }

        }

        public void Insert(string itemName, string itemDesc, string itemType, string itemWorth, int stam, int str, int intl, int agi, int has, int mas)
        {
            string query = "INSERT INTO tableinfo (itemName, itemDesc, itemType,itemWorth,stamina,strength,intellect,agility,haste,mastery) VALUES('" + itemName + "', '" + itemDesc + "','" + itemType + "','" + itemWorth + "','" + stam + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

            }
        }
    }
}
