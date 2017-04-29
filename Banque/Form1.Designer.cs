namespace Banque
{
    partial class logFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logFrame));
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(21, 61);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(29, 13);
            this.user.TabIndex = 0;
            this.user.Text = "User";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(21, 123);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(53, 13);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // userField
            // 
            this.userField.AutoCompleteCustomSource.AddRange(new string[] {
            "admin",
            "maher",
            "user"});
            this.userField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.userField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.userField.Location = new System.Drawing.Point(99, 58);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(120, 20);
            this.userField.TabIndex = 2;
            this.userField.Text = "Enter id";
            this.userField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clearer);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(99, 116);
            this.password.Name = "password";
            this.password.PasswordChar = '#';
            this.password.Size = new System.Drawing.Size(120, 20);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(79, 179);
            this.login.Name = "login";
            this.login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(244, 241);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userField);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
    }
}

