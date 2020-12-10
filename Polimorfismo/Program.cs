using System;
using Polimorfismo.classes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
            Console.WriteLine($"Jogador 1 = {jogador.Correr()}");
            Console.WriteLine($"Jogador 1 = {jogador.Pular()}");

            Zero jogador2 = new Zero();

            Console.WriteLine($"Jogador 2 = {jogador2.Correr()}");
            Console.WriteLine($"Jogador 2 = {jogador2.Pular()}");


           
        }
    }
}
