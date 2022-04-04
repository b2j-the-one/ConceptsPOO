﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public abstract class Employee : Ipay
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} - {LastName}, " +
                $"Date de naissance: {BirthDate}, " +
                $"Date d'embauche: {HiringDate}, " +
                $"Est actif: {IsActive}";
        }
    }
}
