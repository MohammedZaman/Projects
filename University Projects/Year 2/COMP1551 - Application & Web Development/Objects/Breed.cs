using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace friendsWithPaws
{
    public class Breed
    {
       
        int BreedId;
        double FoodCostPerKG;
        double HousingCosts;

        public int BreedID
        {
            get { return BreedId; }
            set { BreedId = value; }
        }
        string PetBreed;

     


        public string breed
        {
            get { return PetBreed; }
            set { PetBreed = value; }
        }

        
        public Species SpeciesID
        {
            get { return SpeciesID; }
            set { SpeciesID = value; }
        }

        public double FoodCostPerKG1 { get => FoodCostPerKG; set => FoodCostPerKG = value; }
        public double HousingCosts1 { get => HousingCosts; set => HousingCosts = value; }

        public Breed(int id, string breed,double foodCostPerKg,double housingCost)
        {
            BreedId = id;
            PetBreed = breed;
            FoodCostPerKG = foodCostPerKg;
            HousingCosts = housingCost;
  
        }

       
    }
}