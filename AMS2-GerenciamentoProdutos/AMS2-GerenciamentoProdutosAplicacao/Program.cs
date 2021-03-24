using System;

namespace AMS2_GerenciamentoProdutosAplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois números para calcular");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            //****************************************
            //OPERADORES ARITMÉTICOS

            //operador adição
            int c = a + b;
            Console.WriteLine($"O Valor da Adição é : {c}");

            //operador subtração
            int d = a - b;
            Console.WriteLine($"O Valor da Subtração é : {d}");

            //operador multiplicação

            //operador divisão

            //****************************************
            //OPERADORES COMPARATIVOS
            // QUAIS SÃO : MAIOR , MENOR, IGUAL , MAIOR IGUAL E MENOR IGUAL, DIFERENTE
            // SINAIS: > , < , ==, >= , <=, !(NOT) =

            if (a > b)
                Console.WriteLine("A é maior do que B");


            //****************************************
            //OPERADORES LÓGICOS - CONDICIONAIS
            // QUAIS SÃO : E , OU
            // SINAIS: && , ||

            bool IsActive = false;

            if (!IsActive)
                Console.WriteLine(IsActive);

            if (true && true)
                Console.WriteLine("true");

            if ()
                Console.WriteLine("false");


        }

    }
}
