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
    public partial class option : Form
    {
        public option(String user)
        {
            InitializeComponent();
            userO.Text = user;
            string userid = user;
        }

        private void Oadd_Click(object sender, EventArgs e)
        {
            addUser ad = new addUser(userO.Text);
            ad.Show();
            this.Hide();
        }

        private void Oaccess_Click(object sender, EventArgs e)
        {
            consult c = new consult(userO.Text);
            c.Show();
            this.Hide();
        }

        private void Ologout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out!");
            this.Hide();
            logFrame log = new logFrame();
            log.Show();
        }
    }
}
