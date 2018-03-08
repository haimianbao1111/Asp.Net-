using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 机试1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 56, 78, 23, 124, 54, 98, 34, 96 };
            int index;
            string Res = GetMax<int>(array, out index);
            Console.WriteLine(Res);
            Console.ReadKey();
        }
        /// <summary>
        /// 找出数组中最大的值
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="Array">数组名称</param>
        /// <param name="index">最大值所对应的索引值</param>
        /// <returns></returns>
        public static string GetMax<T>(T[] Array, out int index) where T : IComparable
        {
            if (Array == null)
            {
                throw new ArgumentException("参数错误！");
            }
            T Max = Array[0];
            index = 1;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].CompareTo(Max) > 0)
                {
                    Max = Array[i];
                    index = i;
                }
            }
            return string.Format("索引为：{0},对应的最大值是：{1}", index, Max);
        }
    }
}
