namespace Intranet.Groups
{
    partial class GroupUpdate
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
            this.updateGroupMsg = new System.Windows.Forms.Label();
            this.newGroupName = new System.Windows.Forms.TextBox();
            this.newGroupDescription = new System.Windows.Forms.TextBox();
            this.newGroupStatus = new System.Windows.Forms.RadioButton();
            this.newGroupStatus2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createdBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Create By";
            // 
            // updateGroupMsg
            // 
            this.updateGroupMsg.AutoSize = true;
            this.updateGroupMsg.Location = new System.Drawing.Point(274, 354);
            this.updateGroupMsg.Name = "updateGroupMsg";
            this.updateGroupMsg.Size = new System.Drawing.Size(0, 13);
            this.updateGroupMsg.TabIndex = 5;
            this.updateGroupMsg.Click += new System.EventHandler(this.label6_Click);
            // 
            // newGroupName
            // 
            this.newGroupName.Location = new System.Drawing.Point(388, 77);
            this.newGroupName.Name = "newGroupName";
            this.newGroupName.Size = new System.Drawing.Size(133, 20);
            this.newGroupName.TabIndex = 6;
            // 
            // newGroupDescription
            // 
            this.newGroupDescription.Location = new System.Drawing.Point(388, 141);
            this.newGroupDescription.Multiline = true;
            this.newGroupDescription.Name = "newGroupDescription";
            this.newGroupDescription.Size = new System.Drawing.Size(133, 66);
            this.newGroupDescription.TabIndex = 7;
            // 
            // newGroupStatus
            // 
            this.newGroupStatus.AutoSize = true;
            this.newGroupStatus.Location = new System.Drawing.Point(388, 232);
            this.newGroupStatus.Name = "newGroupStatus";
            this.newGroupStatus.Size = new System.Drawing.Size(43, 17);
            this.newGroupStatus.TabIndex = 9;
            this.newGroupStatus.TabStop = true;
            this.newGroupStatus.Text = "Yes";
            this.newGroupStatus.UseVisualStyleBackColor = true;
            // 
            // newGroupStatus2
            // 
            this.newGroupStatus2.AutoSize = true;
            this.newGroupStatus2.Location = new System.Drawing.Point(482, 232);
            this.newGroupStatus2.Name = "newGroupStatus2";
            this.newGroupStatus2.Size = new System.Drawing.Size(39, 17);
            this.newGroupStatus2.TabIndex = 10;
            this.newGroupStatus2.TabStop = true;
            this.newGroupStatus2.Text = "No";
            this.newGroupStatus2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateGroupBtn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // createdBy
            // 
            this.createdBy.Location = new System.Drawing.Point(388, 274);
            this.createdBy.Name = "createdBy";
            this.createdBy.ReadOnly = true;
            this.createdBy.Size = new System.Drawing.Size(133, 20);
            this.createdBy.TabIndex = 13;
            // 
            // GroupUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createdBy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newGroupStatus2);
            this.Controls.Add(this.newGroupStatus);
            this.Controls.Add(this.newGroupDescription);
            this.Controls.Add(this.newGroupName);
            this.Controls.Add(this.updateGroupMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupUpdate";
            this.Text = "GroupUpdate";
            this.Load += new System.EventHandler(this.GroupUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label updateGroupMsg;
        private System.Windows.Forms.TextBox newGroupName;
        private System.Windows.Forms.TextBox newGroupDescription;
        private System.Windows.Forms.RadioButton newGroupStatus;
        private System.Windows.Forms.RadioButton newGroupStatus2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox createdBy;
    }
}