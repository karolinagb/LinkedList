using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imagine uma lista de frutas
            List<string> frutas = new List<string>
            {
                "Abacate", "Banana", "Caqui", "Damasco", "Figo"
            };

            //Vamos imprimir essa lista
            foreach(var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine();
            LinkedList<string> dias = new LinkedList<string>();

            var d4 = dias.AddFirst("Quarta");
            Console.WriteLine("d4.Value: " + d4.Value);

            //Vamos adicionar segunda, antes de quarta:
            var d2 = dias.AddBefore(d4, "Segunda");

            //d2.Next é igual a d4
            //d4.Previous é iguala d2

            var d3 = dias.AddAfter(d2, "Terça");

            var d6 = dias.AddAfter(d4, "Sexta");

            var d7 = dias.AddAfter(d6, "Sábado");

            var d5 = dias.AddBefore(d6, "Quinta");

            var d1 = dias.AddBefore(d2, "Domingo");

            foreach(var dia in dias)
            {
                Console.WriteLine(dia);
            }

            dias.Remove("Quarta");

            Console.WriteLine();

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }
}
