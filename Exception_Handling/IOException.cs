using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //creating class for IOException
    public class ExceptionIO
    {
        //constructor
        public ExceptionIO()
        {
            try
            {
                //try to read file with invalid path give IOException
                string demoText = File.ReadAllText(@"../../Text.txt");
                Console.WriteLine(demoText);

            }catch(IOException ioEx)
            {
                Console.WriteLine("IOException occurs");
                //print Exception Message
                Console.WriteLine(ioEx.Message);
            }
        }
    }
}
