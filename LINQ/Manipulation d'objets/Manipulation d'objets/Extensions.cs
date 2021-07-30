using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions {

    public static class StringExtension {

        public static int WordCount(this string str) {
            int i = 0;
            foreach (string word in str.Split(' ')) {
                i++;
            }
            return (i);
        }
    }
}