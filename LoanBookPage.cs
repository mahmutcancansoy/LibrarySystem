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
    public partial class LoanBookPage : Form
    {
        public LoanBookPage()
        {
            InitializeComponent();
        }
        MySqlConnection Connect = new MySqlConnection("server=localhost; user=root; port=3306; password=mahmut123; database=library");
        private void ListData()
        {
            Connect.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("select * from loan", Connect);
            DataTable table = new DataTable();
            data.Fill(table);
            LoanDataView.DataSource = table;
            Connect.Close();
        }
        private void LoanBookPage_Load (object sender, EventArgs e)
        {
            ListData();
        }


        private void MemberFirstName_Click(object sender, EventArgs e)
        {

        }

        private void LoanDate_Click(object sender, EventArgs e)
        {

        }
        
        private void memberjoinedDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoanUpdate_Click(object sender, EventArgs e)
        {
            if (LoanIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the loan id");
            }
            else
            {
                Connect.Open();
                MySqlCommand upDateLoan = new MySqlCommand( "update loan set returned_date = @returned_date Where id =@id",Connect);
                upDateLoan.Parameters.AddWithValue("@id",LoanIdText.Text);
                upDateLoan.Parameters.AddWithValue("@returned_date",ReturnedDateText.Value);
                upDateLoan.ExecuteNonQuery();

                Connect.Close();
                ListData();

                LoanIdText.Clear();

                
            }
        }

        private void MemberAdd_Click(object sender, EventArgs e)
        {
            if (LoanMemberIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the member id");
            }
            if (LoanBookIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book id");
            }
            else 
            {         
                Connect.Open();
                MySqlCommand addLoan = new MySqlCommand("insert into loan (member_id,book_id,loan_date) values (@member_id,@book_id,@loan_date)",Connect);
                addLoan.Parameters.AddWithValue("@member_id",LoanMemberIdText.Text);
                addLoan.Parameters.AddWithValue("@book_id",LoanBookIdText.Text);
                addLoan.Parameters.AddWithValue("@loan_date",LoanDateText.Value);

                addLoan.ExecuteNonQuery();

                Connect.Close();
                ListData();
                LoanMemberIdText.Clear();
                LoanBookIdText.Clear();

            }
        }

        private void LoanMemberIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void LoanBookIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void LoanIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void LoanDelete_Click(object sender, EventArgs e)
        {
            if (LoanMemberIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the member id");
            }
            if (LoanBookIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book id");
            }
            else
            {
                Connect.Open();
                MySqlCommand deleteLoan = new MySqlCommand("Delete from loan where member_id =@member_id and book_id=@book_id", Connect);
                deleteLoan.Parameters.AddWithValue("@member_id", LoanMemberIdText.Text);
                deleteLoan.Parameters.AddWithValue("@book_id", LoanBookIdText.Text);
                deleteLoan.Parameters.AddWithValue("@loan_date", LoanDateText.Value);

                deleteLoan.ExecuteNonQuery();

                Connect.Close();
                ListData();
                LoanMemberIdText.Clear();
                LoanBookIdText.Clear();

            }
        }

        private void LoanSearch_Click_1(object sender, EventArgs e)
        {

            if (LoanMemberIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the member  id");
            }
            if (LoanBookIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book id");
            }
            else
            {
                Connect.Open();
                MySqlCommand searchLoan = new MySqlCommand("select * from loan where member_id=@member_id and book_id=@book_id", Connect);

                searchLoan.Parameters.AddWithValue("@member_id", LoanMemberIdText.Text);
                searchLoan.Parameters.AddWithValue("@book_id", LoanBookIdText.Text);

                MySqlDataAdapter data = new MySqlDataAdapter(searchLoan);
                DataSet ds = new DataSet();
                data.Fill(ds, "loan");
                LoanDataView.DataSource = ds.Tables[0];

                searchLoan.ExecuteNonQuery();
                Connect.Close();

                LoanMemberIdText.Clear();
                LoanBookIdText.Clear();
            }
        }

        private void LoanBookPage_Load_1(object sender, EventArgs e)
        {
            ListData();
        }
    }
}
