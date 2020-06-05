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
        private LinkedList<string> images;
        private LinkedListNode<string> current;
        private readonly string name;

        public LinkedList<string> Images => images;

        public LinkedListNode<string> Current { get => current; set => current = value; }

        public Gallery(string name)
        {
            this.name = name;
            images = new LinkedList<string>();
            Current = null;
        }

        public void Next()
        {
            if (Current != null && Current.Next != null)
            {
                Current = Current.Next;
            }
        }

        public void Previous()
        {
            if (Current != null && Current.Previous != null)
            {
                Current = Current.Previous;
            }                        
        }

        public void Add(string image)
        {
            Current = Images.First;
            images.AddLast(image);            
        }

        public void Remove(string image)
        {
            if (!IsEmpty())
            {
                images.Remove(image);
            }
            
        }

        public Boolean IsEmpty()
        {
            return images.Count == 0;
        }

        public void MergeSort()
        {

        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            return obj is Gallery gallery &&
                   name == gallery.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}
