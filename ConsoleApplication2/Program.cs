using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            RechteckModel objekt1VonRechteck = new RechteckModel();
            objekt1VonRechteck.setLength(1.5);
            objekt1VonRechteck.setWidth(1.5);

            RechteckModel objekt2VonRechteck = new RechteckModel(2.0,2.0);

            RechteckService objectVonRechteckService = new RechteckService();

            Console.WriteLine("Rechteck1: " + objectVonRechteckService.BerechneFlaeche(objekt1VonRechteck));
            Console.WriteLine("Rechteck2: " + objectVonRechteckService.BerechneFlaeche(objekt2VonRechteck));

            Console.ReadLine();
        }
    }
}
