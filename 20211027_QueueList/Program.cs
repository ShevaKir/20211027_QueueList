using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211027_QueueList
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueList queueList = new QueueList();

            queueList.Put(10);
            queueList.Put(20);
            queueList.Put(30);

            Console.WriteLine(queueList.GetData());
            Console.WriteLine(queueList.GetData());
            Console.WriteLine(queueList.GetData());

            Console.ReadKey();
        }
    }
}
