using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Homework3
{
    class Rectangle
    {
        private double side1;//поле
        private double side2;//поле

        public Rectangle(double side1,double side2)//конструктор
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Area //властивість
        {
            get 
            {
                if (side1 == 0 && side2==0)
                {
                    Console.WriteLine("Uncorrect number");
                    return -1;
                }
                else 
                {
                    return AreaCalculator(side1,side2) ;
                }
                   
            }

        }
        public double Perimetr //властивість
        {
            get
            {
                if (side1 == 0 && side2==0)
                {
                    Console.WriteLine("Uncorrect number");
                    return -1;
                }
                else
                {
                    return PerimeterCalculator(side1, side2) ;
                }

            }
        }
    
        private double AreaCalculator(double side1, double side2) //метод
        {
            double result = side1 * side2;
            return result;
        }
        private double PerimeterCalculator(double side1,double side2) //метод
        {
            double result = (side1 + side2) * 2;
            return result;
        }
    }
}
