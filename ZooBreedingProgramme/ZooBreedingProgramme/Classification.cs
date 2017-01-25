﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ZooBreedingProgramme
{
    public interface IClassification
    {
        string Name { get; set; }
        string GetName();
    }

    public class Mammel : IClassification
    {
        public string Name { get; set; }
        public Mammel()
        {
            this.Name = nameof(Mammel);
        }

        public string GetName()
        {
            return Name;
        }


        public void Show()
        {
            
        }

        public string ShowDescription()
        {
            return null;
        }
    }

    public class Reptile : IClassification
    {
        public string Name { get; set; }
        public Reptile()
        {
            this.Name = nameof(Reptile);
        }

        public string GetName()
        {
            return Name;
        }


        public void Show()
        {

        }

        public string ShowDescription()
        {
            return null;
        }
    }

    public class Fish : IClassification
    {
        public string Name { get; set; }
        public Fish()
        {
            this.Name = nameof(Fish);
        }

        public string GetName()
        {
            return Name;
        }


        public void Show()
        {

        }

        public string ShowDescription()
        {
            return null;
        }
    }
}
