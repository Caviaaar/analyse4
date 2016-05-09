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
      string begeleider;
      string abonnement;
      Console.WriteLine("Aantal volwassenen (vanaf 13 jaar, zonder abonnement):");
      volwassenen = Console.ReadLine();

      Console.WriteLine("Aantal kinderen (3 t/m 12 jaar, zonder abonnement):");
      kinderen = Console.ReadLine();

      Console.WriteLine("Aantal begeleiders van gehandicapte personen (zonder abonnement):");
      begeleider = Console.ReadLine();

      Console.WriteLine("Aantal abonnementhouders:");
      abonnement = Console.ReadLine();

      bereken test = new bereken();
      Console.WriteLine(test.bereken1(volwassenen, kinderen, begeleider, abonnement));
      Console.ReadLine();


    }
  }
  class bereken
  {
    public string bereken1(string v , string k, string b, string a)
    {
      double totaal = 0;
      int Iv = Convert.ToInt32(v);
      int Ik = Convert.ToInt32(k);
      int Ib = Convert.ToInt32(b);
      int Ia = Convert.ToInt32(a);
      double vP = 22.00;
      double kP = 17.50;
      double bP = 12.00;
      double disc = 0.25;

      int Intr = Ia * 4;

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

      if (Ib > 0)
      {
        totaal += (Ib * bP);
      }

      if (Intr >= Iv)
      {
        totaal -= (disc * vP) * Iv;
        Intr -= Iv;

        if (Intr >= Ik)
        {
          totaal -= (disc * kP) * Ik;
          Intr -= Ik;

          if(Intr >= Ib)
          {
            totaal -= (disc * bP) * Ib;
          }
          else
          {
            totaal -= (disc * bP) * Intr;
          }
        }
        else
        {
          totaal -= (disc * kP) * Intr;
        }
      }
      else
      {
        totaal -= (disc * vP) * Intr;
      }


      string EindTotaal = totaal.ToString();
      return EindTotaal;
    }
  }
}
