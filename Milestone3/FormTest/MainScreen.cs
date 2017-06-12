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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void EditItemDetails_Click(object sender, EventArgs e)
        {
            EditItem EditItemForm = new EditItem();
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
            UpdateItemForm.ShowDialog();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchResults SearchResultsForm = new SearchResults();
            SearchResultsForm.ShowDialog();
        }

        private void CheckAlerts_Click(object sender, EventArgs e)
        {
            Alerts EditItemForm = new Alerts();
            EditItemForm.Show();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteConfirm DeleteConfirm = new DeleteConfirm();
            DeleteConfirm.Show();
        }
    }
}
