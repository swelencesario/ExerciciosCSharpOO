

namespace ExerciciosClassesObjetos
{
    class Aluno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        
        public string Resultado()
        {
            double resultado = (Nota1 + Nota2 + Nota3) / 3;
            double diferenca = 6 - resultado;            
            if (resultado >= 6)
            {
                return "Nota final: "+resultado+ " - Aprovado";
            }
            else                
                return "Nota final: "+resultado+ " - Reprovado: "+ "Faltou: "+diferenca+" pontos\n";
        }
    }
}
