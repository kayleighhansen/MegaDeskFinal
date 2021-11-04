using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Desk
    {
        public int DeskId { get; set; }
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_DESK_DRAWERS = 0;
        public const short MAX_DESK_DRAWERS = 7;

        public int ID { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
         public int NumberOfDrawers { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public DesktopMaterial desktopMaterial { get; set; }
    }

}