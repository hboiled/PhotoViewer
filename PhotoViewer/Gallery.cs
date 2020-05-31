using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer
{
    public class Gallery
    {
        private readonly LinkedList<Image> images;
        private readonly string name;

        public LinkedList<Image> Images => images;

        public Gallery(string name)
        {
            this.name = name;
            images = new LinkedList<Image>();
        }

        public void Next()
        {
            
        }

        public void Previous()
        {

        }

        public void Add(Image image)
        {
            images.AddLast(image);
        }

        public void Remove(Image image)
        {

        }

        public void MergeSort()
        {

        }

        public override string ToString()
        {
            return name;
        }
    }
}
