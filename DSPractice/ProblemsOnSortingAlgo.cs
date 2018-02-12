using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice
{
    public class ProblemsOnSortingAlgo
    {

        public int getInversionCountOfArray(int[] givenarray, int Size)
        {
            int inversionCount = 0;
            int leftIndex, rightIndex;
            leftIndex = 0;
            rightIndex = Size - 1;
           inversionCount= mergeSort(givenarray, leftIndex, rightIndex);
            return inversionCount;
        }

        private int mergeSort(int[] givenarray, int leftIndex, int rightIndex)
        {
            int middleIndex = 0;
            int inv_count = 0;
            if (leftIndex < rightIndex)
            {
                middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                inv_count = mergeSort(givenarray, leftIndex, middleIndex);
                inv_count += mergeSort(givenarray, middleIndex + 1, rightIndex);
                inv_count += merge(givenarray, leftIndex, middleIndex, rightIndex);
            }
            return inv_count;
        }

        private int merge(int[] givenarray, int leftIndex, int middleIndex, int rightIndex)
        {
            int n1, n2, p, q, r, inv_count;
            p = q = inv_count = 0;
            n1 = middleIndex - leftIndex + 1;
            n2 = rightIndex - middleIndex;
            r = leftIndex; ;
            int[] L, R;
            L = new int[n1];
            R = new int[n2];
            for (int i = 0; i < n1; i++)
            {
                L[i] = givenarray[leftIndex + i];
                i++;
            }
            for (int j = 0; j < n2; j++)
            {
                R[j] = givenarray[middleIndex + j + 1];
            }

            while (p < n1 && q < n2)
            {
                if (L[p] < R[q])
                {
                    givenarray[r] = L[p];
                    p++;
                }
                else
                {
                    givenarray[r] = R[q];
                    q++;
                    inv_count += middleIndex - p+1;
                }
                r++;
            }

            while (p < n1)
            {
                givenarray[r++] = L[p++];
            }
            while (q < n2)
            {
                givenarray[r++] = R[q++];
            }
            return inv_count;

        }

        public void Sort0s_1s_2s(int[] givenarray, int size)
        {
            //famous Dutch flag problem which takes three colors which red(0s),White(1s) and Blue(2s)
            //the algo implemented below takes these three items as some of them are at their right place like at low indexes
            //0s, at mid 1s and at high indexes 2s means a[1-low]=0s, a[low-mid-1]=1s,a[mid-high]=unknown and a[high+1-n]=2s 
            //we have to sort only those uknowns
            int low, mid, high;
            low = 0;mid = 0;high = size - 1;
            Arrays objarr = new Arrays();
            while(mid<=high)
            {
            switch(givenarray[mid])
            {
                    case 0:
                        objarr.swap(ref givenarray[low], ref givenarray[mid]);
                        low++;
                        mid++;
                        break;
                    case 1:                        
                        mid++;
                        break;
                    case 2:
                        objarr.swap(ref givenarray[mid], ref givenarray[high]);                        
                        high--;
                        break;
                }               
            }
            objarr.displayArray(givenarray, size);
        }       

    }
}
