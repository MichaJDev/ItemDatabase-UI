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
            string query = "INSERT INTO tableinfo (ItemName, ItemDesc, ItemType,ItemWorth,Stamina,Strength,Intellect,Agility,Haste,Mastery) VALUES('" + itemName + "', '" + itemDesc + "','" + itemType + "','" + itemWorth + "','" + stam + "')";
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.BeginExecuteNonQuery();

                //close connection
                this.CloseConnection();

            }
        }

        public int getRowCount()
        {

            string query = "select count(*) from item";
            int count = 0;
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
           
                count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();

            }
            return count;

        }

        public bool checkItemTable()
        {
            bool tableExists = false;
            string query = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = \'test\' AND table_name = \'item]\'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    if (count == 0)
                    {
                        tableExists = false;
                    }
                    else if (count == 1)
                    {
                        tableExists = true;
                    }
                }
                reader.Close();
                this.CloseConnection();
            }
            return tableExists;
        }
        public void createItemTable()
        {
            string query = "CREATE TABLE item (ID int NOT NULL PRIMARY KEY AUTO_INCREMENT,ItemName varchar(255) NOT NULL,ItemDesc varchar(255),ItemType varchar(255) NOT NULL,ItemWorth varchar(255) NOT NULL,Stamina int,Strength int,Intellect int,Agility int,Haste int,Mastery int); ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                this.CloseConnection();
            }
        }
    }
}
