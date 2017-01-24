using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public interface IAnimal
    {
        IClassification _iClassification { get; set; }
        ISpecies _iSpecies { get; set; }
        string Name { get; set; }
        IAnimal Breed(IAnimal animal1, IAnimal animal2);
        void Show();
        string ShowDescription();
    }

    public class Animal : IAnimal
    {
        public IClassification _iClassification { get; set; }
        public ISpecies _iSpecies { get;  set; }
        public string Name { get; set; }

        public Animal()
        {
        }

        public Animal(string name, IClassification iClassification, ISpecies iSpecies)
        {
            this.Name = name;
            this._iClassification = iClassification;
            this._iSpecies = iSpecies;
            ZooLogger.Instance.Log("Animal constructed: " + ShowDescription());
        }

        public void Show()
        {
            ZooLogger.Instance.Log("Showing: " + ShowDescription());
            Console.WriteLine("Showing: " + ShowDescription());
        }

        public string ShowDescription()
        {
            return
                $"{Name} belongs to classifation {_iClassification.GetName()} within the species of {_iSpecies.GetName()}s";
        }

        public IAnimal Breed(IAnimal animal1, IAnimal animal2)
        {
            if (animal1._iClassification.Name == animal2._iClassification.Name && animal1._iSpecies.GetName() == animal2._iSpecies.GetName())
            {
                this.Name= $"{animal1.Name}{animal2.Name} IsA{animal1._iSpecies.GetName()}";
                this._iClassification = animal1._iClassification;
                this._iSpecies = animal1._iSpecies; 
                return this;
                //    string ChildName = $"{_chromosome1.Name}{_chromosome2.Name} IsAMammel";
                //    ZooLogger.Instance.Log($"New child is born: {ChildName}");
                //    return new Animal(ChildName, _chromosome1._iClassification, _chromosome1._iSpecies);
            }
            return new Animal();
        }
    }
}
