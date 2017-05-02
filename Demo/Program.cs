using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Swapping

    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            num1 = 10;
            num2 = 20;
            temp = 30;

            //Swapping of numbers
            temp = num1;

            num1 = num2;

            num2 = temp;

            Console.Write("\nAfter Swapping : ");

            Console.Write("\nFirst Number : " + num1);

            Console.Write("\nSecond Number : " + num2);

            Console.Read();

        }
    }
}
