using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine(GenericCache<int>.GetCache());
                    Console.WriteLine(GenericCache<long>.GetCache());
                    Console.WriteLine(GenericCache<string>.GetCache());
                }
            }
        }
    }
}
