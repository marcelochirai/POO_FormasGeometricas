using System;
using System.Collections.Generic;
using System.Text;
using POO_FormasGeometricas.Entities.Enums;

namespace POO_FormasGeometricas.Entities
{
    abstract class Forma
    {
        public Color Color { get; set; }
        public Forma{Color color }
        {
            Color=color;
        }
    public abstract double Area();
    }
}
