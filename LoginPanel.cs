using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LibrarySystem
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {

            InitializeComponent();
        }
        MySqlConnection c = new MySqlConnection("server=localhost; user=root; port=3306; password=mahmut123; database=library");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginEmailArea_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            c.Open();
            string user;
            string password;
            user = LoginEmailArea.Text;
            password = LoginPasswordArea.Text;
           

            MySqlCommand login = new MySqlCommand("Select * from admin where admin_name='" + user + "' and a_password='" + password + "'", c);
            MySqlDataReader read = login.ExecuteReader();
            
            if (read.Read())
            {
                MenuPage menupage = new MenuPage();
                menupage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error 1453");
            }

            c.Close();




        }

        private void LoginPasswordArea_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void LoginPasswordArea_TextChanged(object sender, EventArgs e)
        {
            LoginPasswordArea.PasswordChar = '*';
        }
    }
}
