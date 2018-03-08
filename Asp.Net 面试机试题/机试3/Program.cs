using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 机试3
{
    class Program
    {
        static void Main(string[] args)
        {
            //下面是一个由* 号组成的4行倒三角形图案。
            //要求：
            //1、输入倒三角形的行数，行数的取值3 - 21之间，对于非法的行数，要求抛出提示“非法行数！”；
            //2、在屏幕上打印这个指定了行数的倒三角形。

            while (true)
            {
                Console.Write("请输入行数：范围3-21,输入0退出程序。");
                int line = 0;
                if (!Int32.TryParse(Console.ReadLine(), out line))
                {
                    Console.WriteLine("请输入正确的行数！");
                    continue;
                }
                if (line == 0)
                {
                    Console.WriteLine("退出！");
                    break;
                }
                else if (!(line > 2 && line < 22))
                {
                    Console.WriteLine("非法行数！请输入正确的行数！");
                    continue;
                }
                for (int i = 0; i < line; i++)
                {
                    int j = 0;
                    for (; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = j; k < line; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            
        }
    }
}
