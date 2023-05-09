using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookTransaction booktrans = new BookTransaction();
            booktrans.ShowDialog();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            

        }

        private void MemberMenu_Click(object sender, EventArgs e)
        {
            MemberTransaction membertrans = new MemberTransaction();
            membertrans.ShowDialog();
        }
    }
}
