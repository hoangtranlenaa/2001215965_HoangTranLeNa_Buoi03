//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2001215965_HoangTranLeNa_Buoi03
//{
//    class tinhTongChiaDeTriDeQuy
//    {


//        static int Sum(int[] arr, int low, int high)
//        {
//            if (low == high)
//            {
//                return arr[low];
//            }
//            else
//            {
//                int mid = (low + high) / 2;

//                int leftSum = Sum(arr, low, mid);
//                int rightSum = Sum(arr, mid + 1, high);

//                return leftSum + rightSum;
//            }
//        }

//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//            int result = Sum(arr, 0, arr.Length - 1);
//            Console.WriteLine("Tong la: " + result);

//            Console.ReadKey();
//        }
//    }
//}
