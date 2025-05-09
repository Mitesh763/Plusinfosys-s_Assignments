﻿namespace Intranet.Users
{
    partial class UpdateUser
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newUserName = new System.Windows.Forms.TextBox();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.newPhoneNumber = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newRoleCombo = new System.Windows.Forms.ComboBox();
            this.newCityCombo = new System.Windows.Forms.ComboBox();
            this.newUserActive = new System.Windows.Forms.RadioButton();
            this.newUserNotActive = new System.Windows.Forms.RadioButton();
            this.newBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.userUpdateMsg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Birth Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Active";
            // 
            // newUserName
            // 
            this.newUserName.Location = new System.Drawing.Point(263, 38);
            this.newUserName.Name = "newUserName";
            this.newUserName.Size = new System.Drawing.Size(167, 20);
            this.newUserName.TabIndex = 9;
            // 
            // newEmail
            // 
            this.newEmail.Location = new System.Drawing.Point(263, 126);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(167, 20);
            this.newEmail.TabIndex = 10;
            // 
            // newPhoneNumber
            // 
            this.newPhoneNumber.Location = new System.Drawing.Point(263, 173);
            this.newPhoneNumber.Name = "newPhoneNumber";
            this.newPhoneNumber.Size = new System.Drawing.Size(167, 20);
            this.newPhoneNumber.TabIndex = 11;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(263, 216);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(167, 20);
            this.newPassword.TabIndex = 12;
            // 
            // newRoleCombo
            // 
            this.newRoleCombo.DisplayMember = "RoleName";
            this.newRoleCombo.FormattingEnabled = true;
            this.newRoleCombo.Location = new System.Drawing.Point(263, 82);
            this.newRoleCombo.Name = "newRoleCombo";
            this.newRoleCombo.Size = new System.Drawing.Size(167, 21);
            this.newRoleCombo.TabIndex = 13;
            this.newRoleCombo.ValueMember = "RoleId";
            // 
            // newCityCombo
            // 
            this.newCityCombo.DisplayMember = "CityName";
            this.newCityCombo.FormattingEnabled = true;
            this.newCityCombo.Location = new System.Drawing.Point(263, 302);
            this.newCityCombo.Name = "newCityCombo";
            this.newCityCombo.Size = new System.Drawing.Size(167, 21);
            this.newCityCombo.TabIndex = 14;
            this.newCityCombo.ValueMember = "CityId";
            // 
            // newUserActive
            // 
            this.newUserActive.AutoSize = true;
            this.newUserActive.Location = new System.Drawing.Point(263, 338);
            this.newUserActive.Name = "newUserActive";
            this.newUserActive.Size = new System.Drawing.Size(43, 17);
            this.newUserActive.TabIndex = 15;
            this.newUserActive.TabStop = true;
            this.newUserActive.Text = "Yes";
            this.newUserActive.UseVisualStyleBackColor = true;
            // 
            // newUserNotActive
            // 
            this.newUserNotActive.AutoSize = true;
            this.newUserNotActive.Location = new System.Drawing.Point(332, 338);
            this.newUserNotActive.Name = "newUserNotActive";
            this.newUserNotActive.Size = new System.Drawing.Size(39, 17);
            this.newUserNotActive.TabIndex = 16;
            this.newUserNotActive.TabStop = true;
            this.newUserNotActive.Text = "No";
            this.newUserNotActive.UseVisualStyleBackColor = true;
            // 
            // newBirthDatePicker
            // 
            this.newBirthDatePicker.Location = new System.Drawing.Point(263, 264);
            this.newBirthDatePicker.Name = "newBirthDatePicker";
            this.newBirthDatePicker.Size = new System.Drawing.Size(167, 20);
            this.newBirthDatePicker.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UserUpdateHandler);
            // 
            // userUpdateMsg
            // 
            this.userUpdateMsg.AutoSize = true;
            this.userUpdateMsg.Location = new System.Drawing.Point(231, 435);
            this.userUpdateMsg.Name = "userUpdateMsg";
            this.userUpdateMsg.Size = new System.Drawing.Size(0, 13);
            this.userUpdateMsg.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userUpdateMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newBirthDatePicker);
            this.Controls.Add(this.newUserNotActive);
            this.Controls.Add(this.newUserActive);
            this.Controls.Add(this.newCityCombo);
            this.Controls.Add(this.newRoleCombo);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.newPhoneNumber);
            this.Controls.Add(this.newEmail);
            this.Controls.Add(this.newUserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.getUserDetail);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newUserName;
        private System.Windows.Forms.TextBox newEmail;
        private System.Windows.Forms.TextBox newPhoneNumber;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.ComboBox newRoleCombo;
        private System.Windows.Forms.ComboBox newCityCombo;
        private System.Windows.Forms.RadioButton newUserActive;
        private System.Windows.Forms.RadioButton newUserNotActive;
        private System.Windows.Forms.DateTimePicker newBirthDatePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userUpdateMsg;
        private System.Windows.Forms.Button button2;
    }
}