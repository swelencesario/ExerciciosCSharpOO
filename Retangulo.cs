﻿
namespace ExerciciosClassesObjetos
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura* Altura;
        }
        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

    }
}
