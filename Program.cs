using System;

namespace Parc_1__prueba_
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = "";
            int cont = 0;
            Console.WriteLine("\nAplicacion magica!");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1. Adivinar numero");
            Console.WriteLine("2. Adivinar cumpleaños");
            opc = Console.ReadLine();
            cont = Convert.ToInt32(opc);

            switch (cont)
            {
                case 1: AdivinarNumero(); break;

                case 2: AdivinarCumpleaños(); break;
            }

        }

        static void AdivinarNumero()
        {         

            Console.WriteLine("----Adivinar numero----");
            Console.WriteLine("\nPiensa en un número cualquiera...");
            Console.ReadKey();
            Console.WriteLine("Ahora ese mismo numero multiplicalo por 2...");
            Console.ReadKey();
            Console.WriteLine("Ahora sumale 8 a tu resultado...");
            Console.ReadKey();
            Console.WriteLine("Ahora multiplica por 5 tu resultado actual...");
            Console.ReadKey();
            Console.WriteLine("Magnífico, acercate y dime el resultado de esa operacion al oído... ");
            string num2 = Console.ReadLine();
            num2 = num2.Remove(num2.Length - 1);
            int sobra2 = Convert.ToInt32(num2);
            sobra2 = sobra2 - 4;
            Console.WriteLine("\nGenial! Ahora segun lo que el universo esta manifestando es que el numero que pensaste es el " + (sobra2));
            Console.WriteLine("\nSí este no es el numero que pensaste, deberias repasar matematicas");
            Console.WriteLine("\nEl universo nunca se equivoca...");
            Console.ReadKey();

            
        }

        static void AdivinarCumpleaños()
        {

            Console.WriteLine("----Adivinar cumpleaños----");
            Console.WriteLine("\nPiensa o anota la fecha de el dia en que naciste...");
            Console.ReadKey();
            Console.WriteLine("Ahora ese numero multiplicalo por 20...");
            Console.ReadKey();
            Console.WriteLine("Ahora sumale 73 a tu resultado...");
            Console.ReadKey();
            Console.WriteLine("Ahora multiplica por 5 tu resultado actual...");
            Console.ReadKey();
            Console.WriteLine("Ahora suma el numero del mes en que naciste...");
            Console.ReadKey();
            Console.WriteLine("Magnífico, acercate y dime el resultado de esa operacion al oído... ");
            string dia = Console.ReadLine();
            int dia2 = Convert.ToInt32(dia);
            dia2 = dia2 - 365;
            string diar = dia2.ToString();
            string resul = diar.Insert(2, " del mes ");


            
            Console.WriteLine("\nGenial! Ahora segun lo que el universo esta manifestando es que naciste el día {0} ", resul);
            Console.WriteLine("\nSí esta no es la fecha de tu cumpleaños, deberias repasar matematicas");
            Console.WriteLine("\nEl universo nunca se equivoca...");
            Console.ReadKey();


        }

    }

}
