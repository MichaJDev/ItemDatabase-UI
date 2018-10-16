using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        DBConnect db = new DBConnect();

        public Form2()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            db.CloseConnection();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine(e.CloseReason.CompareTo(CloseReason.UserClosing));
            db.CloseConnection();
            this.Visible = false;
        }

        public void createTreeView()
        {
            string query = "select *from Items";
            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.FieldCount > 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i == 0)
                        {
                            listView1.Columns.Add(reader.GetName(0), 0, HorizontalAlignment.Left);
                        }
                        else
                        {
                            listView1.Columns.Add(reader.GetName(i).ToString().Replace("_", " "), 80, HorizontalAlignment.Left);
                        }
                    }
                    ListViewItem lv = new ListViewItem();
                    //
                    while (reader.Read())
                    {
                        lv = listView1.Items.Add(reader[reader.GetName(0)].ToString().Replace('_', ' '));
                        for (int h = 1; h < reader.FieldCount; h++)
                        {

                            lv.SubItems.Add(reader[reader.GetName(h)].ToString());
                        }
                    }
                }
                for (int i = 1; i < listView1.Columns.Count; i++)
                    listView1.Columns[i].Width = -2;
                //close Data Reader
                reader.Close();
                //close Connection
                db.CloseConnection();
            }
        }
    }
}
