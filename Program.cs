using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Atp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            System.Console.Write("Digite o número do exercício da atividade da Beecrowd (de 1000 a 3486 ou 0 para sair): ");
            string input = Console.ReadLine() ?? "";

            if (input == "0")
            {
                System.Console.WriteLine("Programa encerrado.");
                return; // Encerra o programa
            }

            string nomeDoMetodo = $"Ex_{input}";

            var metodo = typeof(Program).GetMethod(nomeDoMetodo, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public); //typeof(Program).GetMethod(...): procura um método chamado Ex_1001, Ex_1002, etc., dentro da própria classe Program

            if (metodo != null)
            {
                metodo.Invoke(null, null); // Executa o método estático // Invoke(null, null): executa esse método
            }
            else
            {
                Console.WriteLine("Exercício não encontrado.");
                Menu(); // Volta ao menu
            }

        }

        public static void Ex_01()
        {
            double m, km;

            System.Console.Write("Digite um numero: ");
            km = double.Parse(Console.ReadLine() ?? "" ?? "");

            m = km / 3.6;

            System.Console.WriteLine($"Sua velocidade e {m}");

            Menu();
        }

        public static void Ex_02()
        {
            double lado, area, diagonal, perimetro;

            System.Console.Write("Digite o valor do seu lado: ");
            lado = double.Parse(Console.ReadLine() ?? "");

            perimetro = 4 * lado;
            area = Math.Pow(lado, 2);
            diagonal = lado * Math.Sqrt(2);

            System.Console.WriteLine($"Seu Perímetro: {perimetro}");
            System.Console.WriteLine($"Seu Area: {area}");
            System.Console.WriteLine($"Seu Diogonal: {diagonal:F2}");

            Menu();
        }

        public static void Ex_03()
        {
            double leiaBase, leiaAltura, perimetro, area, diagonal;

            System.Console.Write("Digite a sua base: ");
            leiaBase = double.Parse(Console.ReadLine() ?? "");
            System.Console.Write("Digite a sua altura: ");
            leiaAltura = double.Parse(Console.ReadLine() ?? "");

            perimetro = 2 * (leiaBase + leiaAltura);
            area = leiaBase * leiaAltura;
            diagonal = Math.Sqrt(Math.Pow(leiaBase, 2) + Math.Pow(leiaAltura, 2));

            System.Console.WriteLine($"Seu Perímetro: {perimetro:F2}");
            System.Console.WriteLine($"Sua Área: {area:F2}");
            System.Console.WriteLine($"Sua Diagonal: {diagonal:F2}");

            Menu();
        }
        public static void Ex_04()
        {
            double fahrenheit, celsius;

            System.Console.Write("Digite a sua temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine() ?? "");

            celsius = (5 * (fahrenheit - 32)) / 9;

            System.Console.WriteLine($"Sua termpera em Celcius e {celsius}");

            Menu();
        }

        public static void Ex_05()
        {
            int quantidaede, nulos, brancos, validos;

            System.Console.Write("Digite a quantidade de eleitores: ");
            quantidaede = int.Parse(Console.ReadLine() ?? "");

            System.Console.Write("Digite a quantidade de votos nulos: ");
            nulos = int.Parse(Console.ReadLine() ?? "");

            System.Console.Write("Digite a quantidade de votos brancos: ");
            brancos = int.Parse(Console.ReadLine() ?? "");

            validos = quantidaede - (nulos + brancos);

            System.Console.WriteLine($"Quantidade de votos válidos: {validos}");
            System.Console.WriteLine($"Percentual de votos nulos: {(double)nulos / quantidaede * 100:F2}%");
            System.Console.WriteLine($"Percentual de votos brancos: {(double)brancos / quantidaede * 100:F2}%");
            System.Console.WriteLine($"Percentual de votos válidos: {(double)validos / quantidaede * 100:F2}%");

            Menu();

        }
        public static void Ex_06()
        {
            int numeroA, numeroB;

            System.Console.Write("Digite o numero A: ");
            numeroA = int.Parse(Console.ReadLine() ?? "");
            System.Console.Write("Digite o numero B: ");
            numeroB = int.Parse(Console.ReadLine() ?? "");

            numeroA = numeroA ^ numeroB;
            numeroB = numeroA ^ numeroB;
            numeroA = numeroA ^ numeroB;

            System.Console.WriteLine($"O numero A e {numeroA}");
            System.Console.WriteLine($"O numero B e {numeroB}");

            Menu();
        }
        public static void Ex_07()
        {
            double reais, dolar, cotacao;

            System.Console.Write("Digite o valor em reais: ");
            reais = double.Parse(Console.ReadLine() ?? "");

            System.Console.Write("Digite a cotação do dólar: ");
            cotacao = double.Parse(Console.ReadLine() ?? "");

            dolar = reais * cotacao;

            System.Console.WriteLine($"O valor em dólares é: {dolar:F2}");

            Menu();
        }
        public static void Ex_08()
        {
            double valorGato, percentagem, valorGorjeta;

            System.Console.Write("Digite o valor gasto com no restaurante: ");
            valorGato = double.Parse(Console.ReadLine() ?? "");

            System.Console.Write("Digite a porcentagem do valor gasto com o restaurante: ");
            percentagem = double.Parse(Console.ReadLine() ?? "");

            valorGorjeta = valorGato * (percentagem / 100);

            System.Console.WriteLine($"O valor da gorjeta é: {valorGorjeta:F2}");

            Menu();
        }
        public static void Ex_09()
        {
            double g, r, pi = 3.141592;

            System.Console.Write("Digite o valor angulo: ");
            g = double.Parse(Console.ReadLine() ?? "");
            r = g * (pi / 180);

            System.Console.WriteLine($"O valor do angulo em radianos é: {r:F2}");
            Menu();
        }

        public static void Ex_10()
        {
            int numero, centenas, dezenas, unidades, resto;

            System.Console.Write("Digite um numero inteiro com 3 digitos: ");
            numero = int.Parse(Console.ReadLine() ?? "");

            centenas = numero / 100;
            resto = numero % 100;
            dezenas = resto / 10;
            unidades = resto % 10;

            System.Console.WriteLine($"Centenas: {centenas}");
            System.Console.WriteLine($"Dezenas: {dezenas}");
            System.Console.WriteLine($"Unidades: {unidades}");
            Menu();
        }

        public static void Ex_11()
        {
            double gas, volune, mols, temperatura;

            System.Console.Write("Digite Volume: ");
            volune = double.Parse(Console.ReadLine() ?? "");

            System.Console.Write("Digite o numero de mols: ");
            mols = double.Parse(Console.ReadLine() ?? "");

            System.Console.Write("Digite a temperatura em Kelvin: ");
            temperatura = double.Parse(Console.ReadLine() ?? "");

            gas = (mols * 0.082) * temperatura / volune;

            System.Console.WriteLine($"A pressão do gás é: {gas:F2}");
            Menu();
        }

        public static void Ex_12()
        {
            double capitalInicial, taxaJuros, tempo, montante;

            System.Console.Write("Digite o capital inicial: ");
            capitalInicial = double.Parse(Console.ReadLine() ?? "");
            System.Console.Write("Digite a taxa de juros: ");
            taxaJuros = double.Parse(Console.ReadLine() ?? "");
            System.Console.Write("Digite o tempo em anos: ");
            tempo = double.Parse(Console.ReadLine() ?? "");

            montante = capitalInicial * Math.Pow(1 + taxaJuros / 100, tempo);

            System.Console.WriteLine($"O montante acumulado é: {montante:F2}");
            Menu();

        }

        public static void Ex_13()
        {
        }

        public static void Ex_14()
        {
            //estudar mais essa parte
            int divisivelPor3 = 3, divisivelPor5 = 5, numero;

            System.Console.Write("Digite um numero inteiro: ");
            numero = int.Parse(Console.ReadLine() ?? "");

            if (numero % divisivelPor3 == 0 && numero % divisivelPor5 == 0)
            {
                System.Console.WriteLine("Sim, o número é divisível por 3 e 5");
            }
            else
            {
                System.Console.WriteLine("Não, o número não é divisível por 3 e 5");
            }
            Menu();
        }
    }
}