using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.src.Entities
{
    public class Ninja : Hero
    {
    public Ninja(string Name, int Level, string HeroType, int HP)
    {   
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HP = HP;
    }
  }       
}
