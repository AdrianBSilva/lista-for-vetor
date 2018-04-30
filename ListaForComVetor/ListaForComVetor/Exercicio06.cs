using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio06
    {
        public Exercicio06()
        {

            Random numeroAleatorio = new Random();

            double[] numeros = new double[10];
            double soma = 0;
            int pares = 0, impar = 0, positivos = 0, negativos = 0, neutros = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numeroAleatorio.Next(-10, 10);
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Número Aleatórios: " + numeros[i]);
                soma = soma + numeros[i];
                if (numeros[i] == 0)
                {
                    neutros++;
                }
                else if (numeros[i] % 2 == 0)
                {
                    pares++; 
                }
                else if (numeros[i] % 2 != 0)
                {
                    impar++;
                }
                if (numeros[i] > 0)
                {
                    positivos++;
                }
                else if (numeros[i] < 0)
                {
                    negativos++;
                }
            }
            double media = soma / numeros.Length;
            Console.WriteLine("A soma dos números: " + soma);
            Console.WriteLine("A média dos numeros: " + media);
            Console.WriteLine(" Quantidade de números pares: " + pares + "\n Quantidade de números impares: " + impar
                 + "\n Quantidade de números positivos: " + positivos + "\n Quantidade de números negativos: " + negativos 
                 + "\n Quantidade de números neutros: " + neutros);



        }

    }
}
