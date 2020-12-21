using System;


namespace lab1
    {
        public class Program
        {
            const string notTri = "не треугольник", commonTri = "обычный", RSTri = "равносторонний", RBTri = "равнобедренный", uncError = "неизвестная ошибка";
            private static string GetTriangleType(double a, double b, double c)
            {
                if (a + b <= c || a + c <= b || b + c <= a || a < 0 || b < 0 || c < 0)
                {
                    return notTri;
                }
                else if (a != b && a != c && b != c)
                {
                    return commonTri;
                }
                else if (a == b && b == c)
                {
                    return RSTri;
                }
                else
                {
                    return RBTri;
                }
            }

            public static void Main(string[] args)
            {
                if (args.Length != 3)
                {
                    Console.Write(uncError);
                }
                else
                {
                    try
                    {
                        double a = double.Parse(args[0]);
                        double b = double.Parse(args[1]);
                        double c = double.Parse(args[2]);

                        if (a > double.MaxValue || b > double.MaxValue || c > double.MaxValue)
                        {
                            Console.Write(uncError);
                        }
                        else
                        {
                            Console.Write(GetTriangleType(a, b, c));
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Write(uncError);
                    }
                }
            }
        }
    }