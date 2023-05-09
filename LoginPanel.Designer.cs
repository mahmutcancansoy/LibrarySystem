
namespace LibrarySystem
{
    partial class LoginPanel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginPageTittle = new System.Windows.Forms.Label();
            this.LoginPageEmail = new System.Windows.Forms.Label();
            this.LoginPagePassword = new System.Windows.Forms.Label();
            this.LoginEmailArea = new System.Windows.Forms.TextBox();
            this.LoginPasswordArea = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginPageTittle
            // 
            this.LoginPageTittle.AutoSize = true;
            this.LoginPageTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginPageTittle.ForeColor = System.Drawing.Color.White;
            this.LoginPageTittle.Location = new System.Drawing.Point(285, 84);
            this.LoginPageTittle.Name = "LoginPageTittle";
            this.LoginPageTittle.Size = new System.Drawing.Size(170, 24);
            this.LoginPageTittle.TabIndex = 0;
            this.LoginPageTittle.Text = "Admin Login Panel";
            // 
            // LoginPageEmail
            // 
            this.LoginPageEmail.AutoSize = true;
            this.LoginPageEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginPageEmail.ForeColor = System.Drawing.Color.White;
            this.LoginPageEmail.Location = new System.Drawing.Point(221, 181);
            this.LoginPageEmail.Name = "LoginPageEmail";
            this.LoginPageEmail.Size = new System.Drawing.Size(45, 16);
            this.LoginPageEmail.TabIndex = 1;
            this.LoginPageEmail.Text = "Name";
            // 
            // LoginPagePassword
            // 
            this.LoginPagePassword.AutoSize = true;
            this.LoginPagePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginPagePassword.ForeColor = System.Drawing.Color.White;
            this.LoginPagePassword.Location = new System.Drawing.Point(221, 243);
            this.LoginPagePassword.Name = "LoginPagePassword";
            this.LoginPagePassword.Size = new System.Drawing.Size(61, 15);
            this.LoginPagePassword.TabIndex = 2;
            this.LoginPagePassword.Text = "Password";
            // 
            // LoginEmailArea
            // 
            this.LoginEmailArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.LoginEmailArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginEmailArea.ForeColor = System.Drawing.Color.White;
            this.LoginEmailArea.Location = new System.Drawing.Point(329, 184);
            this.LoginEmailArea.Name = "LoginEmailArea";
            this.LoginEmailArea.Size = new System.Drawing.Size(192, 13);
            this.LoginEmailArea.TabIndex = 3;
            this.LoginEmailArea.TextChanged += new System.EventHandler(this.LoginEmailArea_TextChanged);
            // 
            // LoginPasswordArea
            // 
            this.LoginPasswordArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.LoginPasswordArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPasswordArea.ForeColor = System.Drawing.Color.White;
            this.LoginPasswordArea.Location = new System.Drawing.Point(329, 245);
            this.LoginPasswordArea.Name = "LoginPasswordArea";
            this.LoginPasswordArea.Size = new System.Drawing.Size(192, 13);
            this.LoginPasswordArea.TabIndex = 4;
            this.LoginPasswordArea.TextChanged += new System.EventHandler(this.LoginPasswordArea_TextChanged);
            this.LoginPasswordArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPasswordArea_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(289, 323);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(166, 53);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginPasswordArea);
            this.Controls.Add(this.LoginEmailArea);
            this.Controls.Add(this.LoginPagePassword);
            this.Controls.Add(this.LoginPageEmail);
            this.Controls.Add(this.LoginPageTittle);
            this.Name = "LoginPanel";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginPageTittle;
        private System.Windows.Forms.Label LoginPageEmail;
        private System.Windows.Forms.Label LoginPagePassword;
        private System.Windows.Forms.TextBox LoginEmailArea;
        private System.Windows.Forms.TextBox LoginPasswordArea;
        private System.Windows.Forms.Button LoginButton;
    }
}

