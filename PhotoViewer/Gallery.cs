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
        // image gallery
        private LinkedList<string> images;
        // keep track of current image
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

        // calls next after checking current and the potential next for null
        public void Next()
        {
            if (Current != null && Current.Next != null)
            {
                Current = Current.Next;
            }
        }

        // calls previous after checking current and the potential previous for null
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


        public override string ToString()
        {
            return name;
        }

        // override equals and hashcode for equality checks
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
