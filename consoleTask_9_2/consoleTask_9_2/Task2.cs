using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace consoleTask_9
{
    class Task2
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\task2.txt";
        string wPath = AppDomain.CurrentDomain.BaseDirectory + "\\wtask2.txt";
        string[] strArr;
        public Task2()
        {
            strArr = File.ReadAllLines(path);
        }
        public void F()
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                strArr[i] += $" ({i + 1})";
            }
        }
        public void Write()
        {
            File.WriteAllLines(wPath, strArr);
        }
        public string Str
        {
            get
            {
                return String.Join('\n', strArr);
            }
        }
    }
}
