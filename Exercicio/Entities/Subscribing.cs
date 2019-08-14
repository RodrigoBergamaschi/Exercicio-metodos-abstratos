using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities
{
    abstract class Subscribing
    {
        public string Name { get; set; }
        public double annualIncome { get; set; }

        protected Subscribing(string name, double annualIncome)
        {
            Name = name;
            this.annualIncome = annualIncome;
        }

        public abstract double Tax();
       
    }
}
