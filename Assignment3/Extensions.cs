using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri){
            return uri.Scheme == "https";
        }

        public static int WordCount(this string s){
            Regex regex = new Regex("^([^\\P{L}]{1,})$");
            int counter = 0;
            string[] words = s.Split(' ');
            foreach (string word in words)
                if (regex.IsMatch(word)){
                    counter++;
                }

            return counter;
            //return Regex.Matches(s, regex).Count;

        }
    }
}