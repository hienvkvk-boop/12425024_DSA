//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTTH01_CTDL
//{
//    internal class b5c3
//    {
//        static int UocLeMax(int n)
//        {
//            if (n % 2 != 0)
//            {
//                return n;
//            }
//            return UocLeMax(n / 2);
//        }

//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.Write("Nhập số nguyên dương n: ");

//            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//            {
//                int ketQua = UocLeMax(n);
//                Console.WriteLine($"Ước số lẻ lớn nhất của {n} là: {ketQua}");
//            }
//            Console.ReadKey();
//        }
//    }
//}
