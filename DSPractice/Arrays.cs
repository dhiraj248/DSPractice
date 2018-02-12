using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice
{
    public class Arrays
    {

        //complexity<--->O(n)
        public int FindLargest(int[] givenarray, int size)
        {
            int largest = 0;
            if (givenarray != null && size > 0)
            {
                largest = givenarray[0];
                for (int i = 1; i < size; i++)
                {
                    if (largest < givenarray[i])
                    {
                        largest = givenarray[i];                     //largest = givenarray.Max();
                    }
                }
            }
            return largest;
        }

        public int FindKthLargest(int[] givenarray, int size, int k)
        {
            int kthLargest = 0;
            //int temp = 0;
            if (givenarray != null && size > 0)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int i = 0; i < size - 1; i++)
                    {
                        if (givenarray[i] < givenarray[i + 1])       //using Bubble sort complexity---O(n2)
                        {
                            //temp = givenarray[i + 1];
                            //givenarray[i + 1] = givenarray[i];
                            //givenarray[i] = temp;
                            swap(ref givenarray[i], ref givenarray[i + 1]);
                        }
                    }
                }
                kthLargest = givenarray[k - 1];
            }
            return kthLargest;
        }

        public int FindKthLargestusingInsertion(int[] givenarray, int size, int k)
        {
            int kthLargest = 0;
            int Key = 0;
            if (givenarray != null && size > 0)
            {
                for (int j = 1; j < size; j++)
                {
                    Key = givenarray[j];
                    int i = j - 1;
                    while (i >= 0 && givenarray[i] > Key)
                    {
                        givenarray[i + 1] = givenarray[i];
                        i--;
                    }
                    givenarray[i + 1] = Key;
                }
                kthLargest = givenarray[k - 1];
            }
            return kthLargest;
        }

        public int FindKthLargestUsingQuick(int[] givenarray, int size, int k)
        {
            int largest = 0;
            int high = size - 1;
            int low = 0;
            QuickSort(givenarray, high, low);
            displayArray(givenarray, size);
            largest = givenarray[k - 1];
            return largest;
        }

        public void displayArray(int[] givenarray, int size)
        {
            for (int i = 0; i <= size - 1; i++)
            {
                Console.Write(givenarray[i].ToString() + ", ");
            }
        }

        public void QuickSort(int[] givenarray, int high, int low)
        {
            if (low < high)
            {
                int pi = Partition(givenarray, high, low);
                QuickSort(givenarray, pi - 1, low);
                QuickSort(givenarray, high, pi + 1);
            }
        }

        private int Partition(int[] givenarray, int high, int low)
        {
            int i = 0;
            i = low - 1;
            int pivot = givenarray[high];
            for (int j = low; j <= high - 1; j++)
            {
                if (givenarray[j] >= pivot)
                {
                    i++;
                    swap(ref givenarray[j], ref givenarray[i]);

                }
            }
            swap(ref givenarray[high], ref givenarray[i + 1]);
            return i + 1;
        }

        public void swap(ref int a, ref int b)
        {
            if (a != b)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
        }

        public int FindKthlargestUsingSelectionSort(int[] givenarray, int size, int k)
        {
            SelectionSort(givenarray, size);
            displayArray(givenarray, size);
            return givenarray[k - 1];
        }

        private void SelectionSort(int[] givenarray, int size)
        {
            int i;
            for (i = 0; i < size - 1; i++)
            {
                int min = i;
                for (int j = i; j <= size - 1; j++)
                {
                    if (givenarray[min] >= givenarray[j])
                    {
                        min = j;
                    }
                }
                swap(ref givenarray[i], ref givenarray[min]);
            }
        }

        public int FindKthlargestUsingMergeSort(int[] givenarray, int size, int k)
        {
            MergeSort(givenarray, 0, size - 1);
            displayArray(givenarray, size);
            return givenarray[k - 1];
        }

        private void MergeSort(int[] givenarray, int Leftindex, int RightIndex)
        {
            int middleindex = 0;
            if (Leftindex < RightIndex)
            {
                //middleindex = RightIndex- (Leftindex + RightIndex) / 2;
                middleindex = Leftindex + (RightIndex - Leftindex) / 2;
                MergeSort(givenarray, Leftindex, middleindex);
                MergeSort(givenarray, middleindex + 1, RightIndex);

                Merge(givenarray, Leftindex, middleindex, RightIndex);
            }
        }

        private void Merge(int[] givenarray, int leftindex, int middleindex, int rightIndex)
        {
            int s1, s2, i, j, p, q, r;                                     //size of two sub arrays
            p = q = 0;
            s1 = middleindex - leftindex + 1;
            s2 = rightIndex - middleindex;
            int[] temp1 = new int[s1];
            int[] temp2 = new int[s2];
            try
            {
                for (i = 0; i < s1; i++)
                {
                    temp1[i] = givenarray[leftindex + i];
                }
                for (j = 0; j < s2; j++)
                {
                    temp2[j] = givenarray[middleindex + 1 + j];
                }
                r = leftindex;
                while (p < s1 && q < s2)
                {
                    if (temp1[p] < temp2[q])
                    {
                        givenarray[r] = temp1[p];
                        p++;
                    }
                    else
                    {
                        givenarray[r] = temp2[q];
                        q++;
                    }
                    r++;
                }
                while (p < s1)
                {
                    givenarray[r++] = temp1[p];
                    p++;
                }
                while (q < s2)
                {
                    givenarray[r++] = temp2[q];
                    q++;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void iterativeMergesort(int[] givenarray, int size)
        {
            int leftindex, currentSize, rightindex;
            leftindex = 0;
            for (currentSize = 1; currentSize <= size - 1; currentSize = 2 * currentSize)
            {
                for (leftindex = 0; leftindex < size - 1; leftindex += 2 * currentSize)
                {
                    int mid = leftindex + currentSize - 1;
                    rightindex = (leftindex + 2 * currentSize - 1) < (size - 1) ? (leftindex + 2 * currentSize - 1) : (size - 1);
                    Merge(givenarray, leftindex, mid, rightindex);
                }
            }
            displayArray(givenarray, size);
        }
    }
}
