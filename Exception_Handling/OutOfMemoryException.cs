using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //creating class for OutOfMemoryException
    internal class MemoryException
    {
        //Constructor
        public MemoryException()
        {
            try
            {
                //Creating new string
                string demoText = File.ReadAllText(@"../../Demo_Text.txt");

                //create list of string
                List<string> myNumbers = new List<string>();

                //infinite for loop to add value to list 
                for(int i = 0;; i++)
                {
                    myNumbers.Add(demoText);
                }

            }
            catch (OutOfMemoryException omEx)
            {
                Console.WriteLine("OutOfMemoryException occurs");
                //print Exception Message
                Console.WriteLine(omEx.Message);
            }
        }
    }
}
