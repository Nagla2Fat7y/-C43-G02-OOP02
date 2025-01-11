using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Ass2
{
    internal class Program
    {


        static void Main(string[] args)
        {

            #region Question 1
            ///Create an array of three "Person" objects and populate it with data.
            //Person[] P1;
            //P1 = new Person[3]; 
            //P1[0] = new Person("Naglaa"  ,  22);
            //P1[1] = new Person("Ahmed"   ,  30);
            //P1[2] = new Person("Mohamed" ,  35);

            //foreach (Person person in P1)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region Question 2
            ///Create a struct called "Point" to represent a 2D point with properties "X" and   "Y
            ///Write a C# program that takes two points as input from the user and calculates    
            /// the distance between them.



            // Console.Write("Entre  X Point 1 :  ");
            // int.TryParse(Console.ReadLine(), out int x1);
            // Console.Write("Entre  Y Point 1 :  ");
            // int.TryParse(Console.ReadLine(), out int y1);
            // Console.Write("Entre  X Point 2 :  ");
            // int.TryParse(Console.ReadLine(), out int x2);
            // Console.Write("Entre  Y Point 2 :  ");
            // int.TryParse(Console.ReadLine(), out int y2);
            // Point p1 = new Point(x1 ,y1);
            // Point p2 = new Point(x2, y2);
            // Console.WriteLine(p1);
            // Console.WriteLine(p2);

            //double distance = p1.Distance(p1, p2);
            // Console.WriteLine($"Distance Betwwen 2 points = {distance} ");      

            #endregion


            #region Question 3



            //Person[] P = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Entre Name : ");
            //    string? name = Console.ReadLine();
            //    Console.Write("Entre Age : ");
            //    int.TryParse(Console.ReadLine(), out int age);
            //    Person person = new Person(name, age);

            //    P[i] = new Person(name, age);

            //}

            //Person oldest = P[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (P[i].age > oldest.age)
            //    {
            //        oldest = P[i];
            //    }
            //}
            //Console.WriteLine($"The oldest person is {oldest.name} and his age is {oldest.age}");





            #endregion


            #region Question 4


            //Rectangle rectangle = new Rectangle();

            //bool validWidth = false, validHeight = false;
            //while (!validWidth || !validHeight)
            //{
            //    Console.Write("Enter the width of the rectangle: ");
            //    double width = Convert.ToDouble(Console.ReadLine());


            //    Console.Write("Enter the height of the rectangle: ");
            //    double height = Convert.ToDouble(Console.ReadLine());
            //    rectangle.Width = width;
            //    rectangle.Height = height;

            //    if (rectangle.Width >= 0 || rectangle.Height >= 0)
            //        validWidth = true;
            //    validHeight = true;
            //}


            //rectangle.DisplayInfo();

            #endregion
        }
    }
}         