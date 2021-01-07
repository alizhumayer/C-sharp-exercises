using System;
using System.IO; // 10. feladat

namespace OkjKiralynok
{
    class Tábla // 1. feladat
    {
        char[,] T; // 2. feladat
        char ÜresCella; // 2. feladat
        static Random R = new Random(); // 5. feladat

        public Tábla(char üresCella) // 3. feladat
        {
            T = new char[8, 8]; // 3.a
            ÜresCella = üresCella; // 3.b
            for (int i = 0; i < 8; i++) // 3.c
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = ÜresCella; // 3.c
                }
            }
        }

        public void Megjelenít() // 4. feladat
        {
            for (int sor = 0; sor < 8; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    Console.Write($"{T[sor, oszlop]}");
                }
                Console.WriteLine();
            }
        }

        public void Elhelyez(int n) // 5. feladat
        {
            for (int i = 0; i < n;)
            {
                int sor = R.Next(0, 8);
                int oszlop = R.Next(0, 8);
                if (T[sor, oszlop] == ÜresCella)
                {
                    T[sor, oszlop] = 'K';
                    i++;
                }
            }
        }

        public bool ÜresSor(int sorAzon) // 7. feladat
        {
            for (int oszlop = 0; oszlop < 8; oszlop++)
            {
                if (T[sorAzon, oszlop] != ÜresCella) return false;
            }
            return true;
        }

        public bool ÜresOszlop(int oszlopAzon) // 7. feladat
        {
            for (int sor = 0; sor < 8; sor++)
            {
                if (T[sor, oszlopAzon] != ÜresCella) return false;
            }
            return true;
        }

        public int ÜresOszlopokSzáma // 8. feladat
        {
            get
            {
                int üresDb = 0;
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    if (ÜresOszlop(oszlop)) üresDb++;
                }
                return üresDb;
            }
        }

        public int ÜresSorokSzáma // 8. feladat
        {
            get
            {
                int üresDb = 0;
                for (int sor = 0; sor < 8; sor++)
                {
                    if (ÜresSor(sor)) üresDb++;
                }
                return üresDb;
            }
        }

        public void FájlbaÍr(StreamWriter sw) // 10. feladat 
        {
            for (int sor = 0; sor < 8; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    sw.Write($"{T[sor, oszlop]}");
                }
                sw.WriteLine();
            }
            sw.WriteLine();
        }
    }
}