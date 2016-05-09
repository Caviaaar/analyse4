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

    public Automaat()
    {
      this.Saldo = Input("Voer uw banksaldo in: ");
      this.Limiet = Input("Voer uw daglimiet in: ");
      this.Krediet = Input("Voer uw kredietlimiet in: ");
      this.Voorraad = Input("Voer het beschikbare bedrag in de geldautomaat in: ");
      this.Opname = Input("Voer het bedrag in wat u op wilt nemen: ");
    }

    public double Input(string text)
    {
      Console.WriteLine(text);
      return Convert.ToDouble(Console.ReadLine());
    }
  }
}
