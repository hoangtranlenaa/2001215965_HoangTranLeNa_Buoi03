using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215965_HoangTranLeNa_Buoi03
{
    class tinhTongChiaDeTriKhongDeQuy
    {
        static int Sum(int[] arr, int left, int right)
        {
            int s1=0, s2=0;
            int mid = (left + right) / 2;
            if (left == right)
                return arr[left];
            else
            {
                while (mid >= left)
                {
                    s1 += arr[mid];
                    mid--;
                }

                mid = (left + right) / 2 + 1;
                while(mid <= right)
                {
                    s2 += arr[mid];
                    mid++;
                }
            }
            return s1 + s2;
        }

        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 7 };
            int result = Sum(arr, 0, arr.Length-1);
            Console.WriteLine("Tong cac phan tu cua mang la: " + result);
            Console.ReadKey();
        }
    }
}
