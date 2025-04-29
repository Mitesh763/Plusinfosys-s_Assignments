namespace Intranet.Groups
{
    partial class GroupList
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
            this.GroupDetailGridView = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.createGroupBtn = new System.Windows.Forms.Button();
            this.groupActionMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupDetailGridView
            // 
            this.GroupDetailGridView.AllowUserToAddRows = false;
            this.GroupDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.GroupName,
            this.Description,
            this.IsActive,
            this.CreatedAt,
            this.UserName,
            this.Update,
            this.Delete});
            this.GroupDetailGridView.Location = new System.Drawing.Point(68, 144);
            this.GroupDetailGridView.Name = "GroupDetailGridView";
            this.GroupDetailGridView.Size = new System.Drawing.Size(608, 193);
            this.GroupDetailGridView.TabIndex = 1;
            this.GroupDetailGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupActionHandler);
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "GroupId";
            this.GroupId.HeaderText = "Group ID";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Status";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Created Date";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "CreatedBy";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // createGroupBtn
            // 
            this.createGroupBtn.Location = new System.Drawing.Point(556, 46);
            this.createGroupBtn.Name = "createGroupBtn";
            this.createGroupBtn.Size = new System.Drawing.Size(120, 46);
            this.createGroupBtn.TabIndex = 1;
            this.createGroupBtn.Text = "Create Group";
            this.createGroupBtn.UseVisualStyleBackColor = true;
            this.createGroupBtn.Click += new System.EventHandler(this.createGroupHandler);
            // 
            // groupActionMsg
            // 
            this.groupActionMsg.AutoSize = true;
            this.groupActionMsg.Location = new System.Drawing.Point(387, 103);
            this.groupActionMsg.Name = "groupActionMsg";
            this.groupActionMsg.Size = new System.Drawing.Size(0, 13);
            this.groupActionMsg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 46);
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
            this.label1.Location = new System.Drawing.Point(313, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Group List";
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupActionMsg);
            this.Controls.Add(this.createGroupBtn);
            this.Controls.Add(this.GroupDetailGridView);
            this.Name = "GroupList";
            this.Text = "GroupList";
            this.Load += new System.EventHandler(this.GetGroupDetail);
            ((System.ComponentModel.ISupportInitialize)(this.GroupDetailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupDetailGridView;
        private System.Windows.Forms.Button createGroupBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label groupActionMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}