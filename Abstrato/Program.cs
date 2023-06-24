using System;
using System.Collections.Generic;
using System.Globalization;
using Abstrato.Entities;
using Abstrato.Entities.Enums;

namespace Abstrato
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char escolha = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Red/Blue): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                
                if (escolha == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, heigth, color));
                }

                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
         
        }
    }
}