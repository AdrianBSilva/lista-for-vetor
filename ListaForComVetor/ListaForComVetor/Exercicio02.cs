using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            bool validarIdades = true;
            int[] idades = new int[7];

            for (int i = 0; i < idades.Length; i++, validarIdades = true)
            {
                while (validarIdades == true)
                {
                    try
                    {
                        Console.Write("Digite uma idade: ");
                        idades[i] = Convert.ToInt32(Console.ReadLine());
                        validarIdades = false;
                        Console.Clear();
                        
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Idades deveria apresentar apenas números");
                        Console.ReadKey();
                        Console.Clear();
                        
                    }
                }
            }
            Console.Clear();

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Idades: " + idades[i]);
            }
        }
    }
}
