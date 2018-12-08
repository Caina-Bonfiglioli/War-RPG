using System;

namespace war_rpg
{
    public class Jogador
    {
        private string nickName;
        public string NickName { 
            get{
                return nickName;
            } 
            set{
                nickName = value;
            } 
        }

        private int ponto;
        public int Pontos { 
            get{
                return ponto;
            } 
            set{
                ponto = value;
            }
        }
    }
}