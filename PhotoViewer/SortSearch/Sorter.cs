﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.SortSearch
{
    public class Sorter
    {
        // Adapted from: 
        // https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php
        public static List<User> MergeSort(List<User> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<User> left = new List<User>();
            List<User> right = new List<User>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        // merge method which is called recursively
        private static List<User> Merge(List<User> left, List<User> right)
        {
            List<User> result = new List<User>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().Username.CompareTo(right.First().Username) == -1)  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        // adapted from https://www.geeksforgeeks.org/selection-sort/
        public static void GallerySort(List<Gallery> galleries)
        {
            int n = galleries.Count;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (galleries.ElementAt(j).ToString().CompareTo(
                        galleries.ElementAt(minIndex).ToString()) == -1)
                    {
                        minIndex = j;
                    }
                        
                }
                
                // Swap the found minimum element with the first 
                // element 
                Gallery temp = galleries.ElementAt(minIndex);
                galleries[minIndex] = galleries.ElementAt(i);
                galleries[i] = temp;
            }
        }

        // selection sort on linked list of image locations
        public static void ImageSort(LinkedList<string> images)
        {
            int n = images.Count;

            for (int i = 0; i < n; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (images.ElementAt(j).CompareTo(
                        images.ElementAt(minIndex)) == -1)
                    {
                        minIndex = j;
                    }
                }

                string temp = images.ElementAt(minIndex);
                images.Find(images.ElementAt(minIndex)).Value = images.ElementAt(i);
                images.Find(images.ElementAt(i)).Value = temp;
            }
        }

    }
}
