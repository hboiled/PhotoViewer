﻿using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ***TODO
// ** ON INIT
// set displayname to logged in user upon init
// load galleries into gallery list box
// if user has no galleries, create a default gallery

// sign out btn closes and disposes this form and returns clean sign in form
//

namespace PhotoViewer
{
    public partial class Main : Form
    {
        private string userSignedIn;
        private List<Gallery> galleries;
        private Gallery defaultGallery;
        private Gallery selectedGallery;

        public Main(string username)
        {
            InitializeComponent();
            userSignedIn = username;
            DisplayName.Text += username;
            galleries = new List<Gallery>();
            LoadGalleries();

            // Only create a default gallery for users with no galleries
            if (galleries.Count == 0)
            {
                defaultGallery = new Gallery("default");
                galleries.Add(defaultGallery);
            }

            RefreshGalleryList();
        }

        private void LoadGalleries()
        {            
            string userPath = string.Format("..\\..\\Data\\Users\\{0}", userSignedIn);
            Directory.CreateDirectory(userPath);

            DirectoryInfo userInfo = new DirectoryInfo(userPath);
            FileInfo[] galleryFiles = userInfo.GetFiles("*.csv");

            if (galleryFiles.Length > 0)
            {
                foreach (FileInfo file in galleryFiles)
                {
                    Gallery gallery = new Gallery(Path.GetFileNameWithoutExtension(file.FullName));
                    using (CsvReader csv = new CsvReader(
                                    new StreamReader(file.FullName), false))
                    {
                        while (csv.ReadNextRecord())
                        {
                            string location = csv[0];

                            gallery.Add(location);
                        }

                    }
                    galleries.Add(gallery);
                }
            }
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Dispose();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreateGalleryBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GalleryNameTB.Text))
            {
                string name = GalleryNameTB.Text;

                if (!GalleryNameExists(name))
                {
                    Gallery newGallery = new Gallery(name);

                    galleries.Add(newGallery);
                    RefreshGalleryList();
                }
                // display error msg
                
            }            
        }

        private Boolean GalleryNameExists(string name)
        {
            foreach (Gallery gallery in galleries)
            {
                if (gallery.ToString().Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // create dir if does not exist
            Directory.CreateDirectory(string.Format("..\\..\\Data\\Users\\{0}", userSignedIn));

            foreach (Gallery gallery in galleries)
            {
                string name = gallery.ToString();
                string path = string.Format("..\\..\\Data\\Users\\{0}\\{1}.csv", 
                    userSignedIn, name);

                using (var w = new StreamWriter(path))
                {
                    foreach (string location in gallery.Images)
                    {                        
                        w.WriteLine(location);
                        w.Flush();
                    }
                }
            }
        }

        private void RefreshGalleryList()
        {
            GalleryList.DataSource = null;
            GalleryList.DataSource = galleries;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
                openFileDialog.InitialDirectory = path + "\\sample_photos";
                openFileDialog.AutoUpgradeEnabled = true;
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // get file path for other operations
                    // get selected gallery
                    filePath = openFileDialog.FileName;
                    processImage(filePath);
                }
            }
        }

        private void processImage(string filePath)
        {
            if (GalleryList.SelectedIndex >= 0)
            {
                int index = GalleryList.SelectedIndex;
                Gallery selectedGallery = galleries.ElementAt(index);
                selectedGallery.Add(filePath);

                loadImage(filePath);
            }            
        }

        private void loadImage(string filePath)
        {
            Image newImage = Image.FromFile(filePath);
            PictureBox.Image = newImage;
        }

        private void GalleryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GalleryList.SelectedIndex >= 0)
            {
                int targetGallery = GalleryList.SelectedIndex;
                selectedGallery = galleries.ElementAt(targetGallery);
                DisplayGalleryImages();
            }            
        }

        private void DisplayGalleryImages()
        {
            //Gallery selectedGallery = galleries.ElementAt(index).Images;
            
            // Required to generate failed to load display
            Image.GetThumbnailImageAbort Abort = new Image.GetThumbnailImageAbort(ThumbnailCallback);

            ImageGallery.Rows.Clear();

            foreach (string image in selectedGallery.Images)
            {
                Image concreteImage = Image.FromFile(image);

                ImageGallery.Rows.Add(concreteImage.GetThumbnailImage(50, 50,
                    new Image.GetThumbnailImageAbort(Abort), IntPtr.Zero));
                

            }
        }
        
        // Works in conjunction with the thumbnail generator
        public bool ThumbnailCallback()
        {
            return false;
        }

        //private Gallery GetSelectedGallery()
        //{
        //    Gallery targetGallery = null;

        //    if (GalleryList.SelectedIndex >= 0)
        //    {
        //        targetGallery = galleries.ElementAt(GalleryList.SelectedIndex);
        //    }

        //    return targetGallery;
        //}

        private void NextBtn_Click(object sender, EventArgs e)
        {
            //Gallery gallery = GetSelectedGallery();
            
            if (selectedGallery != null && selectedGallery.Current != null)
            {
                selectedGallery.Next();
                loadImage(selectedGallery.Current.Value);
                UpdateDisplayLbl(Path.GetFileName(selectedGallery.Current.Value));
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {                       
            if (selectedGallery != null && selectedGallery.Current != null)
            {
                selectedGallery.Previous();
                loadImage(selectedGallery.Current.Value);
                
                UpdateDisplayLbl(Path.GetFileName(selectedGallery.Current.Value));
            }
        }

        private void UpdateDisplayLbl(string name)
        {
            ViewLbl.Text = "Currently Viewing: ";
            ViewLbl.Text += name;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (selectedGallery != null && selectedGallery.Current != null)
            {
                selectedGallery.Remove(selectedGallery.Current.Value);
                selectedGallery.Current = selectedGallery.Images.First;
                PictureBox.Image = null;
                
                DisplayGalleryImages();                
                UpdateDisplayLbl("");
            }
        }
    }
}
