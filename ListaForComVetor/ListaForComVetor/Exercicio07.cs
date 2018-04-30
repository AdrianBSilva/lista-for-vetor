using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio07
    {
        public Exercicio07()
        {
            char[] caracteres = new char[5];
            bool validar = true;
            int quantidadeVogais = 0, quantidadeConsoante = 0, quantidadeEspeciais = 0;
            string vogais = "", consoantes = "", especiais = "";
            
            for(int i = 0; i < caracteres.Length; i++, validar = true )
            {
                
               while (validar == true)
                {
                    try
                    {
                        Console.Write("Caracter: ");
                        caracteres[i] = Convert.ToChar(Console.ReadLine().ToLower());
                        validar = false;
                        Console.Clear();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Apenas um caracter");

                    }
                }
                
                if ((caracteres[i] == 'a') || (caracteres[i] == 'e') || (caracteres[i] == 'i')
                    || (caracteres[i] == 'o') || (caracteres[i] == 'u'))
                {
                    quantidadeVogais++;
                    vogais = vogais + caracteres[i] + ", ";
                }
                if ((caracteres[i] == 'b') || (caracteres[i] == 'c') || (caracteres[i] == 'd') ||
                    (caracteres[i] == 'f') || (caracteres[i] == 'g') || (caracteres[i] == 'h') ||
                    (caracteres[i] == 'j') || (caracteres[i] == 'k') || (caracteres[i] == 'l') ||
                    (caracteres[i] == 'm') || (caracteres[i] == 'n') || (caracteres[i] == 'p') ||
                    (caracteres[i] == 'q') || (caracteres[i] == 'r') || (caracteres[i] == 's') ||
                    (caracteres[i] == 't') || (caracteres[i] == 'v') || (caracteres[i] == 'w') ||
                     (caracteres[i] == 'x') || (caracteres[i] == 'y') || (caracteres[i] == 'z'))
                {
                    quantidadeConsoante++;
                    consoantes = consoantes + caracteres[i] + ", ";
                }
                if ((caracteres[i] != 'b') && (caracteres[i] != 'c') && (caracteres[i] != 'd') && 
                    (caracteres[i] != 'f') && (caracteres[i] != 'g') && (caracteres[i] != 'h') && 
                    (caracteres[i] != 'j') && (caracteres[i] != 'k') && (caracteres[i] != 'l') && 
                    (caracteres[i] != 'm') && (caracteres[i] != 'n') && (caracteres[i] != 'p') && 
                    (caracteres[i] != 'q') && (caracteres[i] != 'r') && (caracteres[i] != 's') && 
                    (caracteres[i] != 't') && (caracteres[i] != 'v') && (caracteres[i] != 'w') &&
                     (caracteres[i] != 'x') && (caracteres[i] != 'y') && (caracteres[i] != 'z') &&
                    (caracteres[i] != 'a') && (caracteres[i] != 'e') && (caracteres[i] != 'i') && 
                    (caracteres[i] != 'o') && (caracteres[i] != 'u') )
                {
                    quantidadeEspeciais++;
                    especiais = especiais + caracteres[i] + ", ";
                }
                    
                    

            }
            Console.WriteLine("Quantidade de Vogais: " + quantidadeVogais + "\nQue são: " + vogais + "\nQuantide de Consoantes: " + quantidadeConsoante +
                "\nQue são: " + consoantes + "\nQuantidade de caracteres especiais: " + quantidadeEspeciais + "\nQue são: " + especiais);
        }
    }
}
