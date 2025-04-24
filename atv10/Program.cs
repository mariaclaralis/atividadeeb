using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a hora (0-23): ");
        int hora = int.Parse(Console.ReadLine());  // Lê a hora fornecida pelo usuário

        if (hora >= 6 && hora <= 22)
        {
            Console.WriteLine("Acesso permitido");
        }
        else
        {
            Console.WriteLine("Fora do horário");
        }
    }
}
