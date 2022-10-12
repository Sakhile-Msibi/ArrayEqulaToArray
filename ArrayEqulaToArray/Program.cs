using System;

namespace ArrayEqulaToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3, 4, 5 };

            int[] intarray1 = new int[5] { 1, 2, 3, 4, 5 };

            //intarray1 = intarray;

            Console.WriteLine(intarray.Equals(intarray1));
        }
    }
}
