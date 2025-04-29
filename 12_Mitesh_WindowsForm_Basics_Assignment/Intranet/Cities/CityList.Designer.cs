namespace Intranet.Cities
{
    partial class CityList
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
            this.CityListGridView = new System.Windows.Forms.DataGridView();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addCityBtn = new System.Windows.Forms.Button();
            this.cityDeleteMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CityListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CityListGridView
            // 
            this.CityListGridView.AllowUserToAddRows = false;
            this.CityListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityId,
            this.CityName,
            this.Update,
            this.Delete});
            this.CityListGridView.Location = new System.Drawing.Point(144, 137);
            this.CityListGridView.Name = "CityListGridView";
            this.CityListGridView.Size = new System.Drawing.Size(466, 243);
            this.CityListGridView.TabIndex = 0;
            this.CityListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cityButtonAction);
            // 
            // CityId
            // 
            this.CityId.DataPropertyName = "CityId";
            this.CityId.HeaderText = "City ID";
            this.CityId.Name = "CityId";
            this.CityId.ReadOnly = true;
            // 
            // CityName
            // 
            this.CityName.DataPropertyName = "CItyName";
            this.CityName.HeaderText = "City Name";
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
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
            // addCityBtn
            // 
            this.addCityBtn.Location = new System.Drawing.Point(475, 48);
            this.addCityBtn.Name = "addCityBtn";
            this.addCityBtn.Size = new System.Drawing.Size(135, 42);
            this.addCityBtn.TabIndex = 1;
            this.addCityBtn.Text = "Add New City";
            this.addCityBtn.UseVisualStyleBackColor = true;
            this.addCityBtn.Click += new System.EventHandler(this.AddNewCity);
            // 
            // cityDeleteMsg
            // 
            this.cityDeleteMsg.AutoSize = true;
            this.cityDeleteMsg.Location = new System.Drawing.Point(318, 100);
            this.cityDeleteMsg.Name = "cityDeleteMsg";
            this.cityDeleteMsg.Size = new System.Drawing.Size(0, 13);
            this.cityDeleteMsg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true; this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(284, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "City List";
            // 
            // CityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cityDeleteMsg);
            this.Controls.Add(this.addCityBtn);
            this.Controls.Add(this.CityListGridView);
            this.Name = "CityList";
            this.Text = "CityList";
            this.Load += new System.EventHandler(this.GetCityList);
            ((System.ComponentModel.ISupportInitialize)(this.CityListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CityListGridView;
        private System.Windows.Forms.Button addCityBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label cityDeleteMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}