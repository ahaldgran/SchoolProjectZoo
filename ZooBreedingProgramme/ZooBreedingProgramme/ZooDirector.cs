using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public class ZooDirector
    {
#pragma warning disable CS0649 // Field 'ZooDirector._animals' is never assigned to, and will always have its default value null
        private List<AnimalContainer> _animalContainers =new List<AnimalContainer>();

#pragma warning restore CS0649 // Field 'ZooDirector._animals' is never assigned to, and will always have its default value null

        public List<AnimalContainer> AddAnimals(AnimalContainer animalContainer)
        {
            _animalContainers.Add(animalContainer);

            return _animalContainers;
        }

        public IEnumerable<AnimalContainer> GetAnimals()
        {
            return _animalContainers;
        }

#pragma warning disable CS0161 // 'ZooDirector.BreedAnimal(Animal, Animal)': not all code paths return a value
        //public void BreedConstructor(AnimalBuilder animalBuilder)
        //{
        //    animalBuilder.Chromosom1(animalBuilder.Chromosom1());
        //}
    }
}
