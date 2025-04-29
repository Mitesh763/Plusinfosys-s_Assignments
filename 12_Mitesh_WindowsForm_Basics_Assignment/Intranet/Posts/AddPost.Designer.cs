namespace Intranet.Posts
{
    partial class AddPost
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
            this.postTitle = new System.Windows.Forms.TextBox();
            this.PostContent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.subGroupCombo = new System.Windows.Forms.ComboBox();
            this.PostImage1 = new System.Windows.Forms.OpenFileDialog();
            this.postImageBtn1 = new System.Windows.Forms.Button();
            this.PostImageBtn2 = new System.Windows.Forms.Button();
            this.PostImage2 = new System.Windows.Forms.OpenFileDialog();
            this.addPostMsg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.image1Preview = new System.Windows.Forms.PictureBox();
            this.image2Preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image1Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Post";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Image";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Second Image";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // postTitle
            // 
            this.postTitle.Location = new System.Drawing.Point(281, 103);
            this.postTitle.Name = "postTitle";
            this.postTitle.Size = new System.Drawing.Size(194, 20);
            this.postTitle.TabIndex = 6;
            // 
            // PostContent
            // 
            this.PostContent.Location = new System.Drawing.Point(281, 145);
            this.PostContent.Multiline = true;
            this.PostContent.Name = "PostContent";
            this.PostContent.Size = new System.Drawing.Size(194, 55);
            this.PostContent.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "CREATE POST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createPostHandler);
            // 
            // subGroupCombo
            // 
            this.subGroupCombo.DisplayMember = "SubGroupName";
            this.subGroupCombo.FormattingEnabled = true;
            this.subGroupCombo.Location = new System.Drawing.Point(281, 63);
            this.subGroupCombo.Name = "subGroupCombo";
            this.subGroupCombo.Size = new System.Drawing.Size(194, 21);
            this.subGroupCombo.TabIndex = 9;
            this.subGroupCombo.ValueMember = "SubGroupId";
            // 
            // PostImage1
            // 
            this.PostImage1.DefaultExt = "bmp";
            this.PostImage1.FileName = "postimage1";
            this.PostImage1.Filter = "(*.bmp)|*.bmp";
            // 
            // postImageBtn1
            // 
            this.postImageBtn1.Location = new System.Drawing.Point(169, 244);
            this.postImageBtn1.Name = "postImageBtn1";
            this.postImageBtn1.Size = new System.Drawing.Size(175, 23);
            this.postImageBtn1.TabIndex = 10;
            this.postImageBtn1.Text = "Upload Image 1";
            this.postImageBtn1.UseVisualStyleBackColor = true;
            this.postImageBtn1.Click += new System.EventHandler(this.image1Btn);
            // 
            // PostImageBtn2
            // 
            this.PostImageBtn2.Location = new System.Drawing.Point(402, 244);
            this.PostImageBtn2.Name = "PostImageBtn2";
            this.PostImageBtn2.Size = new System.Drawing.Size(175, 23);
            this.PostImageBtn2.TabIndex = 11;
            this.PostImageBtn2.Text = "Upload Image 2";
            this.PostImageBtn2.UseVisualStyleBackColor = true;
            this.PostImageBtn2.Click += new System.EventHandler(this.image2Btn);
            // 
            // PostImage2
            // 
            this.PostImage2.DefaultExt = "bmp";
            this.PostImage2.FileName = "openFileDialog1";
            this.PostImage2.Filter = "(*.bmp)|*.bmp";
            // 
            // addPostMsg
            // 
            this.addPostMsg.AutoSize = true;
            this.addPostMsg.Location = new System.Drawing.Point(281, 447);
            this.addPostMsg.Name = "addPostMsg";
            this.addPostMsg.Size = new System.Drawing.Size(0, 13);
            this.addPostMsg.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBack);
            // 
            // image1Preview
            // 
            this.image1Preview.Location = new System.Drawing.Point(169, 274);
            this.image1Preview.Name = "image1Preview";
            this.image1Preview.Size = new System.Drawing.Size(175, 151);
            this.image1Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1Preview.TabIndex = 14;
            this.image1Preview.TabStop = false;
            // 
            // image2Preview
            // 
            this.image2Preview.Location = new System.Drawing.Point(402, 274);
            this.image2Preview.Name = "image2Preview";
            this.image2Preview.Size = new System.Drawing.Size(175, 151);
            this.image2Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image2Preview.TabIndex = 15;
            this.image2Preview.TabStop = false;
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.image2Preview);
            this.Controls.Add(this.image1Preview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPostMsg);
            this.Controls.Add(this.PostImageBtn2);
            this.Controls.Add(this.postImageBtn1);
            this.Controls.Add(this.subGroupCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PostContent);
            this.Controls.Add(this.postTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPost";
            this.Text = "AddPost";
            this.Load += new System.EventHandler(this.AddPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image1Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2Preview)).EndInit();
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
        private System.Windows.Forms.TextBox postTitle;
        private System.Windows.Forms.TextBox PostContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox subGroupCombo;
        private System.Windows.Forms.OpenFileDialog PostImage1;
        private System.Windows.Forms.Button postImageBtn1;
        private System.Windows.Forms.Button PostImageBtn2;
        private System.Windows.Forms.OpenFileDialog PostImage2;
        private System.Windows.Forms.Label addPostMsg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox image1Preview;
        private System.Windows.Forms.PictureBox image2Preview;
    }
}