namespace Intranet.Roles
{
    partial class RoleList
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
            this.RoleListGridView = new System.Windows.Forms.DataGridView();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddNewRoleBtn = new System.Windows.Forms.Button();
            this.roleDeleteMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoleListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoleListGridView
            // 
            this.RoleListGridView.AllowUserToAddRows = false;
            this.RoleListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleId,
            this.RoleName,
            this.UPDATE,
            this.Delete});
            this.RoleListGridView.Location = new System.Drawing.Point(139, 121);
            this.RoleListGridView.Name = "RoleListGridView";
            this.RoleListGridView.Size = new System.Drawing.Size(482, 198);
            this.RoleListGridView.TabIndex = 0;
            this.RoleListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roleButtonAction);
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "RoleId";
            this.RoleId.HeaderText = "Role ID";
            this.RoleId.Name = "RoleId";
            this.RoleId.ReadOnly = true;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Role Name";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // UPDATE
            // 
            this.UPDATE.HeaderText = "Update";
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.ReadOnly = true;
            this.UPDATE.Text = "Update";
            this.UPDATE.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // AddNewRoleBtn
            // 
            this.AddNewRoleBtn.Location = new System.Drawing.Point(505, 36);
            this.AddNewRoleBtn.Name = "AddNewRoleBtn";
            this.AddNewRoleBtn.Size = new System.Drawing.Size(116, 43);
            this.AddNewRoleBtn.TabIndex = 1;
            this.AddNewRoleBtn.Text = "Add Role";
            this.AddNewRoleBtn.UseVisualStyleBackColor = true;
            this.AddNewRoleBtn.Click += new System.EventHandler(this.AddNewRole);
            // 
            // roleDeleteMsg
            // 
            this.roleDeleteMsg.AutoSize = true;
            this.roleDeleteMsg.Location = new System.Drawing.Point(317, 84);
            this.roleDeleteMsg.Name = "roleDeleteMsg";
            this.roleDeleteMsg.Size = new System.Drawing.Size(0, 13);
            this.roleDeleteMsg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(315, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Role List";
            // 
            // RoleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roleDeleteMsg);
            this.Controls.Add(this.AddNewRoleBtn);
            this.Controls.Add(this.RoleListGridView);
            this.Name = "RoleList";
            this.Text = "RoleList";
            this.Load += new System.EventHandler(this.GetRoleList);
            ((System.ComponentModel.ISupportInitialize)(this.RoleListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoleListGridView;
        private System.Windows.Forms.Button AddNewRoleBtn;
        private System.Windows.Forms.Label roleDeleteMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewButtonColumn UPDATE;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label1;
    }
}