using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme.Contracts
{
    public interface ISpecies
    {
        void SetName(string name);
        string GetName();
    }
}
