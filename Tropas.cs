using System;

namespace war_rpg
{
    public abstract class Tropas
    {
        private int infantaria;
        public int Infantaria {
            get{
                return infantaria;
            }
            set{
                infantaria = value;
            } 
        }
        private int cavalaria;
        public int Cavalaria { 
            get{
                return cavalaria;
            } 
            set{
                cavalaria = value;
            } 
        }
        private int artilharia;
        public int Artilharia { 
            get{
                return artilharia;
            } 
            set{
                artilharia = value;
            } 
        }

        private int valorTropas;
        public int ValorTropas{
            get{
                return valorTropas;
            }
            set{
                valorTropas = value;
            }
        }


        

        public abstract void convocarTropas();
    }
}