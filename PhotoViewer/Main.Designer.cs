namespace PhotoViewer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.DisplayName = new System.Windows.Forms.Label();
            this.GalleryList = new System.Windows.Forms.ListBox();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.GalleryBtnGroup = new System.Windows.Forms.GroupBox();
            this.SongBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageGallery = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchGroup = new System.Windows.Forms.GroupBox();
            this.GalleryBtnGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SearchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.Location = new System.Drawing.Point(1760, 78);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(110, 49);
            this.SignOutBtn.TabIndex = 0;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            this.SignOutBtn.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName.Location = new System.Drawing.Point(1613, 31);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(127, 22);
            this.DisplayName.TabIndex = 2;
            this.DisplayName.Text = "Signed in as:";
            // 
            // GalleryList
            // 
            this.GalleryList.FormattingEnabled = true;
            this.GalleryList.ItemHeight = 20;
            this.GalleryList.Location = new System.Drawing.Point(60, 368);
            this.GalleryList.Name = "GalleryList";
            this.GalleryList.Size = new System.Drawing.Size(255, 604);
            this.GalleryList.TabIndex = 3;
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(34, 41);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(110, 49);
            this.PrevBtn.TabIndex = 4;
            this.PrevBtn.Text = "Previous";
            this.PrevBtn.UseVisualStyleBackColor = true;
            // 
            // GalleryBtnGroup
            // 
            this.GalleryBtnGroup.Controls.Add(this.SongBtn);
            this.GalleryBtnGroup.Controls.Add(this.AddBtn);
            this.GalleryBtnGroup.Controls.Add(this.NextBtn);
            this.GalleryBtnGroup.Controls.Add(this.PrevBtn);
            this.GalleryBtnGroup.Location = new System.Drawing.Point(790, 152);
            this.GalleryBtnGroup.Name = "GalleryBtnGroup";
            this.GalleryBtnGroup.Size = new System.Drawing.Size(320, 166);
            this.GalleryBtnGroup.TabIndex = 5;
            this.GalleryBtnGroup.TabStop = false;
            this.GalleryBtnGroup.Text = "Gallery Controls";
            // 
            // SongBtn
            // 
            this.SongBtn.Location = new System.Drawing.Point(163, 96);
            this.SongBtn.Name = "SongBtn";
            this.SongBtn.Size = new System.Drawing.Size(110, 49);
            this.SongBtn.TabIndex = 7;
            this.SongBtn.Text = "Remove";
            this.SongBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(34, 96);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 49);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(163, 41);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(110, 49);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 600);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ImageGallery
            // 
            this.ImageGallery.FormattingEnabled = true;
            this.ImageGallery.ItemHeight = 20;
            this.ImageGallery.Location = new System.Drawing.Point(1617, 368);
            this.ImageGallery.Name = "ImageGallery";
            this.ImageGallery.Size = new System.Drawing.Size(255, 604);
            this.ImageGallery.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Galleries:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1615, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Images:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sort Images";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sort Galleries";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 26);
            this.textBox1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Search Galleries";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Search Images";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(269, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "Show All";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(756, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(381, 65);
            this.Title.TabIndex = 10;
            this.Title.Text = "Photo Viewer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Currently Viewing: ";
            // 
            // SearchGroup
            // 
            this.SearchGroup.Controls.Add(this.button1);
            this.SearchGroup.Controls.Add(this.textBox1);
            this.SearchGroup.Controls.Add(this.button2);
            this.SearchGroup.Controls.Add(this.label3);
            this.SearchGroup.Controls.Add(this.button3);
            this.SearchGroup.Controls.Add(this.button4);
            this.SearchGroup.Controls.Add(this.button5);
            this.SearchGroup.Location = new System.Drawing.Point(60, 100);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(524, 218);
            this.SearchGroup.TabIndex = 14;
            this.SearchGroup.TabStop = false;
            this.SearchGroup.Text = "Search and Sort";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.SearchGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageGallery);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GalleryBtnGroup);
            this.Controls.Add(this.GalleryList);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.SignOutBtn);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.GalleryBtnGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SearchGroup.ResumeLayout(false);
            this.SearchGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.ListBox GalleryList;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.GroupBox GalleryBtnGroup;
        private System.Windows.Forms.Button SongBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox ImageGallery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox SearchGroup;
    }
}