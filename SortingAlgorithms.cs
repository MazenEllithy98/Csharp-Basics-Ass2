using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Advanced
{
    //public delegate bool CompareFuncDelegate(int A, int B);
    
    public delegate bool CompareFuncDelegate<T>(T A, T B);
    class SortingAlgorithms <T>
    {
        public static void BubbleSort(T[] array , CompareFuncDelegate<T> compfuncDelegate)
        {
            if (array is not null)
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                        //if (array[j] < array[j + 1])
                          //if (CompareFunctions.CompareGrt(array[j] , array[j+1]))
                          if (compfuncDelegate.Invoke(array[j], array[j+1]))
                            Swap(ref array[j], ref array[j + 1]);

        }
        //public static void BubbleSortASC(int[] array)
        //{
        //    if (array is not null)
        //        for (int i = 0; i<array.Length;i++)
        //            for (int j=0; j<array.Length - i -1; j++)
        //                if (array[j]> array[j+1])
        //                    SortingAlgorithms.Swap(ref array[j], ref array[j + 1]);
                        
                    
               
            
        //}

        public static void Swap(ref T a , ref T b) 
        {
            T Temp = a;
            a = b;
            b = Temp;
        }
    }

    class CompareFunctions
    {
        public static bool SortAscending(string x, string y) { return x?.Length > y?.Length; }
        public static bool SortDescending(string x, string y) { return x?.Length < y?.Length; }
        public static bool CompareGrt(int x, int y) { return x > y; } // sort asc

        public static bool CompareLesst(int x, int y) { return x < y; } // sort  desc

    }

}
