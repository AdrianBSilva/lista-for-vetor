using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine();
                Console.Clear();
            }
            
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("nome: " + nomes[i]);
            }
        }
    }
}
