using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attila_2022._02._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.feladat
            //Írj programot, beolvassa a felhasználó nevét, majd köszön neki!
            Console.Write("Kérem adja meg a felhasználónevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine(nev);

            //3.feladat
            //Írj programot, ami beolvas egy számot, majd kiírja a kétszeresét!
            Console.Write("Kérem adjon meg egy számot: ");
            int szam = Convert.ToInt16(Console.ReadLine());
            szam = szam * 2;
            Console.WriteLine(szam);
            

            //4.feladat
            //Írj programot, ami beolvas két számot, majd kiírja:
            //a.az összegüket;
            //b.különbségüket;
            //c.szorzatukat;
            //d.hányadosukat, ha lehet!
            Console.Write("Kérem adjon meg egy egész szamot: ");
            int szam1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Kérem adjon meg egy egész szamot: ");
            int szam2 = Convert.ToInt16(Console.ReadLine());
            int osszege = szam1 + szam2;
            int kulonbseg = szam1 - szam2;
            int szorzata = szam1 * szam2;
            double hanyados = (double)szam1 / szam2;
            Console.WriteLine($"A két szám összege: {osszege}\nkülönbsége: {kulonbseg}\nszorzata: {szorzata}\nhányadosa: {hanyados}");

            //5.feladat
            //Írj programot, mely beolvas két egész számot, és kiírja a képernyőre a
            //nagyobbikat!
            if (szam1 > szam2)
            {
                Console.WriteLine("A {0} nagyobb mint {1}",szam1,szam2);
            }
            else
            {
                Console.WriteLine("A {1} nagyobb mint {0}", szam1, szam2);
            }

            //6.feladat
            //Írj programot, mely beolvas három egész számot, és kiírja a képernyőre a legkisebbet!

            Console.ReadKey();

        }
    }
}
