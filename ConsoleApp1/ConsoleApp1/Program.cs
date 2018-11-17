using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

    class Program
    {
        static void Main(string[] args)
        {int number1; //declare first number to multiply 
       int number2; //declare second number to multiply
            int product; //declare product of number1 and number2 

        Console.Write { Enter first integer: " ); // prompt user
   // read first number from user
  number1 = Convert.ToInt32{ Console.ReadLine{) );

        Console.Write { Enter second integer: " ); //prompt user}
   // read second number from user
  number2 = Convert.ToInt32{ Console.ReadLine{) );

                                    product = number1 * number2; // multiply numbers

                                    Console.WriteLine{  "Product is {0}", product ); // display product }

                                        // Fig. 3.17: Welcome4.cs
                                        // Displaying multiple lines of text with string formatting.
                                        using System;

public class Welcome4
        {
            // Main method begins execution of C# application
            public static void Main(string[] args)

Console.WriteLine( "{0}\n{1}", "Welcome to", "C# Programming!" );
} // end Main
    } //end class Welcome4

    using System;
 
namespace Sample
    {
        class Test
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Hello World  From Dan");
            }
        }
    }
/* The console application executes at Line 14 */

/* Integers do not contain decimals whereas a floating point variable contain decimal points for more precision */

/* An example of method from Chapter 4 would be the gradebook method detailed in figure 4.1. */

/* Like we have types double and int, we can create our own custom types using Classes.  Each class has variables called instance variables or class members.  To read the value of an instance variable, we create method called a reader accessor.  To assign a value to instance variable, we use a method called a writer accessor.*/

    /* A class is a template for objects. Objects are states where all properties have values that are either defined by user or by default settings. The only limitations to instances of a class you can create are heap size. Otherwise you can create as many instances of a class as you wish.*/

