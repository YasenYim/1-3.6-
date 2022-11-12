using System;

namespace _1_3._6_字符串换行
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string s = "我，abc，你，他";
            string s2 = "我，abc，你，他";

            s = s.Replace("，", "\n");  // 这里string.Replace是把逗号都改成了换行
            s2 = s2.Replace("，", "ddd");  // 这里是string.Replace把逗号改成了ddd

            Console.WriteLine(s);
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
