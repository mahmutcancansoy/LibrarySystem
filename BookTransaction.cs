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
    public partial class BookTransaction : Form
    {
        public BookTransaction()
        {
            InitializeComponent();
        }
        MySqlConnection Connect = new MySqlConnection("server=localhost; user=root; port=3306; password=mahmut123; database=library");
        private void BookTransaction_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void ListData()
        {
            Connect.Open();
            MySqlDataAdapter data = new MySqlDataAdapter("select * from book",Connect);
            DataTable table = new DataTable();
            data.Fill(table);
            BookDataView.DataSource = table;
            Connect.Close();
        }

        private void BookAdd_Click(object sender, EventArgs e)
        {
            
            if (BookNameText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book name");
            }
            if (AuthorFirstNameText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the author first name");
            }
            if (AuthorLastNameText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the author last name");
            }
            if (CopiesOwnedText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book copies owned");
            }
            if(CategoryText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book category");
            }
            else
            {
                Connect.Open();


                MySqlCommand addBook = new MySqlCommand("insert into book (title,author_first_name,author_last_name,publication_date,copies_owned,category_name) values(@title,@author_first_name,@author_last_name,@publication_date,@copies_owned,@category_name)",Connect);

                addBook.Parameters.AddWithValue("@title",BookNameText.Text);
                addBook.Parameters.AddWithValue("@author_first_name",AuthorFirstNameText.Text);
                addBook.Parameters.AddWithValue("@author_last_name", AuthorLastNameText.Text);
                addBook.Parameters.AddWithValue("@publication_date",PublicationDateText.Value);
                addBook.Parameters.AddWithValue("@copies_owned",CopiesOwnedText.Text);
                addBook.Parameters.AddWithValue("@category_name",CategoryText.Text);

                addBook.ExecuteNonQuery();
                Connect.Close();
                ListData();

                MessageBox.Show("Your registration is successful");
                BookNameText.Clear();
                AuthorFirstNameText.Clear();
                AuthorLastNameText.Clear();
                CopiesOwnedText.Clear();
                CategoryText.Clear();
            }
            
            

            

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BookDelete_Click(object sender, EventArgs e)
        {
            if (BookIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book id");
            }
            else
            {
                Connect.Open();
                MySqlCommand deleteBook = new MySqlCommand("Delete from book where id=@id", Connect);
                deleteBook.Parameters.AddWithValue("@id", BookIdText.Text);
                deleteBook.ExecuteNonQuery();
                Connect.Close();
                ListData();

                BookIdText.Clear();
            }
        }
        
        private void BookSearch_Click(object sender, EventArgs e)
        {
            if (BookIdText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the book id");
            }
            else
            {
                Connect.Open();
                MySqlCommand searchBook = new MySqlCommand("select * from book where id=@id", Connect);

                searchBook.Parameters.AddWithValue("@id", BookIdText.Text);

                MySqlDataAdapter data = new MySqlDataAdapter(searchBook);
                DataSet ds = new DataSet();
                data.Fill(ds, "book");
                BookDataView.DataSource = ds.Tables[0];

                searchBook.ExecuteNonQuery();
                Connect.Close();


                BookIdText.Clear();
            }
        }

        private void BookIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookidlabel_Click(object sender, EventArgs e)
        {

        }

        private void CategoryText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CopiesOwnedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PublicationDateText_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CopiesOwnedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AuthorFirstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorFirstNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void AuthorLastNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void CategoryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void BookIdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BookLoan_Click(object sender, EventArgs e)
        {
            LoanBookPage loanbooktrans = new LoanBookPage();
            loanbooktrans.ShowDialog();
            ListData();
        }
    }
}
