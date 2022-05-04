namespace IBAN
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "password";
            // 
            // usernameTXT
            // 
            this.usernameTXT.Location = new System.Drawing.Point(97, 74);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(116, 20);
            this.usernameTXT.TabIndex = 1;
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(94, 126);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(119, 20);
            this.passwordTXT.TabIndex = 1;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(111, 184);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 23);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 360);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTXT;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Button LoginBTN;
    }
}

