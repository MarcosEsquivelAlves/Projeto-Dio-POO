using System;
using Projeto.src.Entities;

namespace Projeto.src.Entities
{
  class Program
 {
  static void Main(string[] args)
  {
    Knight arus = new Knight("Arus", 23, "Knight", 299);
    WhiteWizard wizard = new WhiteWizard("Jenica", 44, "Wizard", 70);
    Ninja ninja = new Ninja("Wedger", 38, "Ninja", 150);
    BlackWizard blackWizard = new BlackWizard("Merlin", 40, "Black Wizard", 100);

   Console.WriteLine(wizard);
   Console.WriteLine(wizard.Attack(7));
   Console.WriteLine();
   Console.WriteLine(arus);
   Console.WriteLine();
   Console.WriteLine(ninja);
   Console.WriteLine();
   Console.WriteLine(blackWizard);
   Console.WriteLine(blackWizard.Attack(20));
   
  }

 }

}

