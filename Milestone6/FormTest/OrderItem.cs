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
    public partial class OrderItem : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public OrderItem()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }

        private void OrderItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderItemPlaceOrder_Click(object sender, EventArgs e)
        {
            int itemQuantity;
            //Checks if Quantity textbox contains a whole number. If not, display an error message.
            if (!int.TryParse(textBox_OrderQuantity.Text, out itemQuantity))
            {
                Console.Beep();
                MessageBox.Show("Data Field Quantity: Please enter a whole number.");
                return;
            }
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "UPDATE Table2 SET Quantity = Quantity + '" + int.Parse(textBox_OrderQuantity.Text) + "' WHERE ID = " + label3.Text + "";
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Item ordered.");
        }
    }
}
