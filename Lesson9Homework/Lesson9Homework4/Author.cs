using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Lesson9Homework4
{
    class Author
    {
        private string name { get; set; }
        public void Show()
        {
            Console.WriteLine($"Author of book is:");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            name = Console.ReadLine();
        }
    }
}
