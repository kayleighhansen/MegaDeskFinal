using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Desk
    {
        public int ID { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial desktopMaterial { get; set; }
    }
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
}