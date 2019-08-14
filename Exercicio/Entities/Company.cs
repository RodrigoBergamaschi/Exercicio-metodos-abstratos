using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio.Entities
{
    class Company : Subscribing
    {
        public int employeesNumber { get; set; }



        public Company(string name, double annualIncome, int employeesnumber) : base(name, annualIncome)
        {
            employeesNumber = employeesnumber;
        }

        public override double Tax()
        {
            double tax;
            if (employeesNumber >= 10)
            {
                tax = annualIncome * 0.14;
            }
            else
            {
                tax = annualIncome * 0.16;
            }
            return tax;
        }

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

   

}
