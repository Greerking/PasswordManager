using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Password_Manager_App
{
    public partial class Hash_form : Form
    {
        public Hash_form(string password)
        {
            
            InitializeComponent();
            l_display_pswrd.Text = password;
        }

        private void pb_generate_hash_Click(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();

            byte[] encoding_array = Encoding.ASCII.GetBytes(l_display_pswrd.Text);
            byte[] hash_password = md5.ComputeHash(encoding_array);

            StringBuilder sb = new StringBuilder();
            foreach (var a in hash_password) sb.Append(a.ToString("X2"));
            l_get_hash.Text = sb.ToString();

        }
    }
}
