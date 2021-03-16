using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeQue;

namespace TestDeQue
{
    class Program
    {
        static void Main(string[] args)
        {
            Deque dq = new Deque();
            dq.InsertLast(10);
            dq.InsertLast(20);
            dq.InsertLast(30);
            dq.RemoveFirst();
            dq.InsertLast(100);
            Console.ReadKey();
        }
    }
}
