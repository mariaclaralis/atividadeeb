using System;

class Program
{
    static void Main()
    {
        bool ehClienteVip = false;
        int compras = 12;

        if (!ehClienteVip && compras > 10)
        {
            Console.WriteLine("Ganha desconto especial");
        }
        else
        {
            Console.WriteLine("Não ganha desconto especial");
        }
    }
}
