//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTTH01_CTDL
//{
//    internal class b4c1
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Random rand = new Random();
//            int[] RandomNum = new int[1000];

//            for (int i = 0; i < RandomNum.Length; i++) { RandomNum[i] = rand.Next(1, 101); }

//            Console.Write("Mảng ban đầu: ");
//            for (int i = 0; i < RandomNum.Length; i++) { Console.Write(RandomNum[i] + " "); }
//            Console.WriteLine("\n");

//            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: ");
//            Array.Sort(RandomNum);
//            for (int i = 0; i < RandomNum.Length; i++) { Console.Write(RandomNum[i] + " "); }
//            Console.WriteLine();
//        }
//    }
//}
