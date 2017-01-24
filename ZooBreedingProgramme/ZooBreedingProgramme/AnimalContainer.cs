using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBreedingProgramme.Contracts;

namespace ZooBreedingProgramme
{
    public class AnimalContainer
    {
        public IAnimal animal { get; set; }
        public IHabitat iHabitat { get; set; }

        public AnimalContainer(IAnimal animal, IHabitat iHabitat)
        {
            this.animal = animal;
            this.iHabitat = iHabitat;

            ZooLogger.Instance.Log($"{animal.Name} placed in habitat {iHabitat.GetHabitatType()} {iHabitat.GetName()}");
        }

        public void ChangeHabitat(IHabitat iHabitat)
        {
            this.iHabitat = iHabitat;
            ZooLogger.Instance.Log($"{animal.Name} moved to habitat {iHabitat.GetHabitatType()} {iHabitat.GetName()}");
        }


    }
}
