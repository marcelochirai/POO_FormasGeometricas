using System;
using System.Collections.Generic;
using System.Text;
using POO_FormasGeometricas.Entities.Enums;

namespace POO_FormasGeometricas.Entities
{
    //Super classe abstrata
    abstract class Forma
    {
        public Cor Cor { get; set; }
        public Forma(Cor cor )
        {
            Cor = cor;
        }
        public abstract double Area();
    }
}
