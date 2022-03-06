using System;


namespace LanzarExcepciones3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;  


            try
            {

                Console.WriteLine("Introduce el primer Número");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce el segundo Número");
                num2 = Convert.ToInt32(Console.ReadLine());

                resultado = num1 / num2;
                Console.WriteLine("El resultado de la operación es: {0}",resultado);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error:  {0}", e.ToString());
            }

            Console.ReadKey();
        }
    }
}
