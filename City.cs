using System;
using System.Collections.Generic;

namespace planner {

        class City {


        public City(string cityName){
            CityName = cityName;
        }

        public string mayor {get; set;}
        public string CityName {get; set;}
        public int yearMade {get; set;}
        public List<Building> ListOfBuilding = new List<Building>();

        public void AddBuilding(Building building){
            ListOfBuilding.Add(building);
        }

    }









}