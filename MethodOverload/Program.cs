using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //call base Add method
            Console.WriteLine(Add(2, 3));

            //call 1st overload Add method
            Console.WriteLine(Add(1.56m, 6.78m));

            //call 2nd overload Add method
            Console.WriteLine(Add(2, 5, true));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(0, 0, false));
        }

        /// <summary>
        /// accepts two integers and returns the sum of those two integers
        /// </summary>
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// able to add two decimals together
        /// </summary>
        public static decimal Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return sum;
        }


        /// <summary>
        /// If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers 
        /// plus the word “dollars” at the end of the string
        /// </summary>
        public static string Add(int num1, int num2, bool isDollar)
        {
            int sum = num1 + num2;
            
            if (isDollar == true)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }

            return sum.ToString();
        }
    }
}
