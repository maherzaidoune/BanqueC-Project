namespace Banque
{
    partial class addUser
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
            this.userC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameA = new System.Windows.Forms.TextBox();
            this.lnameA = new System.Windows.Forms.TextBox();
            this.phoneA = new System.Windows.Forms.TextBox();
            this.nciA = new System.Windows.Forms.TextBox();
            this.addA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userC
            // 
            this.userC.AutoSize = true;
            this.userC.Location = new System.Drawing.Point(111, 19);
            this.userC.Name = "userC";
            this.userC.Size = new System.Drawing.Size(27, 13);
            this.userC.TabIndex = 11;
            this.userC.Text = "user";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "User :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(245, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "System date :";
            // 
            // dateC
            // 
            this.dateC.AutoSize = true;
            this.dateC.Location = new System.Drawing.Point(331, 19);
            this.dateC.Name = "dateC";
            this.dateC.Size = new System.Drawing.Size(41, 13);
            this.dateC.TabIndex = 12;
            this.dateC.Text = "--/--/----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Client Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "NCI :";
            // 
            // nameA
            // 
            this.nameA.Location = new System.Drawing.Point(238, 137);
            this.nameA.Name = "nameA";
            this.nameA.Size = new System.Drawing.Size(100, 20);
            this.nameA.TabIndex = 19;
            // 
            // lnameA
            // 
            this.lnameA.Location = new System.Drawing.Point(238, 173);
            this.lnameA.Name = "lnameA";
            this.lnameA.Size = new System.Drawing.Size(100, 20);
            this.lnameA.TabIndex = 20;
            // 
            // phoneA
            // 
            this.phoneA.Location = new System.Drawing.Point(238, 207);
            this.phoneA.Name = "phoneA";
            this.phoneA.Size = new System.Drawing.Size(100, 20);
            this.phoneA.TabIndex = 21;
            // 
            // nciA
            // 
            this.nciA.Location = new System.Drawing.Point(238, 242);
            this.nciA.Name = "nciA";
            this.nciA.Size = new System.Drawing.Size(100, 20);
            this.nciA.TabIndex = 22;
            // 
            // addA
            // 
            this.addA.Location = new System.Drawing.Point(238, 310);
            this.addA.Name = "addA";
            this.addA.Size = new System.Drawing.Size(100, 23);
            this.addA.TabIndex = 23;
            this.addA.Text = "Add User";
            this.addA.UseVisualStyleBackColor = true;
            this.addA.Click += new System.EventHandler(this.addA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(460, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addA);
            this.Controls.Add(this.nciA);
            this.Controls.Add(this.phoneA);
            this.Controls.Add(this.lnameA);
            this.Controls.Add(this.nameA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateC);
            this.Controls.Add(this.userC);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label dateC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lnameA;
        private System.Windows.Forms.TextBox phoneA;
        private System.Windows.Forms.TextBox nciA;
        private System.Windows.Forms.Button addA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameA;
    }
}