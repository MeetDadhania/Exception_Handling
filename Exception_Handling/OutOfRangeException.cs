using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //creating class for IndexOutOfRangeException
    internal class OutOfBoundException
    {
        //constructor
        public OutOfBoundException()
        {
            try
            {
                //Creating int array with 7 values in it
                int[] myNumbers = { 12, 13, 13, 1, 5, 1, 3 };
                //try to access more than the size of array
                for(int i = 0; i < 8; i++)
                {
                    Console.WriteLine(myNumbers[i]);
                }

            }catch(IndexOutOfRangeException iorEx)
            {
                Console.WriteLine("IndexOutOfRangeException occurs");
                //print Exception Message
                Console.WriteLine(iorEx.Message);
            }
        }
    }
}
