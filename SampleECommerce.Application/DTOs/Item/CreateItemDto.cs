using SampleECommerce.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleECommerce.Application.DTOs.Item
{
    public class CreateItemDto
    {
        public string Barcode { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}
