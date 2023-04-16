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

            default:
                Console.WriteLine("Selecione uma opÇão");
                break;

        }
    }
}