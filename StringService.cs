using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    public class StringService
    {
        public  string Reverse(string s)
        {
            if (s == null) return null;
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                result = s.Substring(i, 1) + result;
            }
      
            return result;
        }
    }

}
