﻿using System;

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
            string[] names = { "Ananth", "Sekar", "Nivetha" };
            printArray(names);

            Point point = new Point();

            point.set(3, 2);

            foreach(int weekday in Enum.GetValues(typeof(Weekdays))) {
                Console.WriteLine(weekday);
            }

                   
        }

        public static void printArray(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}