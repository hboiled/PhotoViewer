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

// sign out btn closes and disposes this form and returns clean sign in form
//

namespace PhotoViewer
{
    public partial class Main : Form
    {
        private string userSignedIn;
        private List<Gallery> galleries;
        private Gallery defaultGallery = new Gallery("default");

        public Main(string username)
        {
            InitializeComponent();
            userSignedIn = username;
            DisplayName.Text += username;
            galleries = new List<Gallery>();
            galleries.Add(defaultGallery);
            GalleryList.DataSource = null;            

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
                Gallery newGallery = new Gallery(name);
                
                galleries.Add(newGallery);
                RefreshGalleryList();


                string path = string.Format("..\\..\\Data\\Users\\{0}.csv", name);
            }

            

            //using (var w = new StreamWriter(path))
            //{
            //    foreach (User user in users)
            //    {
            //        string naame = user.Username;
            //        string salt = user.Salt;
            //        string scp = user.SecuredPassword;

            //        string entry = string.Format("{0},{1},{2}", name, salt, scp);

            //        w.WriteLine(entry);
            //        w.Flush();
            //    }
            //}
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
                    filePath = openFileDialog.FileName;
                    loadImage(filePath);
                }
            }
        }

        private void loadImage(string filePath)
        {
            Image newImage = Image.FromFile(filePath);
            defaultGallery.Add(newImage);
            PictureBox.Image = newImage;
        }

        private void GalleryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GalleryList.SelectedIndex >= 0)
            {
                int targetGallery = GalleryList.SelectedIndex;
                DisplayGalleryImages(targetGallery);
            }            
        }

        private void DisplayGalleryImages(int index)
        {
            LinkedList<Image> selectedGallery = galleries.ElementAt(index).Images;

            ImageGallery.Items.Clear();

            //ImageGallery.DisplayMember = "PropertyItems";
            Image.GetThumbnailImageAbort Abort = new Image.GetThumbnailImageAbort(ThumbnailCallback);

            foreach (Image image in selectedGallery)
            {
                
                ImageGallery.Items.Add(image.GetThumbnailImage(50,
                                                       50,
                                                       new Image.GetThumbnailImageAbort(Abort), IntPtr.Zero));
                
            }
        }
        public bool ThumbnailCallback()
        {
            return false;
        }

    }
}
