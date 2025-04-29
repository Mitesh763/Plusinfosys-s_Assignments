namespace Intranet.SubGroups
{
    partial class SubGroupList
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
            this.SubGroupDetailGridView = new System.Windows.Forms.DataGridView();
            this.SubGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.subgroupActionMsg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubGroupDetailGridView
            // 
            this.SubGroupDetailGridView.AllowUserToAddRows = false;
            this.SubGroupDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubGroupDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubGroupId,
            this.SubGroupName,
            this.GroupName,
            this.Description,
            this.IsActive,
            this.CreatedAt,
            this.UserName,
            this.Update,
            this.Delete});
            this.SubGroupDetailGridView.Location = new System.Drawing.Point(22, 156);
            this.SubGroupDetailGridView.Name = "SubGroupDetailGridView";
            this.SubGroupDetailGridView.Size = new System.Drawing.Size(746, 166);
            this.SubGroupDetailGridView.TabIndex = 0;
            this.SubGroupDetailGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subGroupActionHandler);
            // 
            // SubGroupId
            // 
            this.SubGroupId.DataPropertyName = "SubGroupId";
            this.SubGroupId.HeaderText = "SubGroup ID";
            this.SubGroupId.Name = "SubGroupId";
            this.SubGroupId.ReadOnly = true;
            // 
            // SubGroupName
            // 
            this.SubGroupName.DataPropertyName = "SubGroupName";
            this.SubGroupName.HeaderText = "SubGroup Name";
            this.SubGroupName.Name = "SubGroupName";
            this.SubGroupName.ReadOnly = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create New SubGroup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createSubGroupBtn);
            // 
            // subgroupActionMsg
            // 
            this.subgroupActionMsg.AutoSize = true;
            this.subgroupActionMsg.Location = new System.Drawing.Point(296, 100);
            this.subgroupActionMsg.Name = "subgroupActionMsg";
            this.subgroupActionMsg.Size = new System.Drawing.Size(0, 13);
            this.subgroupActionMsg.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(284, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "SubGroupList";
            // 
            // SubGroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subgroupActionMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SubGroupDetailGridView);
            this.Name = "SubGroupList";
            this.Text = "SubGroupList";
            this.Load += new System.EventHandler(this.SubGroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubGroupDetailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubGroupDetailGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label subgroupActionMsg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}