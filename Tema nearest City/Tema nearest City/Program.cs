using System;

namespace Tema_nearest_City
{
    class Program
    {
        static void Main(string[] args)
        {
            Oras Huedin = new Oras(4, 7, "Huedin");
            Oras Oradea = new Oras(2, 6, "Oradea");
            Oras Arad = new Oras(3, 8, "Arad");
            Oras Dej = new Oras(5, 3, "Dej");
            Oras Brasov = new Oras(6, 9, "Brasov");

            string input = Console.ReadLine();
            Oras cityToCompare = new Oras();
            Oras[] orase = { Huedin, Oradea, Arad, Dej, Brasov };
            double smallestdistance = 0;
            string nameOfNearestCity = string.Empty;

            for (int i = 0; i < orase.Length; i++)
            {

                if (orase[i].CityName.Equals(input))
                {
                    cityToCompare = orase[i];
                }
            }

            for (int i = 0; i < orase.Length; i++)
            {
                if (orase[i].CityName.Equals(cityToCompare.CityName))
                {
                    continue;
                }

                var currentDistance = Math.Sqrt(Math.Pow(cityToCompare.FirstCoordonate - orase[i].FirstCoordonate, 2) + Math.Pow(cityToCompare.SecondCoordonate - orase[i].SecondCoordonate, 2));

                if(smallestdistance == 0)
                {
                    smallestdistance = currentDistance;
                }

                if (currentDistance <= smallestdistance)
                {
                    smallestdistance = currentDistance;
                    nameOfNearestCity = orase[i].CityName;
                }
            }

            Console.WriteLine("Cel mai apropiat oras este : " +  nameOfNearestCity);
        }
    }
}

