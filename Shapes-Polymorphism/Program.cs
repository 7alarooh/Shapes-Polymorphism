using System;
namespace Shapes_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create instances of shapes
            shape c = new circle();
            shape R = new rectangle();
            shape t = new triangle();
            shape s = new square();

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
        public class rectangle : shape { }
        public class triangle : shape { }

        public class square : shape { }

    }
}
