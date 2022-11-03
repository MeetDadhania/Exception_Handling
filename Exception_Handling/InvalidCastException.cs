using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //creating class for InvalidCastException
    internal class CastException
    {
        //Constructor
        public CastException()
        {
            try
            {
                //create boolean variable
                bool flag = true;

                //try to cast boolean to char 
                char convertToChar = Convert.ToChar(flag);

            }catch(InvalidCastException icEx)
            {
                Console.WriteLine("InvalidCastException occurs");
                //print Exception Message
                Console.WriteLine(icEx.Message);
            }
        }
    }
}
