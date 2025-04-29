namespace Intranet.Dashboard
{
    partial class UserDashboard
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
            this.newPostBtn = new System.Windows.Forms.Button();
            this.viewPostBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPostBtn
            // 
            this.newPostBtn.Location = new System.Drawing.Point(334, 120);
            this.newPostBtn.Name = "newPostBtn";
            this.newPostBtn.Size = new System.Drawing.Size(112, 55);
            this.newPostBtn.TabIndex = 0;
            this.newPostBtn.Text = "Add Post";
            this.newPostBtn.UseVisualStyleBackColor = true;
            this.newPostBtn.Click += new System.EventHandler(this.AddPostBtn);
            // 
            // viewPostBtn
            // 
            this.viewPostBtn.Location = new System.Drawing.Point(334, 230);
            this.viewPostBtn.Name = "viewPostBtn";
            this.viewPostBtn.Size = new System.Drawing.Size(112, 62);
            this.viewPostBtn.TabIndex = 1;
            this.viewPostBtn.Text = "View Post";
            this.viewPostBtn.UseVisualStyleBackColor = true;
            this.viewPostBtn.Click += new System.EventHandler(this.ViewPostBtn);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logout);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewPostBtn);
            this.Controls.Add(this.newPostBtn);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newPostBtn;
        private System.Windows.Forms.Button viewPostBtn;
        private System.Windows.Forms.Button button1;
    }
}