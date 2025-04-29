namespace Intranet.Groups
{
    partial class AddGroup
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
            this.allUserCombo = new System.Windows.Forms.ComboBox();
            this.addGroupInp = new System.Windows.Forms.TextBox();
            this.addGroupNameLbl = new System.Windows.Forms.Label();
            this.addGroupDescriptionLbl = new System.Windows.Forms.Label();
            this.addDescriptionInp = new System.Windows.Forms.TextBox();
            this.addGroupStatusLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addTrueStatusInp = new System.Windows.Forms.RadioButton();
            this.addFalseStatusInp = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.createGroupBtn = new System.Windows.Forms.Button();
            this.addGroupMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allUserCombo
            // 
            this.allUserCombo.DisplayMember = "UserName";
            this.allUserCombo.FormattingEnabled = true;
            this.allUserCombo.Location = new System.Drawing.Point(327, 283);
            this.allUserCombo.Name = "allUserCombo";
            this.allUserCombo.Size = new System.Drawing.Size(189, 21);
            this.allUserCombo.TabIndex = 0;
            this.allUserCombo.ValueMember = "UserId";
            this.allUserCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addGroupInp
            // 
            this.addGroupInp.Location = new System.Drawing.Point(327, 107);
            this.addGroupInp.Name = "addGroupInp";
            this.addGroupInp.Size = new System.Drawing.Size(189, 20);
            this.addGroupInp.TabIndex = 1;
            // 
            // addGroupNameLbl
            // 
            this.addGroupNameLbl.AutoSize = true;
            this.addGroupNameLbl.Location = new System.Drawing.Point(217, 114);
            this.addGroupNameLbl.Name = "addGroupNameLbl";
            this.addGroupNameLbl.Size = new System.Drawing.Size(67, 13);
            this.addGroupNameLbl.TabIndex = 2;
            this.addGroupNameLbl.Text = "Group Name";
            // 
            // addGroupDescriptionLbl
            // 
            this.addGroupDescriptionLbl.AutoSize = true;
            this.addGroupDescriptionLbl.Location = new System.Drawing.Point(217, 175);
            this.addGroupDescriptionLbl.Name = "addGroupDescriptionLbl";
            this.addGroupDescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.addGroupDescriptionLbl.TabIndex = 3;
            this.addGroupDescriptionLbl.Text = "Description";
            // 
            // addDescriptionInp
            // 
            this.addDescriptionInp.Location = new System.Drawing.Point(327, 150);
            this.addDescriptionInp.Multiline = true;
            this.addDescriptionInp.Name = "addDescriptionInp";
            this.addDescriptionInp.Size = new System.Drawing.Size(189, 53);
            this.addDescriptionInp.TabIndex = 4;
            // 
            // addGroupStatusLbl
            // 
            this.addGroupStatusLbl.AutoSize = true;
            this.addGroupStatusLbl.Location = new System.Drawing.Point(217, 237);
            this.addGroupStatusLbl.Name = "addGroupStatusLbl";
            this.addGroupStatusLbl.Size = new System.Drawing.Size(37, 13);
            this.addGroupStatusLbl.TabIndex = 5;
            this.addGroupStatusLbl.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Create By: ";
            // 
            // addTrueStatusInp
            // 
            this.addTrueStatusInp.AutoSize = true;
            this.addTrueStatusInp.Location = new System.Drawing.Point(327, 233);
            this.addTrueStatusInp.Name = "addTrueStatusInp";
            this.addTrueStatusInp.Size = new System.Drawing.Size(43, 17);
            this.addTrueStatusInp.TabIndex = 8;
            this.addTrueStatusInp.TabStop = true;
            this.addTrueStatusInp.Text = "Yes";
            this.addTrueStatusInp.UseVisualStyleBackColor = true;
            // 
            // addFalseStatusInp
            // 
            this.addFalseStatusInp.AutoSize = true;
            this.addFalseStatusInp.Location = new System.Drawing.Point(431, 233);
            this.addFalseStatusInp.Name = "addFalseStatusInp";
            this.addFalseStatusInp.Size = new System.Drawing.Size(39, 17);
            this.addFalseStatusInp.TabIndex = 9;
            this.addFalseStatusInp.TabStop = true;
            this.addFalseStatusInp.Text = "No";
            this.addFalseStatusInp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(278, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Create New Group";
            // 
            // createGroupBtn
            // 
            this.createGroupBtn.Location = new System.Drawing.Point(327, 351);
            this.createGroupBtn.Name = "createGroupBtn";
            this.createGroupBtn.Size = new System.Drawing.Size(189, 39);
            this.createGroupBtn.TabIndex = 12;
            this.createGroupBtn.Text = "CREATE";
            this.createGroupBtn.UseVisualStyleBackColor = true;
            this.createGroupBtn.Click += new System.EventHandler(this.createGroupBtn_Click);
            // 
            // addGroupMsg
            // 
            this.addGroupMsg.AutoSize = true;
            this.addGroupMsg.Location = new System.Drawing.Point(133, 361);
            this.addGroupMsg.Name = "addGroupMsg";
            this.addGroupMsg.Size = new System.Drawing.Size(0, 13);
            this.addGroupMsg.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBack);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addGroupMsg);
            this.Controls.Add(this.createGroupBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addFalseStatusInp);
            this.Controls.Add(this.addTrueStatusInp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addGroupStatusLbl);
            this.Controls.Add(this.addDescriptionInp);
            this.Controls.Add(this.addGroupDescriptionLbl);
            this.Controls.Add(this.addGroupNameLbl);
            this.Controls.Add(this.addGroupInp);
            this.Controls.Add(this.allUserCombo);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.GetUserDetail);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox allUserCombo;
        private System.Windows.Forms.TextBox addGroupInp;
        private System.Windows.Forms.Label addGroupNameLbl;
        private System.Windows.Forms.Label addGroupDescriptionLbl;
        private System.Windows.Forms.TextBox addDescriptionInp;
        private System.Windows.Forms.Label addGroupStatusLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton addTrueStatusInp;
        private System.Windows.Forms.RadioButton addFalseStatusInp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createGroupBtn;
        private System.Windows.Forms.Label addGroupMsg;
        private System.Windows.Forms.Button button1;
    }
}