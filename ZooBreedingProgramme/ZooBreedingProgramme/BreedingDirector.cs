using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public class BreedingDirector
    {
#pragma warning disable CS0649 // Field 'ZooDirector._animals' is never assigned to, and will always have its default value null

#pragma warning disable CS0161 // 'ZooDirector.BreedAnimal(Animal, Animal)': not all code paths return a value
        public IAnimal BreedAnimal(GenericAnimalBuilder<Animal> genericAnimalBuilder)
#pragma warning restore CS0161 // 'ZooDirector.BreedAnimal(Animal, Animal)': not all code paths return a value
        {
            return genericAnimalBuilder.GetAnimal();
        }
    }
}
