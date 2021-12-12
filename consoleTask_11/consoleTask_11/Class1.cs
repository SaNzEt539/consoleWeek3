using System;
using System.Collections.Generic;
using System.Text;

namespace consoleTask_11
{
    class Class1
    {
        int[] m_IntArray;
        int n;
        public Class1(int n)
        {
            this.n = n;
            m_IntArray = new int[n];
        }
        public Class1():this(0)
        {

        }
        public void Input(string str)
        {
            string[] str2 = str.Split(' ');
            if(str2.Length>m_IntArray.Length || str2.Length < m_IntArray.Length)
            {
                throw new Exception("Некорректное количество введенных элементов");
            }
            else
            {
                for (int i=0; i<m_IntArray.Length; i++)
                {
                    m_IntArray[i] = int.Parse(str2[i]);
                }
            }
        }
        public string Show()
        {
            string str = String.Empty;
            foreach(int a in m_IntArray)
            {
                str += a + " ";
            }
            return str;
        }
        public void Sort()
        {
            for (int i=0; i<m_IntArray.Length; i++)
            {
                for (int j =0; j<m_IntArray.Length-1; j++)
                {
                    if (m_IntArray[j]>m_IntArray[j+1])
                    {
                        int buf = m_IntArray[j+1];
                        m_IntArray[j + 1] = m_IntArray[j];
                        m_IntArray[j] = buf;
                    }
                }
            }
        }
        public int Length
        {
            get
            {
                return m_IntArray.Length;
            }
        }
        public int Skal
        {
            set
            {
                for (int i = 0; i < m_IntArray.Length; i++)
                {
                    m_IntArray[i] *= value;
                }
            }
        }
    }
}
