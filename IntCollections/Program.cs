using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> {1, 10, -30, 10, -5};
            Stack<int> intStack = new Stack<int> (intList);
            Queue<int> intQueue = new Queue<int> (intList);
            HashSet<int> intHashSet = new HashSet<int> (intList);

            
            foreach(int i in intList)
                Console.Write(i + ",");
            
            Console.WriteLine();

            foreach(int i in intStack)
                Console.Write(i + ",");
            

            Console.WriteLine();

             foreach(int i in intQueue)
                Console.Write(i + ",");
            

            Console.WriteLine();

             foreach(int i in intHashSet)
                Console.Write(i + ",");
            

            Console.WriteLine();
        }
    }
}
