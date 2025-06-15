
using System.Reflection.Metadata.Ecma335;

namespace MortalCombatProj.Fighters.Indicators
{
    public abstract class Indicators
    {
        public string Name { get; }
        public int Hp { get; set; }
        public int Attack { get;}
        public int Defence { get;}

        public Indicators(string name, int hp, int attack, int defence)
        {
            this.Name = name;
            this.Hp = hp;
            this.Attack = attack;
            this.Defence = defence;

        }

        public abstract void SkinFightres(); 
        public abstract void Xray(); 

    

    }
}