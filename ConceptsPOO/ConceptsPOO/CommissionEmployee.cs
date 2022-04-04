using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentage { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentage;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tPourcentage commission: {$"{CommissionPercentage:P2}", 18}" +
                $"\n\tVentes................: {$"{Sales: C2}", 18}" +
                $"\n\tMontant à payer.......: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
