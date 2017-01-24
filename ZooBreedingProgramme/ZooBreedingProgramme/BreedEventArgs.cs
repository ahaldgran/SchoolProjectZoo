using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBreedingProgramme.Contracts;

namespace ZooBreedingProgramme
{
    public class BreedEventArgs : EventArgs
    {
        private IAnimal newAnimal;

        public BreedEventArgs(IAnimal animal)
        {
            newAnimal = animal; 
        }

        public IAnimal NewAnimal
        {
            get { return newAnimal; }
        }


    }
}
