namespace Intranet.Users
{
    partial class AddUser
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
            this.userName = new System.Windows.Forms.TextBox();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            this.email = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CityCombo = new System.Windows.Forms.ComboBox();
            this.userActive = new System.Windows.Forms.RadioButton();
            this.UserNotActive = new System.Windows.Forms.RadioButton();
            this.addUserMsg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "UserName :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password :";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(383, 63);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(167, 20);
            this.userName.TabIndex = 6;
            // 
            // roleCombo
            // 
            this.roleCombo.DisplayMember = "RoleName";
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.Location = new System.Drawing.Point(383, 100);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(167, 21);
            this.roleCombo.TabIndex = 7;
            this.roleCombo.ValueMember = "RoleId";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(383, 142);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 20);
            this.email.TabIndex = 8;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(383, 186);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(167, 20);
            this.PhoneNumber.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(383, 226);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(167, 20);
            this.Password.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Birth Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "City :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Status : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddUserHandler);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(383, 265);
            this.birthDatePicker.MaxDate = new System.DateTime(2025, 3, 13, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(167, 20);
            this.birthDatePicker.TabIndex = 15;
            this.birthDatePicker.Value = new System.DateTime(2025, 3, 13, 0, 0, 0, 0);
            // 
            // CityCombo
            // 
            this.CityCombo.DisplayMember = "CityName";
            this.CityCombo.FormattingEnabled = true;
            this.CityCombo.Location = new System.Drawing.Point(383, 301);
            this.CityCombo.Name = "CityCombo";
            this.CityCombo.Size = new System.Drawing.Size(167, 21);
            this.CityCombo.TabIndex = 16;
            this.CityCombo.ValueMember = "CityId";
            // 
            // userActive
            // 
            this.userActive.AutoSize = true;
            this.userActive.Location = new System.Drawing.Point(383, 346);
            this.userActive.Name = "userActive";
            this.userActive.Size = new System.Drawing.Size(43, 17);
            this.userActive.TabIndex = 17;
            this.userActive.TabStop = true;
            this.userActive.Text = "Yes";
            this.userActive.UseVisualStyleBackColor = true;
            // 
            // UserNotActive
            // 
            this.UserNotActive.AutoSize = true;
            this.UserNotActive.Location = new System.Drawing.Point(469, 346);
            this.UserNotActive.Name = "UserNotActive";
            this.UserNotActive.Size = new System.Drawing.Size(39, 17);
            this.UserNotActive.TabIndex = 18;
            this.UserNotActive.TabStop = true;
            this.UserNotActive.Text = "No";
            this.UserNotActive.UseVisualStyleBackColor = true;
            // 
            // addUserMsg
            // 
            this.addUserMsg.AutoSize = true;
            this.addUserMsg.Location = new System.Drawing.Point(251, 425);
            this.addUserMsg.Name = "addUserMsg";
            this.addUserMsg.Size = new System.Drawing.Size(0, 13);
            this.addUserMsg.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addUserMsg);
            this.Controls.Add(this.UserNotActive);
            this.Controls.Add(this.userActive);
            this.Controls.Add(this.CityCombo);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.roleCombo);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "          ";
            this.Load += new System.EventHandler(this.getCityRole_Details);
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
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.ComboBox roleCombo;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.ComboBox CityCombo;
        private System.Windows.Forms.RadioButton userActive;
        private System.Windows.Forms.RadioButton UserNotActive;
        private System.Windows.Forms.Label addUserMsg;
        private System.Windows.Forms.Button button2;
    }
}