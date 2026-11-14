//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BTTH01_CTDL
//{
//    internal class b1c1
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            Random rand = new Random();

//            int[] RandomNum = new int[1000];

//            for (int i = 0; i < RandomNum.Length; i++)
//            {
//                RandomNum[i] = rand.Next(1, 101);
//            }

//            int MaxNum = RandomNum[0];
//            int MinNum = RandomNum[0];

//            for (int i = 0; i < RandomNum.Length; i++)
//            {
//                if (MaxNum < RandomNum[i])
//                {
//                    MaxNum = RandomNum[i];
//                }
//                if (MinNum > RandomNum[i])
//                {
//                    MinNum = RandomNum[i];
//                }
//            }

//            Console.WriteLine("Các phần tử trong mảng: " + string.Join(", ", RandomNum) + "\n");
//            Console.WriteLine("Số lớn nhất: " + MaxNum);
//            Console.WriteLine("Số nhỏ nhất: " + MinNum);

//            Console.ReadKey();
//        }
//    }
//}
