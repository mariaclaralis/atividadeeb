using System;

class Program
{
    static void Main()
    {
        int hora = 22;

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
