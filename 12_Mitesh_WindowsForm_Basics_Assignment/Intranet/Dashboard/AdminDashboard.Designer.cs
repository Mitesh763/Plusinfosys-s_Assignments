namespace Intranet.Dashboard
{
    partial class AdminDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subGroupMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.postToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMasterToolStripMenuItem,
            this.roleMasterToolStripMenuItem,
            this.cityMasterToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userMasterToolStripMenuItem.Text = "User Master";
            this.userMasterToolStripMenuItem.Click += new System.EventHandler(this.GetUserDetail);
            // 
            // roleMasterToolStripMenuItem
            // 
            this.roleMasterToolStripMenuItem.Name = "roleMasterToolStripMenuItem";
            this.roleMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roleMasterToolStripMenuItem.Text = "Role Master";
            this.roleMasterToolStripMenuItem.Click += new System.EventHandler(this.GetRoleDetail);
            // 
            // cityMasterToolStripMenuItem
            // 
            this.cityMasterToolStripMenuItem.Name = "cityMasterToolStripMenuItem";
            this.cityMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cityMasterToolStripMenuItem.Text = "City Master";
            this.cityMasterToolStripMenuItem.Click += new System.EventHandler(this.GetCityDetail);
            // 
            // postToolStripMenuItem
            // 
            this.postToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupMasterToolStripMenuItem,
            this.subGroupMasterToolStripMenuItem});
            this.postToolStripMenuItem.Name = "postToolStripMenuItem";
            this.postToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.postToolStripMenuItem.Text = "Post";
            // 
            // groupMasterToolStripMenuItem
            // 
            this.groupMasterToolStripMenuItem.Name = "groupMasterToolStripMenuItem";
            this.groupMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupMasterToolStripMenuItem.Text = "Group Master";
            this.groupMasterToolStripMenuItem.Click += new System.EventHandler(this.GetGroupDetail);
            // 
            // subGroupMasterToolStripMenuItem
            // 
            this.subGroupMasterToolStripMenuItem.Name = "subGroupMasterToolStripMenuItem";
            this.subGroupMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subGroupMasterToolStripMenuItem.Text = "SubGroup Master";
            this.subGroupMasterToolStripMenuItem.Click += new System.EventHandler(this.GetSubGroupDetail);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logout);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subGroupMasterToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}