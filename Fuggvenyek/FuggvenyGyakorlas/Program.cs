﻿namespace FuggvenyGyakorlas
{
    internal class Program
    {

        public static int BetuSzamol(string szoveg,char betu)
        {
            int db = 0;

            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == betu || szoveg[i] == betu)
                {
                    db++;
                }
            }


            return db;
        }

        //érték szerinti paraméterátadás
        public static int Negyzet(int a)
        {
            a = a * a;
            return a;
        }

        //cím szerinti paraméterátadás

        public static int Negyzet(ref int a)
        {
            a = a * a;
            return a;
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Írjon függvényt, amely a kapott string-ben megszámolja az 'a' betűk számát (írásmódtól függetlenül) és visszatérési értékként visszaadja azt

            Console.WriteLine(BetuSzamol("valami,bármi akármi",'a'));
            Console.WriteLine(BetuSzamol("valami,bármi akármi", 'm'));
            int x = 3;
            Console.WriteLine(Negyzet(x));
            Console.WriteLine($"X értéke:{x}");

            Console.WriteLine(Negyzet(ref x));
            Console.WriteLine($"X értéke:{x}");





        }
    }
}