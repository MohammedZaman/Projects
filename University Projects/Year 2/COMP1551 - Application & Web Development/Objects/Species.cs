using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace friendsWithPaws
{
    public class Species
    {
        int SpeciesId;

        public int SpeciesID
        {
            get { return SpeciesId; }
            set { SpeciesId = value; }
        }
        string PetSpecies;

        public string PetSpecie
        {
            get { return PetSpecies; }
            set { PetSpecies = value; }
        }

        public Species(int id, string species)
        {
            SpeciesId = id;
            PetSpecies = species;
        }

        public static implicit operator Species(int v)
        {
            throw new NotImplementedException();
        }
    }
}