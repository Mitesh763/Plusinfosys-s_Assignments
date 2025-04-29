namespace Intranet.Roles
{
    partial class AddRole
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
            this.newRole = new System.Windows.Forms.TextBox();
            this.newRoleLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addRoleMsg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newRole
            // 
            this.newRole.Location = new System.Drawing.Point(264, 159);
            this.newRole.Name = "newRole";
            this.newRole.Size = new System.Drawing.Size(197, 20);
            this.newRole.TabIndex = 0;
            // 
            // newRoleLbl
            // 
            this.newRoleLbl.AutoSize = true;
            this.newRoleLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.newRoleLbl.Location = new System.Drawing.Point(290, 82);
            this.newRoleLbl.Name = "newRoleLbl";
            this.newRoleLbl.Size = new System.Drawing.Size(155, 30);
            this.newRoleLbl.TabIndex = 1;
            this.newRoleLbl.Text = "Add new Role";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddNewRole);
            // 
            // addRoleMsg
            // 
            this.addRoleMsg.AutoSize = true;
            this.addRoleMsg.Location = new System.Drawing.Point(264, 275);
            this.addRoleMsg.Name = "addRoleMsg";
            this.addRoleMsg.Size = new System.Drawing.Size(0, 13);
            this.addRoleMsg.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addRoleMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newRoleLbl);
            this.Controls.Add(this.newRole);
            this.Name = "AddRole";
            this.Text = "AddRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newRole;
        private System.Windows.Forms.Label newRoleLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label addRoleMsg;
        private System.Windows.Forms.Button button2;
    }
}