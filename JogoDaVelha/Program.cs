using System;

namespace JogoDaVelha
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.SetWindowSize(90, 25);
            Console.Title = "Jogo da Velha";

            Partida Partida = new Partida();
            Partida.IniciarJogo();
            Console.ReadKey();
        }
    }
}