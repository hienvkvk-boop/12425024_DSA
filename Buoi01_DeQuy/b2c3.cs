//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTTH01_CTDL
//{
//    internal class b2c3
//    {
//        static int TinhS(int n)
//        {
//            if (n == 1)
//            {
//                return 1;
//            }
//            return TinhS(n - 1) + (n * n);
//        }
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap so nguyen duong n: ");
//            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//            {
//                int i = TinhS(n);
//                Console.WriteLine($"Ket qua: S({n}) = {i}");
//            }
//            Console.ReadKey();
//        }
//    }
//}
