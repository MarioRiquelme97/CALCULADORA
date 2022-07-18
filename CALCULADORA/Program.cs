using System;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            double num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
            string operacion;
            double resultado;
            string reinicio = "SI";

            while (reinicio == "SI")
            {

                Console.WriteLine("Digite operacion");
                Console.WriteLine("SUMA");
                Console.WriteLine("RESTA");
                Console.WriteLine("MULTI");
                Console.WriteLine("DIVI");
                operacion = Console.ReadLine();



                Console.WriteLine("Digite Numero");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite 2do numero");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite 3do numero");
                num3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite 4do numero");
                num4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite 5do numero");
                num5 = Convert.ToDouble(Console.ReadLine());

                Console.Clear();


                if (operacion == "SUMA")
                {
                    resultado = num1 + num2 + num3 + num4 + num5;
                    Console.WriteLine(resultado);
                }

                if (operacion == "RESTA")
                {
                    resultado = num1 - num2 - num3 - num4 - num5;
                    Console.WriteLine(resultado);
                }
                if (operacion == "MULTI")
                {
                    resultado = num1 * num2 * num3 * num4 * num5;
                    Console.WriteLine(resultado);
                }
                if (operacion == "DIVI")
                {
                    resultado = num1 / num2 / num3 / num4 / num5;
                    Console.WriteLine(resultado);

                }


                Console.WriteLine("OTRA OPERACION?");
                reinicio = Console.ReadLine();
            }
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
