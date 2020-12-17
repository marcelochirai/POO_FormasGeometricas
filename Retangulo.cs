using System;
using System.Collections.Generic;
using System.Text;
using POO_FormasGeometricas.Entities.Enums;

namespace POO_FormasGeometricas.Entities
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }


        public Retangulo(double largura, double altura, Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }

    }
}
