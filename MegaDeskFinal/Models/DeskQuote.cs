using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;

namespace RazorPagesMovie.Models
{
    public enum ShippingType
    {
        //public int ShippingTypeId { get; set; }

        [Description("Rush 3 Days")]
        Rush3Days,

        [Description("Rush 5 Days")]
        Rush5Days,

        [Description("Rush 7 Days")]
        Rush7Days,

        [Description("No Rush")]
        NoRush
    }
    public class DeskQuote
    {
        public int DeskQuoteId { get; set; }
        private int[,] _rushOrderPrices;
        private decimal BASE_DESK_PRICE = 200.00M;
        private decimal SURFACE_AREA_COST = 1.00M;
        private decimal DRAWER_COST = 50.00M;
        // private decimal OAK_COST = 200.00M;
        // private decimal LAMINATE_COST = 100.00M;
        // private decimal PINE_COST = 50.00M;
        // private decimal ROSEWOOD_COST = 300.00M;
        // private decimal VENEER_COST = 125.00M;

        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuoteAmount { get; set; }
        public ShippingType shipping { get; set; }

        // hold the logic in determining the desk quote total

        public decimal GetQuotePrice()
        {
            getRushOrderPrices();

            decimal quotePrice = BASE_DESK_PRICE;

            decimal surfaceArea = this.Desk.Depth * this.Desk.Width;

            decimal surfacePrice = 0.00M;

            if (surfaceArea > 1000)
            {
                surfacePrice = (surfaceArea - 1000) * SURFACE_AREA_COST;
            }

            decimal drawerPrice = this.Desk.NumberOfDrawers * DRAWER_COST;

            decimal surfaceMaterialPrice = 0.0M;

            // switch (this.Desk.desktopMaterial)
            // {
            //     case DesktopMaterial.Laminate:
            //         surfaceMaterialPrice = LAMINATE_COST;
            //         break;
            //     case DesktopMaterial.Pine:
            //         surfaceMaterialPrice = PINE_COST;
            //         break;
            //     case DesktopMaterial.Oak:
            //         surfaceMaterialPrice = OAK_COST;
            //         break;
            //     case DesktopMaterial.Rosewood:
            //         surfaceMaterialPrice = ROSEWOOD_COST;
            //         break;
            //     case DesktopMaterial.Veneer:
            //         surfaceMaterialPrice = VENEER_COST;
            //         break;
            // }

            decimal shippingPrice = 0.00M;

            switch (this.shipping)
            {
                case ShippingType.Rush3Days:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = _rushOrderPrices[0, 0];
                    }
                    else if (surfaceArea <= 2000)
                    {
                        shippingPrice = _rushOrderPrices[0, 1];
                    }
                    else
                    {
                        shippingPrice = _rushOrderPrices[0, 2];
                    }
                    break;

                case ShippingType.Rush5Days:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = _rushOrderPrices[1, 0];
                    }
                    else if (surfaceArea <= 2000)
                    {
                        shippingPrice = _rushOrderPrices[1, 1];
                    }
                    else
                    {
                        shippingPrice = _rushOrderPrices[1, 2];
                    }
                    break;

                case ShippingType.Rush7Days:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = _rushOrderPrices[2, 0];
                    }
                    else if (surfaceArea <= 2000)
                    {
                        shippingPrice = _rushOrderPrices[2, 1];
                    }
                    else
                    {
                        shippingPrice = _rushOrderPrices[2, 2];
                    }
                    break;
            }

            quotePrice = quotePrice + surfacePrice + drawerPrice + surfaceMaterialPrice + shippingPrice;

            return quotePrice;
        }
        public void getRushOrderPrices()
        {
            _rushOrderPrices = new int[3, 3];

            var pricesFile = @"../../rushOrderPrices.txt";

            try
            {
                string[] prices = File.ReadAllLines(pricesFile);
                int i = 0, j = 0;

                foreach (string price in prices)
                {
                    _rushOrderPrices[i, j] = int.Parse(price);

                    if (j == 2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            };
        }
    }
}