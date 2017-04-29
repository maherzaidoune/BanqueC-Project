using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Banque
{
    public partial class logFrame : Form
    {
        public logFrame()
        {
            InitializeComponent();
        }
        
        private void login_Click(object sender, EventArgs e)
        {
            if (userField.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                dbManip db = new dbManip();
                if (db.verifConnection(userField.Text,password.Text) > 0)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    option o = new option(userField.Text);
                    o.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearer(object sender, MouseEventArgs e)
        {
            userField.Text = "";
            password.Text = "";
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Text = "";
        }
    }
}
