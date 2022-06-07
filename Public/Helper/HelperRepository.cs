using System;

namespace Public.Helper
{
    public class HelperRepository
    {
        public static string Get6DigitCode()
        {
            Random generator = new Random();
            string code = generator.Next(0, 1000000).ToString("D6");
            if (code.StartsWith("0")) { code = Get6DigitCode(); }
            return code;
        }
        public static string Get8DigitCode()
        {
            Random generator = new Random();
            string code = generator.Next(0, 100000000).ToString("D8");
            if (code.StartsWith("0")) { code = Get8DigitCode(); }
            return code;
        }
        public static  string GetHashCode() 
        {

            return null;
        }
    }
}
