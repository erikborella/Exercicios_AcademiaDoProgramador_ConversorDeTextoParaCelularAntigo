using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladorDeTecladoAntigo
{
    public class StringParaTecladoNumerico
    {

        private int numeroCorrespondenteAnterior = -1;
        public char[] Simbolos { get; private set; }
        public string MensagemEmNumeros { get; private set; }

        public char[][] teclado =
        {
            new char[] {'A', 'B', 'C'},
            new char[]  {'D', 'E', 'F' },
            new char[]  {'G', 'H', 'I' },
            new char[]  {'J', 'K', 'L' },
            new char[]  {'M', 'N', 'O' },
            new char[]  {'P', 'Q', 'R', 'S' },
            new char[]  {'T', 'U', 'V' },
            new char[]  {'W', 'X', 'Y', 'Z' },
        };

        public StringParaTecladoNumerico(string entrada)
        {
            Simbolos = entrada.ToCharArray();

            if (Simbolos.Length > 255)
                throw new ArgumentException("A mensagem é muito grande", nameof(entrada));

            MensagemEmNumeros = Parse();
        }

        private string Parse()
        {
            StringBuilder saida = new StringBuilder();

            foreach(char simbolo in Simbolos)
            {
                saida.Append(ConverterLetraParaNumero(simbolo));
            }

            return saida.ToString();
        }


        private string ConverterLetraParaNumero(char l)
        {
            l = char.ToUpper(l);

            StringBuilder saida = new StringBuilder();

            int numeroCorrespondente;
            int vezesRepetidas;

            EncontrarIndicesDaLetra(l, out numeroCorrespondente, out vezesRepetidas);

            if (numeroCorrespondente == numeroCorrespondenteAnterior)
                saida.Append("_");

            for (int i = 0; i < vezesRepetidas; i++)
                saida.Append(numeroCorrespondente);

            numeroCorrespondenteAnterior = numeroCorrespondente;

            return saida.ToString();
        }

        private void EncontrarIndicesDaLetra(char l, out int i, out int j)
        {
            if (l == ' ')
            {
                i = 0;
                j = 1;
                return;
            }
                
            for (i = 0; i < teclado.Length; i++)
            {
                for (j = 0; j < teclado[i].Length; j++)
                {
                    if (teclado[i][j] == l)
                    {
                        i += 2;
                        j += 1;
                        return;
                    }
                }
            }

            throw new ArgumentOutOfRangeException(nameof(l), "Simbolo não encontrado");
        }
  
    }
}
