using System;
using System.Text;

namespace consoleTask_7_2
{
    class Task
    {
        StringBuilder str;
        public Task(string str)
        {
            this.str = new StringBuilder(str);
            Ans();
        }
        void Ans()
        {
            int i = 0;
            while(i<str.Length-1) 
            {
                switch(str[i])
                {
                    case ' ':
                       switch(str[i+1])
                        {
                            case '?':
                            case '!':
                            case ',':
                            case '.':
                                str.Remove(i, 1);
                                i--;
                                break;
                            default:
                                break;
                        }
                        break;
                    case '?':
                    case '!':
                    case ',':
                    case '.':
                        if (str[i + 1] == ' ' ) 
                        {
                            break;
                        }
                        else
                        {
                            str.Insert(i+1, ' ');
                            break;
                        }
                    default:
                        break;
                }
                i++;
            }
        }
        public string Show()
        {
            return str.ToString();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Task t = new Task(Console.ReadLine());
            Console.WriteLine("Результат:\n{0}", t.Show());
        }
    }
}
