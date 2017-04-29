namespace Banque
{
    partial class withdraw
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
            this.label3 = new System.Windows.Forms.Label();
            this.idW = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.amountW = new System.Windows.Forms.TextBox();
            this.balanceW = new System.Windows.Forms.Label();
            this.withdrawW = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ID :";
            // 
            // idW
            // 
            this.idW.AutoSize = true;
            this.idW.Location = new System.Drawing.Point(91, 54);
            this.idW.Name = "idW";
            this.idW.Size = new System.Drawing.Size(35, 13);
            this.idW.TabIndex = 3;
            this.idW.Text = "label4";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(166, 54);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(52, 13);
            this.a.TabIndex = 4;
            this.a.Text = "Balance :";
            // 
            // amountW
            // 
            this.amountW.Location = new System.Drawing.Point(85, 100);
            this.amountW.Name = "amountW";
            this.amountW.Size = new System.Drawing.Size(100, 20);
            this.amountW.TabIndex = 6;
            // 
            // balanceW
            // 
            this.balanceW.AutoSize = true;
            this.balanceW.Location = new System.Drawing.Point(224, 54);
            this.balanceW.Name = "balanceW";
            this.balanceW.Size = new System.Drawing.Size(35, 13);
            this.balanceW.TabIndex = 7;
            this.balanceW.Text = "label7";
            // 
            // withdrawW
            // 
            this.withdrawW.Location = new System.Drawing.Point(94, 144);
            this.withdrawW.Name = "withdrawW";
            this.withdrawW.Size = new System.Drawing.Size(75, 23);
            this.withdrawW.TabIndex = 8;
            this.withdrawW.Text = "Withdraw";
            this.withdrawW.UseVisualStyleBackColor = true;
            this.withdrawW.Click += new System.EventHandler(this.withdrawW_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "User :";
            // 
            // userW
            // 
            this.userW.AutoSize = true;
            this.userW.Location = new System.Drawing.Point(85, 22);
            this.userW.Name = "userW";
            this.userW.Size = new System.Drawing.Size(35, 13);
            this.userW.TabIndex = 11;
            this.userW.Text = "label2";
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.userW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.withdrawW);
            this.Controls.Add(this.balanceW);
            this.Controls.Add(this.amountW);
            this.Controls.Add(this.a);
            this.Controls.Add(this.idW);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdraw";
            this.Load += new System.EventHandler(this.withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idW;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox amountW;
        private System.Windows.Forms.Label balanceW;
        private System.Windows.Forms.Button withdrawW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userW;
    }
}