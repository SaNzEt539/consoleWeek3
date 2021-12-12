using System;

namespace consoleTask_11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                Class1 o = new Class1(int.Parse(Console.ReadLine()));
                Console.WriteLine("Вводите числа через пробел: ");
                o.Input(Console.ReadLine());
                o.Sort();
                Console.WriteLine("Сортированный массив: {0}", o.Show());
                Console.WriteLine("Размер массива: {0}", o.Length);
                Console.Write("Введите скаляр, на который умножить: ");
                o.Skal = int.Parse(Console.ReadLine());
                Console.WriteLine("Массив: {0}", o.Show());
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
