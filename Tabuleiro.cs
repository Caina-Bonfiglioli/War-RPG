using System;
using System.Collections.Generic;

namespace war_rpg
{
    public class Tabuleiro
    {
        List<Territorio> territorios = new List<Territorio>();
        List<Jogador> jogadores = new List<Jogador>();
        
        public void addJogador(Jogador jogador){
            jogadores.Add(jogador);
        }

        public void addTeritoros(string nomeTerritorio, Jogador comandante, int valor){
            territorios.Add(new Territorio{
                NomeTerritorio = nomeTerritorio,
                Valor = valor,
                Comandante = comandante
            });
        }

        
    }
}