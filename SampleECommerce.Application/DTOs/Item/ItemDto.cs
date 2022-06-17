using SampleECommerce.Application.DTOs.Common;
using SampleECommerce.Application.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleECommerce.Application.DTOs.Item
{
    public class ItemDto
    {
        public string Barcode { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}
