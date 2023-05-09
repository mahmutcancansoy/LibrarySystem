
namespace LibrarySystem
{
    partial class LoanBookPage
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
            this.LoanDataView = new System.Windows.Forms.DataGridView();
            this.LoanRegistration = new System.Windows.Forms.GroupBox();
            this.LoanSearch = new System.Windows.Forms.Button();
            this.LoanDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoanAdd = new System.Windows.Forms.Button();
            this.LoanMemberIdText = new System.Windows.Forms.TextBox();
            this.LoanBookIdText = new System.Windows.Forms.TextBox();
            this.LoanDateText = new System.Windows.Forms.DateTimePicker();
            this.LoanMemberid = new System.Windows.Forms.Label();
            this.LoanDate = new System.Windows.Forms.Label();
            this.LoanBookid = new System.Windows.Forms.Label();
            this.ReturnedDateText = new System.Windows.Forms.DateTimePicker();
            this.LoanPageTittle = new System.Windows.Forms.Label();
            this.LoanUpdateDelete = new System.Windows.Forms.GroupBox();
            this.LoanIdText = new System.Windows.Forms.TextBox();
            this.LoanIdLabel = new System.Windows.Forms.Label();
            this.LoanUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoanDataView)).BeginInit();
            this.LoanRegistration.SuspendLayout();
            this.LoanUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoanDataView
            // 
            this.LoanDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanDataView.Location = new System.Drawing.Point(66, 84);
            this.LoanDataView.Name = "LoanDataView";
            this.LoanDataView.Size = new System.Drawing.Size(539, 532);
            this.LoanDataView.TabIndex = 0;
            // 
            // LoanRegistration
            // 
            this.LoanRegistration.Controls.Add(this.LoanSearch);
            this.LoanRegistration.Controls.Add(this.LoanDelete);
            this.LoanRegistration.Controls.Add(this.label1);
            this.LoanRegistration.Controls.Add(this.LoanAdd);
            this.LoanRegistration.Controls.Add(this.LoanMemberIdText);
            this.LoanRegistration.Controls.Add(this.LoanBookIdText);
            this.LoanRegistration.Controls.Add(this.LoanDateText);
            this.LoanRegistration.Controls.Add(this.LoanMemberid);
            this.LoanRegistration.Controls.Add(this.LoanDate);
            this.LoanRegistration.Controls.Add(this.LoanBookid);
            this.LoanRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanRegistration.ForeColor = System.Drawing.Color.White;
            this.LoanRegistration.Location = new System.Drawing.Point(750, 84);
            this.LoanRegistration.Name = "LoanRegistration";
            this.LoanRegistration.Size = new System.Drawing.Size(468, 393);
            this.LoanRegistration.TabIndex = 14;
            this.LoanRegistration.TabStop = false;
            this.LoanRegistration.Text = "Loan Registration";
            // 
            // LoanSearch
            // 
            this.LoanSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.LoanSearch.FlatAppearance.BorderSize = 0;
            this.LoanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanSearch.ForeColor = System.Drawing.Color.White;
            this.LoanSearch.Location = new System.Drawing.Point(165, 314);
            this.LoanSearch.Name = "LoanSearch";
            this.LoanSearch.Size = new System.Drawing.Size(158, 42);
            this.LoanSearch.TabIndex = 17;
            this.LoanSearch.Text = "Search";
            this.LoanSearch.UseVisualStyleBackColor = false;
            this.LoanSearch.Click += new System.EventHandler(this.LoanSearch_Click_1);
            // 
            // LoanDelete
            // 
            this.LoanDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.LoanDelete.FlatAppearance.BorderSize = 0;
            this.LoanDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanDelete.ForeColor = System.Drawing.Color.White;
            this.LoanDelete.Location = new System.Drawing.Point(264, 252);
            this.LoanDelete.Name = "LoanDelete";
            this.LoanDelete.Size = new System.Drawing.Size(158, 42);
            this.LoanDelete.TabIndex = 16;
            this.LoanDelete.Text = "Delete";
            this.LoanDelete.UseVisualStyleBackColor = false;
            this.LoanDelete.Click += new System.EventHandler(this.LoanDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 15;
            // 
            // LoanAdd
            // 
            this.LoanAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.LoanAdd.FlatAppearance.BorderSize = 0;
            this.LoanAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanAdd.ForeColor = System.Drawing.Color.White;
            this.LoanAdd.Location = new System.Drawing.Point(70, 252);
            this.LoanAdd.Name = "LoanAdd";
            this.LoanAdd.Size = new System.Drawing.Size(158, 42);
            this.LoanAdd.TabIndex = 8;
            this.LoanAdd.Text = "Add";
            this.LoanAdd.UseVisualStyleBackColor = false;
            this.LoanAdd.Click += new System.EventHandler(this.MemberAdd_Click);
            // 
            // LoanMemberIdText
            // 
            this.LoanMemberIdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.LoanMemberIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoanMemberIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanMemberIdText.ForeColor = System.Drawing.Color.White;
            this.LoanMemberIdText.Location = new System.Drawing.Point(203, 69);
            this.LoanMemberIdText.Name = "LoanMemberIdText";
            this.LoanMemberIdText.Size = new System.Drawing.Size(185, 15);
            this.LoanMemberIdText.TabIndex = 1;
            this.LoanMemberIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoanMemberIdText_KeyPress);
            // 
            // LoanBookIdText
            // 
            this.LoanBookIdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.LoanBookIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoanBookIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanBookIdText.ForeColor = System.Drawing.Color.White;
            this.LoanBookIdText.Location = new System.Drawing.Point(203, 131);
            this.LoanBookIdText.Name = "LoanBookIdText";
            this.LoanBookIdText.Size = new System.Drawing.Size(185, 15);
            this.LoanBookIdText.TabIndex = 2;
            this.LoanBookIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoanBookIdText_KeyPress);
            // 
            // LoanDateText
            // 
            this.LoanDateText.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanDateText.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoanDateText.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.LoanDateText.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoanDateText.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoanDateText.Location = new System.Drawing.Point(203, 184);
            this.LoanDateText.Name = "LoanDateText";
            this.LoanDateText.Size = new System.Drawing.Size(185, 22);
            this.LoanDateText.TabIndex = 3;
            this.LoanDateText.ValueChanged += new System.EventHandler(this.memberjoinedDate_ValueChanged);
            // 
            // LoanMemberid
            // 
            this.LoanMemberid.AutoSize = true;
            this.LoanMemberid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanMemberid.ForeColor = System.Drawing.Color.White;
            this.LoanMemberid.Location = new System.Drawing.Point(93, 69);
            this.LoanMemberid.Name = "LoanMemberid";
            this.LoanMemberid.Size = new System.Drawing.Size(72, 16);
            this.LoanMemberid.TabIndex = 4;
            this.LoanMemberid.Text = "Member Id";
            this.LoanMemberid.Click += new System.EventHandler(this.MemberFirstName_Click);
            // 
            // LoanDate
            // 
            this.LoanDate.AutoSize = true;
            this.LoanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanDate.ForeColor = System.Drawing.Color.White;
            this.LoanDate.Location = new System.Drawing.Point(93, 184);
            this.LoanDate.Name = "LoanDate";
            this.LoanDate.Size = new System.Drawing.Size(70, 16);
            this.LoanDate.TabIndex = 5;
            this.LoanDate.Text = "Loan Date";
            this.LoanDate.Click += new System.EventHandler(this.LoanDate_Click);
            // 
            // LoanBookid
            // 
            this.LoanBookid.AutoSize = true;
            this.LoanBookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanBookid.ForeColor = System.Drawing.Color.White;
            this.LoanBookid.Location = new System.Drawing.Point(93, 131);
            this.LoanBookid.Name = "LoanBookid";
            this.LoanBookid.Size = new System.Drawing.Size(54, 16);
            this.LoanBookid.TabIndex = 6;
            this.LoanBookid.Text = "Book Id";
            // 
            // ReturnedDateText
            // 
            this.ReturnedDateText.Location = new System.Drawing.Point(264, 28);
            this.ReturnedDateText.Name = "ReturnedDateText";
            this.ReturnedDateText.Size = new System.Drawing.Size(185, 20);
            this.ReturnedDateText.TabIndex = 16;
            // 
            // LoanPageTittle
            // 
            this.LoanPageTittle.AutoSize = true;
            this.LoanPageTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanPageTittle.ForeColor = System.Drawing.Color.White;
            this.LoanPageTittle.Location = new System.Drawing.Point(525, 35);
            this.LoanPageTittle.Name = "LoanPageTittle";
            this.LoanPageTittle.Size = new System.Drawing.Size(198, 29);
            this.LoanPageTittle.TabIndex = 16;
            this.LoanPageTittle.Text = "Loan Transaction";
            // 
            // LoanUpdateDelete
            // 
            this.LoanUpdateDelete.Controls.Add(this.LoanIdText);
            this.LoanUpdateDelete.Controls.Add(this.LoanIdLabel);
            this.LoanUpdateDelete.Controls.Add(this.LoanUpdate);
            this.LoanUpdateDelete.Controls.Add(this.ReturnedDateText);
            this.LoanUpdateDelete.ForeColor = System.Drawing.Color.White;
            this.LoanUpdateDelete.Location = new System.Drawing.Point(750, 494);
            this.LoanUpdateDelete.Name = "LoanUpdateDelete";
            this.LoanUpdateDelete.Size = new System.Drawing.Size(468, 122);
            this.LoanUpdateDelete.TabIndex = 17;
            this.LoanUpdateDelete.TabStop = false;
            this.LoanUpdateDelete.Text = "Returned  Date";
            // 
            // LoanIdText
            // 
            this.LoanIdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.LoanIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoanIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanIdText.ForeColor = System.Drawing.Color.White;
            this.LoanIdText.Location = new System.Drawing.Point(99, 33);
            this.LoanIdText.Name = "LoanIdText";
            this.LoanIdText.Size = new System.Drawing.Size(137, 15);
            this.LoanIdText.TabIndex = 20;
            this.LoanIdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoanIdText_KeyPress);
            // 
            // LoanIdLabel
            // 
            this.LoanIdLabel.AutoSize = true;
            this.LoanIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanIdLabel.ForeColor = System.Drawing.Color.White;
            this.LoanIdLabel.Location = new System.Drawing.Point(23, 32);
            this.LoanIdLabel.Name = "LoanIdLabel";
            this.LoanIdLabel.Size = new System.Drawing.Size(52, 16);
            this.LoanIdLabel.TabIndex = 19;
            this.LoanIdLabel.Text = "Loan Id";
            // 
            // LoanUpdate
            // 
            this.LoanUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.LoanUpdate.FlatAppearance.BorderSize = 0;
            this.LoanUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoanUpdate.ForeColor = System.Drawing.Color.White;
            this.LoanUpdate.Location = new System.Drawing.Point(165, 64);
            this.LoanUpdate.Name = "LoanUpdate";
            this.LoanUpdate.Size = new System.Drawing.Size(158, 42);
            this.LoanUpdate.TabIndex = 18;
            this.LoanUpdate.Text = "Update";
            this.LoanUpdate.UseVisualStyleBackColor = false;
            this.LoanUpdate.Click += new System.EventHandler(this.LoanUpdate_Click);
            // 
            // LoanBookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1269, 646);
            this.Controls.Add(this.LoanUpdateDelete);
            this.Controls.Add(this.LoanPageTittle);
            this.Controls.Add(this.LoanRegistration);
            this.Controls.Add(this.LoanDataView);
            this.Name = "LoanBookPage";
            this.Text = "Loan Book Page";
            this.Load += new System.EventHandler(this.LoanBookPage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.LoanDataView)).EndInit();
            this.LoanRegistration.ResumeLayout(false);
            this.LoanRegistration.PerformLayout();
            this.LoanUpdateDelete.ResumeLayout(false);
            this.LoanUpdateDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LoanDataView;
        private System.Windows.Forms.GroupBox LoanRegistration;
        private System.Windows.Forms.Button LoanAdd;
        private System.Windows.Forms.TextBox LoanMemberIdText;
        private System.Windows.Forms.TextBox LoanBookIdText;
        private System.Windows.Forms.DateTimePicker LoanDateText;
        private System.Windows.Forms.Label LoanMemberid;
        private System.Windows.Forms.Label LoanDate;
        private System.Windows.Forms.Label LoanBookid;
        private System.Windows.Forms.DateTimePicker ReturnedDateText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoanSearch;
        private System.Windows.Forms.Button LoanDelete;
        private System.Windows.Forms.Label LoanPageTittle;
        private System.Windows.Forms.GroupBox LoanUpdateDelete;
        private System.Windows.Forms.TextBox LoanIdText;
        private System.Windows.Forms.Label LoanIdLabel;
        private System.Windows.Forms.Button LoanUpdate;
    }
}