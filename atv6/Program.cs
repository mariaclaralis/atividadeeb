using System;

class Program
{
    static void Main()
    {
        bool temIngresso = true;
        bool documentoValido = false;

        if (temIngresso && documentoValido)
        {
            Console.WriteLine("Entrada permitida");
        }
        else
        {
            Console.WriteLine("Entrada negada");
        }
    }
}
