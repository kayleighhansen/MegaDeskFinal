using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;

namespace RazorPagesMovie.Models
{
    public enum ShippingType
    {
        [Description("Rush 3 Days")]
        Rush3Days,

        [Description("Rush 5 Days")]
        Rush5Days,

        [Description("Rush 7 Days")]
        Rush7Days,

        [Description("No Rush")]
        NoRush
    }
}