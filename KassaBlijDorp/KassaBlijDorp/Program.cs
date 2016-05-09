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



    }
  }
  class bereken
  {
    public string bereken1(string v , string k)
    {
      int totaal=0;
      int Iv = Convert.ToInt32(v);
      int Ik = Convert.ToInt32(k);

      if (Iv != 0)
      {
        totaal += (Iv * 20);
      }
      if (Ik != 0)
      {
        totaal +=( Ik * 17);
      }
      string EindTotaal = totaal.ToString();
      return EindTotaal;
    }
  }
}
