//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTTH01_CTDL
//{
//    internal class b3c3
//    {
//        static double TinhS(int n)
//        {
//            if (n == 1)
//            {
//                return 1;
//            }
//            return TinhS(n -1) + (1.0/n);
//        }
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap so nguyen duong n: ");
//            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//            {
//                double i = TinhS(n);
//                Console.WriteLine($"Ket qua: S({n}) = {i}");
//            }
//            Console.ReadKey();
//        }
//    }
//}
