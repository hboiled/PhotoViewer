using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer
{
    public class GalleryFetcher
    {
        public static List<Gallery> FindGalleries(string username)
        {
            List<Gallery> galleries = new List<Gallery>();

            string userPath = string.Format("..\\..\\Data\\Users\\{0}", username);
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

            return galleries;
        }
    }
}
