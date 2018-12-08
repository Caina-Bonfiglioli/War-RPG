using System;
using System.Collections.Generic;

namespace war_rpg
{
    class Program
    {
        static void Main(string[] args){
            var tabuleiro = new Tabuleiro();

            Console.WriteLine("BEM VINDO AO WAR RPG");
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 - Para jogar\n2 - Para ler as regras\n3 - Para sair");

            Console.Write("Entre com a opção: ");
            var opcao = Convert.ToInt32(Console.ReadLine());
 
            switch (opcao){
                case 1:
                    tabuleiro.IniciarPartida();
                    tabuleiro.Batalhar();
                    break;
                case 2:
                    Console.WriteLine("REGRAS");
                    Console.WriteLine("As regras são como iguais a war tradicional,\n" + 
                    "prorem com os traços de um RPG de mesa");
                    Console.WriteLine("Escolha o número de jogadores da partida,"+
                     "depois Coloquem seus nicknames e seus territorios");
                    break;
                case 3:
                    Console.WriteLine("Até mais");
                    break;
                default:
                    Console.WriteLine("Entre com uma opção valida");
                    break;
            }
            
        }
    }
}
