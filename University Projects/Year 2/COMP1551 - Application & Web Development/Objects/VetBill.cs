using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace friendsWithPaws.Objects
{
    public class VetBill
    {
        int PetID;
        String PetName;
        Double HousingCosts;
        Double FoodCostPerKG;
        Double PetWeight;
        Double vaccines;
        Double Neutering_Procedures;
        Double Id_Chipping;
        Double Flea_Spraying;
        Double Worming_Pills;
        Double Total;

        public VetBill(int petID, string petName, double housingCosts, double foodCostPerKG, double petWeight, double vaccines, double neutering_Procedures, double id_Chipping, double flea_Spraying, double worming_Pills,double total)
        {
            PetID = petID;
            PetName = petName;
            HousingCosts = housingCosts;
            FoodCostPerKG = foodCostPerKG;
            PetWeight = petWeight;
            this.vaccines = vaccines;
            Neutering_Procedures = neutering_Procedures;
            Id_Chipping = id_Chipping;
            Flea_Spraying = flea_Spraying;
            Worming_Pills = worming_Pills;
            Total = total;
          
        }

        public int PetID1{ get => PetID; set => PetID = value; }
        public string PetName1 { get => PetName; set => PetName = value; }
        public double HousingCosts1 { get => HousingCosts; set => HousingCosts = value; }
        public double FoodCostPerKG1 { get => FoodCostPerKG; set => FoodCostPerKG = value; }
        public double PetWeight1 { get => PetWeight; set => PetWeight = value; }
        public double Vaccines { get => vaccines; set => vaccines = value; }
        public double Neutering_Procedures1 { get => Neutering_Procedures; set => Neutering_Procedures = value; }
        public double Id_Chipping1 { get => Id_Chipping; set => Id_Chipping = value; }
        public double Flea_Spraying1 { get => Flea_Spraying; set => Flea_Spraying = value; }
        public double Worming_Pills1 { get => Worming_Pills; set => Worming_Pills = value; }
        public double Total1 { get => Total; set => Total = value; }


    }
}