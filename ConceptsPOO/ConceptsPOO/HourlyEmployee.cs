using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHeures................: {$"{Hours:N2}", 18}" +
                $"\n\tMontant horaire.......: {$"{HourValue:C2}", 18}" +
                $"\n\tMontant à payer.......: {$"{GetValueToPay():C2}",18}";
        }
    }
}
