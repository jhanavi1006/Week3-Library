
using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(
                "C# for beginners",
                "Bill Gates",
                "1234567"
            );

            Book book2 = new Book(
                "Ultimate C#",
                "Microsoft",
                "2233445"
            );

            book1.DisplayInfo();
            book2.DisplayInfo();
        }
    }
}
