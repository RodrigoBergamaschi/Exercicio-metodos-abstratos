using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio.Entities
{
    class Individual : Subscribing
    {
        public double expensesHealth { get; set; }

        public Individual(string name, double annualincome, double healthspend) : base(name, annualincome)
        {
            expensesHealth = healthspend;
        }

        public override double Tax()
        {
            double tax;
            if (annualIncome < 20000)
            {
                tax = annualIncome * 0.15 - expensesHealth * 0.5;
            }
            else
            {
                tax = annualIncome * 0.25 - expensesHealth * 0.5;
            }

            return tax;
        }
        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
