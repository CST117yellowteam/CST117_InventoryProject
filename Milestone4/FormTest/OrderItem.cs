using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class OrderItem : Form
    {
        public OrderItem()
        {
            InitializeComponent();
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
            MessageBox.Show("Item ordered.");
        }
    }
}
