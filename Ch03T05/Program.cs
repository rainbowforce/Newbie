using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03T05
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, thirdNum, fourthNum;
            string userName;
            Console.WriteLine("请输入你的名字： ");
            userName = Console.ReadLine();
            Console.WriteLine("{0} 你好！",userName);
            Console.WriteLine("请输入第一个数字：");
            firstNum = Convert.ToInt32(Console.ReadLine());//从string 转换为int
            Console.WriteLine("请输入第二个数字：");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字：");
            thirdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第四个数字：");
            fourthNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("四个数{0},{1},{2},{3}相乘的结果是 {4} 。", firstNum, secondNum, thirdNum, fourthNum, firstNum*secondNum*thirdNum*fourthNum);
            Console.WriteLine("按任意键退出……");
            Console.ReadKey();
        }
    }
}
