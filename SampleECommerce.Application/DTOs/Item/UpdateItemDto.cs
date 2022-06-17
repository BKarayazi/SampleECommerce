using SampleECommerce.Application.DTOs.Common;
using SampleECommerce.Application.DTOs.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleECommerce.Application.DTOs.Item
{
    public class UpdateItemDto : BaseDto, IItemDto
    {
        public string Barcode { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

    }
}
