using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ZooBreedingProgramme.Contracts;

namespace ZooBreedingProgramme
{
    public class GenericAnimalBuilder<T> : AnimalBuilder<IAnimal> where T : new() 
    {
        private IAnimal _chromosome1;
        private IAnimal _chromosome2;

        public override void Chromosome1(IAnimal chromosome1)
        {
            _chromosome1 = chromosome1;
        }

        public override void Chromosome2(IAnimal chromosome2)
        {
            _chromosome2 = chromosome2;
        }
    }
}
