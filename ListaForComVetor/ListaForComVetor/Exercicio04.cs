using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForComVetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            string[] tamanhoCamisas = new string[4];
            int QunatidadePP = 0, QunatidadeP = 0, QunatidadeM = 0,
                QunatidadeG = 0, QunatidadeGG = 0, QunatidadeXG = 0,
                QunatidadeXGG = 0;
            for (int i = 0; i < tamanhoCamisas.Length; i++)
            {
                Console.Write("Tamanhos de camisas: PP, P M, G, GG, XG, XGG. \n Informe o tamanho da camisa: ");
                tamanhoCamisas[i] = Console.ReadLine().ToLower();

                while ((tamanhoCamisas[i] != "pp") && (tamanhoCamisas[i] != "p")
                    && (tamanhoCamisas[i] != "m") && (tamanhoCamisas[i] != "g")
                    && (tamanhoCamisas[i] != "g") && (tamanhoCamisas[i] != "gg")
                    && (tamanhoCamisas[i] != "xg") && (tamanhoCamisas[i] != "xgg"))
                {
                    Console.Clear();
                    Console.WriteLine("O tamanho das camisas deve ser APENAS: PP, P, M, G, GG, XG, XGG.");
                    Console.Write("Informe novamente: ");
                    tamanhoCamisas[i] = Console.ReadLine().ToLower();
                    Console.Clear();
                }
                
                if(tamanhoCamisas[i] == "pp")
                {
                    QunatidadePP++;
                }
                if (tamanhoCamisas[i] == "p")
                {
                    QunatidadeP++;
                }
                if (tamanhoCamisas[i] == "m")
                {
                    QunatidadeM++;
                }
                if (tamanhoCamisas[i] == "g")
                {
                    QunatidadeG++;
                }
                if (tamanhoCamisas[i] == "gg")
                {
                    QunatidadeGG++;
                }
                if (tamanhoCamisas[i] == "xg")
                {
                    QunatidadeXG++;
                }
                if (tamanhoCamisas[i] == "xgg")
                {
                    QunatidadeXGG++;
                }
                
            }
            Console.WriteLine("PP: " + QunatidadePP);
            Console.WriteLine("P: " + QunatidadeP);
            Console.WriteLine("M:" + QunatidadeM);
            Console.WriteLine("G: " + QunatidadeG);
            Console.WriteLine("GG: " + QunatidadeGG);
            Console.WriteLine("XG: " + QunatidadeXG);
            Console.WriteLine("XGG: " + QunatidadeXGG);
        }
    }
}
