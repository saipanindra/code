using System;

namespace AtoI
{
    class Program
    {
            //00023 return 23
    //-000032 return -32
    //INT.MAX.ToSTring() 0
    //INT.MIN.tostring() 0
        //+-2 return 0
        //ab2 return 0
        //+-ab3 return 0
        //+234ab3 return 234
        //-234 return -234
        //-abc return 0
        static void Main(string[] args)
        {
            Console.WriteLine(myAtoi("00023"));
            Console.WriteLine(myAtoi("-000032"));
            Console.WriteLine(myAtoi("-000032"));
            Console.WriteLine(myAtoi("+-2"));
            Console.WriteLine(myAtoi("ab3"));
            Console.WriteLine(myAtoi("+-ab4"));
            Console.WriteLine(myAtoi("+234ab3"));
            Console.WriteLine(myAtoi("-234ab3"));
            Console.WriteLine(myAtoi("-abc"));
            Console.WriteLine(myAtoi(((long)(Int32.MaxValue)+1).ToString()));
            Console.WriteLine(myAtoi((Int32.MinValue).ToString()));
            Console.WriteLine(myAtoi("  010"));
            Console.WriteLine(myAtoi("9223372036854775809"));
        }

        private static int myAtoi(string str)
        {
           string trimmedStr = str.Trim();
            if(string.IsNullOrEmpty(trimmedStr))
            {
                return 0;
            }
            int multiplier = trimmedStr[0] == '-' ? -1: 1;
            int startIndex = trimmedStr[0] == '+' || trimmedStr[0] == '-' ? 1: 0;
            long sum_so_far = 0;
            int power = 0;
            int i = trimmedStr.Length - 1;
            while(i >= startIndex)
            {
                int v = trimmedStr[i] - 48;
                if(v >= 0 && v <= 9)
                {
                    if(!(sum_so_far > Int32.MaxValue))
                      sum_so_far += v * (long)Math.Pow(10, power);
                    power++;
                }
                else
                {
                    sum_so_far = 0;
                    power = 0;
                }
                i--;
            }
            if(sum_so_far > Int32.MaxValue && multiplier == 1)
            {
                return Int32.MaxValue;
            }
            if(sum_so_far > (long)Int32.MaxValue +1 && multiplier == -1)
            {
                return Int32.MinValue;
            }
            return (int)sum_so_far * multiplier;
        
        }
}
}

    


