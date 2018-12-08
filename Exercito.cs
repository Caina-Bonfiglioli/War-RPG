using System;

namespace war_rpg
{
  public class Exercito : Tropas
  {
      public int Tanques { get; set; }
    public override void convocarTropas(){
            Console.WriteLine($"\nDigite a quantidade de tropas do Exercito (O maximo é 5)");
            Console.Write($"Artilharia: ");
            var artilharia = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Cavalaria: ");
            var cavalaria = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Infantaria: ");
            var infantaria = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Taques: ");
            var tanques = Convert.ToInt32(Console.ReadLine());

            Infantaria = artilharia;
            Cavalaria = cavalaria;
            Artilharia = infantaria;
            Tanques = tanques;
            ValorTropas = artilharia + cavalaria + infantaria + tanques;
        }
  }
}