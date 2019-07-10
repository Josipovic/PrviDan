using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvidan
{
    class Auto {
        public int TrenutnaBrzina;
        public string Model;
        public int PrijedjeniKilometri;
        public bool Upaljen;

        public Auto()
        {
             TrenutnaBrzina=0;
        Model="Nije postavljen";
         PrijedjeniKilometri=0;
         Upaljen=false;
    }

        public Auto(string Model, int TrenutnaBrzina )
        {
            PrijedjeniKilometri = 0;
            Upaljen = false;

            this.Model = Model;
            this.TrenutnaBrzina = TrenutnaBrzina;

        }

        public void Upali() {
            Upaljen = true;

        }
        public void Ugasi() {
            Upaljen = false;

        }

        public void UbrzajNa100() {

            TrenutnaBrzina = 100;

        }

        public void Ubrzaj(int x) {

            TrenutnaBrzina = x;
        }


    }



    class Trgovina {


        public string Naziv;
        public int BrojRadnika;
        public string RadnoVrijeme;

        public Trgovina()
        {
            RadnoVrijeme = "Od 8 do 1";
        }

        public Trgovina(string Naziv)
        {
            RadnoVrijeme = "Od 8 do 1";
            this.Naziv = Naziv;
        }

        public void Ispis() {

            Console.WriteLine(Naziv);
            Console.WriteLine(BrojRadnika);
            Console.WriteLine(RadnoVrijeme);

        }
        public void PrikaziRadnoVrijeme() {

            Console.WriteLine(RadnoVrijeme);

        }
    }




   // class Lokacija {
      //  public float Longitude;
      //  public float Latitude;

    //}

    /*  class Kuca {

        public int KucniBro;
        public string Adresa;
        public int BrojStanara;
        public Lokacija Lokacija;
        public string BojaKuce;
        public bool NaProdaji;

        public void IspisiInformacije() {
            Console.WriteLine(KucniBro);
            Console.WriteLine(Adresa);
            Console.WriteLine(BrojStanara);
            Console.WriteLine(Lokacija);
            Console.WriteLine(BojaKuce);
            Console.WriteLine(NaProdaji);
            Console.WriteLine(Lokacija.Latitude);
            Console.WriteLine(Lokacija.Longitude);


        }

    }



    class Kupac {
        public string Ime;
        public string Prezime;
        public int Godine;

        public Kupac()
        {
            Ime = "Nije upisano";
            Prezime = "Nije upisano";
           

        }

        public void Ispis() {
            Console.WriteLine(Ime);
            Console.WriteLine(Prezime);
            Console.WriteLine(Godine);


        }
    }     */
    class Program
    {
        static void Main(string[] args)
        {

            Auto bmw = new Auto("bmw1",100);
            



            Trgovina lidl = new Trgovina();
            lidl.PrikaziRadnoVrijeme();
           /* Lokacija lokacija = new Lokacija();
            lokacija.Longitude = 2.1f;
            lokacija.Latitude = 2.3f;
            Kuca a = new Kuca();
            a.Adresa = "Nova adresa";
           
            a.BrojStanara = 3;
            a.KucniBro = 4;
            a.NaProdaji = false;
            a.Lokacija = lokacija;
            a.BojaKuce = "zelena";
            a.IspisiInformacije();


            Kupac k = new Kupac();
            k.Ime = "Katarina";
            k.Prezime = "Josipovic";
            k.Godine = 20;
            k.Ispis();

            
            Console.ReadLine();

          /*  for (int i=1;i<=20;i++) {     //svi kvadrati brojeva do 20
                Console.WriteLine(i*i);
            }

            Console.ReadLine();
            
           */ 
            
            
            
            //  int a = Convert.ToInt32(Console.ReadLine());  //konvertanje u int 
           // int b = int.Parse(Console.ReadLine());

          /* int Iznos;    //shop
            Pocetak:
            Console.WriteLine("Odaberite namirnicu");
            Console.WriteLine("1-Kruh");
            Console.WriteLine("2-Mlijeko");
            Console.WriteLine("3-Brasno");

            int Namirnica = Convert.ToInt32(Console.ReadLine());

            switch (Namirnica) {

                case 1:
                    Iznos = + 5;
                    break;
                case 2:
                    Iznos = +4;
                    break;
                case 3:
                    Iznos = +6;
                    break;
                default:
                    Console.WriteLine("Error izaberite broj izmedju 1-3");
                    goto Pocetak;
                    
                  

            }
            Nastavak:
            Console.WriteLine("Zelite li nastaviti  da/ ne ?");
            string o = Console.ReadLine();
            switch (o.ToLower()) { 
                case "da":
                    goto Pocetak;
                case "ne":
                    break;
                default:
                    Console.WriteLine("Error");
                    goto Nastavak;
            }


            Console.WriteLine("Ukupni iznos racuna je " + Iznos);

    */

        }
    }
}
