using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task_9
{
    class Task_1
    {
        string result;
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\task1.bin";
        public string Result
        {
            get
            {
                return result;
            }
        }
        public Task_1(string str)
        {
            result = f(str);
        }
        string f(string str)
        {
            StringBuilder sBuild = new StringBuilder(String.Empty);
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        continue;
                    default:
                        sBuild.Append(str[i]);
                        break;
                }
            }
            return sBuild.ToString();
        }
        public void Write()
        {            
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
                writer.Close();
            }
        }
        public string Read()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {                
                string str = reader.ReadString();
                reader.Close();
                return str;
            }
        }
    }
}
