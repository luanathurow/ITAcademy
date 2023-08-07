using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            b = Byte.MaxValue;
            Console.WriteLine("Valor máximo de byte: " + b);

            int i;
            i = int.MaxValue;
            Console.WriteLine("Valor máximo de int: " + i);

            long l;
            l = long.MaxValue;
            Console.WriteLine("Valor máximo de long: " + l);
        }
    }
}
