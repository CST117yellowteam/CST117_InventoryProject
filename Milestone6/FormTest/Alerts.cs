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
    public partial class Alerts : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Alerts()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }

        private void CloseAlerts_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlertsOrderItem_Click(object sender, EventArgs e)
        {
            OrderItem OrderItemForm = new OrderItem();
            OrderItemForm.label3.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            OrderItemForm.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            OrderItemForm.Show();
        }

        private void Alerts_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT * From Table2 WHERE Quantity < 10";
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView1.DataSource = data;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                }
            }

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * From Table2 WHERE Quantity < 10";
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView1.DataSource = data;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                }
            }

        }
    }
}
