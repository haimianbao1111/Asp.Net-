using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 机试6
{
    class Program
    {
        static void Main(string[] args)
        {
            int res= sum(31);
            Console.WriteLine(res);
            Console.WriteLine(res*12);
            Console.ReadKey();
        }
        /// <summary>
        /// 递归求和1+2+...+n
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static int sum(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            else
            {
                return x + sum(x - 1);
            }
        }
    }
}
