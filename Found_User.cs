using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_App
{
    public partial class Found_User : Form
    {
        public Found_User(string site, string email, string pswrd)
        {

            InitializeComponent();
            l_email.Text = email;
            l_pswrd.Text = pswrd;
            l_site.Text = site;
        }
        private void pb_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bp_copy_site_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_site.Text);
        }

        private void pb_copy_email_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_email.Text);
        }

        private void pb_copy_pswrd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_pswrd.Text);
        }
    }
}
