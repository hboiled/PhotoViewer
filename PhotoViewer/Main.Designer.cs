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
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchGalBtn = new System.Windows.Forms.Button();
            this.SearchImgBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ViewLbl = new System.Windows.Forms.Label();
            this.SearchGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GalleryNameTB = new System.Windows.Forms.TextBox();
            this.DeleteGalleryBtn = new System.Windows.Forms.Button();
            this.CreateGalleryBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ImageGallery = new System.Windows.Forms.DataGridView();
            this.ImageCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.GalleryBtnGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SearchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGallery)).BeginInit();
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
            this.DisplayName.Location = new System.Drawing.Point(1628, 31);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(133, 22);
            this.DisplayName.TabIndex = 2;
            this.DisplayName.Text = "Signed in as: ";
            // 
            // GalleryList
            // 
            this.GalleryList.FormattingEnabled = true;
            this.GalleryList.ItemHeight = 20;
            this.GalleryList.Location = new System.Drawing.Point(60, 368);
            this.GalleryList.Name = "GalleryList";
            this.GalleryList.Size = new System.Drawing.Size(255, 604);
            this.GalleryList.TabIndex = 3;
            this.GalleryList.SelectedIndexChanged += new System.EventHandler(this.GalleryList_SelectedIndexChanged);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(34, 41);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(110, 49);
            this.PrevBtn.TabIndex = 4;
            this.PrevBtn.Text = "Previous";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // GalleryBtnGroup
            // 
            this.GalleryBtnGroup.Controls.Add(this.RemoveBtn);
            this.GalleryBtnGroup.Controls.Add(this.AddBtn);
            this.GalleryBtnGroup.Controls.Add(this.NextBtn);
            this.GalleryBtnGroup.Controls.Add(this.PrevBtn);
            this.GalleryBtnGroup.Location = new System.Drawing.Point(1130, 152);
            this.GalleryBtnGroup.Name = "GalleryBtnGroup";
            this.GalleryBtnGroup.Size = new System.Drawing.Size(320, 166);
            this.GalleryBtnGroup.TabIndex = 5;
            this.GalleryBtnGroup.TabStop = false;
            this.GalleryBtnGroup.Text = "Gallery Controls";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(163, 96);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(110, 49);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(34, 96);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 49);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(163, 41);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(110, 49);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.InitialImage")));
            this.PictureBox.Location = new System.Drawing.Point(450, 368);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1000, 600);
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
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
            // SearchGalBtn
            // 
            this.SearchGalBtn.Location = new System.Drawing.Point(6, 110);
            this.SearchGalBtn.Name = "SearchGalBtn";
            this.SearchGalBtn.Size = new System.Drawing.Size(239, 36);
            this.SearchGalBtn.TabIndex = 11;
            this.SearchGalBtn.Text = "Search Galleries";
            this.SearchGalBtn.UseVisualStyleBackColor = true;
            this.SearchGalBtn.Click += new System.EventHandler(this.SearchGalBtn_Click);
            // 
            // SearchImgBtn
            // 
            this.SearchImgBtn.Location = new System.Drawing.Point(6, 158);
            this.SearchImgBtn.Name = "SearchImgBtn";
            this.SearchImgBtn.Size = new System.Drawing.Size(239, 37);
            this.SearchImgBtn.TabIndex = 12;
            this.SearchImgBtn.Text = "Search Images";
            this.SearchImgBtn.UseVisualStyleBackColor = true;
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
            // ViewLbl
            // 
            this.ViewLbl.AutoSize = true;
            this.ViewLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLbl.Location = new System.Drawing.Point(440, 332);
            this.ViewLbl.Name = "ViewLbl";
            this.ViewLbl.Size = new System.Drawing.Size(195, 25);
            this.ViewLbl.TabIndex = 11;
            this.ViewLbl.Text = "Currently Viewing: ";
            // 
            // SearchGroup
            // 
            this.SearchGroup.Controls.Add(this.label5);
            this.SearchGroup.Controls.Add(this.GalleryNameTB);
            this.SearchGroup.Controls.Add(this.DeleteGalleryBtn);
            this.SearchGroup.Controls.Add(this.CreateGalleryBtn);
            this.SearchGroup.Controls.Add(this.button1);
            this.SearchGroup.Controls.Add(this.textBox1);
            this.SearchGroup.Controls.Add(this.button2);
            this.SearchGroup.Controls.Add(this.label3);
            this.SearchGroup.Controls.Add(this.SearchGalBtn);
            this.SearchGroup.Controls.Add(this.SearchImgBtn);
            this.SearchGroup.Controls.Add(this.button5);
            this.SearchGroup.Location = new System.Drawing.Point(60, 100);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(854, 218);
            this.SearchGroup.TabIndex = 14;
            this.SearchGroup.TabStop = false;
            this.SearchGroup.Text = "Search and Sort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gallery";
            // 
            // GalleryNameTB
            // 
            this.GalleryNameTB.Location = new System.Drawing.Point(580, 69);
            this.GalleryNameTB.Name = "GalleryNameTB";
            this.GalleryNameTB.Size = new System.Drawing.Size(239, 26);
            this.GalleryNameTB.TabIndex = 16;
            // 
            // DeleteGalleryBtn
            // 
            this.DeleteGalleryBtn.Location = new System.Drawing.Point(580, 161);
            this.DeleteGalleryBtn.Name = "DeleteGalleryBtn";
            this.DeleteGalleryBtn.Size = new System.Drawing.Size(239, 36);
            this.DeleteGalleryBtn.TabIndex = 15;
            this.DeleteGalleryBtn.Text = "Delete Selected Gallery";
            this.DeleteGalleryBtn.UseVisualStyleBackColor = true;
            this.DeleteGalleryBtn.Click += new System.EventHandler(this.DeleteGalleryBtn_Click);
            // 
            // CreateGalleryBtn
            // 
            this.CreateGalleryBtn.Location = new System.Drawing.Point(580, 110);
            this.CreateGalleryBtn.Name = "CreateGalleryBtn";
            this.CreateGalleryBtn.Size = new System.Drawing.Size(239, 36);
            this.CreateGalleryBtn.TabIndex = 14;
            this.CreateGalleryBtn.Text = "Create New Gallery";
            this.CreateGalleryBtn.UseVisualStyleBackColor = true;
            this.CreateGalleryBtn.Click += new System.EventHandler(this.CreateGalleryBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1760, 193);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 102);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ImageGallery
            // 
            this.ImageGallery.AllowUserToAddRows = false;
            this.ImageGallery.AllowUserToDeleteRows = false;
            this.ImageGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImageGallery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageCol});
            this.ImageGallery.Location = new System.Drawing.Point(1620, 368);
            this.ImageGallery.Name = "ImageGallery";
            this.ImageGallery.ReadOnly = true;
            this.ImageGallery.RowHeadersWidth = 62;
            this.ImageGallery.RowTemplate.Height = 28;
            this.ImageGallery.Size = new System.Drawing.Size(240, 600);
            this.ImageGallery.TabIndex = 15;
            // 
            // ImageCol
            // 
            this.ImageCol.HeaderText = "Image";
            this.ImageCol.MinimumWidth = 100;
            this.ImageCol.Name = "ImageCol";
            this.ImageCol.ReadOnly = true;
            this.ImageCol.Width = 150;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.ImageGallery);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SearchGroup);
            this.Controls.Add(this.ViewLbl);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.GalleryBtnGroup);
            this.Controls.Add(this.GalleryList);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.SignOutBtn);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.GalleryBtnGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.SearchGroup.ResumeLayout(false);
            this.SearchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGallery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.ListBox GalleryList;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.GroupBox GalleryBtnGroup;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button SearchImgBtn;
        private System.Windows.Forms.Button SearchGalBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ViewLbl;
        private System.Windows.Forms.GroupBox SearchGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GalleryNameTB;
        private System.Windows.Forms.Button DeleteGalleryBtn;
        private System.Windows.Forms.Button CreateGalleryBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView ImageGallery;
        private System.Windows.Forms.DataGridViewImageColumn ImageCol;
    }
}