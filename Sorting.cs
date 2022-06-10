using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    class Sorting
    {
        public void Insertion_Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = current;
            }
        }

        public void Selection_Sort(int[] arr)
        {
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_posotion = i;
                for (int j = i + 1; j < arr.Length; j++) 
                {
                    if(arr[j] < arr[min_posotion])
                    {
                        min_posotion = j;
                    }
                }
                Swap(ref arr[min_posotion], ref arr[i]);
            }
        }
        public void Buuble_Sort(int [] arr)
        {
            bool isSorted;
            for (int i = 0; i < arr.Length; i++)
            {
                isSorted = true;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if(arr[j] < arr[j-1])
                    {
                        Swap(ref arr[j - 1], ref arr[j]);
                        isSorted = false;
                    }
                }
                if (isSorted) 
                    return;
            }
        }

        public void Swap(ref int val1, ref int  val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

        public void Sort(int[] arr)
        {
            int sz = arr.Length;
            for (int i = 0; i < sz - 1; i++)
            {
                for (int j = i + 1; j < sz; j++)
                {
                    if (arr[j] < arr[i]) 
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        public void Print(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + "\t");

            Console.Write("\n");
        }
    }
}
