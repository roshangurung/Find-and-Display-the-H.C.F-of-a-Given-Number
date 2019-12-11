using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)///In program we are reading the first and second numbers using ‘num1’ and ‘num2’ variables respectively. If condition statement is used to check the condition that the modulus of the value of ‘num1’ variable by the value of ‘i’ variable is equal to 0 and the modulus of the value of ‘num2’ variable by the value of ‘i’ variable is equal to 0. If the condition is true, then execute the statement and assign the number to hcf variable. Print the HCF of a given number.///
        {
            int num1, num2, i;
            int hcf = 0;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            for (i = 1; i <= num1 || i <= num2; ++i)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf = i;
                }
            }
            Console.Write("\nCommon Factor is : ");
            Console.WriteLine(hcf);
            Console.Read();
        }
    }
}
////Output:Enter the First Number : 12
////Enter the Second Number : 16
////Common Factor is : 4