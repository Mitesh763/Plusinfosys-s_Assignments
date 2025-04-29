namespace Intranet.Cities
{
    partial class CityUpdate
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
            this.roleIdLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityUpdateMsg = new System.Windows.Forms.Label();
            this.roleNameInp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roleIdLbl
            // 
            this.roleIdLbl.AutoSize = true;
            this.roleIdLbl.Location = new System.Drawing.Point(308, 96);
            this.roleIdLbl.Name = "roleIdLbl";
            this.roleIdLbl.Size = new System.Drawing.Size(0, 13);
            this.roleIdLbl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Name: ";
            // 
            // cityUpdateMsg
            // 
            this.cityUpdateMsg.AutoSize = true;
            this.cityUpdateMsg.Location = new System.Drawing.Point(317, 221);
            this.cityUpdateMsg.Name = "cityUpdateMsg";
            this.cityUpdateMsg.Size = new System.Drawing.Size(0, 13);
            this.cityUpdateMsg.TabIndex = 2;
            // 
            // roleNameInp
            // 
            this.roleNameInp.Location = new System.Drawing.Point(386, 130);
            this.roleNameInp.Name = "roleNameInp";
            this.roleNameInp.Size = new System.Drawing.Size(153, 20);
            this.roleNameInp.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updateCityHandler);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(308, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Update City";
            // 
            // CityUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roleNameInp);
            this.Controls.Add(this.cityUpdateMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roleIdLbl);
            this.Name = "CityUpdate";
            this.Text = "CityUpdate";
            this.Load += new System.EventHandler(this.GetCityDetail);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleIdLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cityUpdateMsg;
        private System.Windows.Forms.TextBox roleNameInp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}