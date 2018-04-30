using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio08
    {
        public Exercicio08()
        {
            bool validarQunatidadesDeNumeros = true;
            bool validarNumero = true;
            int cadastros = 0;
            while (validarQunatidadesDeNumeros == true)
            {

                try
                {
                    Console.Write("Quantos números deseja cadastrar: ");
                    cadastros = Convert.ToInt32(Console.ReadLine());
                    validarQunatidadesDeNumeros = false;
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("''Apenas números'' ");
                }
            }
            int[] numeros = new int[cadastros];
            int par = 0, impar = 0;
            int[] numerosPares = new int[par];
            int[] numerosImpares = new int[impar];
            for (int i = 0; i < cadastros; i++, validarNumero = true)
            {

                while (validarNumero == true)
                {

                    try
                    {
                        Console.Write("Digite um número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        validarNumero = false;
                        Console.Clear();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("''Apenas números'' ");
                    }
                }
                if (numeros[i] % 2 == 0)
                {

                    par++;
                    
                }
                else if (numeros[i] % 2 != 0)
                {

                    impar++;
                    
                }
                if (numeros[i] % 2 == 0)
                {
                    
                    par++;
                    numerosPares[i] = numerosPares[i] + numeros[i];
                }
                else if (numeros[i] % 2 != 0)
                {
                    
                    impar++;
                    numerosImpares[i] = numerosImpares[i] + numeros[i];
                }
                
                
            }
            Console.Write("Vetor Original: ");
            for (int i = 0; i < cadastros; i++)
            {
                Console.Write(numeros[i] + ", ");
            }
            Console.WriteLine();
            Console.Write("Vetor Par: ");
            for (int i = 0; i < numerosPares.Length; i++)
            {

                Console.Write(numerosPares[i] + ", ");
            }
            Console.WriteLine();
            Console.Write("Vetor Impar: ");
            for (int i = 0; i < numerosImpares.Length; i++)
            {
                Console.Write(numerosImpares[i] + ", ");
            }
            Console.WriteLine();




        }
    }
}
