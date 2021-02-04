

namespace ExerciciosClassesObjetos
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
            Saldo = 0;
        }
        public ContaBancaria(string nome, int conta, double saldo) : this(nome, conta)
        {
            Saldo = saldo;
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public double Saque(double quantia)
        {
            return Saldo -= quantia + 5.00;
        }
        public override string ToString()
        {
            return "Conta: " + Nome + ", " + Conta + ", " + Saldo.ToString();
        }
    }
}
