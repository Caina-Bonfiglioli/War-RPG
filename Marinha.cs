using System;

namespace war_rpg
{
    public class Marinha : Tropas
    {
        public int Navios { get; set; }
        public override void convocarTropas(){
            Console.WriteLine($"\nDigite a quantidade de tropas da Marinha (O maximo é 5)");
            Console.Write($"Artilharia: ");
            var artilharia = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Cavalaria: ");
            var cavalaria = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Infantaria: ");
            var infantaria = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Navios: ");
            var navios = Convert.ToInt32(Console.ReadLine());

            Infantaria = artilharia;
            Cavalaria = cavalaria;
            Artilharia = infantaria;
            Navios = navios;
            ValorTropas = artilharia + cavalaria + infantaria + navios;
        }
    }
}