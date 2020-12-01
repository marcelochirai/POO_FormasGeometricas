using System;
using System.Collections.Generic;
using System.Text;

namespace POO_FormasGeometricas.Entities
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }


        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }

    }
}
