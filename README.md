# PO_Zad_2

Program do zadania w ramach przemiotu Programowanie obiektowe.

Treść zadania:

1. Napisać klasę Samochod posiadającą następujące pola prywatne:
    marka,
    poj_baku,
    predkosc_max,
    zuzycia_paliwa.
2. Ma ona posiadać następujące funkcje publiczne:
    konstruktor ustawiający wszystkie pola na podstawie swoich parametrów,
    jedz(float jakSzybko, float jakDaleko) – wyświetla komunikat mówiący jak
    szybko samochód pojedzie (nie szybciej niż predkosc_max) i ile razy po drodze
    będzie musiał tankować.
3. Następnie napisać klasę Kabriolet dziedziczącą po klasie Samochod. Ma ona
    dodatkowo posiadać pole logiczne dach_otwarty ustawiane w konstruktorze na
    false oraz funkcje:
    otworz_dach,
    zamknij_dach.
4. Należy zmodyfikować funkcję jedz biorąc pod uwagę, że z otwartym dachem
kabriolet pali o 15% więcej.
