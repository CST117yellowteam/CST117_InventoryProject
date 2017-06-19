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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usernameOne = "manager";
            String passwordOne = "passwordOne";
            String usernameTwo = "purchasing";
            String passwordTwo = "passwordTwo";
            String usernameThree = "storeclerk";
            String passwordThree = "passwordThree";
            if (textBox1.Text == usernameOne && textBox2.Text == passwordOne)
            {
                this.Visible = false;
                MainScreen MainScreen = new MainScreen();
                MainScreen.Show();
            }
            else if (textBox1.Text == usernameTwo && textBox2.Text == passwordTwo)
            {
                this.Visible = false;
                MainScreen MainScreen = new MainScreen();
                MainScreen.Show();
            }
            else if (textBox1.Text == usernameThree && textBox2.Text == passwordThree)
            {
                this.Visible = false;
                MainScreen MainScreen = new MainScreen();
                MainScreen.Show();
            }
            else
                labelError.Visible = true;
        }

    }
}
