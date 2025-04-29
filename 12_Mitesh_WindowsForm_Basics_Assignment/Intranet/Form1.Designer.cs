namespace Intranet
{
    partial class Form1
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
            this.loginHandler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginMsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(115, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login - Intranet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // loginHandler
            // 
            this.loginHandler.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginHandler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginHandler.ForeColor = System.Drawing.Color.White;
            this.loginHandler.Location = new System.Drawing.Point(120, 187);
            this.loginHandler.Name = "loginHandler";
            this.loginHandler.Size = new System.Drawing.Size(100, 30);
            this.loginHandler.TabIndex = 5;
            this.loginHandler.Text = "Login";
            this.loginHandler.UseVisualStyleBackColor = false;
            this.loginHandler.Click += new System.EventHandler(this.LoginHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(150, 75);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 25);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(150, 125);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 25);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // loginMsg
            // 
            this.loginMsg.AutoSize = true;
            this.loginMsg.ForeColor = System.Drawing.Color.Red;
            this.loginMsg.Location = new System.Drawing.Point(150, 220);
            this.loginMsg.Name = "loginMsg";
            this.loginMsg.Size = new System.Drawing.Size(0, 19);
            this.loginMsg.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.loginHandler);
            this.panel1.Controls.Add(this.loginMsg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 300);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(926, 550);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginHandler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label loginMsg;
        private System.Windows.Forms.Panel panel1;
    }
}