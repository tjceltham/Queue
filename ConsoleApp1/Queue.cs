using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Queue
    {
        private int[] Q;
        private int front;
        private int back;
        private Boolean full;
   

        public Queue(int s)
        {
            Q = new int[s];
            front = 0;
            back = 0;
            full = false;

        }
        public void enqueue(int value )
        {
            if (full == false)
            {
                Q[back] = value;
                back = (back + 1) % Q.Length;
                if (back == front) full = true;
            }else Console.WriteLine("Full");
        }

        public int dequeue()
        {
            int value;
            if (back != front || full == true)
            {
                value = Q[front];
                front = (front + 1) % Q.Length;
                full = false;
            }
            else
            {
                value = -999;
                Console.WriteLine("Q Full");
            }
            return value;

        }




    }
}
