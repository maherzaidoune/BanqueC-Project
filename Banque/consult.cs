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
    public partial class consult : Form
    {
        public consult(string user)
        {
            InitializeComponent();
            userC.Text = user;
            dateC.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
            
        }
        public consult(string user,string id)
        {
            InitializeComponent();
            userC.Text = user;
            idField.Hide();
            button1.Hide();
            //idC.Text = idField.Text;
            idC.Text = id;
            dateC.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
            dbManip db = new dbManip();
            // set name
            String name = db.getName(int.Parse(id));
            String lname = db.getLname(int.Parse(id));
            int nci = db.getNci(int.Parse(id));
            float balance = db.getBalance(int.Parse(id));
            
                nameC.Text = name;
                lnameC.Text = lname;
                balanceC.Text = balance.ToString();
                nciC.Text = nci.ToString();
        }


        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            option o = new option(userC.Text);
            o.Show();
        }

       

        private void withdraw_Click_1(object sender, EventArgs e)
        {
            if (!idField.Visible)
            {
                withdraw w = new withdraw(idC.Text, balanceC.Text, userC.Text);
                w.Show();
                this.Hide();
            }
            else { MessageBox.Show("Enter client id first"); }
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            if (!idField.Visible)
            {
                deposit d = new deposit(idC.Text, balanceC.Text, userC.Text);
                d.Show();
                this.Hide();
            }
            else { MessageBox.Show("Enter client id first"); }
        }

        private void idField_MouseClick(object sender, MouseEventArgs e)
        {
            idField.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idField.Hide();
            button1.Hide();
            idC.Text = idField.Text;
            dbManip db = new dbManip();
            // set name
            String name = db.getName(int.Parse(idC.Text));
            String lname = db.getLname(int.Parse(idC.Text));
            int nci = db.getNci(int.Parse(idC.Text));
            float balance = db.getBalance(int.Parse(idC.Text));
            if (name == "vide")
            {
                MessageBox.Show("Invalid Input !");
                idField.Show();
                button1.Show();
                idC.Text = "Invalid Id";

            } else
            {
                nameC.Text = name;
                lnameC.Text = lname;
                balanceC.Text = balance.ToString();
                nciC.Text = nci.ToString();

            }


        }

        private void dateC_Click(object sender, EventArgs e)
        {

        }
    }
}
