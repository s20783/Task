using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.Services
{
    public class StringService
    {
        public static string ReverseString(string text)
        {
            int l = text.Length;
            if(l > 1)
            {
                return text.ElementAt(l - 1) + ReverseString(text.Remove(l - 1));
            }

            return text;
        }
    }
}
