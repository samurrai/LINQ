using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class Extensions
    {
        public static int GetLettersCount(this string data)
        {
            return data.Length;
        }
    }
}
