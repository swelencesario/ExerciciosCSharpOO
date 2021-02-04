
namespace ExerciciosClassesObjetos
{
    class Pessoa
    {
        public int Idade;
        public string Nome;

        public string MaisIdade (Pessoa a, Pessoa b)
        {
            if (a.Idade > b.Idade)
            {
                return a.Nome + " tem a maior idade " + a.Idade;
            }
            else if (a.Idade < b.Idade)
            {
                return b.Nome + " tem a maior idade " + b.Idade;                
            }
            else 
            {
                return b.Nome + " e " + a.Nome + " têm a mesma idade.\n";
            }
        }   
    }
}
