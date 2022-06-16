using System;

namespace Zad_2
{
    public class Samochod
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
        public void Jedz(float jakSzybko, float jakDaleko)
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

        public bool Predkosc(float jakSzybko)
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

        public double Tankowanie(float jakDaleko)
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

    public class Kabriolet : Samochod
    {
        private string marka;
        private float poj_baku;
        private float predkosc_max;
        private double zuzycie_paliwa;
        private bool dach_otwarty;


        //Konstruktor domyslny:
        public Kabriolet()
        {
            marka = "nieznana";
            poj_baku = 0;
            predkosc_max = 0;
            zuzycie_paliwa = 0;
            dach_otwarty = false;
        }
        //Konstruktor parametryczny:
        public Kabriolet(string _marka, float _poj_baku, float _predkosc_max, double _zuzycie_paliwa, bool _dach_otwarty)
        {
            marka = _marka;
            poj_baku = _poj_baku;
            predkosc_max = _predkosc_max;
            zuzycie_paliwa = _zuzycie_paliwa;
            dach_otwarty = _dach_otwarty;
        }
        //Metody klasy:
        public bool Otworz_dach(bool dach_otwarty)
        {
            return true;
        }

        public bool Zamknij_dach(bool dach_otwarty)
        {
            return false;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("Peugeot", 50, 180, 5.5);
            s1.Jedz(200, 910);


        }
    }
}
