using System;
using System.Collections.Generic;

namespace SimuladorDeTecladoAntigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new StringParaTecladoNumerico("ABCDEFGHIJKLMNOPQRSTUVWXYZ   ").MensagemEmNumeros);
        }
    }
}
