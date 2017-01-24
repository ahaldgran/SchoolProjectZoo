using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme.Contracts
{
    public interface IAnimal
    {
        IClassification _iClassification { get; set; }
        ISpecies _iSpecies { get; set; }
        string Name { get; set; }
        //IAnimal Breed(IAnimal animal1, IAnimal animal2);
        void Show();
        string ShowDescription();
        event EventHandler<BreedEventArgs> ChildCreatedEvent;
    }
}
