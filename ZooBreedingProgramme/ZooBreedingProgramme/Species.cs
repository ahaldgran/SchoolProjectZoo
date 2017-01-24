using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public interface ISpecies
    {
        void SetName(string name);
        string GetName();
    }

    public class Monkey : ISpecies
    {
        private string _name;

        public Monkey(string name)
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
