using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public interface IHabitat
    {
        void SetName(string name);
        string GetName();
        string GetHabitatType();
    }

    public class Cage : IHabitat
    {
        private string _name;

        public Cage(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetHabitatType()
        {
            return nameof(Cage);
        }

        public void SetName(string name)
        {
            this._name = name;
        }
    }
}
