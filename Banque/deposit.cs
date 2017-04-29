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
    public partial class deposit : Form
    {
        public deposit(string id, string balance, string user)
        {

            InitializeComponent();
            idD.Text = id;
            balanceW.Text = balance;
            userW.Text = user;
        }

        private void depositD_Click(object sender, EventArgs e)
        {
            dbManip db = new dbManip();
            try
            {
                db.deposit(float.Parse(amountW.Text), int.Parse(idD.Text));
                MessageBox.Show(amountW.Text + " Added to ur Account");
            }catch(Exception ex)
            {
                MessageBox.Show("Enter a valid amount");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consult c = new consult(userW.Text, idD.Text);
            c.Show();
            this.Hide();
        }
    }
}
