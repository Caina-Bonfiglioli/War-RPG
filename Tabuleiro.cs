using System;
using System.Collections.Generic;

namespace war_rpg
{
    public class Tabuleiro
    {
        private List<Territorio> territorios = new List<Territorio>();
        private List<Jogador> jogadores = new List<Jogador>();
        private Marinha marinha = new Marinha();
        private Aeronautica aeronautica = new Aeronautica();
        private Exercito exercito = new Exercito();
        
        private Jogador AddJogador(Jogador jogador){
            jogadores.Add(jogador);

            return jogador;
        }

        private List<Territorio> AddTeritoros(string nomeTerritorio, Jogador comandante){
            territorios.Add(new Territorio{
                NomeTerritorio = nomeTerritorio,
                Comandante = comandante
            });

            return territorios;
        }

        private void MostraTerritorios(){
            foreach (var territorio in territorios)
            {
                Console.WriteLine("______________________________________");
                Console.WriteLine($"O terrio: {territorio.NomeTerritorio}");
                Console.WriteLine($"É comandado por : {territorio.Comandante.NickName}");
                Console.WriteLine("______________________________________");
            }
        }

        private void MostraJogadores(){
            Console.WriteLine("______________________________________");
            Console.WriteLine("Os jogadores são:");
            foreach (var jogador in jogadores)
            {
                Console.WriteLine($"{jogador.NickName}, pontos {jogador.Pontos}");
            }
        }

        public void IniciarPartida(){
            
            Console.Write($"Digite o numero de jogadores da partida: ");
            int numeroJogadores = Convert.ToInt32(Console.ReadLine());

            if(numeroJogadores == 1){
                Console.WriteLine("É preciso mais de um jogador para iniciar a partida");
            }

            if(numeroJogadores > 6){
                Console.WriteLine("Somente 6 jogadores são permitidos");
            }

            if(numeroJogadores > 1 && numeroJogadores <= 6){
                for (int i = 1; i <= numeroJogadores ; i++){
                    Console.Write($"Digite no nickname do {i}º jogador: ");
                    var nickname = Console.ReadLine();

                    var jogador = AddJogador(new Jogador{
                        NickName = nickname
                    });

                    Console.Write($"Digite o nome do territorio do {i}º jogador: ");
                    var nomeTerritorio = Console.ReadLine();

                    AddTeritoros(nomeTerritorio, jogador);
                }
            }           
        }

        public void Batalhar(){
            int[] arrayTropas = new int[2];
            var dado = new Dado();

            foreach (var jogador in jogadores)
            {
                Console.WriteLine($"\nVez do jogador {jogador.NickName}");

                exercito.convocarTropas();
                marinha.convocarTropas();
                aeronautica.convocarTropas();

                for (int i = 0; i < jogadores.Count ; i++){
                    arrayTropas[i] = exercito.ValorTropas + marinha.ValorTropas + aeronautica.ValorTropas;
                }
                
                dado.RolarDado();
           
                for (int i = 0; i < jogadores.Count ; i++){
                    if (dado.Valor <= 5){
                        arrayTropas[i] += 1; 
                    }else if(dado.Valor > 5 && dado.Valor <= 10){
                        arrayTropas[i] += 3;
                    }else{
                        arrayTropas[i] += 5;
                    }
                }
            }

            MostraJogadores();
            MostraTerritorios();
        }
    }
}