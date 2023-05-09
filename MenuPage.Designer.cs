
namespace LibrarySystem
{
    partial class MenuPage
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
            this.MemberMenu = new System.Windows.Forms.Button();
            this.MenuBookTransactions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MemberMenu
            // 
            this.MemberMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.MemberMenu.FlatAppearance.BorderSize = 0;
            this.MemberMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MemberMenu.ForeColor = System.Drawing.Color.White;
            this.MemberMenu.Location = new System.Drawing.Point(61, 165);
            this.MemberMenu.Name = "MemberMenu";
            this.MemberMenu.Size = new System.Drawing.Size(264, 102);
            this.MemberMenu.TabIndex = 0;
            this.MemberMenu.Text = "Member Transactions";
            this.MemberMenu.UseVisualStyleBackColor = true;
            this.MemberMenu.Click += new System.EventHandler(this.MemberMenu_Click);
            // 
            // MenuBookTransactions
            // 
            this.MenuBookTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.MenuBookTransactions.FlatAppearance.BorderSize = 0;
            this.MenuBookTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBookTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MenuBookTransactions.ForeColor = System.Drawing.Color.White;
            this.MenuBookTransactions.Location = new System.Drawing.Point(468, 165);
            this.MenuBookTransactions.Name = "MenuBookTransactions";
            this.MenuBookTransactions.Size = new System.Drawing.Size(264, 102);
            this.MenuBookTransactions.TabIndex = 6;
            this.MenuBookTransactions.Text = "Book Transactions";
            this.MenuBookTransactions.UseVisualStyleBackColor = false;
            this.MenuBookTransactions.Click += new System.EventHandler(this.button6_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuBookTransactions);
            this.Controls.Add(this.MemberMenu);
            this.Name = "MenuPage";
            this.Text = "Menu Page";
            this.Load += new System.EventHandler(this.MenuPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MemberMenu;
        private System.Windows.Forms.Button MenuBookTransactions;
    }
}