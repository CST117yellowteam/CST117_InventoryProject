using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InventoryManager
{
    public partial class EditItem : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public EditItem()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }

        private void EditItemClose_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void EditItemSave_Click(object sender, EventArgs e)
        {
            int itemQuantity;
            decimal itemPrice;

            if (EditItemSave.Enabled == true)
            {
                //A check will be input here once database is added to see if the Item Name already exists in database.

                //Checks if Price textbox contains a whole number or a decimal up to 2 places. If not, display error message and alert via beep.
                if (decimal.TryParse(textBox_NewPrice.Text, out itemPrice))
                {
                    if (textBox_NewPrice.Text.IndexOf('.') != -1 && textBox_NewPrice.Text.Split('.')[1].Length > 2)
                    {
                        Console.Beep();
                        MessageBox.Show("Data Field Price: Please enter a decimal. Example: 19.99");
                        return;
                    }
                    //If input is a whole number, add .00 to end of number.
                    else textBox_NewPrice.Text = itemPrice.ToString(".00");
                }
                else
                {
                    Console.Beep();
                    MessageBox.Show("Data Field Price: Please enter a decimal. Example: 19.99");
                    return;
                }

                //Checks if Quantity textbox contains a whole number. If not, display an error message.
                if (!int.TryParse(textBox_NewQuantity.Text, out itemQuantity))
                {
                    Console.Beep();
                    MessageBox.Show("Data Field Quantity: Please enter a whole number.");
                    return;
                }
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "UPDATE Table2 SET Price = '" + double.Parse(textBox_NewPrice.Text) + "', Item_Name = '" + textBox_NewName.Text + "', Quantity = '" + int.Parse(textBox_NewQuantity.Text) + "' WHERE ID = " + textBox_ID.Text + "";
                command.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Item successfully changed.");
                EditItemSave.Enabled = false;
            }
        }

        private void EditItemReset_Click(object sender, EventArgs e)
        {
            textBox_NewName.Clear();
            textBox_NewPrice.Clear();
            textBox_NewQuantity.Clear();
            EditItemSave.Enabled = true;
        }

        
    }
}
