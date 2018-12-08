using System;

namespace war_rpg
{
    public class Dado
    {
        public int Valor { get; set; }

        public int RolarDado(){
            var random = new Random();
            Valor = random.Next(1, 20);
            Console.WriteLine($"O valor do dado foi {Valor}");
            return Valor;
        }
    }
}