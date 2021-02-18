using System;

namespace Examen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Billetes, B1000, B500, B200, B100;
            B1000 = 0;
            B500 = 0;
            B200 = 0;
            B100 = 0;
            Billetes = int.Parse(Console.ReadLine());
            if (Billetes >= 1000)
            {
                B1000 = (Billetes / 1000);
                Billetes = Billetes - (B1000 * 1000);
            }
            if (Billetes >= 500)
            {
                B500 = (Billetes / 500);
                Billetes = Billetes - (B500 * 500);
            }
            if (Billetes >= 200)
            {
                B200 = (Billetes / 200);
                Billetes = Billetes - (B200 * 200);
            }
            if (Billetes >= 100)
            {
                B100 = (Billetes / 100);
                Billetes = Billetes - (B100 * 100);
            }
            Console.WriteLine("Cantidad de Billetes de 1000: " + B1000);
            Console.WriteLine("Cantidad de Billetes de 500: " + B500);
            Console.WriteLine("Cantidad de Billetes de 200: " + B200);
            Console.WriteLine("Cantidad de Billetes de 100: " + B100);
        }
    }
}