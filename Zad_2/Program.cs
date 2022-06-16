﻿using System;

namespace Zad_2
{
    public class Samochod
    {
        private string marka;
        private float poj_baku;
        private float predkosc_max;
        private float zuzycie_paliwa;


        //Konstruktor domyslny:
        public Samochod()
        {
            marka = "nieznana";
            poj_baku = 0;
            predkosc_max = 0;
            zuzycie_paliwa = 0;
        }
        //Konstruktor parametryczny:
        public Samochod(string _marka, float _poj_baku, float _predkosc_max, float _zuzycie_paliwa)
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
            }
            else
            {
                Console.WriteLine("Podana predkosc przekracza maksymalna predkosc pojazdu, wyznoszaca: " + predkosc_max + " Podaj prawidlowa predkosc.");
            }

        }

        public bool Predkosc(float jakSzybko)
        {
            if (jakSzybko <= predkosc_max)
            {
                return(true);
            }
            else
            {
                return (false);
            }
        }

    }



        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
