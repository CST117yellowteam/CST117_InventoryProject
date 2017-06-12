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
    public partial class Alerts : Form
    {
        public Alerts()
        {
            InitializeComponent();
        }

        private void CloseAlerts_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlertsOrderItem_Click(object sender, EventArgs e)
        {
            OrderItem OrderItemForm = new OrderItem();
            OrderItemForm.Show();
        }
    }
}
