using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------Start----------------------------------");

            //Creating Object of ExceptionIO class
            ExceptionIO exceptionIO = new ExceptionIO();

            Console.WriteLine("------------------------------------------------------------------------");

            //Creating Objct of OutOfBoundException
            OutOfBoundException outOfBoundException = new OutOfBoundException();

            Console.WriteLine("------------------------------------------------------------------------");

            //Creating object of TypeMismatchException
            TypeMismatchException typeMismatchException = new TypeMismatchException();

            Console.WriteLine("------------------------------------------------------------------------");

            //Creating object of NullPointException
            NullPointException nullPointException = new NullPointException();

            Console.WriteLine("------------------------------------------------------------------------");

            //Creating object of MathematicalException
            MathematicalException mathematicalException = new MathematicalException();

            Console.WriteLine("------------------------------------------------------------------------");

            //Creating object of CastException
            CastException castException = new CastException();

            Console.WriteLine("------------------------------------------------------------------------");

            //Creating object of MemoryException
            MemoryException memoryException = new MemoryException();

            Console.WriteLine("------------------------------------------------------------------------");

            //Creating object of MemoryException
            OverflowException overflowException = new OverflowException();

            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
