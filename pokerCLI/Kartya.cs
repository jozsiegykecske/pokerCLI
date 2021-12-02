using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pokerCLI
{
  class Kartya
  {
    private Ertek ertek;
    public Ertek Ertek
    {
      get { return ertek; }
      set { ertek = value; }
    }
    private Szin szin;
    public Szin Szin
    {
      get { return szin; }
      set { szin = value; }
    }
    public Kartya(Ertek ertek, Szin szin)
    {
      Ertek = ertek;
      Szin = szin;
    }
  }
}