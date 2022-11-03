using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //creating class for DivideByZeroException
    internal class MathematicalException
    {
        //constructor
        public MathematicalException()
        {
            try
            {
                //assign int value
                int myNumber = 134;

                //create variable assign it to 0
                int yourNumber = 0;

                //try to divide int with Zero
                int result = myNumber/yourNumber;

            }catch (DivideByZeroException dbzEx)
            {
                Console.WriteLine("DivideByZeroException occurs");
                //print Exception Message
                Console.WriteLine(dbzEx.Message);
            }
        }
    }
}
