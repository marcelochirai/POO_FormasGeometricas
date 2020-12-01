using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FormasGeometricas.Entities
{
    class Circulo : Forma
    {
        public double Raio { get; set; }
        
        public Circulo(double raio,ConsoleColor cor) : base(cor)
        {
            Raio = raio;
        }        
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
