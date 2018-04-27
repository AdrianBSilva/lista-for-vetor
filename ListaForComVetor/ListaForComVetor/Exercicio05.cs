using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            bool validarRegistros = true;
            bool validarQuantidade = true;
            int registros = 0;
            while (validarRegistros == true)
            {
                try
                {
                    Console.Write("Quantos jogos deseja cadastrar: ");
                     registros = Convert.ToInt32(Console.ReadLine());
                    validarRegistros = false;
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Cadastros deve se ter apenas numeros");
                }
            }
            Console.Clear();



            string[] nomes = new string[registros];
            int[] estoque = new int[registros];

            for (int i = 0; i < registros; i++)
            {
                Console.Write("Nome do jogo: ");
                nomes[i] = Console.ReadLine();
                validarQuantidade = true;
                while (validarQuantidade == true)
                {
                    try
                    {
                        Console.Write("Quantidade em estoque: ");
                        estoque[i] = Convert.ToInt32(Console.ReadLine());
                        validarQuantidade = false;
                        Console.Clear();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Apenas Números nas quantidades");

                    }
                }
                
            }
            Console.WriteLine("Nomes            unidades");
            for (int i = 0; i < registros; i++)
            {
                Console.WriteLine(nomes[i]+ "                " + estoque[i]);
            }


        }
    }
}
