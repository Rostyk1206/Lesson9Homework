using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Homework4
{
    class Book
    {
        private string name { get; set; }
        
        public void Show()
        {
            Console.WriteLine($"Name of book is:");
            Console.BackgroundColor = ConsoleColor.Blue;
            name = Console.ReadLine();
        }
    }
}
