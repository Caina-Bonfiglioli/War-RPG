using System;
namespace war_rpg
{
    public class Aeronautica : Tropas
    {
        public int Avioes { get; set; }
        public override void convocarTropas(){
            Console.WriteLine($"\nDigite a quantidade de tropas da Aeronautica (O maximo é 5)");
            Console.Write($"Artilharia: ");
            var artilharia = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Cavalaria: ");
            var cavalaria = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Infantaria: ");
            var infantaria = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Aviões: ");
            var avioes = Convert.ToInt32(Console.ReadLine());

            Infantaria = artilharia;
            Cavalaria = cavalaria;
            Artilharia = infantaria;
            Avioes = avioes;
            ValorTropas = artilharia + cavalaria + infantaria + avioes;
        }
    }
}