namespace Intranet.Roles
{
    partial class RoleUpdate
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
            this.readRoleId = new System.Windows.Forms.Label();
            this.readRoleName = new System.Windows.Forms.TextBox();
            this.roleUpdateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateRoleMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readRoleId
            // 
            this.readRoleId.AutoSize = true;
            this.readRoleId.Location = new System.Drawing.Point(289, 95);
            this.readRoleId.Name = "readRoleId";
            this.readRoleId.Size = new System.Drawing.Size(49, 13);
            this.readRoleId.TabIndex = 0;
            this.readRoleId.Text = "Role ID: ";
            // 
            // readRoleName
            // 
            this.readRoleName.Location = new System.Drawing.Point(384, 137);
            this.readRoleName.Name = "readRoleName";
            this.readRoleName.Size = new System.Drawing.Size(184, 20);
            this.readRoleName.TabIndex = 1;
            // 
            // roleUpdateBtn
            // 
            this.roleUpdateBtn.Location = new System.Drawing.Point(292, 181);
            this.roleUpdateBtn.Name = "roleUpdateBtn";
            this.roleUpdateBtn.Size = new System.Drawing.Size(276, 44);
            this.roleUpdateBtn.TabIndex = 2;
            this.roleUpdateBtn.Text = "UPDATE";
            this.roleUpdateBtn.UseVisualStyleBackColor = true;
            this.roleUpdateBtn.Click += new System.EventHandler(this.RoleUpdateHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Role Name: ";
            // 
            // updateRoleMsg
            // 
            this.updateRoleMsg.AutoSize = true;
            this.updateRoleMsg.Location = new System.Drawing.Point(153, 233);
            this.updateRoleMsg.Name = "updateRoleMsg";
            this.updateRoleMsg.Size = new System.Drawing.Size(0, 13);
            this.updateRoleMsg.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBack);
            // 
            // RoleUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateRoleMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleUpdateBtn);
            this.Controls.Add(this.readRoleName);
            this.Controls.Add(this.readRoleId);
            this.Name = "RoleUpdate";
            this.Text = "RoleUpdate";
            this.Load += new System.EventHandler(this.GetRoleDetail);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label readRoleId;
        private System.Windows.Forms.TextBox readRoleName;
        private System.Windows.Forms.Button roleUpdateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label updateRoleMsg;
        private System.Windows.Forms.Button button1;
    }
}