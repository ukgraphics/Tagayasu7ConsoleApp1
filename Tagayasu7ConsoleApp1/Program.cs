using System;
using System.Collections.Generic;

namespace Tagayasu7ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("タガヤスのイベント履歴を表示");
            Console.WriteLine("\r\n");

            List<Event.EventItem> result;
            result = Event.GetEvent("タガヤス");

            foreach (Event.EventItem a in result)
            {
                Console.WriteLine(a.title);
                Console.WriteLine(a.place);
                Console.WriteLine(a.event_url);
                Console.WriteLine("\r\n");
                
            }
        }
    }
}
