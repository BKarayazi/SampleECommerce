using SampleECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleECommerce.Domain
{
    public class Offer : BaseEntity
    {
        public Decimal OfferAmount { get; set; }     
        public Item Item { get; set; }
        public Guid ItemId { get; set; }
    }
}
