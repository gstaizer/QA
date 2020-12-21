using System;

namespace lab3
{
    public class Rectangle
    {
        public int a = 0, b = 0;

        public Rectangle(int a, int b){ this.a = a; this.b = b;
        }
        public Rectangle() { }

        public void setAB(int a, int b)
        {
            this.a = a;
            this.b = b;

        }

        public void setA(int a)
        {
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }

        public double getSquare()
        {
            return a * b;
        }

        public int getPerimeter()
        {
            return (a + b)*2;
        }

        public bool isSquare()
        {
            return a == b;
        }

        public bool isCorrect()
        {
            return a > 0 && b > 0;
        }
    }
}