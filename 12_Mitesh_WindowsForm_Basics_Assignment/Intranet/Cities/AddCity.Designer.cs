namespace Intranet.Cities
{
    partial class AddCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCiyMsg = new System.Windows.Forms.Label();
            this.newCityBtn = new System.Windows.Forms.Button();
            this.newCityInp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(316, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new City";
            // 
            // addCiyMsg
            // 
            this.addCiyMsg.AutoSize = true;
            this.addCiyMsg.Location = new System.Drawing.Point(316, 267);
            this.addCiyMsg.Name = "addCiyMsg";
            this.addCiyMsg.Size = new System.Drawing.Size(0, 13);
            this.addCiyMsg.TabIndex = 1;
            // 
            // newCityBtn
            // 
            this.newCityBtn.Location = new System.Drawing.Point(293, 216);
            this.newCityBtn.Name = "newCityBtn";
            this.newCityBtn.Size = new System.Drawing.Size(189, 23);
            this.newCityBtn.TabIndex = 2;
            this.newCityBtn.Text = "ADD";
            this.newCityBtn.UseVisualStyleBackColor = true;
            this.newCityBtn.Click += new System.EventHandler(this.NewCityHandler);
            // 
            // newCityInp
            // 
            this.newCityInp.Location = new System.Drawing.Point(293, 164);
            this.newCityInp.Name = "newCityInp";
            this.newCityInp.Size = new System.Drawing.Size(189, 20);
            this.newCityInp.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBack);
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newCityInp);
            this.Controls.Add(this.newCityBtn);
            this.Controls.Add(this.addCiyMsg);
            this.Controls.Add(this.label1);
            this.Name = "AddCity";
            this.Text = "AddCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addCiyMsg;
        private System.Windows.Forms.Button newCityBtn;
        private System.Windows.Forms.TextBox newCityInp;
        private System.Windows.Forms.Button button1;
    }
}