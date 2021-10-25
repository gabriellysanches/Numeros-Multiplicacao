using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite os 3 numeros:");
            string numeros = Console.ReadLine();
            var numerosArray = numeros.Split(",");

            int resultado = 1;

            foreach (string item in numerosArray)
            {
                resultado *= int.Parse(item);
            }

            Console.WriteLine("O resultado é " + resultado + ".");


            if (resultado > 10 && resultado < 20)
            {
                Console.WriteLine("Sim, é verdadeiro, achou o número premiado!");
            }

            else if (resultado > 100 && resultado < 200)
            {
                Console.WriteLine("Sim, é verdadeiro, achou o número premiado!");
            }

            else if (resultado > 1000 && resultado < 2000)
            {
                Console.WriteLine("Sim, é verdadeiro, achou o número premiado!");
            }

            else
            {
                Console.WriteLine("Infelizmente você perdeu!");
            }



        }
    }
}
