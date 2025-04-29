namespace Intranet.SubGroups
{
    partial class SubGroupUpdate
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
            this.updateSubGroupMsg = new System.Windows.Forms.Label();
            this.newSubGroupName = new System.Windows.Forms.TextBox();
            this.newSubGroupDescription = new System.Windows.Forms.TextBox();
            this.newSub_GroupCombo = new System.Windows.Forms.ComboBox();
            this.newSubGrouptrueStatus = new System.Windows.Forms.RadioButton();
            this.newSubGroupFalseStatus = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createdBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(290, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update SubGroup";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SubGroup Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Active: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Created By: ";
            // 
            // updateSubGroupMsg
            // 
            this.updateSubGroupMsg.AutoSize = true;
            this.updateSubGroupMsg.Location = new System.Drawing.Point(292, 78);
            this.updateSubGroupMsg.Name = "updateSubGroupMsg";
            this.updateSubGroupMsg.Size = new System.Drawing.Size(0, 13);
            this.updateSubGroupMsg.TabIndex = 6;
            // 
            // newSubGroupName
            // 
            this.newSubGroupName.Location = new System.Drawing.Point(378, 110);
            this.newSubGroupName.Name = "newSubGroupName";
            this.newSubGroupName.Size = new System.Drawing.Size(180, 20);
            this.newSubGroupName.TabIndex = 7;
            // 
            // newSubGroupDescription
            // 
            this.newSubGroupDescription.Location = new System.Drawing.Point(378, 216);
            this.newSubGroupDescription.Multiline = true;
            this.newSubGroupDescription.Name = "newSubGroupDescription";
            this.newSubGroupDescription.Size = new System.Drawing.Size(180, 63);
            this.newSubGroupDescription.TabIndex = 8;
            // 
            // newSub_GroupCombo
            // 
            this.newSub_GroupCombo.DisplayMember = "GroupName";
            this.newSub_GroupCombo.FormattingEnabled = true;
            this.newSub_GroupCombo.Location = new System.Drawing.Point(378, 165);
            this.newSub_GroupCombo.Name = "newSub_GroupCombo";
            this.newSub_GroupCombo.Size = new System.Drawing.Size(180, 21);
            this.newSub_GroupCombo.TabIndex = 10;
            this.newSub_GroupCombo.ValueMember = "GroupId";
            // 
            // newSubGrouptrueStatus
            // 
            this.newSubGrouptrueStatus.AutoSize = true;
            this.newSubGrouptrueStatus.Location = new System.Drawing.Point(378, 308);
            this.newSubGrouptrueStatus.Name = "newSubGrouptrueStatus";
            this.newSubGrouptrueStatus.Size = new System.Drawing.Size(43, 17);
            this.newSubGrouptrueStatus.TabIndex = 11;
            this.newSubGrouptrueStatus.TabStop = true;
            this.newSubGrouptrueStatus.Text = "Yes";
            this.newSubGrouptrueStatus.UseVisualStyleBackColor = true;
            // 
            // newSubGroupFalseStatus
            // 
            this.newSubGroupFalseStatus.AutoSize = true;
            this.newSubGroupFalseStatus.Location = new System.Drawing.Point(484, 308);
            this.newSubGroupFalseStatus.Name = "newSubGroupFalseStatus";
            this.newSubGroupFalseStatus.Size = new System.Drawing.Size(39, 17);
            this.newSubGroupFalseStatus.TabIndex = 12;
            this.newSubGroupFalseStatus.TabStop = true;
            this.newSubGroupFalseStatus.Text = "No";
            this.newSubGroupFalseStatus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.subGroupUpdateHandler);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // createdBy
            // 
            this.createdBy.Location = new System.Drawing.Point(378, 350);
            this.createdBy.Name = "createdBy";
            this.createdBy.ReadOnly = true;
            this.createdBy.Size = new System.Drawing.Size(180, 20);
            this.createdBy.TabIndex = 15;
            // 
            // SubGroupUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createdBy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newSubGroupFalseStatus);
            this.Controls.Add(this.newSubGrouptrueStatus);
            this.Controls.Add(this.newSub_GroupCombo);
            this.Controls.Add(this.newSubGroupDescription);
            this.Controls.Add(this.newSubGroupName);
            this.Controls.Add(this.updateSubGroupMsg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubGroupUpdate";
            this.Text = "SubGroupUpdate";
            this.Load += new System.EventHandler(this.GetSubGroupDetail);
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
        private System.Windows.Forms.Label updateSubGroupMsg;
        private System.Windows.Forms.TextBox newSubGroupName;
        private System.Windows.Forms.TextBox newSubGroupDescription;
        private System.Windows.Forms.ComboBox newSub_GroupCombo;
        private System.Windows.Forms.RadioButton newSubGrouptrueStatus;
        private System.Windows.Forms.RadioButton newSubGroupFalseStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox createdBy;
    }
}