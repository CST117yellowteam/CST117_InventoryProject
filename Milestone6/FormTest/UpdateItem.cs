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
    public partial class UpdateItem : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public UpdateItem()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            int itemQuantity;
            //Checks if Quantity textbox contains a whole number. If not, display an error message.
            if (!int.TryParse(textBox_NewQuantity.Text, out itemQuantity))
            {
                Console.Beep();
                MessageBox.Show("Data Field New Quantity: Please enter a whole number.");
                return;
            }
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "UPDATE Table2 SET Quantity = '" + int.Parse(textBox_NewQuantity.Text) + "' WHERE ID = " + textBox_ID.Text + "";
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Quantity updated.");
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_NewQuantity.Clear();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
