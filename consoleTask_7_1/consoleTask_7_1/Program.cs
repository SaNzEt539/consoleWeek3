using System;

namespace consoleTask_7_1
{
    class Task
    {
        string str;
        public Task(string str)
        {
            this.str = str;
        }
        public string Ans()
        {
            string ans = String.Empty;
            for (int i = 0; i<str.Length; i++)
            {
                if (str[i]!=':')
                {
                    ans += str[i];
                }
                else
                {
                    return ans;
                }
            }
            return ans;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            try
            {
                Task t = new Task(str);
                Console.WriteLine("Результат: {0}", t.Ans());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то!");
            }
        }
    }
}
