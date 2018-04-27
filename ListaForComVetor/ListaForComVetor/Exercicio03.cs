using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            bool validarQunatidadesDeCadastros = true;
            int quantidadedeCadastros = 0;
            double soma = 0;
            while (validarQunatidadesDeCadastros == true)
            {
                try
                {
                    Console.Write("Quantos preços deseja cadastrar: ");
                    quantidadedeCadastros = Convert.ToInt32(Console.ReadLine());
                    validarQunatidadesDeCadastros = false;
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("''Apenas números'' ");
                    
                    
                    
                }
            }
            double[] precos = new double[quantidadedeCadastros];
            for (int i = 0; i < quantidadedeCadastros; i++)
            {
                Console.Write("Preço: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                soma = soma + precos[i];
            }
            for (int i = 0; i < quantidadedeCadastros; i++)
            {
                Console.WriteLine("Preço cadastrado: " + precos[i]);

            }
            Console.WriteLine("Total: " + soma);

            
        }
    }
}
