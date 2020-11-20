using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Homework4
{
    class Title
    {
        private string name { get; set; }
        public void Show()
        {
            Console.WriteLine($"Title of book is:{name}");
            Console.BackgroundColor = ConsoleColor.Red;
            name = Console.ReadLine();
        }
    }
}
