namespace Banque
{
    partial class deposit
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
            this.userW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.depositD = new System.Windows.Forms.Button();
            this.balanceW = new System.Windows.Forms.Label();
            this.amountW = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.idD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userW
            // 
            this.userW.AutoSize = true;
            this.userW.Location = new System.Drawing.Point(92, 16);
            this.userW.Name = "userW";
            this.userW.Size = new System.Drawing.Size(35, 13);
            this.userW.TabIndex = 20;
            this.userW.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "User :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // depositD
            // 
            this.depositD.Location = new System.Drawing.Point(101, 138);
            this.depositD.Name = "depositD";
            this.depositD.Size = new System.Drawing.Size(75, 23);
            this.depositD.TabIndex = 17;
            this.depositD.Text = "Deposit";
            this.depositD.UseVisualStyleBackColor = true;
            this.depositD.Click += new System.EventHandler(this.depositD_Click);
            // 
            // balanceW
            // 
            this.balanceW.AutoSize = true;
            this.balanceW.Location = new System.Drawing.Point(231, 48);
            this.balanceW.Name = "balanceW";
            this.balanceW.Size = new System.Drawing.Size(35, 13);
            this.balanceW.TabIndex = 16;
            this.balanceW.Text = "label7";
            // 
            // amountW
            // 
            this.amountW.Location = new System.Drawing.Point(92, 94);
            this.amountW.Name = "amountW";
            this.amountW.Size = new System.Drawing.Size(100, 20);
            this.amountW.TabIndex = 15;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(173, 48);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(52, 13);
            this.a.TabIndex = 14;
            this.a.Text = "Balance :";
            // 
            // idD
            // 
            this.idD.AutoSize = true;
            this.idD.Location = new System.Drawing.Point(98, 48);
            this.idD.Name = "idD";
            this.idD.Size = new System.Drawing.Size(35, 13);
            this.idD.TabIndex = 13;
            this.idD.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Client ID :";
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.userW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depositD);
            this.Controls.Add(this.balanceW);
            this.Controls.Add(this.amountW);
            this.Controls.Add(this.a);
            this.Controls.Add(this.idD);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button depositD;
        private System.Windows.Forms.Label balanceW;
        private System.Windows.Forms.TextBox amountW;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label idD;
        private System.Windows.Forms.Label label3;
    }
}