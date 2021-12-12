using System;
using System.Text;
using Task_9;


namespace consoleTask_9_1
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            Task_1 obj = new Task_1(str);
            obj.Write();
            string result = obj.Read();
            Console.WriteLine(result);
        }
    }
}
