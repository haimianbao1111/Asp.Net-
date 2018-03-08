using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 机试4
{
    class Program
    {
        static void Main(string[] args)
        {
            show();
            Console.ReadKey();
        }
        /// <summary>
        /// 现有1-100共一百个自然数，已随机放入一个有98个元素的数组a[98]。
        /// 要求写出一个尽量简单的方案，找出没有被放入数组的那2个数，并在屏幕上打印这2个数。
        /// 注意：程序不用实现自然数随机放入数组的过程。
        /// </summary>
        private static void show()
        {
            int[] arry = new int[98];
            Random rd = new Random();
            List<int> temp = new List<int>();
            //随机产生98个1-100自然数
            while (temp.Count < 98)
            {
                int result = rd.Next(1, 101);//随机产生1~100随机数；
                if (temp.Contains(result))
                {
                    continue;
                }
                temp.Add(result);
            }
            //将98个数填充到数组中；
            for (int i = 0; i < 98; i++)
            {
                arry[i] = temp[i];
            }
            int[] arrytemp = new int[101];
            for (int i = 0; i < 98; i++)
            {
                arrytemp[arry[i]] = 1;//给98个自然数标识；
            }
            for (int i = 1; i <= 100; i++)
            {
                if (arrytemp[i] == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
