using System;
using System.Runtime.ExceptionServices;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            System.Console.Write("Digite o número do exercício ( De 01... ): ");
            string input = Console.ReadLine() ?? "";

            if (input == "0")
            {
                System.Console.WriteLine("Programa encerrado.");
                return; // Encerra o programa
            }

            string nomeDoMetodo = $"Ex_{input}";

            var metodo = typeof(Program).GetMethod(nomeDoMetodo, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public); //typeof(Program).GetMethod(...): procura um método chamado Ex_01, Ex_02, etc., dentro da própria classe Program

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
        public static void Ex_101() //LISTA 01 - 40
        {
            int n1, n2, r;
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine() ?? "");

            if (n1 > n2)
            {
                r = n1;
            }
            else
            {
                r = n2;
            }

            System.Console.WriteLine($"O maior número é: {r}");

            Menu(); // Volta ao menu
        }
        public static void Ex_102()
        {
            int numero;

            System.Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine() ?? "");

            if (numero > 0)
            {
                numero = (int)Math.Sqrt(2);
                System.Console.WriteLine($"O quadrado do número é: {numero}");
            }
            else
            {
                System.Console.WriteLine($"O número é negativo: {numero}");
            }
            Menu(); // Volta ao menu
        }
        public static void Ex_103()
        {
            int numero;

            System.Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine() ?? "");

            if (numero > 0)
            {
                numero = (int)Math.Sqrt(2);
                System.Console.WriteLine($"O raiz quadrada do número é: {numero}");
            }
            else
            {
                numero = (int)Math.Pow(numero, 2);
                System.Console.WriteLine($"O número ao quadrado é: {numero}");
            }
            Menu(); // Volta ao menu
        }

        public static void Ex_104()
        {
            int numero, raizQuadrada, quadrado;

            System.Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine() ?? "");

            if (numero != 0)
            {
                raizQuadrada = (int)Math.Sqrt(numero);
                quadrado = (int)Math.Pow(numero, 2);

                System.Console.WriteLine($"Raiz quadrada: {raizQuadrada}");
                System.Console.WriteLine($"Número ao quadrado: {quadrado}");
            }
            else
            {
                System.Console.WriteLine("O número é zero.");
            }
        }
        public static void Ex_105()
        {
            int numero;

            System.Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine() ?? "");

            if (numero % 2 != 0)
            {
                System.Console.WriteLine("O número é Impar.");
            }
            else
            {
                System.Console.WriteLine("O número é Par.");
            }
            Menu(); // Volta ao menu

        }
        public static void Ex_106()
        {
            int n1, n2, resto;
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine() ?? "");

            int maior = Math.Max(n1, n2);
            int menor = Math.Min(n1, n2);

            resto = maior - menor;

            System.Console.WriteLine($"Maior numero: {maior}");
            System.Console.WriteLine($"Resto: {resto}");

            Menu(); // Volta ao menu
        }
        public static void Ex_107()
        {
            int n1, n2, resto;
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine() ?? "");

            int maior = Math.Max(n1, n2);
            int menor = Math.Min(n1, n2);


            resto = maior - menor;

            System.Console.WriteLine($"Maior numero: {maior}");
            System.Console.WriteLine($"Resto: {resto}");

            Menu(); // Volta ao menu
        }
        public static void Ex_226()
        {
            int numero1, numero2;

            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine() ?? "");

            int inicio = Math.Min(numero1, numero2);
            int fim = Math.Max(numero1, numero2);

            int somaPares = 0;
            int multiplicacaoImpares = 1;

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 2 == 0)
                {
                    somaPares += i;
                }
                else
                {
                    multiplicacaoImpares *= i;
                }
            }

            Console.WriteLine($"Soma dos números pares do intervalo [{inicio}, {fim}]: {somaPares}");
            Console.WriteLine($"Multiplicação dos números ímpares do intervalo [{inicio}, {fim}]: {multiplicacaoImpares}");
            Menu(); // Volta ao menu
        }


    }
}