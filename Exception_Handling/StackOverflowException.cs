using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //creating class StackOverflowException 
    internal class OverflowException
    {
        //constructor
        public OverflowException()
        {
            try
            {
                //calling Recursive method
                RecursiveMethod(0);
            }
            catch (StackOverflowException soEx)
            {
                Console.WriteLine("StackOverflowException occurs");
                //print Exception Message
                Console.WriteLine(soEx.Message);
            }
        }

        public void RecursiveMethod(int myNumber)
        {
            //calling recursive method again and again
            RecursiveMethod(++myNumber);
        }
    }
}
