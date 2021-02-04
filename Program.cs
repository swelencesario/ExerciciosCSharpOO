using System;

namespace ExerciciosClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeiros exercícios - Quem tem a maior idade:
            
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa: \n");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: \n");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            pessoa2 = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa: \n");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: \n");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            string resultado = pessoa1.MaisIdade(pessoa1, pessoa2);
            Console.WriteLine(resultado);

            //Primeiros exercícios - Mostrar a média do salário de dois funcionários

            Funcionario p1, p2;

            p1 = new Funcionario();
            Console.WriteLine("Digite o o nome da pessoa: \n");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário: \n");
            p1.Salario = int.Parse(Console.ReadLine());

            p2 = new Funcionario();
            Console.WriteLine("Digite o nome da pessoa: \n");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário: \n");
            p2.Salario = int.Parse(Console.ReadLine());

            double resultadoSalario = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine("Salário médio dos funcionários é: " + resultadoSalario.ToString());

            //Primeiros exercícios - Adicionar e remover produtos do estoque

            Produto novoProduto = new Produto();
            Console.WriteLine("Digite o nome do produto: \n");
            novoProduto.Nome = Console.ReadLine();           

            Console.WriteLine("Digite a quantidade do produto: \n");
            novoProduto.Qtde = int.Parse(Console.ReadLine());           

            Console.WriteLine("Digite o preço do produto: \n");
            novoProduto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + novoProduto);

            Console.WriteLine("Digite a quantidade a ser adicionada ao total dos produtos: \n");
            int qtde = int.Parse(Console.ReadLine());
            novoProduto.AdicionarProdutos(qtde);
            Console.WriteLine("Dados atualizados: " + novoProduto);

            Console.WriteLine("Digite a quantidade de produtos a ser removida do estoque: \n");
            qtde = int.Parse(Console.ReadLine());
            novoProduto.RemoverProdutos(qtde);

            Console.WriteLine("Dados atualizados: " + novoProduto);

            //Primeiros exercícios - Calcular área e perímetro do retângulo

            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Digite a altura do retângulo: \n");
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura do retângulo: \n");
            retangulo.Largura = double.Parse(Console.ReadLine());

            retangulo.Area();
            retangulo.Perimetro();

            Console.WriteLine("Area do retângulo é: " + retangulo.Area());
            Console.WriteLine("O perímetro do retângulo é: " + retangulo.Perimetro());

            //Primeiros exercícios - Calcular a nota final do aluno

            Aluno nota = new Aluno();
            Console.WriteLine("Digite a nota do primeiro trimestre: \n");
            nota.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo trimestre: \n");
            nota.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro trimestre: \n");
            nota.Nota3 = double.Parse(Console.ReadLine());
            nota.Resultado();
            Console.WriteLine(nota.Resultado());

            //Treinando membros estáticos - Conversor de moeda

            Console.WriteLine("Digite a cotação do dólar: \n");
            double cot = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar? \n");
            double qtdeDolar = double.Parse(Console.ReadLine());
            double resultadoConversao = ConversorDeMoeda.Calculos(cot, qtde);
            Console.WriteLine("Valor a ser pago em reais: " + resultado);




        }
    }
}
