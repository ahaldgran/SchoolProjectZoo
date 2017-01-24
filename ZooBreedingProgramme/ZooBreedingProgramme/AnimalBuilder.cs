using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public interface IAnimalBuilder<T>
    {
        void Chromosome1(T chromesome1);
        void Chromosome2(T chromesome2);
        //T GetAnimal();
    }

    public abstract class AnimalBuilder<T> : IAnimalBuilder<T> where T: IAnimal
    {
        public abstract void Chromosome1(T chromesome1);
        public abstract void Chromosome2(T chromesome2);
        //public abstract T GetAnimal();
    }
}
