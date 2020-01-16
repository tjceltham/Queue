using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Queue q = new Queue(3);

            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);
            q.enqueue(4);
          


            Console.WriteLine(q.dequeue());
            q.enqueue(5);
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());
        }
    }
}
