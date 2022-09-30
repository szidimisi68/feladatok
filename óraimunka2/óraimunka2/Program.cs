using System;

namespace óraimunka2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("kérem az adott napot: ");
            int hetNapja = Convert.ToInt32(Console.ReadLine());

            if (0 < hetNapja && hetNapja < 6)
            {
                Console.WriteLine("Hétköznap");
            }

            else if (5 < hetNapja && hetNapja < 8)
            {
                Console.WriteLine("hétvége");
            }

            else
            {
                Console.WriteLine("Rossz adat");
            }


            switch (hetNapja)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Hétköznap");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Hétvége");
                    break;

                default:
                    Console.WriteLine("Rossz adat");
                    break;
            }
            */



            //4.19

            /*
            Console.Write("kérem a létszámot: ");
            double letszam = Convert.ToInt32(Console.ReadLine());

            //Csoportos kedv
            double csoportosKedvezmeny = 0;
            if (9 < letszam && letszam < 20)
            {
                csoportosKedvezmeny = 0.05;
            }

            else if (19 < letszam && letszam < 30)
            {
                csoportosKedvezmeny = 0.08;
            }

            else if (29 < letszam && letszam < 41)
            {
                csoportosKedvezmeny = 0.12;
            }

            else if (letszam > 40)
            {
                csoportosKedvezmeny = 0.14;
            }


            //Intézményi kedvezmény
            double intezmenyiKedvezmeny = 0;
            if (4 < letszam && letszam < 12)
            {
                intezmenyiKedvezmeny = 1 - (letszam - 1) / letszam;
            }

            else if (11 < letszam && letszam < 20)
            {
                intezmenyiKedvezmeny = 1 - (letszam - 2) / letszam;
            }

            else if (19 < letszam && letszam < 29)
            {
                intezmenyiKedvezmeny = 1 - (letszam - 3) / letszam;
            }

            else if (28 < letszam && letszam < 41)
            {
                intezmenyiKedvezmeny = 1 - (letszam - 4) / letszam;
            }

            else if (letszam > 40)
            {
                intezmenyiKedvezmeny = 1 - (letszam - 5) / letszam;
            }

            double diakKedvezmeny = 0.10; 

            //printelés
            if ( diakKedvezmeny < csoportosKedvezmeny && csoportosKedvezmeny > intezmenyiKedvezmeny)
            {
                Console.WriteLine("A csoportos kedvezmény a jobb, " + csoportosKedvezmeny*100 + "%");
            }

            else if (diakKedvezmeny < intezmenyiKedvezmeny && intezmenyiKedvezmeny > csoportosKedvezmeny)
            {
                Console.WriteLine("Az intézmény kedvezmény a jobb, " + intezmenyiKedvezmeny*100 + "%");
            }

            else
            {
                Console.WriteLine("A diákkedvezmény a jobb, " + diakKedvezmeny*100 + "%");
            }
            */




            //5.20
            Console.Write("Hány évre?: ");
            double evekSzama = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mekkora összeg?: ");
            double osszeg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hány százalék a kamat?: ");
            double kamat = Convert.ToInt32(Console.ReadLine()) /100;

            double kamatEredmeny = 0;

            kamatEredmeny = osszeg * (1 + kamat * evekSzama);

            Console.WriteLine("a kamat eredmény " + evekSzama + " év múlva: " + kamatEredmeny + "Ft.");

        }
    }
}
