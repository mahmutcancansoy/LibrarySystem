
namespace LibrarySystem
{
    partial class BookTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.categorylabel = new System.Windows.Forms.Label();
            this.AuthorFirstNameText = new System.Windows.Forms.TextBox();
            this.AuthorLastNameText = new System.Windows.Forms.TextBox();
            this.CopiesOwnedText = new System.Windows.Forms.TextBox();
            this.BookAdd = new System.Windows.Forms.Button();
            this.BookNameText = new System.Windows.Forms.TextBox();
            this.PublicationDateText = new System.Windows.Forms.DateTimePicker();
            this.booknamelabel = new System.Windows.Forms.Label();
            this.authorlastnamelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.publicationdatelabel = new System.Windows.Forms.Label();
            this.copiesownedlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BookPageTittle = new System.Windows.Forms.Label();
            this.BookDataView = new System.Windows.Forms.DataGridView();
            this.BookLoan = new System.Windows.Forms.Button();
            this.bookidlabel = new System.Windows.Forms.Label();
            this.BookIdText = new System.Windows.Forms.TextBox();
            this.BookSearch = new System.Windows.Forms.Button();
            this.BookDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryText
            // 
            this.CategoryText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.CategoryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryText.ForeColor = System.Drawing.Color.White;
            this.CategoryText.Location = new System.Drawing.Point(180, 291);
            this.CategoryText.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(261, 13);
            this.CategoryText.TabIndex = 16;
            this.CategoryText.TextChanged += new System.EventHandler(this.CategoryText_TextChanged);
            this.CategoryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryText_KeyPress);
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categorylabel.ForeColor = System.Drawing.Color.White;
            this.categorylabel.Location = new System.Drawing.Point(20, 291);
            this.categorylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(63, 16);
            this.categorylabel.TabIndex = 15;
            this.categorylabel.Text = "Category";
            // 
            // AuthorFirstNameText
            // 
            this.AuthorFirstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.AuthorFirstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorFirstNameText.ForeColor = System.Drawing.Color.White;
            this.AuthorFirstNameText.Location = new System.Drawing.Point(180, 81);
            this.AuthorFirstNameText.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorFirstNameText.Name = "AuthorFirstNameText";
            this.AuthorFirstNameText.Size = new System.Drawing.Size(261, 13);
            this.AuthorFirstNameText.TabIndex = 1;
            this.AuthorFirstNameText.TextChanged += new System.EventHandler(this.AuthorFirstNameText_TextChanged);
            this.AuthorFirstNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuthorFirstNameText_KeyPress);
            // 
            // AuthorLastNameText
            // 
            this.AuthorLastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.AuthorLastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorLastNameText.ForeColor = System.Drawing.Color.White;
            this.AuthorLastNameText.Location = new System.Drawing.Point(180, 132);
            this.AuthorLastNameText.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorLastNameText.Name = "AuthorLastNameText";
            this.AuthorLastNameText.Size = new System.Drawing.Size(261, 13);
            this.AuthorLastNameText.TabIndex = 2;
            this.AuthorLastNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuthorLastNameText_KeyPress);
            // 
            // CopiesOwnedText
            // 
            this.CopiesOwnedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.CopiesOwnedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopiesOwnedText.ForeColor = System.Drawing.Color.White;
            this.CopiesOwnedText.Location = new System.Drawing.Point(180, 246);
            this.CopiesOwnedText.Margin = new System.Windows.Forms.Padding(4);
            this.CopiesOwnedText.Name = "CopiesOwnedText";
            this.CopiesOwnedText.Size = new System.Drawing.Size(261, 13);
            this.CopiesOwnedText.TabIndex = 4;
            this.CopiesOwnedText.TextChanged += new System.EventHandler(this.CopiesOwnedText_TextChanged);
            this.CopiesOwnedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CopiesOwnedText_KeyPress);
            // 
            // BookAdd
            // 
            this.BookAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.BookAdd.FlatAppearance.BorderSize = 0;
            this.BookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookAdd.Location = new System.Drawing.Point(180, 348);
            this.BookAdd.Name = "BookAdd";
            this.BookAdd.Size = new System.Drawing.Size(261, 55);
            this.BookAdd.TabIndex = 13;
            this.BookAdd.Text = "Add";
            this.BookAdd.UseVisualStyleBackColor = false;
            this.BookAdd.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // BookNameText
            // 
            this.BookNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.BookNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookNameText.ForeColor = System.Drawing.Color.White;
            this.BookNameText.Location = new System.Drawing.Point(180, 30);
            this.BookNameText.Margin = new System.Windows.Forms.Padding(4);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(261, 13);
            this.BookNameText.TabIndex = 5;
            // 
            // PublicationDateText
            // 
            this.PublicationDateText.Location = new System.Drawing.Point(180, 188);
            this.PublicationDateText.Name = "PublicationDateText";
            this.PublicationDateText.Size = new System.Drawing.Size(261, 20);
            this.PublicationDateText.TabIndex = 11;
            this.PublicationDateText.ValueChanged += new System.EventHandler(this.PublicationDateText_ValueChanged);
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.booknamelabel.ForeColor = System.Drawing.Color.White;
            this.booknamelabel.Location = new System.Drawing.Point(20, 30);
            this.booknamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(80, 16);
            this.booknamelabel.TabIndex = 6;
            this.booknamelabel.Text = "Book Name";
            // 
            // authorlastnamelabel
            // 
            this.authorlastnamelabel.AutoSize = true;
            this.authorlastnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorlastnamelabel.ForeColor = System.Drawing.Color.White;
            this.authorlastnamelabel.Location = new System.Drawing.Point(20, 132);
            this.authorlastnamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorlastnamelabel.Name = "authorlastnamelabel";
            this.authorlastnamelabel.Size = new System.Drawing.Size(114, 16);
            this.authorlastnamelabel.TabIndex = 10;
            this.authorlastnamelabel.Text = "Author Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Author First Name";
            // 
            // publicationdatelabel
            // 
            this.publicationdatelabel.AutoSize = true;
            this.publicationdatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.publicationdatelabel.ForeColor = System.Drawing.Color.White;
            this.publicationdatelabel.Location = new System.Drawing.Point(20, 188);
            this.publicationdatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publicationdatelabel.Name = "publicationdatelabel";
            this.publicationdatelabel.Size = new System.Drawing.Size(106, 16);
            this.publicationdatelabel.TabIndex = 9;
            this.publicationdatelabel.Text = "Publication Date";
            // 
            // copiesownedlabel
            // 
            this.copiesownedlabel.AutoSize = true;
            this.copiesownedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.copiesownedlabel.ForeColor = System.Drawing.Color.White;
            this.copiesownedlabel.Location = new System.Drawing.Point(20, 246);
            this.copiesownedlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copiesownedlabel.Name = "copiesownedlabel";
            this.copiesownedlabel.Size = new System.Drawing.Size(96, 16);
            this.copiesownedlabel.TabIndex = 8;
            this.copiesownedlabel.Text = "Copies Owned";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CategoryText);
            this.groupBox1.Controls.Add(this.categorylabel);
            this.groupBox1.Controls.Add(this.AuthorFirstNameText);
            this.groupBox1.Controls.Add(this.AuthorLastNameText);
            this.groupBox1.Controls.Add(this.CopiesOwnedText);
            this.groupBox1.Controls.Add(this.BookAdd);
            this.groupBox1.Controls.Add(this.BookNameText);
            this.groupBox1.Controls.Add(this.PublicationDateText);
            this.groupBox1.Controls.Add(this.booknamelabel);
            this.groupBox1.Controls.Add(this.authorlastnamelabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.publicationdatelabel);
            this.groupBox1.Controls.Add(this.copiesownedlabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(848, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 422);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adding A Book";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BookPageTittle
            // 
            this.BookPageTittle.AutoSize = true;
            this.BookPageTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookPageTittle.ForeColor = System.Drawing.Color.White;
            this.BookPageTittle.Location = new System.Drawing.Point(604, 25);
            this.BookPageTittle.Name = "BookPageTittle";
            this.BookPageTittle.Size = new System.Drawing.Size(201, 29);
            this.BookPageTittle.TabIndex = 19;
            this.BookPageTittle.Text = "Book Transaction";
            // 
            // BookDataView
            // 
            this.BookDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataView.Location = new System.Drawing.Point(51, 76);
            this.BookDataView.Name = "BookDataView";
            this.BookDataView.Size = new System.Drawing.Size(754, 414);
            this.BookDataView.TabIndex = 21;
            // 
            // BookLoan
            // 
            this.BookLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.BookLoan.FlatAppearance.BorderSize = 0;
            this.BookLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookLoan.ForeColor = System.Drawing.Color.White;
            this.BookLoan.Location = new System.Drawing.Point(212, 571);
            this.BookLoan.Name = "BookLoan";
            this.BookLoan.Size = new System.Drawing.Size(398, 124);
            this.BookLoan.TabIndex = 16;
            this.BookLoan.Text = "Loan Book";
            this.BookLoan.UseVisualStyleBackColor = false;
            this.BookLoan.Click += new System.EventHandler(this.BookLoan_Click);
            // 
            // bookidlabel
            // 
            this.bookidlabel.AutoSize = true;
            this.bookidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookidlabel.ForeColor = System.Drawing.Color.White;
            this.bookidlabel.Location = new System.Drawing.Point(49, 88);
            this.bookidlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookidlabel.Name = "bookidlabel";
            this.bookidlabel.Size = new System.Drawing.Size(54, 16);
            this.bookidlabel.TabIndex = 19;
            this.bookidlabel.Text = "Book Id";
            this.bookidlabel.Click += new System.EventHandler(this.bookidlabel_Click);
            // 
            // BookIdText
            // 
            this.BookIdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.BookIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookIdText.ForeColor = System.Drawing.Color.White;
            this.BookIdText.Location = new System.Drawing.Point(180, 89);
            this.BookIdText.Margin = new System.Windows.Forms.Padding(4);
            this.BookIdText.Name = "BookIdText";
            this.BookIdText.Size = new System.Drawing.Size(261, 13);
            this.BookIdText.TabIndex = 18;
            this.BookIdText.TextChanged += new System.EventHandler(this.BookIdText_TextChanged);
            this.BookIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookIdText_KeyPress);
            // 
            // BookSearch
            // 
            this.BookSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.BookSearch.FlatAppearance.BorderSize = 0;
            this.BookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookSearch.Location = new System.Drawing.Point(326, 144);
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Size = new System.Drawing.Size(245, 55);
            this.BookSearch.TabIndex = 17;
            this.BookSearch.Text = "Search";
            this.BookSearch.UseVisualStyleBackColor = false;
            this.BookSearch.Click += new System.EventHandler(this.BookSearch_Click);
            // 
            // BookDelete
            // 
            this.BookDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.BookDelete.FlatAppearance.BorderSize = 0;
            this.BookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookDelete.Location = new System.Drawing.Point(52, 144);
            this.BookDelete.Name = "BookDelete";
            this.BookDelete.Size = new System.Drawing.Size(245, 55);
            this.BookDelete.TabIndex = 14;
            this.BookDelete.Text = "Delete";
            this.BookDelete.UseVisualStyleBackColor = false;
            this.BookDelete.Click += new System.EventHandler(this.BookDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bookidlabel);
            this.groupBox2.Controls.Add(this.BookIdText);
            this.groupBox2.Controls.Add(this.BookSearch);
            this.groupBox2.Controls.Add(this.BookDelete);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(848, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 227);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Deletion and Search";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BookTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1498, 766);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BookDataView);
            this.Controls.Add(this.BookLoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BookPageTittle);
            this.Name = "BookTransaction";
            this.Text = "BookTransaction";
            this.Load += new System.EventHandler(this.BookTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.TextBox AuthorFirstNameText;
        private System.Windows.Forms.TextBox AuthorLastNameText;
        private System.Windows.Forms.TextBox CopiesOwnedText;
        private System.Windows.Forms.Button BookAdd;
        private System.Windows.Forms.TextBox BookNameText;
        private System.Windows.Forms.DateTimePicker PublicationDateText;
        private System.Windows.Forms.Label booknamelabel;
        private System.Windows.Forms.Label authorlastnamelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label publicationdatelabel;
        private System.Windows.Forms.Label copiesownedlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BookPageTittle;
        private System.Windows.Forms.DataGridView BookDataView;
        private System.Windows.Forms.Button BookLoan;
        private System.Windows.Forms.Label bookidlabel;
        private System.Windows.Forms.TextBox BookIdText;
        private System.Windows.Forms.Button BookSearch;
        private System.Windows.Forms.Button BookDelete;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}