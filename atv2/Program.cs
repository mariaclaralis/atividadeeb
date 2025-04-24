using System;

class Program
{
    static void Main()
    {
        int idade = 20;
        bool temCarteira = true;

        if (idade >= 18 && temCarteira)
        {
            Console.WriteLine("Pode dirigir");
        }
        else
        {
            Console.WriteLine("Não pode dirigir");
        }
    }
}