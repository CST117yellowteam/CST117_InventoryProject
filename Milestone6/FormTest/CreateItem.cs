using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace InventoryManager
{
    public partial class CreateItem : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public CreateItem()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemNumValue;
            int itemQuantity;
            decimal itemPrice;
   
            if (btnAdd.Enabled == true) 
            {
                //Checks if Item Number textbox contains a whole integer. If not, display error message and alert via beep.             
                if (!int.TryParse(textBox_ItemNum.Text, out itemNumValue))
                {
                    Console.Beep();
                    MessageBox.Show("Data Field Item #: Please enter a whole number.");
                    return;
                }
                

                //A check will be input here once database is added to see if the Item ID or Item Name already exist in database.

                //Checks if Price textbox contains a whole number or a decimal up to 2 places. If not, display error message and alert via beep.
                if (decimal.TryParse(textBox_Price.Text, out itemPrice))
                {
                    if (textBox_Price.Text.IndexOf('.') != -1 && textBox_Price.Text.Split('.')[1].Length > 2)
                    {
                        Console.Beep();
                        MessageBox.Show("Data Field Price: Please enter a decimal. Example: 19.99");
                        return;
                    }
                    //If input is a whole number, add .00 to end of number.
                    else textBox_Price.Text = itemPrice.ToString(".00");
                }
                else
                {
                    Console.Beep();
                    MessageBox.Show("Data Field Price: Please enter a decimal. Example: 19.99");
                    return;
                }

                //Checks if Quantity textbox contains a whole number. If not, display an error message.
                if (!int.TryParse(textBox_Quantity.Text, out itemQuantity))
                {
                    Console.Beep();
                    MessageBox.Show("Data Field Quantity: Please enter a whole number.");
                    return;
                }
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                command.CommandText = "INSERT INTO Table2 (Item_Number, Item_Name, Price, Quantity) VALUES('" + textBox_ItemNum.Text + "', '" + textBox_Name.Text + "'," +
                    " '" + textBox_Price.Text + "', '" + textBox_Quantity.Text + "')";
                command.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Item successfully added.");
                
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ItemNum.Clear();
            textBox_Name.Clear();
            textBox_Price.Clear();
            textBox_Quantity.Clear();
        }

        private void CreateItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
