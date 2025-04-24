using System;

class Program
{
    static void Main()
    {
        int idade = 66;
        double renda = 1900.0;

        if (idade > 65 || renda < 2000)
        {
            Console.WriteLine("Está isento de imposto");
        }
        else
        {
            Console.WriteLine("Deve pagar imposto");
        }
    }
}
