using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class MainScreen : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        DataTable data = new DataTable();

        public MainScreen()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }

        private void EditItemDetails_Click(object sender, EventArgs e)
        {
            EditItem EditItemForm = new EditItem();
            EditItemForm.textBox_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditItemForm.textBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditItemForm.textBox2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EditItemForm.textBox3.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EditItemForm.Show();
        }

        private void CreateNewItem_Click(object sender, EventArgs e)
        {
            CreateItem CreateItemForm = new CreateItem();
            CreateItemForm.ShowDialog();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateQuantity_Click(object sender, EventArgs e)
        {
            UpdateItem UpdateItemForm = new UpdateItem();
            UpdateItemForm.textBox_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            UpdateItemForm.textBox1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            UpdateItemForm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataView search = new DataView(data);
            search.RowFilter = string.Format("Item_Name LIKE '%{0}%'", textBox_Search.Text);
            dataGridView1.DataSource = search;
            //Code will be changed once database is added to display a prompt if item is not found
            //SearchResults SearchResultsForm = new SearchResults();
            //SearchResultsForm.ShowDialog();
        }

        private void CheckAlerts_Click(object sender, EventArgs e)
        {
            Alerts EditItemForm = new Alerts();
            EditItemForm.Show();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteConfirm DeleteConfirm = new DeleteConfirm();
            DeleteConfirm.label_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DeleteConfirm.Show();
        }

        private void ClearSearch_Click(object sender, EventArgs e)
        {
            textBox_Search.Clear();
            GetData("SELECT * From Table2");
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            string query = "SELECT * From Table2";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                DataGridViewColumn column1 = dataGridView1.Columns[1];
                column1.Width = 70;
                DataGridViewColumn column3 = dataGridView1.Columns[3];
                column3.Width = 70;
                DataGridViewColumn column4 = dataGridView1.Columns[4];
                column4.Width = 70;
            }
        }

        private void button_RefreshDB_Click(object sender, EventArgs e)
        {
            GetData("SELECT * From Table2");
        }

        public DataTable GetData(string query)
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);               
                return data;                
            }           
        }

    }
}
