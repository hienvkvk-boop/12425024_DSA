//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTTH01_CTDL
//{
//    internal class b1c2
//    {
//        static void ThapHaNoi(int n, char nguon, char trungGian, char dich)
//        {
//            if (n == 1) return;
//            ThapHaNoi(n - 1, nguon, dich, trungGian);
//            ThapHaNoi(n - 1, trungGian, nguon, dich);
//        }

//        static void Main()
//        {
//            Console.Write("Nhap so luong dia n: ");
//            int n = int.Parse(Console.ReadLine());
//            Stopwatch sw = Stopwatch.StartNew();
//            ThapHaNoi(n, 'A', 'B', 'C');
//            sw.Stop();
//            Console.WriteLine($"Thoi gian thuc thi: {sw.Elapsed.TotalMilliseconds} ms");
//        }
//    }
//}
