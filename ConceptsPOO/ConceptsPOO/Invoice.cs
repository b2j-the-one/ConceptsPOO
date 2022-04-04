using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Invoice : Ipay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public float Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tQuantité.......: {$"{Quantity:N2}", 18}" + 
                $"\n\tPrix...........: {$"{Price:C2}", 18}" + 
                $"\n\tValeur.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
