using System;
using System.Globalization;

namespace hackerrank_time_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        
        }
    }

    class Result
    {
        public static string timeConversion(string s)
        {
            var dt =DateTime.ParseExact(
                s, "hh:mm:sstt",
            CultureInfo.InvariantCulture);
            
            return $"{dt:HH:mm:ss}";
        }
    }
}