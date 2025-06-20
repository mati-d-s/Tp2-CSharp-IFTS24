using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bucles");
            Console.WriteLine();

            //While
            int Contador = 0; //Probar inicializando Contador en 10
            Console.WriteLine("while");
            Console.WriteLine();
            while (Contador < 10)
            {
                Console.WriteLine("contador = {0}", Contador);
                Contador = Contador + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Valor final: {0}", Contador);

            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //Do While
            Console.WriteLine("do while");
            Console.WriteLine();
            Contador = 0; //probar inicializando Contador en 10
            do
            {
                Console.WriteLine("contador = {0}", Contador);
                Contador = Contador + 1;

            }
            while (Contador < 10);
            {
                Console.WriteLine();
                Console.WriteLine("Valor final: {0}", Contador);

                Console.WriteLine();
                Console.WriteLine("Pulse una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                //for
                Console.WriteLine("for");
                Console.WriteLine();
                for (int Var = 1; Var <= 10; Var++)
                {
                    Console.WriteLine("Var = {0}", Var);
                }

                // otro ejemplo
                for (int Var = 100; Var >= 10; Var = Var - 10)
                {
                    Console.WriteLine();
                    Console.Write("Pulse una tecla para continuar...");
                    Console.ReadKey();

                    Console.Clear();
                }
            }
        }
    }
}


