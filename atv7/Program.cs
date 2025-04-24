using System;

class Program
{
    static void Main()
    {
        bool cadastrado = true;
        bool cupomValido = false;
        bool jaUsouCupom = false;

        if (cadastrado && cupomValido && !jaUsouCupom)
        {
            Console.WriteLine("Promoção válida");
        }
        else
        {
            Console.WriteLine("Promoção inválida");
        }
    }
}
