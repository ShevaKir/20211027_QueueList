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
            queueList.Put(40);

            //Console.WriteLine(queueList.GetData());
            //Console.WriteLine(queueList.GetData());
            //Console.WriteLine(queueList.GetData());
            //Console.WriteLine(queueList.GetData());

            foreach (object item in queueList)
            {
                Console.WriteLine(item);
                if(item is Entry data)
                {
                    Console.WriteLine(data.Data);
                }
            }

            Console.ReadKey();
        }
    }
}
