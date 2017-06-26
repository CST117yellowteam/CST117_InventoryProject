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
    
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mcrog\Documents\GCU\CST-117\Group\Week6\Database1.accdb";
        }
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Table1 where User_Name = '" + textBox1.Text + "' and User_Password= '" + textBox2.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
               count++;
            }
          
            if (count == 1)
            {
                this.Visible = false;
                MainScreen MainScreen = new MainScreen();
                MainScreen.Show();
            }
           
            else
                labelError.Visible = true;
            connection.Close();
        }
       
       
    }
}
