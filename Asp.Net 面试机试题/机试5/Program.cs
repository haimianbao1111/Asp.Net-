using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 机试5
{
    class Program
    {
        /// <summary>
        /// 一个文本文件含有如下内容：
        ///4580616022644994|3000|赵涛
        ///4580616022645017|6000|张屹
        ///4580616022645090|3200|郑欣夏
        ///上述文件每行为一个转账记录，第一列表示帐号，第二列表示金额，第三列表示开户人姓名。
        ///创建一张数据库表（MS SQLServer数据库，表名和字段名自拟），请将上述文件逐条插入此表中。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
            //启用秒表来计时
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string[] lines = System.IO.File.ReadAllLines(@"D:\转账记录.txt", Encoding.Default);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] str = lines[i].Split('|');
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;
AttachDBFilename=|DataDirectory|\ZhuanZhang.mdf;Integrated Security=True;User Instance=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "Insert into T_ZhuanZhang (CardNum,Money,Name) values (@CardNum,@Money,@Name)";
                        cmd.Parameters.Add(new SqlParameter("CardNum", str[0]));
                        cmd.Parameters.Add(new SqlParameter("Money", str[1]));
                        cmd.Parameters.Add(new SqlParameter("Name", str[2]));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            Console.WriteLine("数据导入成功！");
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            Console.ReadKey();
        }
    }
}
