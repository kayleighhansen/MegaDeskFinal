using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;


namespace MegaDeskFinal.Models
{
    public class DesktopMaterials
    {
        public int DesktopMaterialId { get; set; }

        public string DesktopMaterialName { get; set; }

        public decimal DeskMaterialPrice { get; set; }
    }

}