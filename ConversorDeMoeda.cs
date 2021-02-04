namespace ExerciciosClassesObjetos
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double Calculos(double cot, double qtde)
        {
            double total = cot * qtde;
            return total + total * Iof;
        }

    }
}
