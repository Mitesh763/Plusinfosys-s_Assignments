namespace Intranet.Posts
{
    partial class ViewAllPost
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
            this.PostGridView = new System.Windows.Forms.DataGridView();
            this.PostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LikeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PostGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PostGridView
            // 
            this.PostGridView.AllowUserToAddRows = false;
            this.PostGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PostId,
            this.Title,
            this.Content,
            this.SubGroupName,
            this.LikeCount,
            this.PostedDate,
            this.Detail});
            this.PostGridView.Location = new System.Drawing.Point(12, 144);
            this.PostGridView.Name = "PostGridView";
            this.PostGridView.Size = new System.Drawing.Size(748, 229);
            this.PostGridView.TabIndex = 0;
            this.PostGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetGroupPostDetail);
            // 
            // PostId
            // 
            this.PostId.DataPropertyName = "PostId";
            this.PostId.HeaderText = "Post ID";
            this.PostId.Name = "PostId";
            this.PostId.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // SubGroupName
            // 
            this.SubGroupName.DataPropertyName = "SubGroupName";
            this.SubGroupName.HeaderText = "PostBy";
            this.SubGroupName.Name = "SubGroupName";
            this.SubGroupName.ReadOnly = true;
            // 
            // LikeCount
            // 
            this.LikeCount.DataPropertyName = "LikeCount";
            this.LikeCount.HeaderText = "Like";
            this.LikeCount.Name = "LikeCount";
            this.LikeCount.ReadOnly = true;
            // 
            // PostedDate
            // 
            this.PostedDate.DataPropertyName = "PostedDate";
            this.PostedDate.HeaderText = "Posted Date";
            this.PostedDate.Name = "PostedDate";
            this.PostedDate.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "More";
            this.Detail.Name = "Detail";
            this.Detail.Text = "GET DETAIL";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(279, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Post Detail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBack);
            // 
            // ViewAllPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostGridView);
            this.Name = "ViewAllPost";
            this.Text = "ViewAllPost";
            this.Load += new System.EventHandler(this.ViewAllPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PostGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LikeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostedDate;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Button button1;
    }
}