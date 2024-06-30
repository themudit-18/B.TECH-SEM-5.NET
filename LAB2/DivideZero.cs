using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class DivideZero
    {
        public void DividezeroFun()
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You can't divide any value with Zero");
            }
            Console.WriteLine("There is no problem for division");

        }
    }
}
