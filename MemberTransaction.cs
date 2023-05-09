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
    public partial class MemberTransaction : Form
    {
        public MemberTransaction()
        {
            InitializeComponent();
        }
        MySqlConnection Connect = new MySqlConnection("server=localhost; user=root; port=3306; password=mahmut123; database=library");

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void MemberFirstName_Click(object sender, EventArgs e)
        {

        }

        private void MemberDateOfRegistration_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (memberLastNameText.Text.Length==0) 
            {
                MemberAdd.Enabled = false;
            
            }
            else
            {
                MemberAdd.Enabled = true;
            }
        }

        private void MemberTransaction_Load(object sender, EventArgs e)
        {
           
           listData();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void listData()
        {
            Connect.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("select *from members", Connect);
            DataTable table = new DataTable();
            data.Fill(table);
            memberData.DataSource = table;
            Connect.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            if (memberFirstNameText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the member's first name");
            }
            if (memberLastNameText.Text == string.Empty)
            {

                MessageBox.Show("Please enter the member's last name");
            }
            else
            {
                Connect.Open();

                MySqlCommand membersAdd = new MySqlCommand("insert into members (first_name,last_name,joined_date) values (@first_name,@last_name,@joined_date)", Connect);

                membersAdd.Parameters.AddWithValue("@first_name", memberFirstNameText.Text);
                membersAdd.Parameters.AddWithValue("@last_name", memberLastNameText.Text);
                membersAdd.Parameters.AddWithValue("@joined_date", memberjoinedDate.Value);
                membersAdd.ExecuteNonQuery();

                Connect.Close();
                memberFirstNameText.Clear();
                memberLastNameText.Clear();

                listData();

                MessageBox.Show("Your registration is successful");




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Memberidtext.Text == string.Empty)
            {
                MessageBox.Show("Please enter the member's id");
            }
            
            else
            {
                Connect.Open();
                MySqlCommand membersDelete = new MySqlCommand("delete from members where id=@id", Connect);

                membersDelete.Parameters.AddWithValue("@id", Memberidtext.Text);
                

                membersDelete.ExecuteNonQuery();

                Connect.Close();
                memberFirstNameText.Clear();
                memberLastNameText.Clear();

                listData();
                MessageBox.Show("Your deletion is successful");



            }

        }

        private void MemberStatus_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void memberFirstNameText_TextChanged(object sender, EventArgs e)
        {
            if (memberFirstNameText.Text.Length==0) {

                MemberAdd.Enabled = false;
            }
            else
            {
                MemberAdd.Enabled = true;
            }
        }

        private void memberData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MemberCancel_Click(object sender, EventArgs e)
        {
            
           
           



        }

        private void memberSearch_Click(object sender, EventArgs e)
        {
            
            if (Memberidtext.Text == string.Empty)
            {

                MessageBox.Show("Please enter the member's id");
            }


            else { 

            Connect.Open();
            MySqlCommand membersSearch = new MySqlCommand("Select * from members where id=@id", Connect);

            membersSearch.Parameters.AddWithValue("@id", Memberidtext.Text);
            

            MySqlDataAdapter data = new MySqlDataAdapter(membersSearch);
            DataSet ds = new DataSet();
            data.Fill(ds,"members");
            memberData.DataSource =ds.Tables[0];

            Connect.Close();
            

            memberFirstNameText.Clear();
            memberLastNameText.Clear();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Memberidtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void memberLastNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void memberFirstNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void MemberPageTittle_Click(object sender, EventArgs e)
        {

        }

        private void memberDeleteAndSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
