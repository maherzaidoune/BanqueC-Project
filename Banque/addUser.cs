using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque
{
    public partial class addUser : Form
    {
        
        public addUser(String user)
        {
            InitializeComponent();
            userC.Text = user;
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            option o = new option(userC.Text);
            o.Show();
            
        }

        private void addA_Click(object sender, EventArgs e)
        {
            try
            {
                (new dbManip()).addClient(nameA.Text, lnameA.Text, int.Parse(phoneA.Text), int.Parse(nciA.Text));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Done !");
        }
    }
}
