namespace ExerciciosClassesObjetos
{
    class Produto
    {
        public string Nome { get; set; }
        public int Qtde { get; set; }
        public double Preco { get; set; }

        public double ValorTotalEstoque()
        {
            return Preco * Qtde;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Qtde += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Qtde -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString() + ", " + Qtde + "unidades, Total: $" + ValorTotalEstoque().ToString();

        }

    }   
}
