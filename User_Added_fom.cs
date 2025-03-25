using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_App
{
    public partial class User_Added_fom : Form
    {
        public User_Added_fom()
        {
            
            InitializeComponent();
        }

        private void bp_OK_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
