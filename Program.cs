using System;

namespace Primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador1 = new Personagem();
            jogador1.nome = "Nayane Crist";
            jogador1.idade = 18;

            Console.WriteLine( jogador1.Correr(250.3f));
            Console.WriteLine( "força : " + jogador1.Atacar(40f));

            jogador1.pulando = true;
            Console.WriteLine("força : " + jogador1.Atacar(40f));


        }
    }
}
