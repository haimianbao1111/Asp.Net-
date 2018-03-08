using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 机试2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "CSDN GOD!";
            Console.WriteLine(GetInfo(str));
            Console.ReadKey();
        }
        /// <summary>
        /// 找出字符串中出现最多的字符以及次数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetInfo(string str)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (d.ContainsKey(str[i]))
                {
                    d[str[i]]++;
                }
                else
                {
                    d[str[i]] = 1;
                }
            }
            char Max = str[0];
            foreach (KeyValuePair<char, int> temp in d)
            {
                if (temp.Value > d[Max])
                {
                    Max = temp.Key;
                }
            }
            return string.Format("出现次数最多的值是：{0},次数是：{1}", Max, d[Max]);
        }
    }
}
