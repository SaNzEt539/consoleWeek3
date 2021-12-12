using System;
using System.Text.RegularExpressions;

namespace consoleTask_8
{
    class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вводите слова через пробел: ");
                string str = Console.ReadLine();
                Class1 o = new Class1(str);
                Console.WriteLine("Результат:\n{0}", o.Result);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }
    }
}
