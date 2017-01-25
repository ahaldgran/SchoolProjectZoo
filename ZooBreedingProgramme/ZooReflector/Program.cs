using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ZooBreedingProgramme;
using ZooBreedingProgramme.Contracts;

namespace ZooReflector
{
    public class dummy
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            var asm = typeof(IAnimal).Assembly.GetTypes();//.Where(x )
            
            foreach (Type t in asm)
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
