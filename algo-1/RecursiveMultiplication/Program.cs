using System;

namespace RecursiveMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfDigitsIn(456));
            Console.WriteLine(NumberOfDigitsIn(12));
            Console.WriteLine(NumberOfDigitsIn(0));
        }
        //((10^n/2)a + b) * ((10^n/2)c + d) = ((10^n)ac + (10^n/2)(bc + ad) + bd)
        //(a+b)*(c+d)-ac-bd = bc + ad 
        static int RecursiveMultiplication(int X, int Y)
        {
            if(X % 10 == X && Y % 10 == Y)
            {
                return X * Y;
            }
            if(X == 0 || Y ==0)
            {
                return 0;
            }
            int numberOfDigitsInX = NumberOfDigitsIn(X);
            int numberOfDigitsInY = NumberOfDigitsIn(Y);
            int MultiplierOfa = (int)(Math.Pow(10, numberOfDigitsInX/2));
            int a = (X / MultiplierOfa);
            int b = (X % MultiplierOfa);
            int MultiplierOfc = (int)(Math.Pow(10, numberOfDigitsInY/2));
            int c = (Y / MultiplierOfc);
            int d = (Y % MultiplierOfc);
            int ac = RecursiveMultiplication(a, c);
            int bd = RecursiveMultiplication(b, d);
            int aPlusbTimescPlusd = RecursiveMultiplication(a + b, c + d);
            int bcPlusad = aPlusbTimescPlusd - ac - bd;
            
        }

        static int NumberOfDigitsIn(int input)
        {
            int c = 1;
            while((input = input / 10) != 0)
            {
                c++;
            }
            return c;
       }

    }
}
