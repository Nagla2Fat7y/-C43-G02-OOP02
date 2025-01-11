

namespace Ass2
{
    internal struct Rectangle
    {

        #region Question 4
        ///            4.Create a struct named Rectangle that represents a rectangle with the following fields:
        ///            width(type: double)
        ///            height(type: double)
        ///            Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:
        ///            The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.
        ///            Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * heigh
        ///            Implement a method DisplayInfo that prints the rectangle's dimensions and area.
        ///            Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.
        ///            

        //prameters
        private double width;
        private double height;



        //Properties
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Width should not be negative");
                }
                else
                {
                    width = value;
                }
            }
        }


        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Height should not be negative");
                }
                else
                {
                    height = value;
                }
            }
        }

       
        public double Area
        {
            get { return width * height; }
        }
        //method
        public void DisplayInfo()
        {
            Console.WriteLine($"Width = {width}\nHeight = {height}\nArea = {Area}");
        }
        #endregion






    }
}
