using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;


namespace MegaDeskFinal.Models
{
    public class ShippingType
    {
        public int ShippingTypeId { get; set; }
        public string ShippingTypeName { get; set; }
        public int PriceLessOneThousand { get; set; }
        public int PriceThousandToTwoThousand { get; set; }
        public int PriceGreaterTwoThousand { get; set; }
    }

}