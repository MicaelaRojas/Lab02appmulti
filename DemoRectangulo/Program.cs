using DemoRectangulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Rectangulo rectangulo = new Rectangulo();
            double x1, y1, x2, y2, x3, y3, x4, y4;
            
            Console.WriteLine("Ingrese las coordenadas x1, y1:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            rectangulo.punto1 = new Punto(x1, y1);
            Console.WriteLine("Ingrese las coordenadas x2, y2:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            rectangulo.punto2 = new Punto(x2, y2);
            Console.WriteLine("Ingrese las coordenadas x3, y3:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            rectangulo.punto3 = new Punto(x3, y3);
            Console.WriteLine("Ingrese las coordenadas x4, y4:");
            x4 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
            rectangulo.punto4 = new Punto(x4, y4);

            double base1, altura1, base2, altura2, fin1, fin2;
            
            base1 = rectangulo.base1();
            altura1= rectangulo.altura1();          
            base2 = rectangulo.base2();
            altura2 = rectangulo.altura2();

            fin1 = rectangulo.Area();
            fin2 = rectangulo.Perimetro();

            if (base1 == base2 && altura1 == altura2)
            {
                Console.WriteLine("Resultados de las coordenadas ingresadas: ");
                Console.WriteLine("x1(" + x1+") y y1("+y1+")");
                Console.WriteLine("x2(" + x2+") y y2("+y2+")");
                Console.WriteLine("x3(" + x3+") y y3("+y3+")");
                Console.WriteLine("x4(" + x4+") y y4("+y4+")");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\n"+"El área del rectangulo es: " + fin1+"\n");
                Console.WriteLine("El perimetro del rectangulo es: " + fin2);
            }
            else
            {
                Console.WriteLine("Las coordenadas ingresadas no pertenecen a un rectangulo");
            }

            Console.Read();

        }
    }
}