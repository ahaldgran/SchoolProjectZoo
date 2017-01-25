using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public static class Exstensionmethods
    {

        public static int GetNumbersOfGorillas(this List<Animal> listofAnimals )
        {
           var listofMonkeys =  listofAnimals.Where(a => a._iSpecies.GetName() == "Gorilla");

            return listofMonkeys.Count();

        }

    }
}
