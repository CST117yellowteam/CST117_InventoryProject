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
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
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
