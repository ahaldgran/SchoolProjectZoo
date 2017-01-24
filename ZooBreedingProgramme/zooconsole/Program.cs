using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooBreedingProgramme;

namespace zooconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ZooLogger.Instance.Log("Create new ZooDirector");
            Console.WriteLine();

            GenericAnimalBuilder<Mammel> genericAnimalBuilder = new GenericAnimalBuilder<Mammel>();

            IHabitat cage1 = new Cage("No1");
            IHabitat cage2 = new Cage("No2");

            AnimalContainer animalContainer1 = new AnimalContainer(new Animal("Bob", new Mammel(), new Monkey("Gorilla")), cage1);
            AnimalContainer animalContainer2 = new AnimalContainer(new Animal("Marly", new Mammel(), new Monkey("Gorilla")), cage2);
            genericAnimalBuilder.Chromosome1(animalContainer1.animal);
            genericAnimalBuilder.Chromosome2(animalContainer2.animal);

            animalContainer1.animal.ChildCreatedEvent += Animal_ChildCreatedEvent;

            IAnimal childAnimal = animalContainer1.animal.Breed(animalContainer1.animal, animalContainer2.animal);
            childAnimal.Show();
            AnimalContainer animalContainer3 = new AnimalContainer(childAnimal,cage2);
            animalContainer1.ChangeHabitat(cage2);

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Animal_ChildCreatedEvent(object sender, BreedEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Animal created: is " + e.NewAnimal._iClassification.Name);
            Console.ResetColor();
        }
    }
}
