using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Password_Manager_App
{

    public partial class main_window : Form
    {

        int p_length = 16;
        string pswrd = "";
        string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
        NpgsqlConnection connect = new NpgsqlConnection("Server=localhost;"
            + "Database=pswrd_data_base;"
            + "User Id = postgres;"
            + "Password = postgres;");





        public main_window()
        {
            
            InitializeComponent();
            
        }

        private void pb_generate_password_Click(object sender, EventArgs e)
        {
            pswrd = "";
            Random random = new Random();
            for (int i = 0; i < p_length; i++)
            {

                pswrd = pswrd + validChars[random.Next(0, validChars.Length)];

            }
            
            tb_password.Text = pswrd;
            Clipboard.SetText(tb_password.Text);
            
        }

        private void pb_add_user_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("No connect");
                Environment.Exit(1);
            }
            string sqlText = @" INSERT INTO users (site, user_email, pw)
                                VALUES (@website, @email, @pswrd)";
            NpgsqlCommand sqlInsert = new NpgsqlCommand(sqlText, connect);
            sqlInsert.Parameters.AddWithValue("@website", tb_website.Text);
            sqlInsert.Parameters.AddWithValue("@email", tb_email.Text);
            sqlInsert.Parameters.AddWithValue("@pswrd", tb_password.Text);
            sqlInsert.ExecuteNonQuery();
            
            new User_Added_fom().ShowDialog();
        }

        private void pb_find_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("No connect");
                Environment.Exit(1);
            }
            string sqlText1 = @"SELECT * FROM users WHERE site = @website";
            NpgsqlParameter find_user_param = new NpgsqlParameter("@website", tb_website.Text);
            NpgsqlCommand sqlCommand = new NpgsqlCommand(sqlText1, connect);
            sqlCommand.Parameters.Add(find_user_param);
            NpgsqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    string found_site = reader.GetString(0);
                    string found_user = reader.GetString(1);
                    string found_pw = reader.GetString(2);
                    new Found_User(found_site, found_user, found_pw).ShowDialog();
                    
                }
                
            }
            else
            {
                string found_site = "No user found";
                string found_user = "No user found";
                string found_pw = "No user found";
                new Found_User(found_site, found_user, found_pw).ShowDialog();

            }

        }

        private void bp_hash_Click(object sender, EventArgs e)
        {
            new Hash_form(tb_password.Text).ShowDialog();
        }
    }
}
