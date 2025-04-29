using System;

class TamaSymulacja
{
   static void Main(string[] args)
   {
       const int maksymalnaPojemnosc = 1000;
       const double progBezpieczenstwa = 0.9; // 90%
       int aktualnyPoziomWody = 0;
       Random losowy = new Random();
       int dzien = 1;

       while (true)
       {
           Console.WriteLine($"Dzień {dzien}:");

           
           int opad = losowy.Next(0, 151); // od 0 do 150
           aktualnyPoziomWody += opad;
           Console.WriteLine($"Opad deszczu: {opad} jednostek.");

           
           if (aktualnyPoziomWody > maksymalnaPojemnosc)
           {
               aktualnyPoziomWody = maksymalnaPojemnosc;
           }

           Console.WriteLine($"Poziom wody po opadach: {aktualnyPoziomWody} jednostek.");

           
           int prog = (int)(maksymalnaPojemnosc * progBezpieczenstwa);
           if (aktualnyPoziomWody > prog)
           {
               Console.WriteLine("Poziom wody przekroczył próg bezpieczeństwa!");
               int nadmiar = aktualnyPoziomWody - prog;
               Console.WriteLine($"Otwieranie rury spustowej i wypuszczanie {nadmiar} jednostek wody.");
               aktualnyPoziomWody -= nadmiar;
           }

           Console.WriteLine($"Poziom wody na koniec dnia: {aktualnyPoziomWody} jednostek.\n");

         
           Console.WriteLine("Naciśnij Enter, aby przejść do następnego dnia...");
           Console.ReadLine();
           dzien++;
       }
   }
}
