using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.Classes.Enums;

namespace Figuras.Classes
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
    }
