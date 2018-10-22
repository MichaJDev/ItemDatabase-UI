using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DBConnect db = new DBConnect();
        ItemDB item = new ItemDB();
        Form form2 = new Form2();
        int stam, str, intl, agi, has, mas = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            if(db.checkItemTable() == true)
            {
                db.createItemTable();
            }
        }
        //Event Handler adding item to database
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (isTextBoxNull(itemDesc) == 0 || isTextBoxNull(itemName) == 0)
            {
                MessageBox.Show("MissingArgumentsError: You haven't filled in all the options");
            }
            else
            {
                Boolean[] checkedStats = new bool[] { itemStamCheck.Checked, itemStrCheck.Checked, itemIntCheck.Checked, itemAgilCheck.Checked, itemHastCheck.Checked, itemMastCheck.Checked };
                String[] typeNames = new string[] { itemStamCheck.Text, itemStrCheck.Text, itemIntCheck.Text, itemAgilCheck.Text, itemHastCheck.Text, itemMastCheck.Text };

                for (int i = 0; i < checkedStats.Length; i++)
                {
                    validateChecked(typeNames[i], checkedStats[i]);
                }
                
                item.addItem(itemName.Text,itemDesc.Text,itemType.Text,itemWorth.Text,stam,str,intl,agi,has,mas);
                int countNew = db.getRowCount();
                if(countNew >= count)
                {
                    MessageBox.Show("Item added! Items in Database: \nOld: "+ count + "\nNew: " + countNew);
                    count = countNew;
                }
                clearAll();
            }
        }

        //Getting Itemtype
        public String getItemType(int itemID)
        {
            return itemType.GetItemText(itemID).ToString();
        }
        /*
         * 
         *  Making sure Textboxes only allow Ints or doubles
         * 
         */
        private void itemStam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void itemStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void itemInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void itemAgi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //When loads make Database window disabled.
        private void ItemDatabase_Load(object sender, EventArgs e)
        {
            form2.Visible = false;
            count = db.getRowCount();
        }

        private void itemDBBtn_Click(object sender, EventArgs e)
        {
            form2.Visible = true;
        }

        private void dbBtn_Click(object sender, EventArgs e)
        {
            form2.Visible = true;
        }

        private void itemMas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void itemHas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private int isTextBoxNull(TextBox tb)
        {
            int isNull;
            if (tb.Text == "")
            {
                isNull = 0;
            }
            else
            {
                isNull = tb.Text.Length;
            }
            return isNull;
        }

        private void validateChecked(String typeName, Boolean check)
        {
            if (check && typeName == "Stamina")
            {
                stam = Convert.ToInt32(itemStam.Text);
            }
            if (check && typeName == "Strength")
            {
                str = Convert.ToInt32(itemStr.Text);
            }
            if (check && typeName == "Intellect")
            {
                intl = Convert.ToInt32(itemInt.Text);
            }
            if (check && typeName == "Agility")
            {
                agi = Convert.ToInt32(itemAgi.Text);
            }
            if (check && typeName == "Haste")
            {
                has = Convert.ToInt32(itemHas.Text);
            }
            if (check && typeName == "Mastery")
            {
                mas = Convert.ToInt32(itemMas.Text);
            }
        }
        private void clearAll()
        {
            stam = 0;
            str = 0;
            intl = 0;
            agi = 0;
            has = 0;
            mas = 0;
            itemDesc.Clear();
            itemName.Clear();
            itemStam.Clear();
            itemStr.Clear();
            itemInt.Clear();
            itemAgi.Clear();
            itemHas.Clear();
            itemMas.Clear();
            itemStamCheck.Checked = false;
            itemStrCheck.Checked = false;
            itemIntCheck.Checked = false;
            itemAgilCheck.Checked = false;
            itemHastCheck.Checked = false;
            itemMastCheck.Checked = false;
            itemWorth.SelectedIndex = -1;
            itemType.SelectedIndex = -1;

        }
    }

}
