internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo!, Selecione um exercício que deseje executar (0-10)");
        int selecao;
        selecao = int.Parse(Console.ReadLine());

        switch (selecao)
        {
            case 1:
                int num1, num2;

                Console.WriteLine("Digite dois números para somá-los!");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                int soma = num1 + num2;
                Console.WriteLine($"O resultado da soma é {soma}");
                break;


            case 2:
                int num;
                Console.WriteLine("Digite um número e verifique se ele é par ou ímpar!");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("O número é par!");
                }
                else
                {
                    Console.WriteLine("O número é ímpar!");
                }
                break;

            case 3:
                string nome;
                int idade;
                Console.WriteLine("Olá!, Digite seu nome e a sua idade!");
                nome = Console.ReadLine();
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine($"nome do paciente: {nome}, idade: {idade}");
                break;

            case 4:
                string marca;
                string modelo;
                int km;
                Console.WriteLine("Olá!, digite a marca do carro");
                marca = Console.ReadLine();
                Console.WriteLine("Agora informe o modelo do veículo");
                modelo = Console.ReadLine();
                Console.WriteLine("Por último, informe a kilometragem do veículo");
                km = int.Parse(Console.ReadLine());
                if (km > 10000)
                {
                    Console.WriteLine($"O veículo de marca {marca}, modelo: {modelo} precisa realizar revisão");
                }
                else
                {
                    Console.WriteLine("O veículo ainda não precisa de revisão!");
                }
                break;

            case 5:
                int[] numeros = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Digite o " + (i + 1) + "º número: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(numeros);
                Console.WriteLine("Os números ordenados são:");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
                break;

            case 6:
                string frase = "A linguagem de programação C# é muito poderosa";
                List<string> palavras = new List<string>(frase.Split(' '));
                Console.WriteLine(palavras[7]);
                break;

            case 7:
                int numero;
                do
                {
                    Console.Write("Digite um número inteiro positivo: ");
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("Número inválido. Tente novamente.");
                    }
                } while (numero <= 0);

                for (int i = 0; i < numero; i += 2)
                {
                    Console.WriteLine(i);
                }
                break;

            case 8:

                int[] numerosInput = new int[5];

                Console.WriteLine("Digite cinco números inteiros:");

                for (int i = 0; i < numerosInput.Length; i++)
                {
                    Console.Write("Número {0}: ", i + 1);
                    numerosInput[i] = int.Parse(Console.ReadLine());
                }

                int maior = numerosInput[0];

                for (int i = 1; i < numerosInput.Length; i++)
                {
                    if (numerosInput[i] > maior)
                    {
                        maior = numerosInput[i];
                    }
                }

                Console.WriteLine($"O maior número digitado foi: {0}", maior);
                break;

            case 9:
                int quantidade = int.Parse(Console.ReadLine());

                double[] numIn = new double[quantidade];
                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Digite o {i + 1}º número: ");
                    numIn[i] = double.Parse(Console.ReadLine());
                }

                double sum = 0;
                foreach (double num5 in numIn)
                {
                    sum += num5;
                }

                double media = sum / quantidade;

                Console.WriteLine($"A média aritmética é: {media}");
                break;

            case 10:
                Console.WriteLine("Bem-vindo(a) à calculadora simples!");

                while (true)
                {
                    Console.WriteLine("\nEscolha uma operação:");
                    Console.WriteLine("1. Soma");
                    Console.WriteLine("2. Subtração");
                    Console.WriteLine("3. Multiplicação");
                    Console.WriteLine("4. Divisão");
                    Console.WriteLine("0. Sair");

                    Console.Write("\nDigite o número correspondente à operação desejada: ");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 0)
                    {
                        Console.WriteLine("\nObrigado por utilizar a calculadora simples!");
                        break;
                    }

                    Console.Write("Digite o primeiro número: ");
                    double calcNum1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double calcNum2 = double.Parse(Console.ReadLine());

                    double resultado;

                    switch (opcao)
                    {
                        case 1:
                            resultado = calcNum1 + calcNum2;
                            Console.WriteLine($"O resultado da soma entre {calcNum1} e {calcNum2} é: {resultado}");
                            break;
                        case 2:
                            resultado = calcNum1 - calcNum2;
                            Console.WriteLine($"O resultado da subtração entre {calcNum1} e {calcNum2} é: {resultado}");
                            break;
                        case 3:
                            resultado = calcNum1 * calcNum2;
                            Console.WriteLine($"O resultado da multiplicação entre {calcNum1} e {calcNum2} é: {resultado}");
                            break;
                        case 4:
                            if (calcNum2 == 0)
                            {
                                Console.WriteLine("Não é possível dividir por zero!");
                            }
                            else
                            {
                                resultado = calcNum1 / calcNum2;
                                Console.WriteLine($"O resultado da divisão entre {calcNum1} e {calcNum2} é: {resultado}");
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");

                            break;


                    }
                }

                break;
            default:
                Console.WriteLine("Selecione uma opÇão");
                break;

        }
        }
    }