using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaBlijDorp
{
  class Program
  {
    static void Main(string[] args)
    {
      string volwassenen;
      string kinderen;
      Console.WriteLine("Hoeveel volwassenen");
      volwassenen = Console.ReadLine();
      Console.WriteLine("Hoeveel kinderen");
      kinderen = Console.ReadLine();
      bereken test = new bereken();
      Console.WriteLine(test.bereken1(volwassenen, kinderen));
      Console.ReadLine();


    }
  }
  class bereken
  {
    public string bereken1(string v , string k)
    {
      double totaal = 0;
      int Iv = Convert.ToInt32(v);
      int Ik = Convert.ToInt32(k);
      double vP = 22.00;
      double kP = 17.50;

      if (Ik+ Iv >= 20)
      {
        vP -= 2;
        kP -= 2;
      }

      if (Iv > 0)
      {
        totaal += (Iv * vP);
      }
      if (Ik > 0)
      {
        totaal +=( Ik * kP);
      }
      string EindTotaal = totaal.ToString();
      return EindTotaal;
    }
  }
}
