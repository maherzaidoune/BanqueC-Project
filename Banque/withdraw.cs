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
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }
        public withdraw(string id,string balance,string user)
        {
            
            InitializeComponent();
            idW.Text = id;
            balanceW.Text = balance;
            userW.Text = user;
        }

        private void withdrawW_Click(object sender, EventArgs e)
        {
            
            dbManip db = new dbManip();
            try
            {
                float a = float.Parse(amountW.Text);
                int id = int.Parse(idW.Text);
            
            if (float.Parse(amountW.Text) < db.getBalance(id))
            {
                db.withdraw(float.Parse(amountW.Text), id);
                MessageBox.Show("Withdraw " + amountW.Text + " !");
            }else
            {
                MessageBox.Show("Insufficient Funds");
            }
            }
            catch (Exception ex) { MessageBox.Show("Enter a valid amount"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consult c = new consult(userW.Text,idW.Text);
            c.Show();
            this.Hide();
        }

        private void withdraw_Load(object sender, EventArgs e)
        {
        }
            
    }
}
