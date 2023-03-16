using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um número ímpar: ");
        int num = int.Parse(Console.ReadLine());
        int espacos = (num - 1) / 2;
        int x = 1;

        if(num % 2 == 0)
        {
            Console.WriteLine("[ERROR] Você informou um número par");
        }
        else { 

        for (int l = 1; espacos > 0; l++)
        {
            for(int i = 1; i <= espacos; i++)
            {
                Console.Write(" ");
            }
            for(int j = 1; j <= x; j++)
            {
                Console.Write("x");
            }
            x += 2;
            espacos--;
            Console.WriteLine();
        }
        for (int l = 1; x > 0; l++)
        {
            for (int i = 1; i <= espacos; i++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= x; j++)
            {
                Console.Write("x");
            }
            x -= 2;
            espacos++;
            Console.WriteLine();
        }
        }
    }
}