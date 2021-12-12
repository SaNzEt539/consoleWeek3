using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace consoleTask_8
{
    class Class1
    {
        string pattern = @"((https?|ftp)\:\/\/)?([a-z0-9]{1})((\.[a-z0-9-])|([a-z0-9-]))*\.([a-z]{2,6})(\/?)";
        string result = String.Empty;        
        public Class1(string str)
        {
            Regex newReg = new Regex(pattern);
            MatchCollection matches = newReg.Matches(str);
            foreach (Match mat in matches)
            {
                result += mat.Value + '\n';
            }
        }
        public string Result
        {
            get
            {
                return result;
            }
        }
    }
}
