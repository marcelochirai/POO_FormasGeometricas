using System;
using System.Collections.Generic;
using System.Text;
using POO_FormasGeometricas.Entities.Enums;

namespace POO_FormasGeometricas.Entities
{
    class Circulo : Forma
    {
        public double Raio { get; set; }
        
        public Circulo(double raio,Cor cor) : base(cor)
        {
            Raio = raio;
        }        
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
