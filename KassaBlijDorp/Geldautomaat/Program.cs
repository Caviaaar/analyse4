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
      this.Saldo = Input("Voer uw banksaldo in: ");
      this.Limiet = Input("Voer uw daglimiet in: ");
      this.Krediet = Input("Voer uw kredietlimiet in: ");
      this.Voorraad = Input("Voer het beschikbare bedrag in de geldautomaat in: ");
      this.Opname = Input("Voer het bedrag in wat u op wilt nemen: ");

      Console.WriteLine("Is de automaat in werking (Y/N): ");
      string werkend = Console.ReadLine();
      if(werkend == "Y" || werkend == "y")
      {
        this.Actief = true;
      }
      else
      {
        this.Actief = false;
      }
    }

    public double Input(string text)
    {
      Console.WriteLine(text);
      return Convert.ToDouble(Console.ReadLine());
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
              return "De transactie is mislukt. U overschrijdt uw dagmlimiet!";
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