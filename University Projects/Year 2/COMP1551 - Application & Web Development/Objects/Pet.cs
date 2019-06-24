using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace friendsWithPaws
{
    public class Pet
    {

        int PetID;

        public int petId
        {
            get { return PetID; }
            set { PetID = value; }
        }

        string PetName;
        public string petName
        {
            get { return PetName; }
            set { PetName = value; }
        }

        public Pet(int id, string petName)
        {
           PetID = id;
           PetName = petName;
        }
    }
}