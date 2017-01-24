using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBreedingProgramme.Contracts;

namespace ZooBreedingProgramme
{
    public class MammelBuilder: AnimalBuilder<IAnimal> //where Mammel : new()
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

        //public override IAnimal GetAnimal()
        //{
        //    if (_chromosome1._iClassification == _chromosome2._iClassification && _chromosome1._iSpecies == _chromosome2._iSpecies)
        //    {
        //        string ChildName = $"{_chromosome1.Name}{_chromosome2.Name} IsAMammel";
        //        ZooLogger.Instance.Log($"New child is born: {ChildName}");
                
        //        return new Animal(ChildName,_chromosome1._iClassification,_chromosome1._iSpecies);
        //    }
        //    else
        //    {
        //        return null;
        //    }
            
        //}
    }
}
