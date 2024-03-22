using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Mang_Array
{
    internal class Program
    {
        /*
        Nhập vào mảng gồm n phần tử, với giá trị n được nhập từ người dùng.
        1. Đọc và in các phần tử trong mảng vừa nhập.
        2. In mang dữ liệu trên theo chiều đảo ngược
        3. Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau ra màn hình
        4. In các phần tử duy nhất trong mảng
        5. Chia mảng dữ liệu ban đầu thành mảng chẵn và mảng lẻ
        6. Sắp xếp mảng theo thứ tự giảm dần.
        7. Tìm kiếm phần tử lớn thứ hai trong mảng dữ liệu ban đầu.
         */

        static int[] NhapMang(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so luong phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;

        }
        static void XuatMang(int[] arr)
        {
            Console.WriteLine("Mang vua nhap: ");
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i + " ");
            //}
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = " + arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void InMangNguoc(int[] arr)
        {
            Console.WriteLine("Mang nguoc lai so voi ban dau: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"arr[{i}] = " + arr[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] SapXepMangGiamDan(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        /*
         - Nếu có 1 số >= firstMax:
            secondMax = firstMax;
            firstMax = số lớn nhất mới tìm được
        - Nếu có 1 số chỉ > secondMax:
            secondMax = số lớn hơn mới tìm được
         */
        static int FindByLoop(int[] arr)
        {
            int firstMax, secondMax;
            if (arr[0] > arr[1])
            {
                firstMax = arr[0];
                secondMax = arr[1];
            }
            else
            {
                firstMax = arr[1];
                secondMax = arr[0];
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] >= firstMax)
                {
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else if (arr[i] > secondMax)
                {
                    secondMax = arr[i];
                }
            }
            return secondMax;
        }
        static void Main(string[] args)
        {
            int[] arr1 = NhapMang("Nhap mang: ");
            XuatMang(arr1);
            InMangNguoc(arr1);
            int[] arr2 = SapXepMangGiamDan(arr1);
            XuatMang(arr2);
            Console.WriteLine($"So lon thu hai trong mang: {arr2[1]}");
            Console.WriteLine($"So lon thu hai trong mang: {FindByLoop(arr1)}");



            Console.ReadKey();
        }
    }
}
