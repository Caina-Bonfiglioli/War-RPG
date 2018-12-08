using System;

namespace war_rpg
{
    public class Territorio
    {
        private string nomeTerritorio;
        public string NomeTerritorio { 
            get{
                return nomeTerritorio;
            } 
            set{
                nomeTerritorio = value;
            } 
        }
        private Jogador comandante;
        public Jogador Comandante {
            get{
                return comandante;
            }
            set{
                comandante = value;
            } 
        }
    }
}