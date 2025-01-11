using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ass2
{
    #region
    
    //Create a struct called "Point" to represent a 2D point with properties "X" and   "Y"   
    //Write a C# program that takes two points as input from the user and calculates 
    // the distance between them.

    internal struct Point
    {
        //Properties
        private int X;
        private int Y;

        //property
        public int x
        {
            get => X;
            set => X = value;
        }
        public int y
        {
            get => Y;
            set => Y = value;
        }

        //Constructor
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        //Method
        public double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

        public override string ToString()
        {
            return $"Point: ({X} , {Y})";
        }


    }
    #endregion
}
