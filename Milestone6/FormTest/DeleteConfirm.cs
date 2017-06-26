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
    public partial class DeleteConfirm : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public DeleteConfirm()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }

        private void YesDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "DELETE FROM Table2 WHERE ID = " + label_ID.Text + "";
            command.ExecuteNonQuery();
            connect.Close();
            this.Close();
        }

        private void NoDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
