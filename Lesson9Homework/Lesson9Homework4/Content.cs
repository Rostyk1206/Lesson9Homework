using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Homework4
{
    class Content
    {
        private string content { get; set; }
        public void Show()
        {
            Console.WriteLine($"Content of book is:");
            Console.BackgroundColor = ConsoleColor.Green;
            content = Console.ReadLine();
        }
    }
}
