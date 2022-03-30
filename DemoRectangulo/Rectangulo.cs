using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    class Rectangulo
    {
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public Punto punto3 { get; set; }
        public Punto punto4 { get; set; }


        public double base1( )
        {
            return Math.Sqrt((Math.Pow((punto2.x - punto1.x), 2) + Math.Pow((punto2.y - punto1.y), 2)));
        }

        public double altura1()
        {
            return Math.Sqrt((Math.Pow((punto3.x - punto2.x), 2) + Math.Pow((punto3.y - punto2.y), 2)));
        }

        public double base2()
        {
            return Math.Sqrt((Math.Pow((punto4.x - punto3.x), 2) + Math.Pow((punto4.y - punto3.y), 2)));
        }

        public double altura2()
        {
            return Math.Sqrt((Math.Pow((punto1.x - punto4.x), 2) + Math.Pow((punto1.y - punto4.y), 2)));
        }
        public double Area()
        {
            return base1() * altura1();
        }

        public double Perimetro()
        {
            return (base1() + altura1())*2; 
        }
      

    }
}
