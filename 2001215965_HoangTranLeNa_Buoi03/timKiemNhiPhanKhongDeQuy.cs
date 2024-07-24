//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2001215965_HoangTranLeNa_Buoi03
//{
//    class timKiemNhiPhanKhongDeQuy
//    {
//        static int BinarySearch(int[] arr, int x)
//        {
//            int left = 0;
//            int right = arr.Length - 1;

//            while (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                if (arr[mid] == x)
//                    return mid;

//                if (arr[mid] > x)
//                    right = mid - 1;

//                else
//                    left = mid + 1;
//            }

//            return -1;
//        }

//        static void Main()
//        {
//            int[] arr = { 2, 3, 4, 10, 40 };
//            int x = 10;

//            Console.Write("Mang nhap la: ");
//            foreach (var item in arr)
//            {
//                Console.Write(item + " ");
//            }

//            int result = BinarySearch(arr, x);

//            if (result == -1)
//                Console.WriteLine("\nKhong tim thay phan tu " + x);
//            else
//                Console.WriteLine("\nPhan tu " + x + " duoc tim thay tai vi tri so " + result);

//            Console.ReadKey();
//        }
//    }
//}
