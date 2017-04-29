namespace Banque
{
    partial class option
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
            this.Oadd = new System.Windows.Forms.Button();
            this.Oaccess = new System.Windows.Forms.Button();
            this.Ologout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Oadd
            // 
            this.Oadd.Location = new System.Drawing.Point(100, 59);
            this.Oadd.Name = "Oadd";
            this.Oadd.Size = new System.Drawing.Size(75, 39);
            this.Oadd.TabIndex = 0;
            this.Oadd.Text = "Add a New Customer";
            this.Oadd.UseVisualStyleBackColor = true;
            this.Oadd.Click += new System.EventHandler(this.Oadd_Click);
            // 
            // Oaccess
            // 
            this.Oaccess.Location = new System.Drawing.Point(100, 113);
            this.Oaccess.Name = "Oaccess";
            this.Oaccess.Size = new System.Drawing.Size(75, 39);
            this.Oaccess.TabIndex = 1;
            this.Oaccess.Text = "Access to Account";
            this.Oaccess.UseVisualStyleBackColor = true;
            this.Oaccess.Click += new System.EventHandler(this.Oaccess_Click);
            // 
            // Ologout
            // 
            this.Ologout.Location = new System.Drawing.Point(100, 171);
            this.Ologout.Name = "Ologout";
            this.Ologout.Size = new System.Drawing.Size(75, 39);
            this.Ologout.TabIndex = 2;
            this.Ologout.Text = "Log Out";
            this.Ologout.UseVisualStyleBackColor = true;
            this.Ologout.Click += new System.EventHandler(this.Ologout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User :";
            // 
            // userO
            // 
            this.userO.AutoSize = true;
            this.userO.Location = new System.Drawing.Point(83, 13);
            this.userO.Name = "userO";
            this.userO.Size = new System.Drawing.Size(35, 13);
            this.userO.TabIndex = 4;
            this.userO.Text = "label2";
            // 
            // option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.userO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ologout);
            this.Controls.Add(this.Oaccess);
            this.Controls.Add(this.Oadd);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Oadd;
        private System.Windows.Forms.Button Oaccess;
        private System.Windows.Forms.Button Ologout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userO;
    }
}