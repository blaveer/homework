using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plant
{
    class Factory
    {
        public static void CreateGraph(string type)
        {
            switch (type)
            {
                case "Triangle":
                    Triangle triangle = new Triangle();
                    Console.WriteLine("Please enter the base and height of the triangle");
                    triangle.Base =Double.Parse(Console.ReadLine());
                    triangle.High = Double.Parse(Console.ReadLine());
                    triangle.GetArea();
                    break;
                case "Round":
                    Round round = new Round();
                    Console.WriteLine("Please enter the radius of the round");
                    round.Radius = Double.Parse(Console.ReadLine());
                    round.GetArea();
                    break;
                case "Square":
                    Square square = new Square();
                    Console.WriteLine("Please enter the length of side of the square");
                    square.LengthOfSide = Double.Parse(Console.ReadLine());
                    square.GetArea();
                    break;
                case "Rect":
                    Rect rect = new Rect();
                    Console.WriteLine("Please enter the width and height of the rect");
                    rect.Width = Double.Parse(Console.ReadLine());
                    rect.High = Double.Parse(Console.ReadLine());
                    rect.GetArea();
                    break;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the type of graph you want to compute,you can choose from the following!");
                Console.WriteLine("Triangle     Round       Square      Rect");
                string type = Console.ReadLine();
                CreateGraph(type);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error that cannot be resolved" + ex.Message);
            }

        }
    }
    abstract class Graph
    {
        public abstract void GetArea();
    }
    class Triangle: Graph
    {
        public double Base { set; get; }
        public double High { set; get; }
        public override void GetArea()
        {
            double Area = Base * High;
            Console.WriteLine("The area of the triangle you entered is " + Area);
        }
    }
    class Round : Graph
    {
        public double Radius { set; get; }
        public override void GetArea()
        {
            double Area = Radius * Radius * 3.1415926;
            Console.WriteLine("The area of the round you entered is " + Area);
        }
    }
    class Square : Graph
    {
        public double LengthOfSide { set; get; }
        public override void GetArea()
        {
            double Area = LengthOfSide * LengthOfSide;
            Console.WriteLine("The area of the square you entered is " + Area);
        }
    }
    class Rect : Graph
    {
        public double Width { set; get; }
        public double High { set; get; }
        public override void GetArea()
        {
            double Area = Width * High;
            Console.WriteLine("The area of the rect you entered is " + Area);
        }
    }
}
