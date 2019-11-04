using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hTable = new Hashtable();

            hTable.Add("Test", 1);
            hTable.Add("Test2", 10);
            hTable.Add("Test3", 100);
            hTable.Add("Test4", 1000);
            hTable.Add("Test5", 10000);
            hTable.Add("Test6", 20);

            foreach(object obj in hTable.Values)
            {
                Console.WriteLine($"Content: {obj.ToString()}");
            }
        }
    }
}
