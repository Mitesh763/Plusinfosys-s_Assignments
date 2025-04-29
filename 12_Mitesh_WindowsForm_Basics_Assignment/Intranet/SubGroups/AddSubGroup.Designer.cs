namespace Intranet.SubGroups
{
    partial class AddSubGroup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addSubGroupInp = new System.Windows.Forms.TextBox();
            this.subGroupDescription = new System.Windows.Forms.TextBox();
            this.Sub_GroupCombo = new System.Windows.Forms.ComboBox();
            this.subGroupTrueStatus = new System.Windows.Forms.RadioButton();
            this.subGroupFalseStatus = new System.Windows.Forms.RadioButton();
            this.sub_UsersCombo = new System.Windows.Forms.ComboBox();
            this.addSubGroupMsg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(273, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New SubGroup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub Group Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Create By: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createSubGroupHandler);
            // 
            // addSubGroupInp
            // 
            this.addSubGroupInp.Location = new System.Drawing.Point(352, 89);
            this.addSubGroupInp.Name = "addSubGroupInp";
            this.addSubGroupInp.Size = new System.Drawing.Size(193, 20);
            this.addSubGroupInp.TabIndex = 7;
            // 
            // subGroupDescription
            // 
            this.subGroupDescription.Location = new System.Drawing.Point(352, 172);
            this.subGroupDescription.Multiline = true;
            this.subGroupDescription.Name = "subGroupDescription";
            this.subGroupDescription.Size = new System.Drawing.Size(193, 47);
            this.subGroupDescription.TabIndex = 8;
            // 
            // Sub_GroupCombo
            // 
            this.Sub_GroupCombo.DisplayMember = "GroupName";
            this.Sub_GroupCombo.FormattingEnabled = true;
            this.Sub_GroupCombo.Location = new System.Drawing.Point(352, 124);
            this.Sub_GroupCombo.Name = "Sub_GroupCombo";
            this.Sub_GroupCombo.Size = new System.Drawing.Size(193, 21);
            this.Sub_GroupCombo.TabIndex = 9;
            this.Sub_GroupCombo.ValueMember = "GroupId";
            // 
            // subGroupTrueStatus
            // 
            this.subGroupTrueStatus.AutoSize = true;
            this.subGroupTrueStatus.Location = new System.Drawing.Point(352, 251);
            this.subGroupTrueStatus.Name = "subGroupTrueStatus";
            this.subGroupTrueStatus.Size = new System.Drawing.Size(43, 17);
            this.subGroupTrueStatus.TabIndex = 10;
            this.subGroupTrueStatus.TabStop = true;
            this.subGroupTrueStatus.Text = "Yes";
            this.subGroupTrueStatus.UseVisualStyleBackColor = true;
            // 
            // subGroupFalseStatus
            // 
            this.subGroupFalseStatus.AutoSize = true;
            this.subGroupFalseStatus.Location = new System.Drawing.Point(429, 251);
            this.subGroupFalseStatus.Name = "subGroupFalseStatus";
            this.subGroupFalseStatus.Size = new System.Drawing.Size(39, 17);
            this.subGroupFalseStatus.TabIndex = 11;
            this.subGroupFalseStatus.TabStop = true;
            this.subGroupFalseStatus.Text = "No";
            this.subGroupFalseStatus.UseVisualStyleBackColor = true;
            // 
            // sub_UsersCombo
            // 
            this.sub_UsersCombo.DisplayMember = "UserName";
            this.sub_UsersCombo.FormattingEnabled = true;
            this.sub_UsersCombo.Location = new System.Drawing.Point(352, 298);
            this.sub_UsersCombo.Name = "sub_UsersCombo";
            this.sub_UsersCombo.Size = new System.Drawing.Size(193, 21);
            this.sub_UsersCombo.TabIndex = 12;
            this.sub_UsersCombo.ValueMember = "UserId";
            // 
            // addSubGroupMsg
            // 
            this.addSubGroupMsg.AutoSize = true;
            this.addSubGroupMsg.Location = new System.Drawing.Point(276, 393);
            this.addSubGroupMsg.Name = "addSubGroupMsg";
            this.addSubGroupMsg.Size = new System.Drawing.Size(0, 13);
            this.addSubGroupMsg.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // AddSubGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addSubGroupMsg);
            this.Controls.Add(this.sub_UsersCombo);
            this.Controls.Add(this.subGroupFalseStatus);
            this.Controls.Add(this.subGroupTrueStatus);
            this.Controls.Add(this.Sub_GroupCombo);
            this.Controls.Add(this.subGroupDescription);
            this.Controls.Add(this.addSubGroupInp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSubGroup";
            this.Text = "AddSubGroup";
            this.Load += new System.EventHandler(this.getCombodetail);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addSubGroupInp;
        private System.Windows.Forms.TextBox subGroupDescription;
        private System.Windows.Forms.ComboBox Sub_GroupCombo;
        private System.Windows.Forms.RadioButton subGroupTrueStatus;
        private System.Windows.Forms.RadioButton subGroupFalseStatus;
        private System.Windows.Forms.ComboBox sub_UsersCombo;
        private System.Windows.Forms.Label addSubGroupMsg;
        private System.Windows.Forms.Button button2;
    }
}