using System;
using System.Collections.Generic;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");

            Building one = new Building("512 9th Avenue");

            Building two = new Building("512 10th Avenue");

            FiveOneTwoEigth .width = 50;
            FiveOneTwoEigth.depth = 100;
            FiveOneTwoEigth.stories = 15;


            one.width = 25;
            one.depth = 40;
            one.stories = 50;

            two.width = 40;
            two.depth = 15;
            two.stories = 60;

            FiveOneTwoEigth.Construct();
            one.Construct();
            two.Construct();

            FiveOneTwoEigth.Purchase("Bob Smith");
            one.Purchase("Bob Smith");
            two.Purchase("Bob Smith");

            List<Building> buildingList = new List<Building>() {
                FiveOneTwoEigth, one, two
            };
            City megalopolis = new City("Megalopolis");
            megalopolis.mayor= "Joanthan";
            megalopolis.yearMade = 1992; 

        foreach(Building building in buildingList){
            megalopolis.AddBuilding(building);
        }

            List<City> listOfCities = new List<City>(){
                megalopolis
            };

            foreach(City city in listOfCities){
                Console.WriteLine(city.CityName);
                Console.WriteLine($"Established in {city.yearMade}");
                Console.WriteLine($"Mayor name: {city.mayor}");
                Console.WriteLine($"- - - List of Buildings in {city.CityName} - - -");

            foreach(Building building in buildingList){
                Console.WriteLine(building.GetAddress());
                Console.WriteLine("----------");
                Console.WriteLine($"Designed by {building.GetDesginer()}");
                Console.WriteLine($"Cosnstruced on {building.GetDate()}");
                Console.WriteLine($"Owned By {building.GetOwner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space");
                Console.WriteLine(" ");
            }
        }
        }
    }
}
