using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SampleECommerce.Domain.Common;

using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleECommerce.Domain
{
    public class Item : BaseEntity
    {
        public string Barcode { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
        public List<Offer> Offers { get; set; }

    }
}
