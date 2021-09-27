using System;
using System.Collections.Generic;
using System.IO;
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
        public static void Print<T>(this IEnumerable<T> items) 
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintSingle<T>(this T item)
        {
            Console.WriteLine(item);
        }
    }
}