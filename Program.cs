using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Casting :-
            // Automatically convert one type to another, no need to use external function
            int a = 5;
            double b = a;

            // Explicit Type Casting :-
            // Need external function to convert one type to another
            string x = "123";
            int y = int.Parse(x);
        }
    }
}
