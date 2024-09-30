using System;
namespace Shapes_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create instances of shapes
            shape c = new circle(5);
            shape R = new rectangle(5,3.62);
            shape t = new triangle(5,3);
            shape s = new square(5);
            Console.WriteLine($"circle(5)={c.area()}\n" +
                $"rectangle(5,3.62)={R.area()}\n" +
                $"triangle(5,3)= {t.area()}\n" +
                $"square(5)= {s.area()}\n");
            c.area();
            R.area();
            s.area();
            t.area();

        }
        //Base class
        public class shape
        {
            protected double lentgh;
            protected double width;

            public virtual double area() { return 0; }
        }
        //derived class: Circle
        public class circle:shape 
        {
            private double radius;
            public circle(double radius)
            {
                this.radius = radius;
            }
            public override double area() { return Math.PI*radius*radius; }
        }
        //derived class: Rectangle
        public class rectangle : shape 
        {public rectangle(double lentgh,double width) { this.lentgh=lentgh; this.width=width; }
            public override double area(){return lentgh*width;}
        }
        //derived class: Triangle
        public class triangle : shape {
            public triangle(double baseLength, double height) { lentgh = baseLength; width = height; }
            public override double area() { return 0.5 * lentgh * width; }
        }

        public class square : shape {
            public square(double side) { lentgh = side; width = side; }
            public override double area() { return lentgh * width; }
        }

    }
}
