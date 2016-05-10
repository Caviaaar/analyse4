using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geldautomaat
{
  class Program
  {
    static void Main(string[] args)
    {
      Automaat A = new Automaat();
      Console.WriteLine(A.Opnemen());
      Console.ReadLine();
    }    
  }

  class Automaat
  {
    public double Saldo;
    public double Limiet;
    public double Krediet;
    public double Voorraad;
    public double Opname;
    public bool Actief;

    public Automaat()
    {
      this.Saldo = Input("Voer uw banksaldo in: ",true);
      this.Limiet = Input("Voer uw daglimiet in: ");
      this.Krediet = Input("Voer uw kredietlimiet in: ");
      this.Voorraad = Input("Voer het beschikbare bedrag in de geldautomaat in: ");
      this.Opname = Input("Voer het bedrag in wat u op wilt nemen: ");
      this.Actief = CheckActief();
    }

    public bool CheckActief()
    {
      Console.WriteLine("Is de automaat in werking (Y/N): ");
      string werkend = Console.ReadLine();

      string[] array = { "N", "n", "Y", "y" };
      if (array.Any(werkend.Equals))
      {
        if (werkend == "Y" || werkend == "y")
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      else
      {
        Console.WriteLine("Ongeldige invoer. Voer Y of N in!");
        return CheckActief();
      }
    }

    public double Input(string text, bool neg = false)
    {
      double value;
      Console.WriteLine(text);
      string input = Console.ReadLine();
      if(double.TryParse(input, out value))
      {
        if (value >= 0 || neg == true) 
        {
          return value;
        }
        else
        {
          Console.WriteLine("Voer een getal groter dan 0 in!");
          return Input(text, neg);
        }
      }
      else
      {
        Console.WriteLine("Ongeldige invoer. Voer een getal in!");
        return Input(text, neg);
      }
    }

    public string Opnemen()
    {
      if(Actief)
      {
        if(Saldo + Krediet >= Opname)
        {
          if(Opname <= Voorraad)
          {
            if(Opname <= Limiet)
            {
              return "De transactie is geslaagd!";
            }
            else
            {
              return "De transactie is mislukt. U overschrijdt uw daglimiet!";
            }
          }
          else
          {
            return "De transactie is mislukt. Er is niet voldoende geld voorradig";
          }
        }
        else
        {
          return "De transactie is mislukt. U heeft onvoldoende saldo en krediet om het gewenste bedrag op te nemen!";
        }
      }
      else
      {
        return "De automaat is niet in werking dus er kan geen geld worden opgenomen!";
      }
    }
  }
}