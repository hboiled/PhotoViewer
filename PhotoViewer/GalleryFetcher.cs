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

            // construct path to user, create if does not exist
            string userPath = string.Format("..\\..\\Data\\Users\\{0}", username);
            Directory.CreateDirectory(userPath);

            // get info on what files are stored within the dir, then filter out non csv files
            DirectoryInfo userInfo = new DirectoryInfo(userPath);
            FileInfo[] galleryFiles = userInfo.GetFiles("*.csv");

            if (galleryFiles.Length > 0)
            {
                foreach (FileInfo file in galleryFiles)
                {
                    // create new gallery based on csv file
                    Gallery gallery = new Gallery(Path.GetFileNameWithoutExtension(file.FullName));
                    using (CsvReader csv = new CsvReader(
                                    new StreamReader(file.FullName), false))
                    {
                        // read all entries (which should be the location of img)
                        // insert into fresh gallery
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
