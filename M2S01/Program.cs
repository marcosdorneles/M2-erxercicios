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
                if(num % 2 ==0 ){
                    Console.WriteLine("O número é par!");
                } else{
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
            default:
                Console.WriteLine("Selecione uma opÇão");
                break;

        }
    }
}