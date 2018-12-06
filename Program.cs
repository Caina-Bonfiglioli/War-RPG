using System;

namespace war_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dado = new Dado();
            dado.RolarDado();

            if(dado.Valor <= 20){
                Console.WriteLine($"o valor {dado.Valor}");
            }
        }
    }
}
