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
      Kassa K = new Kassa();
      Console.WriteLine(K.Bereken());
      Console.ReadLine();
    }
  }

  class Kassa
  {
    public int Volwassenen;
    public int Kinderen;
    public int Begeleiders;
    public int Abonnement;

    public Kassa()
    {
      this.Volwassenen = Input("Aantal volwassenen (vanaf 13 jaar, zonder abonnement): ");
      this.Kinderen = Input("Aantal kinderen (3 t/m 12 jaar, zonder abonnement): ");
      this.Begeleiders = Input("Aantal begeleiders van gehandicapte personen (zonder abonnement): ");
      this.Abonnement = Input("Aantal abonnementhouders: ",true);
    }

    public int Input(string text,bool abo=false)
    {
      int value;
      Console.WriteLine(text);
      string input = Console.ReadLine();
      if (int.TryParse(input, out value))
      {
        if(value < 0)
        {
          if (abo)
          {
            return value;
          }
          else
          {
            Console.WriteLine("Ongeldige invoer. Voer een geheel getal groter dan 0 in!");
            return Input(text);
          }
        }
        else
        {
          return value;
        }
      }
      else
      {
        Console.WriteLine("Ongeldige invoer. Voer een geheel getal in!");
        return Input(text);
      }
    }

    public double Bereken()
    {
      double totaal = 0;
      double vP = 22.00;
      double kP = 17.50;
      double bP = 12.00;
      double disc = 0.25;

      int Intr = Abonnement * 4;

      if (Kinderen + Volwassenen + Begeleiders >= 20)
      {
        vP -= 2;
        kP -= 2;
      }

      if (Volwassenen > 0)
      {
        totaal += (Volwassenen * vP);
      }

      if (Kinderen > 0)
      {
        totaal += (Kinderen * kP);
      }

      if (Begeleiders > 0)
      {
        totaal += (Begeleiders * bP);
      }

      if (Intr >= Volwassenen)
      {
        totaal -= (disc * vP) * Volwassenen;
        Intr -= Volwassenen;

        if (Intr >= Kinderen)
        {
          totaal -= (disc * kP) * Kinderen;
          Intr -= Kinderen;

          if (Intr >= Begeleiders)
          {
            totaal -= (disc * bP) * Begeleiders;
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

      totaal = Math.Round(totaal, 2);
      return totaal;
    }
  }
}