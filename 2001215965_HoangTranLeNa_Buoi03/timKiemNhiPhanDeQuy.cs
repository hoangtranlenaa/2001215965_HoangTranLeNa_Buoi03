//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2001215965_HoangTranLeNa_Buoi03
//{
//    class timKiemNhiPhanDeQuy
//    {
//        static int BinarySearchRecursive(int[] arr, int x, int left, int right)
//        {
//            if (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                if (arr[mid] == x)
//                    return mid;

//                if (arr[mid] > x)
//                    return BinarySearchRecursive(arr, x, left, mid - 1);

//                return BinarySearchRecursive(arr, x, mid + 1, right);
//            }

//            return -1;
//        }

//        static void Main()
//        {
//            int[] arr = { 2, 7, 4, 10, 50, 55, 70 };
//            int x = 55;

//            Console.Write("Mang la: ");
//            foreach (var item in arr)
//            {
//                Console.Write(item + " ");
//            }

//            int result = BinarySearchRecursive(arr, x, 0, arr.Length - 1);

//            if (result == -1)
//                Console.WriteLine("\nKhong tim thay phan tu " + x);
//            else
//                Console.WriteLine("\nPhan tu " + x + " duoc tim thay tai vi tri so " + result);

//            Console.ReadKey();
//        }
//    }
//}
