using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Download_webpage_content_project
{
    public static class ListExtentions
    {
        public static void SortTheList(this List<char> content)
        {
            QuickSort(content, 0, content.Count - 1);
        }
        static void QuickSort(List<char> list, int min, int max)
        {
            if (min < max)
            {
                int pivotIndex = Partition(list, min, max);

                QuickSort(list, min, pivotIndex - 1);
                QuickSort(list, pivotIndex + 1, max);
            }
        }

        static int Partition(List<char> list, int low, int high)
        {
            char pivot = list[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (list[j] <= pivot)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }

        static void Swap(List<char> list, int a, int b)
        {
            char temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}
