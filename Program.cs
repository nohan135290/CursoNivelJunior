using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;


namespace NivelJunior
{
    class Program
    {
        static void Main( string [] args )
        {
            //Curso nélio Alves Parte Junior.

            // Camada básica
            Basicos();

            //Calculos matemáticos atraves de abas
            Triangulos();

            //Conta Bancaria
            ContaBancaria();
        }
        static void Basicos()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Computador";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produto: ");
            Console.WriteLine(produto1 + ", cujo o preço é $" + preco1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Split

            String s = Console.ReadLine();
            string [] vet = s.Split(' ');
            string p1 = vet [0];
            string p2 = vet [1];
            string p3 = vet [2];

            Console.WriteLine(p1 + " " +  p2 + " " + p3);

            //Exercicios dos codigos acima.
            Console.WriteLine();

            //Exercicios Fixação 1
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("entre com o preco de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura(mesma linha): ");
           
            string [] NomeIdadeAltura = Console.ReadLine().Split(' ');
            string primeiroNome = NomeIdadeAltura [0];
            int idadeAtual = ( int.Parse(NomeIdadeAltura[1]) );
            float alturaAtual = ( float.Parse(NomeIdadeAltura [2]) );
            Console.WriteLine();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(primeiroNome);
            Console.WriteLine(idadeAtual);
            Console.WriteLine(alturaAtual);

            //Relogia utilizando if/ else
            Console.WriteLine();

            Console.WriteLine("Digite o horario: ");
            int hora = int.Parse(Console.ReadLine());
            if(hora < 10 )
            {
                Console.WriteLine("Horário de Manhã!");
            }
            else if(hora > 10 && hora < 17)
            {
                Console.WriteLine("Horário tarde!");
            }
            else
            {
                Console.WriteLine("Horário anoite!");
            }
        }

        static void Triangulos()
        {
            
            //calculo por triangulo com a aba Triangulo.

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            //Tentando utilizar split no calculo
            
            Console.WriteLine("Entre com as medidas do Triangulo X: ");
            String [] n1 = Console.ReadLine().Split(' ');
            x.A = double.Parse(n1 [0], CultureInfo.InvariantCulture);
            x.B = double.Parse(n1 [1], CultureInfo.InvariantCulture);
            x.C = double.Parse(n1 [2], CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do Triangulo Y: ");
            string [] n2 = Console.ReadLine().Split(' ');
            y.A = double.Parse(n2 [0], CultureInfo.InvariantCulture);
            y.B = double.Parse(n2 [1], CultureInfo.InvariantCulture);
            y.C = double.Parse(n2 [2], CultureInfo.InvariantCulture);   

            double p = (x.A + x.B + x.C) / 2.0;
            double AreaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double AreaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if(AreaY > AreaX)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("Maior área: X");
            }         

            //Programa para descobrir quem é o mais velho

            Console.WriteLine("Dados da primeira pessoa: ");
            string [] nomeEidade = Console.ReadLine().Split(' ');
            string nome = nomeEidade [0];
            int idade = int.Parse( nomeEidade [1] );
            Console.WriteLine("Dados da segunda pessoa: ");
            string [] nomeEidade1 = Console.ReadLine().Split(' ');
            string nome1 = nomeEidade1 [0];
            int idade1 = int.Parse(nomeEidade1 [1]);

            if(idade > idade1)
            {
                Console.WriteLine("Pessoa mais velha: " + nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + nome1);
            }
        }

        static void ContaBancaria()
        {
            //Fazendo um programa básico para adicionar e remover produto de estoque.
            //Com a aba Produto
            /*
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Preço: ");
            double preco1 = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome1, preco1, quantidade);

            Console.WriteLine("Dados do produto:" + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionaro ao estoque: ");
            int adicionarProduto = int.Parse(Console.ReadLine());
            p.AdicionarProduto(adicionarProduto);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int removerProduto = int.Parse(Console.ReadLine());
            p.RemoverProduto(removerProduto);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            */

            //Exemplo de programas.
            //programa que utiliza conta bancaria

            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depos = char.Parse(Console.ReadLine());
            if(depos == 's' || depos == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
        }
    }
}
