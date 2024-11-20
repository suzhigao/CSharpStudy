using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWithCSharp //命名空间：用于组织代码，避免类名冲突
{
    class Program  //类名, 类是面向对象编程的基本构建块，用于封装数据和行为。
    {
        static void Main(string[] args) //主方法，这是程序的入口点方法。每个控制台应用程序都需要一个 Main 方法，它是程序开始执行的地方。
        {
            Console.WriteLine("Hello,World!\n Welcome to the home of CSharp!"); //用于在控制台上输出一行文本

            Console.ReadKey();  //用于读取用户的按键输入。它会暂停程序的执行，直到用户按下某个键。这样可以防止控制台窗口在输出消息后立即关闭，让用户有机会看到输出内容。
        }
    }
}
