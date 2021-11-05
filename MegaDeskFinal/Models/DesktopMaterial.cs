using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class DesktopMaterials
    {
        public int DesktopMaterialId { get; set; }

        public string DesktopMaterialName { get; set; }

        public decimal DeskMaterialPrice { get; set; }
    }

}