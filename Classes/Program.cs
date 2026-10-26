  /*
Hrdina nasPrvyHrdina = new Hrdina();
       nasPrvyHrdina.Meno = "Iron-man";
       nasPrvyHrdina.Zdravie = 50;
       nasPrvyHrdina.Energia = 150;


       Hrdina nasDruhyHrdina = new Hrdina();
       nasDruhyHrdina.Meno = "Augustin";
       nasDruhyHrdina.Zdravie = 45;
       nasDruhyHrdina.Energia = 100;


       Random randomizer = new Random();
       int silaUtoku = randomizer.Next(10,30);
      
       while (!(nasPrvyHrdina.Zdravie == 0 || nasDruhyHrdina.Zdravie == 0))
       {
           nasPrvyHrdina.Regeneruj();
           nasDruhyHrdina.Regeneruj();
          
           bool podarilSaUtok = nasPrvyHrdina.Utok(silaUtoku);
           if (podarilSaUtok)
           {
               nasDruhyHrdina.PrijmiZranenie(silaUtoku);
               Console.WriteLine(nasPrvyHrdina.Meno + " Trafil");
               Console.WriteLine(nasDruhyHrdina.Meno + " ma uz len "+ nasDruhyHrdina.Zdravie +" zdravia.");
           }
           else
           {
               Console.WriteLine(nasPrvyHrdina.Meno +" je unaveny");
           }
          
           podarilSaUtok = nasDruhyHrdina.Utok(silaUtoku);
           if (podarilSaUtok)
           {
               Console.WriteLine(nasDruhyHrdina.Meno + " Trafil");
               nasPrvyHrdina.PrijmiZranenie(silaUtoku);
               Console.WriteLine(nasPrvyHrdina.Meno + " ma uz len "+ nasPrvyHrdina.Zdravie +" zdravia.");


           }
           else
           {
               Console.WriteLine(nasDruhyHrdina.Meno +" je unaveny");
           }
       }


       if (nasDruhyHrdina.Zdravie == 0 && nasPrvyHrdina.Zdravie == 0)
       {
           Console.WriteLine("Remiza!");
       }
       else if(nasPrvyHrdina.Zdravie == 0)
       {
           Console.WriteLine("Vyhral "+nasDruhyHrdina.Meno);
       }
       else if (nasDruhyHrdina.Zdravie == 0)
       {
           Console.WriteLine("Vyhral "+nasPrvyHrdina.Meno);
       }




       class Hrdina
       {
           public string Meno = "";
           public int Zdravie = 0;
           public int Energia = 0;


           public void StavHrdinu()
           {
               Console.WriteLine("Meno: " + Meno);
               Console.WriteLine("Zdravie: " + Zdravie);
               Console.WriteLine("Energia: " + Energia);
           }


           public void Regeneruj()
           {
               Energia = Energia + 5;
           }


           public int PrijmiZranenie(int sila)
           {
               Zdravie = Zdravie - sila;


               if (Zdravie < 0)
               {
                   Zdravie = 0;
               }


               return Zdravie;
           }


           public bool Utok(int cenaUtoku)
           {
               if (Energia < cenaUtoku)
               {
                   return false;
               }
               else
               {
                   Energia = Energia - cenaUtoku;
                   return true;
               }
           }
       }
*/
  Ucet nasPrvyUcet = new Ucet();
  nasPrvyUcet.Cislo = "1";
  nasPrvyUcet.Majitel = "Janko";
  nasPrvyUcet.Zostatok = 100;

  nasPrvyUcet.VlozPeniaze(50);
  Console.WriteLine(nasPrvyUcet.Zostatok);

  nasPrvyUcet.VyberPeniaze(30);
  Console.WriteLine(nasPrvyUcet.Zostatok);
  Ucet nasDruhyUcet = new Ucet();
  nasDruhyUcet.Cislo = "2";
  nasDruhyUcet.Majitel = "tviler";
  nasDruhyUcet.Zostatok = 50;

  nasDruhyUcet.VlozPeniaze(20);
  Console.WriteLine(nasDruhyUcet.Zostatok);

  nasDruhyUcet.VyberPeniaze(40);
  Console.WriteLine(nasDruhyUcet.Zostatok);
  class Ucet
  {
      public string Cislo = "";
      public decimal Zostatok = 0;
      public string Majitel = "";
      public decimal VlozPeniaze(decimal suma)
      {
          if (suma > 0)
          {
              Zostatok = Zostatok + suma;
          }

          return Zostatok;
      }
      public bool VyberPeniaze(decimal suma)
      {
          if (suma <= 0)
          {
              return false;
          }

          if (Zostatok >= suma)
          {
              Zostatok = Zostatok - suma;
              return true;
          }
          else
          {
              return false;
          }
      }
  }


