using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    //Creating class for ArrayTypeMismatchException
    internal class TypeMismatchException
    {
        public TypeMismatchException()
        {
            try
            {
                //Creat string array cars 
                string[] cars ={"Ford", "Kia", "Honda", "BMW" } ;

                //Creat int array name types
                int[] types = { 1900, 1000, 2000 };

                //try to copy cars array into types array
                Array.Copy(cars, types, 2);
            }
            catch (ArrayTypeMismatchException atmEx)
            {
                Console.WriteLine("ArrayTypeMismatchException occurs");
                //print Exception Message
                Console.WriteLine(atmEx.Message);
            }
        }
    }
}
