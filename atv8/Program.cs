using System;

class Program
{
    static void Main()
    {
        double nota = 6.5;
        int frequencia = 80;

        if (nota >= 6 && frequencia >= 75)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
