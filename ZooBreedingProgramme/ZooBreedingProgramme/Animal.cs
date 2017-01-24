using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBreedingProgramme.Contracts;

namespace ZooBreedingProgramme
{
   

    public class Animal : IAnimal
    {
        public IClassification _iClassification { get; set; }
        public ISpecies _iSpecies { get;  set; }
        public string Name { get; set; }

        public Animal()
        {
        }
        public Animal(string name, IClassification iClassification, ISpecies iSpecies, Action<IAnimal> mutateAction=null)
        {
            this.Name = name;
            this._iClassification = iClassification;
            this._iSpecies = iSpecies;
            mutateAction?.Invoke(this);
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
        //public IAnimal Breed(Func<IAnimal,IAnimal,IAnimal>   )



        //public IAnimal Breed(IAnimal animal1, IAnimal animal2)
        //{
        //    if (animal1._iClassification.Name == animal2._iClassification.Name && animal1._iSpecies.GetName() == animal2._iSpecies.GetName())
        //    {
        //        this.Name= $"{animal1.Name}{animal2.Name} IsA{animal1._iSpecies.GetName()}";
        //        this._iClassification = animal1._iClassification;
        //        this._iSpecies = animal1._iSpecies;
        //        //Event

        //        OnChildCreatedEvent(new BreedEventArgs(this));
        //        return this;
        //    }
        //    return new Animal();
        //}


        protected virtual void OnChildCreatedEvent(BreedEventArgs e)
        {
            ChildCreatedEvent?.Invoke(this,e);
        }

        public event EventHandler<BreedEventArgs> ChildCreatedEvent;
    }
    
}
