using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions {

    public static class LINQExtension {
        public static double Median(this IEnumerable<double>? source) {
            if (!(source?.Any() ?? false)) {
                throw new InvalidOperationException("Ensemble NULL ou vide.");
            }

            source = (from number in source
                      orderby number
                      select number).ToList<double>();
            int index = source.Count() / 2;

            if (source.Count() % 2 == 0) {
                return (source.ElementAt(index) + source.ElementAt(index) - 1) / 2;
            } else {
                return source.ElementAt(index);
            }
        }
    }

    public static class StringExtension {

        public static int WordCount(this string str) {
            int i = 0;
            foreach (string word in str.Split(' ')) {
                i++;
            }
            return i;
        }
    }
}