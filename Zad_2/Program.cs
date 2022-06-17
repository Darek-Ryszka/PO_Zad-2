using System;

namespace Zad_2
{
    public class Samochod //klasa bazowa
    {
        private string marka; 
        private float poj_baku;
        private float predkosc_max;
        private double zuzycie_paliwa;


        //Konstruktor domyslny:
        public Samochod()
        {
            marka = "nieznana";
            poj_baku = 0;
            predkosc_max = 0;
            zuzycie_paliwa = 0;
        }
        //Konstruktor parametryczny:
        public Samochod(string _marka, float _poj_baku, float _predkosc_max, double _zuzycie_paliwa)
        {
            marka = _marka;
            poj_baku = _poj_baku;
            predkosc_max = _predkosc_max;
            zuzycie_paliwa = _zuzycie_paliwa;
        }
        //Metody klasy:
        public virtual void Jedz(float jakSzybko, float jakDaleko)
        {
            if (Predkosc(jakSzybko) == true)
            {
                Console.WriteLine("Samochod pojedzie z predkoscia: " + jakSzybko + " km/h");
                Console.WriteLine("Samochod bedzie musial tankowac " + Tankowanie(jakDaleko) + " razy");
            }
            else
            {
                Console.WriteLine("Podana predkosc przekracza maksymalna predkosc pojazdu wynoszaca: " + predkosc_max + " Podaj prawidlowa predkosc.");
            }
        }

        public virtual bool Predkosc(float jakSzybko)
        {
            if (jakSzybko <= predkosc_max)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public virtual double Tankowanie(float jakDaleko)
        {
            float Dystans100 = jakDaleko / 100;
            double PotrzebnePaliwo = zuzycie_paliwa * Dystans100;
            double Tankowania = PotrzebnePaliwo / poj_baku;
            return (Tankowania);
        }
        //Wlasciwosci klasy:
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public float PojemnoscBaku
        {
            get { return poj_baku; }
            set { poj_baku = value; }
        }

        public float PredkoscMax
        {
            get { return predkosc_max; }
            set { predkosc_max = value; }
        }

        public double ZuzyciePaliwa
        {
            get { return zuzycie_paliwa; }
            set { zuzycie_paliwa = value; }
        }
    }

    public class Kabriolet : Samochod //klasa pochodna
    {   
        private bool dach_otwarty;

         
        //Konstruktor domyslny:
        public Kabriolet()
        {
            dach_otwarty = false;
        }
        //Konstruktor parametryczny:
        public Kabriolet(string _marka, float _poj_baku, float _predkosc_max, double _zuzycie_paliwa, bool _dach_otwarty):
            base(_marka, _poj_baku, _predkosc_max, _zuzycie_paliwa)
        {
            dach_otwarty = _dach_otwarty;
        }
        //Metody klasy:
        public bool Otworz_dach()
        {
            return dach_otwarty = true;
        }

        public bool Zamknij_dach()
        {
            return dach_otwarty = false;
        }
        
        public override void Jedz(float jakSzybko, float jakDaleko)
        {
            if (Predkosc(jakSzybko) == true)
            {
                Console.WriteLine("Samochod pojedzie z predkoscia: " + jakSzybko + " km/h");
                if (dach_otwarty == true)
                {
                    Console.WriteLine("Samochod z otwartym dachem bedzie musial tankowac " + Tankowanie(jakDaleko) * 1.15 + " razy");
                }
                if (dach_otwarty == false)
                {
                    Console.WriteLine("Samochod z zamkniętym dachem bedzie musial tankowac " + Tankowanie(jakDaleko) + " razy");
                }               
            }
            else
            {
                Console.WriteLine("Podana predkosc przekracza maksymalna predkosc pojazdu wynoszaca: " + PredkoscMax + " Podaj prawidlowa predkosc.");
            }
        }
        /*
        //Wlasciwosci klasy:      
        new public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        new public float PojemnoscBaku
        {
            get { return poj_baku; }
            set { poj_baku = value; }
        }

        new public float PredkoscMax
        {
            get { return predkosc_max; }
            set { predkosc_max = value; }
        }

        new public double ZuzyciePaliwa
        {
            get { return zuzycie_paliwa; }
            set { zuzycie_paliwa = value; }
        }
        public bool DachOtwarty
        {
            get { return dach_otwarty; }
            set { dach_otwarty = value; }
        }
        */
    }
    class Program
    {
        static void Main(string[] args)
        {           
            Samochod s1 = new Samochod("Peugeot", 50, 180, 5.5);        //Samochod bazowy do testow
            s1.Jedz(120, 910);

            Samochod s2 = new Samochod("Peugeot", 50, 180, 6.325);      //Zwiekszenie spalania samochodu
            s2.Jedz(120, 910);

            Kabriolet c1 = new Kabriolet("Fiat", 50, 180, 5.5, false);  //Kabriolet o parametrach identycznych jak samochod testowy
            c1.Otworz_dach();                                           //Otwarcie dachu i zwiekszenie spalania
            c1.Jedz(120, 910);

            c1.Zamknij_dach();                                          //Zamkniecie dachu i zmniejszenie spalania
            c1.Jedz(120, 910);

            Kabriolet c2 = new Kabriolet("Fiat", 50, 180, 6.3, false);  //Kabriolet numer 2  
            c2.Jedz(200, 910);                                          //Proba przekroczenia maksymalnej predkosci
        }
    }
}
