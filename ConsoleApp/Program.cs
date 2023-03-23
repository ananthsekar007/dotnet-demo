using System;

namespace ConsoleApp
{
    internal class Program
    {
        public struct Point
        {
             int xCoordinate;
             int yCoordinate;

            public void set(int xCoordinate, int yCoordinate)
            {
                this.xCoordinate = xCoordinate;
                this.yCoordinate = yCoordinate;
            }
            public int diff()
            {
                return this.xCoordinate - this.yCoordinate;
            }
        }

        public enum Weekdays
        {
            monday, tuesday, wednesday, thursday, friday
        }
        static void Main(string[] args)
        {
            //string[] names = { "Ananth", "Sekar", "Nivetha" };
            //printArray(names);

            //Point point = new Point();

            //point.set(3, 2);

            //foreach(int weekday in Enum.GetValues(typeof(Weekdays))) {
            //    Console.WriteLine(weekday);
            //}

            //Shape shape1 = new Shape();
            //Shape shape2 = new Shape(2,3);
            //Shape shape3 = new Shape(2, 2);

            //shape2.determineShape();
            //shape3.determineShape();

            Arithmetic arithmetic = new Arithmetic(1, 0);
            arithmetic.divide();
        }

        public static void printArray(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }

    internal class Arithmetic
    {
        int a;
        int b;

        public Arithmetic() {

            Console.WriteLine("called");
        }


        public Arithmetic(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void divide()
        {
            try
            {
                int result = this.a / this.b;
                Console.WriteLine("The result of division is {0}", result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"DivideByZero: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally is called");
            }
        }


    }

    internal class Shape
    {

        int length;
        int breadth;

        public Shape()
        {
            Console.WriteLine("Calling the default constructor");
        }

        public Shape(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public void determineShape()
        {
            if(this.length == this.breadth)
            {
                Console.WriteLine($"This is the dimensions of a square with length = {this.length} and breadth = {this.breadth}");
            }

            else
            {
                Console.WriteLine("This is the dimesions of a rectangle with length = {0} and breadth = {1}", this.length, this.breadth);
            }
        }

        ~Shape()
        {
            Console.WriteLine("The desctructor is called");
        }

    }
}