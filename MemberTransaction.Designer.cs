
namespace LibrarySystem
{
    partial class MemberTransaction
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
            this.memberData = new System.Windows.Forms.DataGridView();
            this.memberFirstNameText = new System.Windows.Forms.TextBox();
            this.memberLastNameText = new System.Windows.Forms.TextBox();
            this.memberjoinedDate = new System.Windows.Forms.DateTimePicker();
            this.MemberFirstName = new System.Windows.Forms.Label();
            this.MemberDateOfRegistration = new System.Windows.Forms.Label();
            this.MemberLastName = new System.Windows.Forms.Label();
            this.MemberPageTittle = new System.Windows.Forms.Label();
            this.MemberAdd = new System.Windows.Forms.Button();
            this.MemberDelete = new System.Windows.Forms.Button();
            this.memberSearch = new System.Windows.Forms.Button();
            this.Memberidtext = new System.Windows.Forms.TextBox();
            this.MemberRegistration = new System.Windows.Forms.GroupBox();
            this.memberDeleteAndSearch = new System.Windows.Forms.GroupBox();
            this.Memberid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberData)).BeginInit();
            this.MemberRegistration.SuspendLayout();
            this.memberDeleteAndSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberData
            // 
            this.memberData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberData.Location = new System.Drawing.Point(37, 68);
            this.memberData.Name = "memberData";
            this.memberData.Size = new System.Drawing.Size(443, 542);
            this.memberData.TabIndex = 0;
            this.memberData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberData_CellContentClick);
            // 
            // memberFirstNameText
            // 
            this.memberFirstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.memberFirstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberFirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberFirstNameText.ForeColor = System.Drawing.Color.White;
            this.memberFirstNameText.Location = new System.Drawing.Point(203, 69);
            this.memberFirstNameText.Name = "memberFirstNameText";
            this.memberFirstNameText.Size = new System.Drawing.Size(185, 15);
            this.memberFirstNameText.TabIndex = 1;
            this.memberFirstNameText.TextChanged += new System.EventHandler(this.memberFirstNameText_TextChanged);
            this.memberFirstNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memberFirstNameText_KeyPress);
            // 
            // memberLastNameText
            // 
            this.memberLastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.memberLastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberLastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberLastNameText.ForeColor = System.Drawing.Color.White;
            this.memberLastNameText.Location = new System.Drawing.Point(203, 131);
            this.memberLastNameText.Name = "memberLastNameText";
            this.memberLastNameText.Size = new System.Drawing.Size(185, 15);
            this.memberLastNameText.TabIndex = 2;
            this.memberLastNameText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.memberLastNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memberLastNameText_KeyPress);
            // 
            // memberjoinedDate
            // 
            this.memberjoinedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberjoinedDate.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.memberjoinedDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.memberjoinedDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memberjoinedDate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.memberjoinedDate.Location = new System.Drawing.Point(234, 184);
            this.memberjoinedDate.Name = "memberjoinedDate";
            this.memberjoinedDate.Size = new System.Drawing.Size(154, 22);
            this.memberjoinedDate.TabIndex = 3;
            this.memberjoinedDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MemberFirstName
            // 
            this.MemberFirstName.AutoSize = true;
            this.MemberFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberFirstName.ForeColor = System.Drawing.Color.White;
            this.MemberFirstName.Location = new System.Drawing.Point(93, 69);
            this.MemberFirstName.Name = "MemberFirstName";
            this.MemberFirstName.Size = new System.Drawing.Size(73, 16);
            this.MemberFirstName.TabIndex = 4;
            this.MemberFirstName.Text = "First Name";
            this.MemberFirstName.Click += new System.EventHandler(this.MemberFirstName_Click);
            // 
            // MemberDateOfRegistration
            // 
            this.MemberDateOfRegistration.AutoSize = true;
            this.MemberDateOfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberDateOfRegistration.ForeColor = System.Drawing.Color.White;
            this.MemberDateOfRegistration.Location = new System.Drawing.Point(93, 184);
            this.MemberDateOfRegistration.Name = "MemberDateOfRegistration";
            this.MemberDateOfRegistration.Size = new System.Drawing.Size(128, 16);
            this.MemberDateOfRegistration.TabIndex = 5;
            this.MemberDateOfRegistration.Text = "Date Of Registration";
            this.MemberDateOfRegistration.Click += new System.EventHandler(this.MemberDateOfRegistration_Click);
            // 
            // MemberLastName
            // 
            this.MemberLastName.AutoSize = true;
            this.MemberLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberLastName.ForeColor = System.Drawing.Color.White;
            this.MemberLastName.Location = new System.Drawing.Point(93, 131);
            this.MemberLastName.Name = "MemberLastName";
            this.MemberLastName.Size = new System.Drawing.Size(73, 16);
            this.MemberLastName.TabIndex = 6;
            this.MemberLastName.Text = "Last Name";
            this.MemberLastName.Click += new System.EventHandler(this.label3_Click);
            // 
            // MemberPageTittle
            // 
            this.MemberPageTittle.AutoSize = true;
            this.MemberPageTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberPageTittle.ForeColor = System.Drawing.Color.White;
            this.MemberPageTittle.Location = new System.Drawing.Point(500, 23);
            this.MemberPageTittle.Name = "MemberPageTittle";
            this.MemberPageTittle.Size = new System.Drawing.Size(184, 24);
            this.MemberPageTittle.TabIndex = 7;
            this.MemberPageTittle.Text = "Member Transaction";
            this.MemberPageTittle.Click += new System.EventHandler(this.MemberPageTittle_Click);
            // 
            // MemberAdd
            // 
            this.MemberAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.MemberAdd.FlatAppearance.BorderSize = 0;
            this.MemberAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberAdd.ForeColor = System.Drawing.Color.White;
            this.MemberAdd.Location = new System.Drawing.Point(96, 219);
            this.MemberAdd.Name = "MemberAdd";
            this.MemberAdd.Size = new System.Drawing.Size(292, 42);
            this.MemberAdd.TabIndex = 8;
            this.MemberAdd.Text = "Add";
            this.MemberAdd.UseVisualStyleBackColor = false;
            this.MemberAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemberDelete
            // 
            this.MemberDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.MemberDelete.FlatAppearance.BorderSize = 0;
            this.MemberDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberDelete.ForeColor = System.Drawing.Color.White;
            this.MemberDelete.Location = new System.Drawing.Point(96, 137);
            this.MemberDelete.Name = "MemberDelete";
            this.MemberDelete.Size = new System.Drawing.Size(130, 42);
            this.MemberDelete.TabIndex = 10;
            this.MemberDelete.Text = "Delete";
            this.MemberDelete.UseVisualStyleBackColor = false;
            this.MemberDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // memberSearch
            // 
            this.memberSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.memberSearch.FlatAppearance.BorderSize = 0;
            this.memberSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberSearch.ForeColor = System.Drawing.Color.White;
            this.memberSearch.Location = new System.Drawing.Point(258, 137);
            this.memberSearch.Name = "memberSearch";
            this.memberSearch.Size = new System.Drawing.Size(130, 42);
            this.memberSearch.TabIndex = 11;
            this.memberSearch.Text = "Search";
            this.memberSearch.UseVisualStyleBackColor = false;
            this.memberSearch.Click += new System.EventHandler(this.memberSearch_Click);
            // 
            // Memberidtext
            // 
            this.Memberidtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.Memberidtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Memberidtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Memberidtext.ForeColor = System.Drawing.Color.White;
            this.Memberidtext.Location = new System.Drawing.Point(203, 74);
            this.Memberidtext.Name = "Memberidtext";
            this.Memberidtext.Size = new System.Drawing.Size(185, 15);
            this.Memberidtext.TabIndex = 12;
            this.Memberidtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Memberidtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Memberidtext_KeyPress);
            // 
            // MemberRegistration
            // 
            this.MemberRegistration.Controls.Add(this.MemberAdd);
            this.MemberRegistration.Controls.Add(this.memberFirstNameText);
            this.MemberRegistration.Controls.Add(this.memberLastNameText);
            this.MemberRegistration.Controls.Add(this.memberjoinedDate);
            this.MemberRegistration.Controls.Add(this.MemberFirstName);
            this.MemberRegistration.Controls.Add(this.MemberDateOfRegistration);
            this.MemberRegistration.Controls.Add(this.MemberLastName);
            this.MemberRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberRegistration.ForeColor = System.Drawing.Color.White;
            this.MemberRegistration.Location = new System.Drawing.Point(709, 68);
            this.MemberRegistration.Name = "MemberRegistration";
            this.MemberRegistration.Size = new System.Drawing.Size(468, 297);
            this.MemberRegistration.TabIndex = 13;
            this.MemberRegistration.TabStop = false;
            this.MemberRegistration.Text = "Member Registration";
            // 
            // memberDeleteAndSearch
            // 
            this.memberDeleteAndSearch.Controls.Add(this.Memberid);
            this.memberDeleteAndSearch.Controls.Add(this.memberSearch);
            this.memberDeleteAndSearch.Controls.Add(this.MemberDelete);
            this.memberDeleteAndSearch.Controls.Add(this.Memberidtext);
            this.memberDeleteAndSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberDeleteAndSearch.ForeColor = System.Drawing.Color.White;
            this.memberDeleteAndSearch.Location = new System.Drawing.Point(709, 382);
            this.memberDeleteAndSearch.Name = "memberDeleteAndSearch";
            this.memberDeleteAndSearch.Size = new System.Drawing.Size(468, 228);
            this.memberDeleteAndSearch.TabIndex = 14;
            this.memberDeleteAndSearch.TabStop = false;
            this.memberDeleteAndSearch.Text = "Member Deletion and Search";
            this.memberDeleteAndSearch.Enter += new System.EventHandler(this.memberDeleteAndSearch_Enter);
            // 
            // Memberid
            // 
            this.Memberid.AutoSize = true;
            this.Memberid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Memberid.ForeColor = System.Drawing.Color.White;
            this.Memberid.Location = new System.Drawing.Point(93, 74);
            this.Memberid.Name = "Memberid";
            this.Memberid.Size = new System.Drawing.Size(72, 16);
            this.Memberid.TabIndex = 9;
            this.Memberid.Text = "Member Id";
            // 
            // MemberTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1212, 648);
            this.Controls.Add(this.memberDeleteAndSearch);
            this.Controls.Add(this.MemberRegistration);
            this.Controls.Add(this.MemberPageTittle);
            this.Controls.Add(this.memberData);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MemberTransaction";
            this.Text = "Member Transaction";
            this.Load += new System.EventHandler(this.MemberTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberData)).EndInit();
            this.MemberRegistration.ResumeLayout(false);
            this.MemberRegistration.PerformLayout();
            this.memberDeleteAndSearch.ResumeLayout(false);
            this.memberDeleteAndSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memberData;
        private System.Windows.Forms.TextBox memberFirstNameText;
        private System.Windows.Forms.TextBox memberLastNameText;
        private System.Windows.Forms.DateTimePicker memberjoinedDate;
        private System.Windows.Forms.Label MemberFirstName;
        private System.Windows.Forms.Label MemberDateOfRegistration;
        private System.Windows.Forms.Label MemberLastName;
        private System.Windows.Forms.Label MemberPageTittle;
        private System.Windows.Forms.Button MemberAdd;
        private System.Windows.Forms.Button MemberDelete;
        private System.Windows.Forms.Button memberSearch;
        private System.Windows.Forms.TextBox Memberidtext;
        private System.Windows.Forms.GroupBox MemberRegistration;
        private System.Windows.Forms.GroupBox memberDeleteAndSearch;
        private System.Windows.Forms.Label Memberid;
    }
}