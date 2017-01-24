using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBreedingProgramme.Contracts;

namespace ZooBreedingProgramme
{
    public class RedFish : ISpecies
    {
        private string _name;

        public RedFish(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }
    }
}
