using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class SwapTwoNum
    {
       public void Swap()
        {

            Console.WriteLine("Enter first number...");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter second number...");
            int num2 = Convert.ToInt16(Console.ReadLine());
           
            Console.WriteLine( "Before Swap numbers are :" + "num1: "+ num1 + " And " + "num2: " +  num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swap Numbers are :" + "num1: " + num1 + " And " + "num2: " + num2);


        }


    }
}
