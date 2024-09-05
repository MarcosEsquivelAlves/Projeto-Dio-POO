using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.src.Entities
{
    public class BlackWizard :  Hero
    {
    public BlackWizard(string Name, int Level, string HeroType, int HP)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP = HP;
    }

        public string Attack(int Bonus){

        if (Bonus > 10)
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