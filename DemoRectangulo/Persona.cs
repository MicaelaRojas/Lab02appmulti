using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    class Persona
    {
        public string Nombres   { get; set; }
        public string Apellidos { get; set; }


        public string DevolverNombresCompletos()
        {
            return string.Concat(Nombres, " ", Apellidos);
        }
    }
}
