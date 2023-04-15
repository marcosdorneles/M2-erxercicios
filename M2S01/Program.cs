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
                Console.WriteLine("2");
                break;


            default:
                Console.WriteLine("Selecione uma opÇão");
                break;

        }
    }
}