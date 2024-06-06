using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        public Rectangle(double a) : this(a, 5) { }

        public Rectangle() : this(4, 3) { }

        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        public bool IsSquare()
        {
            return sideA == sideB;
        }

        public void ReplaceSides()
        {
            double temp = sideA;
            sideA = sideB;
            sideB = temp;
        }
    }

    public class ArrayRectangles
    {
        private readonly Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(params Rectangle[] rectangles)
        {
            rectangle_array = rectangles;
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
            }
            return false;
        }

        public int NumberMaxArea()
        {
            double maxArea = double.MinValue;
            int maxAreaIndex = -1;

            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] != null && rectangle_array[i].Area() > maxArea)
                {
                    maxArea = rectangle_array[i].Area();
                    maxAreaIndex = i;
                }
            }

            return maxAreaIndex;
        }

        public int NumberMinPerimeter()
        {
            double minPerimeter = double.MaxValue;
            int minPerimeterIndex = -1;

            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] != null && rectangle_array[i].Perimeter() < minPerimeter)
                {
                    minPerimeter = rectangle_array[i].Perimeter();
                    minPerimeterIndex = i;
                }
            }

            return minPerimeterIndex;
        }

        public int NumberSquare()
        {
            int squareCount = 0;

            foreach (Rectangle rectangle in rectangle_array)
            {
                if (rectangle != null && rectangle.IsSquare())
                {
                    squareCount++;
                }
            }

            return squareCount;
        }
    }
}
