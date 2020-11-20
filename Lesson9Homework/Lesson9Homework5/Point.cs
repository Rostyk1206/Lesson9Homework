using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Homework5
{
    class Point
    {
        public int field1;
        public int field2;
        public string field3;

        public int Field1
        {
            get
            {
                if (field1 = value)
                {
                    return field1;
                }
                else
                {
                    return Console.WriteLine("There is no value");
                    
                }
            }
        }
        public int Field2
        {
            get
            {
                if (field2 = value)
                {
                    return field2;
                }
                else
                {
                    return Console.WriteLine("There is no value");
                }
            }
        }
        public string Field3
        {
            get
            {
                if (field3 = value)
                {
                    return field3;
                }
                else
                {
                    return Console.WriteLine("There is no value");
                }
            }
        }
        public Point(int field1,int field2,string field3)
        {
            this.field1 = field1;
            this.field2 = field2;
            this.field3 = field3;
        }


    }
}

