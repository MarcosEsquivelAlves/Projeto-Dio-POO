using System;

namespace Projeto.src.Entities
{

public class WhiteWizard : Hero 
{
    public WhiteWizard(string Name, int Level, string HeroType, int HP)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP = HP;
    }
        public override string Attack()
        {
            return this.Name + " " + "Lançou uma magia";
        }

        public string Attack(int Bonus){

        if (Bonus < 6)
        {
         return this.Name + " " +  "Lançou uma magia super efetiva com um bonus de "  + Bonus ;
        }
        else
        {
            return this.Name + " " + "Lançou uma magia fraca com um bonus de " + Bonus;
        }
         
        }
    }

}