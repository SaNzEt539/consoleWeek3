using System;
using System.IO;
using System.Text;
using consoleTask_9;
namespace consoleTask_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2 t = new Task2();
            Console.WriteLine("Считано:\n{0}\n", t.Str);
            t.F();
            t.Write();
            Console.WriteLine("Изменено:\n{0}", t.Str);
        }
    }
}
