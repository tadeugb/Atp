using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

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
        { // preciso repassar aqui novamente.
            double x0, x1, y0, y1, x, y;

            Console.Write("Digite o limite inferior do intervalo X (x0): ");
            x0 = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Digite o limite superior do intervalo X (x1): ");
            x1 = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Digite o limite inferior do intervalo Y (y0): ");
            y0 = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Digite o limite superior do intervalo Y (y1): ");
            y1 = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Digite o valor de x para interpolar: ");
            x = double.Parse(Console.ReadLine() ?? "");

            // Validação: x deve estar dentro do intervalo [x0, x1]
            if (x < x0 || x > x1)
            {
                Console.WriteLine("Erro: x deve ser interno ao intervalo [x0, x1].");
            }
            else
            {
                // Fórmula: y = y0 + (y1 - y0) * ((x - x0) / (x1 - x0))
                y = y0 + (y1 - y0) * ((x - x0) / (x1 - x0));

                Console.WriteLine($"O valor interpolado y = {y:F4}");
            }

            Menu();
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

        public static void Ex_15()
        {
            int trianguloA, trianguloB, trianguloC;

            Console.Write("Digite o lado A: ");
            trianguloA = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Digite o lado B: ");
            trianguloB = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Digite o lado C: ");
            trianguloC = int.Parse(Console.ReadLine() ?? "");


            if (trianguloA < trianguloB + trianguloC && trianguloB < trianguloA + trianguloC && trianguloC < trianguloA + trianguloB)
            {
                Console.WriteLine("Triângulo válido!");
            }
            else
            {
                Console.WriteLine("Triângulo inválido.");
            }
            Menu();
        }

        public static void Ex_16()
        {
            int unidades = 20, unidadeDigitada;
            double coxinha = 2.0, coxinhaCaipara = 1.50;

            System.Console.Write("Digite a quantidade de coxinha: ");
            unidadeDigitada = int.Parse(Console.ReadLine() ?? "");

            if (unidadeDigitada >= unidades)
            {
                System.Console.WriteLine($"O seu valor da cozinha e R$ {unidades * coxinhaCaipara:F2}");
            }
            else
            {
                System.Console.WriteLine($"O seu valor da cozinha e R$ {unidades * coxinha:F2}");
            }
            Menu();

        }

        // SEGUNDA LISTA DE ATP

        public static void Ex_17()
        { // 01
            int numero;

            System.Console.Write("Digite un numero 0 a 5: ");
            numero = int.Parse(Console.ReadLine() ?? "");

            if (numero == 1)
            {
                System.Console.WriteLine("Seu numero e Um");
            }
            else if (numero == 2)
            {
                System.Console.WriteLine("Seu numero e dois");
            }
            else if (numero == 3)
            {
                System.Console.WriteLine("Seu numero e treis");
            }
            else if (numero == 4)
            {
                System.Console.WriteLine("Seu numero e quatro");
            }
            else if (numero == 5)
            {
                System.Console.Write("Seu numero e Cinco");
            }
            else
            {
                System.Console.Write("Invalido");
            }
            Menu();
        }

        public static void Ex_18()
        { // 002
            int idade1, idade2, idade3;

            System.Console.Write("Digite sua idade: ");
            idade1 = int.Parse(Console.ReadLine() ?? "");
            System.Console.Write("Digite sua idade: ");
            idade2 = int.Parse(Console.ReadLine() ?? "");
            System.Console.Write("Digite sua idade: ");
            idade3 = int.Parse(Console.ReadLine() ?? "");

            if (idade1 > idade2 && idade1 > idade3)
            {
                System.Console.WriteLine($"Maior idade e {idade1}");
            }
            else if (idade2 > idade1 && idade2 > idade3)
            {
                System.Console.WriteLine($"Maior idade e {idade2}");
            }
            else if (idade3 > idade1 && idade3 > idade2)
            {
                System.Console.WriteLine($"Maior idade e {idade2}");
            }

            if (idade1 < idade2 && idade1 < idade3)
            {
                System.Console.WriteLine($"Menor idade e {idade1}");
            }
            else if (idade2 < idade1 && idade2 < idade3)
            {
                System.Console.WriteLine($"Menor idade e {idade2}");
            }
            else if (idade3 < idade1 && idade3 < idade2)
            {
                System.Console.WriteLine($"Menor idade e {idade2}");
            }
            Menu();
        }
        public static void Ex_19()
        {// 03
            // int idade, categoriaB, categoriaC, categoriaD;

            // System.Console.Write("Digite a sua idade: ");
            // idade = int.Parse(Console.ReadLine() ?? "");


            // if (idade < 18)
            // {
            //     System.Console.WriteLine("Nao e apto para carteira nao tem idade");
            // }
            // else if (idade <= 18)
            // {
            //     System.Console.Write("Qual e sua carteira: ");
            // }


        }

        public static void Ex_20()
        { // 04
            int valor;

            System.Console.Write("Digite um numero para saber ser e divisivel: ");
            valor = int.Parse(Console.ReadLine() ?? "");

            if (valor % 3 == 0 && valor % 5 == 0)
            {
                System.Console.WriteLine("Seu numero e divisivel");
            }
            else
            {
                System.Console.WriteLine("Seu numero e nao e divisivel");
            }
            Menu();
        }
        public static void Ex_21()
        { // 05
            int w, x, y, z;
            System.Console.WriteLine("Seu numero da equacao que gotaria de fazer");
            System.Console.WriteLine("1 - Geometria");
            System.Console.WriteLine("2 - Ponderada");
            System.Console.WriteLine("3 - Hormonica");
            System.Console.WriteLine("4 - Aritimetrica");
            System.Console.Write("Digite O unumero: ");
            w = int.Parse(Console.ReadLine() ?? "");

            if (w == 1)
            {
                System.Console.Write($"Digite seu numero x: ");
                x = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero y: ");
                y = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero z: ");
                z = int.Parse(Console.ReadLine() ?? "");

                double resultando = Math.Pow(x * y * z, 1.0 / 3);

                System.Console.Write($"Digite seu numero: {resultando}");
            }
            else if (w == 2)
            {
                System.Console.Write($"Digite seu numero x: ");
                x = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero y: ");
                y = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero z: ");
                z = int.Parse(Console.ReadLine() ?? "");

                double resultando = 3.0 / ((1.0 / x) + (1.0 / y) + (1.0 / z));
                System.Console.Write($"Digite seu numero: {resultando}");
            }
            else if (w == 3)
            {
                System.Console.Write($"Digite seu numero x: ");
                x = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero y: ");
                y = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero z: ");
                z = int.Parse(Console.ReadLine() ?? "");

                double resultando = 1 / ((1.0 / x) + (1.0 / y) + (1.0 / z));
                System.Console.Write($"Digite seu numero: {resultando:F2}");
            }
            else if (w == 4)
            {
                System.Console.Write($"Digite seu numero x: ");
                x = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero y: ");
                y = int.Parse(Console.ReadLine() ?? "");
                System.Console.Write($"Digite seu numero z: ");
                z = int.Parse(Console.ReadLine() ?? "");

                double resultando = (x + y + z) / 3.0;
                System.Console.Write($"Digite seu numero: {resultando}");
            }
            Menu();
        }

        public static void Ex_22()
        { // 06
            int idade;

            System.Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine() ?? "");

            if (idade >= 5 && idade < 7 || idade >= 11 && idade <= 13)
            {
                System.Console.WriteLine("Infatil A");
            }
            else if (idade >= 8 && idade < 10 || idade >= 14 && idade <= 17)
            {
                System.Console.WriteLine("Infatil B");
            }
            else
            {
                System.Console.WriteLine("Maior de 18");
            }
            Menu();
        }

        public static void Ex_23()
        { // 07
            // double distancia, peso;
            // int urgente;

            // System.Console.Write("Digite a distância (km): ");
            // distancia = double.Parse(Console.ReadLine());

            // System.Console.Write("Digite o peso (kg): ");
            // peso = double.Parse(Console.ReadLine());

            // System.Console.Write("Entrega urgente? (1 = sim / 2 = nao): ");
            // urgente = int.Parse(Console.ReadLine());

            // double PKM = 1;

            // // MOTO
            // if (distancia <= 5 && peso <= 20)
            // {
            //     double precoMoto = PKM * distancia;

            //     // seguro +20%
            //     precoMoto = precoMoto * 1.2;

            //     if (urgente == 1)
            //         precoMoto = precoMoto * 1.3;

            //     System.Console.WriteLine("Moto: R$ " + precoMoto.ToString("F2"));
            // }
            // else
            // {
            //     System.Console.WriteLine("Moto: invalido");
            // }

            // // VAN
            // if (peso <= 1000)
            // {
            //     double precoVan = PKM * distancia;

            //     if (urgente == 1)
            //         precoVan = precoVan * 1.7;

            //     System.Console.WriteLine("Van: R$ " + precoVan.ToString("F2"));
            // }
            // else
            // {
            //     System.Console.WriteLine("Van: invalido");
            // }

            // // CAMINHÃO
            // if (true)
            // {
            //     double precoCaminhao = PKM * distancia;

            //     if (urgente == 1)
            //         precoCaminhao = precoCaminhao * 2.0;

            //     System.Console.WriteLine("Caminhao: R$ " + precoCaminhao.ToString("F2"));
            // }
            // else
            // {
            //     System.Console.WriteLine("Caminhao: invalido");
            // }
        }

        public static void Ex_24()
        { // 08
            // Console.Write("Volume consumido (litros): ");
            // double litros = double.Parse(Console.ReadLine());

            // double vol = litros / 1000.0; // converte para k litros (×1000)

            // double tarifaAgua = 0;
            // double tarifaEsgoto = 0;

            // double consumido;

            // // ── Faixa 0 – 75 k litros ────────────────────────────
            // if (vol > 0)
            // {
            //     if (vol < 75)
            //     {
            //         consumido = vol;
            //     }
            //     else
            //     {
            //         consumido = 75;
            //     }

            //     tarifaAgua += consumido * 2.110;
            //     tarifaEsgoto += consumido * 1.560;
            // }

            // // ── Faixa 75 – 150 k litros ──────────────────────────
            // if (vol > 75)
            // {
            //     if (vol < 150)
            //     {
            //         consumido = vol - 75;
            //     }
            //     else
            //     {
            //         consumido = 75;
            //     }

            //     tarifaAgua += consumido * 4.496;
            //     tarifaEsgoto += consumido * 3.327;
            // }

            // // ── Faixa 150 – 225 k litros ─────────────────────────
            // if (vol > 150)
            // {
            //     if (vol < 225)
            //     {
            //         consumido = vol - 150;
            //     }
            //     else
            //     {
            //         consumido = 75;
            //     }

            //     tarifaAgua += consumido * 6.968;
            //     tarifaEsgoto += consumido * 5.156;
            // }

            // // ── Faixa 225 – ∞ k litros ───────────────────────────
            // if (vol > 225)
            // {
            //     consumido = vol - 225;

            //     tarifaAgua += consumido * 9.512;
            //     tarifaEsgoto += consumido * 7.039;
            // }

            // double totalAgua = 305.55 + tarifaAgua;
            // double totalEsgoto = 226.05 + tarifaEsgoto;
            // double fatura = totalAgua + totalEsgoto;

            // Console.WriteLine($"Fatura total: R$ {fatura:F2}");
            // Menu();
        }
        public static void Ex_25()
        {
            // string empresa, funcionario, cargo;
            // double salarioBruto, descontoINSS = 0;

            // Console.Write("Nome da empresa: ");
            // empresa = Console.ReadLine();

            // Console.Write("Nome do funcionario: ");
            // funcionario = Console.ReadLine();

            // Console.Write("Cargo: ");
            // cargo = Console.ReadLine();

            // Console.Write("Salario bruto: ");
            // salarioBruto = double.Parse(Console.ReadLine());

            // // Cálculo do INSS (tabela progressiva aproximada)
            // if (salarioBruto <= 1412.00)
            // {
            //     descontoINSS = salarioBruto * 0.075;
            // }
            // else if (salarioBruto <= 2666.68)
            // {
            //     descontoINSS = (1412.00 * 0.075) +
            //                    ((salarioBruto - 1412.00) * 0.09);
            // }
            // else if (salarioBruto <= 4000.03)
            // {
            //     descontoINSS = (1412.00 * 0.075) +
            //                    ((2666.68 - 1412.00) * 0.09) +
            //                    ((salarioBruto - 2666.68) * 0.12);
            // }
            // else if (salarioBruto <= 7786.02)
            // {
            //     descontoINSS = (1412.00 * 0.075) +
            //                    ((2666.68 - 1412.00) * 0.09) +
            //                    ((4000.03 - 2666.68) * 0.12) +
            //                    ((salarioBruto - 4000.03) * 0.14);
            // }
            // else
            // {
            //     // teto do INSS
            //     descontoINSS = (1412.00 * 0.075) +
            //                    ((2666.68 - 1412.00) * 0.09) +
            //                    ((4000.03 - 2666.68) * 0.12) +
            //                    ((7786.02 - 4000.03) * 0.14);
            // }

            // double salarioLiquido = salarioBruto - descontoINSS;

            // Console.WriteLine("\n--- Folha de Pagamento ---");
            // Console.WriteLine("Empresa: " + empresa);
            // Console.WriteLine("Funcionario: " + funcionario);
            // Console.WriteLine("Cargo: " + cargo);
            // Console.WriteLine("Salario Bruto: R$ " + salarioBruto.ToString("F2"));
            // Console.WriteLine("Desconto INSS: R$ " + descontoINSS.ToString("F2"));
            // Console.WriteLine("Salario Liquido: R$ " + salarioLiquido.ToString("F2"));
        }

        public static void Ex_26()
        {//10
            // int dia;

            // Console.Write("Digite um numero de 1 a 7: ");
            // dia = int.Parse(Console.ReadLine());

            // switch (dia)
            // {
            //     case 1:
            //         Console.WriteLine("Domingo");
            //         break;
            //     case 2:
            //         Console.WriteLine("Segunda-feira");
            //         break;
            //     case 3:
            //         Console.WriteLine("Terca-feira");
            //         break;
            //     case 4:
            //         Console.WriteLine("Quarta-feira");
            //         break;
            //     case 5:
            //         Console.WriteLine("Quinta-feira");
            //         break;
            //     case 6:
            //         Console.WriteLine("Sexta-feira");
            //         break;
            //     case 7:
            //         Console.WriteLine("Sabado");
            //         break;
            //     default:
            //         Console.WriteLine("Dia invalido");
            //         break;
            // }
        }

        public static void Ex_27()
        {// 11
            // int numero;

            // Console.Write("Digite um numero de 0 a 4: ");
            // numero = int.Parse(Console.ReadLine());

            // switch (numero)
            // {
            //     case 0:
            //         Console.WriteLine("Zero");
            //         break;
            //     case 1:
            //         Console.WriteLine("Um");
            //         break;
            //     case 2:
            //         Console.WriteLine("Dois");
            //         break;
            //     case 3:
            //         Console.WriteLine("Tres");
            //         break;
            //     case 4:
            //         Console.WriteLine("Quatro");
            //         break;
            //     default:
            //         Console.WriteLine("Valor invalido");
            //         break;
            // }
        }
        public static void Ex_28()
        {
            // int opcao;
            // double valor, resultado;

            // Console.WriteLine("Menu de Conversoes:");
            // Console.WriteLine("1 - Centimetros para Metros");
            // Console.WriteLine("2 - Metros para Centimetros");
            // Console.WriteLine("3 - Milimetros para Metros");
            // Console.WriteLine("4 - Metros para Milimetros");

            // Console.Write("Escolha uma opcao: ");
            // opcao = int.Parse(Console.ReadLine());

            // switch (opcao)
            // {
            //     case 1:
            //         Console.Write("Digite o valor em centimetros: ");
            //         valor = double.Parse(Console.ReadLine());
            //         resultado = valor / 100;
            //         Console.WriteLine("Resultado: " + resultado + " metros");
            //         break;

            //     case 2:
            //         Console.Write("Digite o valor em metros: ");
            //         valor = double.Parse(Console.ReadLine());
            //         resultado = valor * 100;
            //         Console.WriteLine("Resultado: " + resultado + " centimetros");
            //         break;

            //     case 3:
            //         Console.Write("Digite o valor em milimetros: ");
            //         valor = double.Parse(Console.ReadLine());
            //         resultado = valor / 1000;
            //         Console.WriteLine("Resultado: " + resultado + " metros");
            //         break;

            //     case 4:
            //         Console.Write("Digite o valor em metros: ");
            //         valor = double.Parse(Console.ReadLine());
            //         resultado = valor * 1000;
            //         Console.WriteLine("Resultado: " + resultado + " milimetros");
            //         break;

            //     default:
            //         Console.WriteLine("Opcao Invalida");
            //         break;
            // }

        }


        public static void Ex_29()
        {
            // Char letras;
            // Console.Write("Digite uma letra minusculo: ");
            // letras = Char.Parse(Console.ReadLine());

            // switch (letras)
            // {
            //     case 'a':
            //         Console.WriteLine("Vogal");
            //         break;
            //     case 'e':
            //         Console.WriteLine("Vogal");
            //         break;
            //     case 'i':
            //         Console.WriteLine("Vogal");
            //         break;
            //     case 'o':
            //         Console.WriteLine("Vogal");
            //         break;
            //     case 'u':
            //         Console.WriteLine("Vogal");
            //         break;
            //     default:
            //         Console.WriteLine("Consoante");
            //         break;
        }


        public static void Ex_30()
        {
            // double altura, pesoIdeal;
            // int sexo;

            // Console.Write("Digite a altura: ");
            // altura = double.Parse(Console.ReadLine());

            // Console.Write("Digite o sexo (1 = M / 2 = F): ");
            // sexo = int.Parse(Console.ReadLine());

            // pesoIdeal = (sexo == 1)
            //     ? (72.7 * altura) - 58  // Homem
            //     : (62.1 * altura) - 44.7; // Mulher

            // Console.WriteLine("Peso ideal: " + pesoIdeal.ToString("F2") + " kg");
        }

        public static void Ex_31()
        {
            // int ano;

            // Console.Write("Digite um ano: ");
            // ano = int.Parse(Console.ReadLine());

            // // Verifica se é bissexto
            // bool bissexto = (ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0);

            // Console.WriteLine(bissexto
            //     ? $"{ano} é bissexto."
            //     : $"{ano} não é bissexto.");
        }

        public static void Ex_32() // LISTA 3
        { // 01
            int numero = 10;
            while (numero >= 0)
            {
                System.Console.Write($"{numero}, ");
                numero--;
            }
            System.Console.Write("Feliz Ano Novo!");
        }

        public static void Ex_33()
        {//02
            int imparX, imparY;

            System.Console.Write("Digite um numero X: ");
            imparX = int.Parse(Console.ReadLine() ?? "");

            System.Console.Write("Digite um numero Y: ");
            imparY = int.Parse(Console.ReadLine() ?? "");

            if (imparX % 2 != 0 && imparY % 2 != 0)
            {
                while (imparX <= imparY)
                {
                    if (imparX % 2 != 0)
                    {
                        System.Console.WriteLine($"{imparX}");
                    }
                    imparX++;
                }
            }
            else
            {
                Console.WriteLine("Valores invalido");
            }
        }
        public static void Ex_34()
        {//03
            int valores = 0, text = 0;

            while (text < 5)
            {
                System.Console.Write($"{text}Digite um numero: ");
                valores = int.Parse(Console.ReadLine() ?? "");

                text++;
            }
            System.Console.WriteLine(valores);
        }
        public static void Ex_35()
        {//04
            // int n, idade, contatod = 0, faixa1, faixa2, faixa3, faixa4, faixa5, porcentagem1, porcentagem2, porcentagem3, porcentagem4, porcentagem5;

            // System.Console.Write("Digite um numero: ");
            // n = int.Parse(Console.ReadLine() ?? "");

            // while (contatod <= n)
            // {
            //     System.Console.Write("Digite a sua idade: ");
            //     idade = int.Parse(Console.ReadLine() ?? "");

            //     if (idade >= 1 && idade <= 15)
            //     {
            //         faixa1 = +1;
            //         porcentagem1 = +1;
            //         Console.Write($"{faixa1}");
            //         contatod++;
            //     }
            // }
        }
        public static void Ex_36()
        {
            //05
        }
        public static void Ex_37()
        {
            //06
        }
        public static void Ex_38()
        {
            //07
        }
        public static void Ex_39()
        {
            //08
        }
        public static void Ex_40()
        {
            //09
        }
        public static void Ex_41()
        {
            //10
        }
        public static void Ex_42()// LISTA 04
        {//01

            double valeAlimentacao, valeTransporte, quantosMetrosQuadrados, totalAPagar;

            for (int i = 0; i <= 25; i++)
            {
                System.Console.Write("Digite o valor do vale alimentação: ");
                valeAlimentacao = double.Parse(Console.ReadLine() ?? "");
                System.Console.Write("Digite o valor do vale transporte: ");
                valeTransporte = double.Parse(Console.ReadLine() ?? "");
                System.Console.Write("Digite quantos metros quadrados tem a sua casa: ");
                quantosMetrosQuadrados = double.Parse(Console.ReadLine() ?? "");

                if (quantosMetrosQuadrados < 10)
                {
                    totalAPagar = (quantosMetrosQuadrados * 10.00) + valeAlimentacao + (valeTransporte * 2);
                }
                else if (quantosMetrosQuadrados < 20)
                {
                    totalAPagar = (quantosMetrosQuadrados * 11.50) + valeAlimentacao + (valeTransporte * 2);
                }
                else
                {
                    totalAPagar = (quantosMetrosQuadrados * 13.00) + valeAlimentacao + (valeTransporte * 2);
                }

                System.Console.WriteLine($"O valor total a pagar é: R$ {totalAPagar:F2}");
            }
        }
        public static void Ex_43()
        {//02

        }
        public static void Ex_44()
        {//03
            double precoKWh, quantidadeKWh, valorPagar;
            double maiorConsumo = double.MinValue, menorConsumo = double.MaxValue;

            for (int i = 0; i < 4; i++)
            {
                System.Console.Write("Digite o preço do kWh: ");
                precoKWh = double.Parse(Console.ReadLine() ?? "");
                System.Console.Write("Digite a quantidade de kWh consumida: ");
                quantidadeKWh = double.Parse(Console.ReadLine() ?? "");

                valorPagar = precoKWh * quantidadeKWh;

                if (valorPagar > maiorConsumo)
                {
                    maiorConsumo = valorPagar;
                }

                else if (valorPagar < menorConsumo)
                {
                    menorConsumo = valorPagar;
                }

                System.Console.WriteLine($"O valor a pagar é: R$ {valorPagar:F2}\n");
            }
            System.Console.WriteLine($"Maior consumo: R$ {maiorConsumo:F2}");
            System.Console.WriteLine($"Menor consumo: R$ {menorConsumo:F2}");
        }
        public static void Ex_50()
        {//09
            int candidato, candidato1 = 0, candidato2 = 0, candidato3 = 0, branco = 0, nulo = 0, totalVotos = 0;
            char votoSIM = 'S', voto;
            do
            {
                System.Console.Write("Digite o seu candidato 1, 2, 3, 4 branco: ");
                candidato = int.Parse(Console.ReadLine() ?? "");
                if (candidato == 1)
                {
                    candidato1++;
                    totalVotos++;
                }
                else if (candidato == 2)
                {
                    candidato2++;
                    totalVotos++;
                }
                else if (candidato == 3)
                {
                    candidato3++;
                    totalVotos++;
                }
                else if (candidato == 4)
                {
                    branco++;
                    totalVotos++;
                }
                else
                {
                    nulo++;
                    totalVotos++;

                }

                System.Console.Write("Digite seu voto (S para SIM, N para NAO): ");
                voto = char.Parse(Console.ReadLine() ?? "");

            } while (voto == votoSIM);
            System.Console.WriteLine();
            System.Console.WriteLine($"Total de votos para o candidato 1: {candidato1}");
            System.Console.WriteLine($"Total de votos para o candidato 2: {candidato2}");
            System.Console.WriteLine($"Total de votos para o candidato 3: {candidato3}");
            System.Console.WriteLine($"Total de votos em branco: {branco}");
            System.Console.WriteLine($"Total de votos nulos: {nulo}");
            System.Console.WriteLine($"Total de votos: {totalVotos}");
        }
    }

}
