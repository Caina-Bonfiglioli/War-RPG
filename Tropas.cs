using System;

namespace war_rpg
{
    public abstract class Tropas
    {
        public int Infantaria { get; set; }
        public int Cavalaria { get; set; }
        public int Artilharia { get; set; }

        public abstract void convocarTropas();
    }
}