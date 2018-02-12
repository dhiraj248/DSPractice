using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please entre the length");
            int Size=Convert.ToInt32(Console.ReadLine());
            int[] givenArray = new int[Size];
            Console.WriteLine("Please entre the numbers");
            for (int i = 0; i < Size; i++)
            {
                string s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    givenArray[i] = Convert.ToInt32(s);
                }
            }
            Arrays ar = new Arrays();
            //largest number in the array
            //int largest=ar.FindLargest(givenArray,Size);

            //Console.WriteLine("Largest number of given array is {0}", largest);

            //kth largest number
            //Console.WriteLine("Which largest you want to find now?");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int kthlargest = ar.FindKthLargestusingInsertion(givenArray, Size,k);
            //int kthlargest= ar.FindKthLargestUsingQuick(givenArray, Size,k);
            //int kthlargest = ar.FindKthlargestUsingSelectionSort(givenArray, Size, k);
            //int kthlargest = ar.FindKthlargestUsingMergeSort(givenArray, Size, k);
            //Console.WriteLine("{1}th largest number of given array is {0}", kthlargest, k);
           ProblemsOnSortingAlgo objPOSA = new ProblemsOnSortingAlgo();
            //int InversionCount = objPOSA.getInversionCountOfArray(givenArray, Size);
            //Console.WriteLine("{0} is the count of inversion of given array", InversionCount);
            // ar.iterativeMergesort(givenArray, Size);
            objPOSA.Sort0s_1s_2s(givenArray, Size);
            Console.ReadKey();

        }
    }
}
