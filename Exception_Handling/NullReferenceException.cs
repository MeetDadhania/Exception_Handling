using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //creating class for NullReferenceException
    internal class NullPointException
    {
        //constructor
        public NullPointException()
        {
            try
            {
                //create array and assign it to null
                int[] myNumbers = null;

                for (int i = 0; i < 7; i++)
                {
                    //try to access array which is assign to null
                    myNumbers[i] = i * i;
                }

            }catch (NullReferenceException nrEx)
            {
                Console.WriteLine("NullReferenceException occurs");
                //print Exception Message
                Console.WriteLine(nrEx.Message);
            }
        }
    }
}
