//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2001215965_HoangTranLeNa_Buoi03
//{
//    class QuickSort
//    {
//        static void Swap(int[] arr, int i, int j)
//        {
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }

//        static int Partition(int[] arr, int low, int high)
//        {
//            int pivot = arr[high];
//            int i = low - 1;

//            for (int j = low; j < high; j++)
//            {

//                if (arr[j] < pivot)
//                {
//                    i++;
//                    Swap(arr, i, j);
//                }
//            }


//            Swap(arr, i + 1, high);

//            return i + 1;
//        }


//        static void quickSort(int[] arr, int low, int high)
//        {
//            if (low < high)
//            {

//                int pi = Partition(arr, low, high);


//                quickSort(arr, low, pi - 1);
//                quickSort(arr, pi + 1, high);
//            }
//        }

//        static void Main()
//        {
//            int[] arr = { 10, 7, 8, 9, 1, 5 };
//            int n = arr.Length;

//            Console.WriteLine("Mang ban dau:");
//            PrintArray(arr);

//            quickSort(arr, 0, n - 1);

//            Console.WriteLine("\nMang sau khi sap xep:");
//            PrintArray(arr);

//            Console.ReadKey();
//        }

//        static void PrintArray(int[] arr)
//        {
//            foreach (var item in arr)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
