using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.IO;
using MegaDeskFinal.Data;

namespace MegaDeskFinal.Models
{
    public class DeskQuote
    {
        public int DeskQuoteId { get; set; }

        [Display(Name = "Customer Name")]  
        public string CustomerName { get; set; }

        [Display(Name = "Quote Price")]  
        public decimal QuotePrice { get; set; }

        public int DeskId { get; set; }
        public Desk Desk { get; set; }

        public int ShippingTypeId { get; set; }


        [Display(Name = "Shipping Type")]  
        public ShippingType ShippingType { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }


        private decimal BASE_DESK_PRICE = 200.00M;
        private decimal SURFACE_AREA_COST = 1.00M;
        private decimal DRAWER_COST = 50.00M;

        public decimal GetQuotePrice(MegaDeskFinalContext context)
        {
            decimal quotePrice = BASE_DESK_PRICE;
            decimal surfaceArea = this.Desk.Depth * this.Desk.Width * this.SURFACE_AREA_COST;
            decimal numOfDrawsCost = this.Desk.NumberOfDrawers * this.DRAWER_COST;
            //decimal desktopMaterialPrice = this.Desk.DesktopMaterial.DeskMaterialPrice;
            decimal desktopMaterialPrice = 0.00M;
            var desktopMaterialPrices = context.DesktopMaterial;
            decimal shippingPrice;

            if (surfaceArea > 1000)
            {
                quotePrice += surfaceArea;
            }

            if (surfaceArea < 1000)
            {
                shippingPrice = this.ShippingType.PriceLessOneThousand;
            }
            else if (surfaceArea <= 2000)
            {
                shippingPrice = this.ShippingType.PriceThousandToTwoThousand;
            }
            else
            {
                shippingPrice = this.ShippingType.PriceGreaterTwoThousand;
            }

            quotePrice += numOfDrawsCost + desktopMaterialPrice + shippingPrice;

            return quotePrice;

        }

        // hold the logic in determining the desk quote total

        //     public decimal GetQuotePrice()
        //     {
        //         getRushOrderPrices();

        //         decimal quotePrice = BASE_DESK_PRICE;

        //         decimal surfaceArea = this.Desk.Depth * this.Desk.Width;

        //         decimal surfacePrice = 0.00M;

        //         if (surfaceArea > 1000)
        //         {
        //             surfacePrice = (surfaceArea - 1000) * SURFACE_AREA_COST;
        //         }

        //         decimal drawerPrice = this.Desk.NumberOfDrawers * DRAWER_COST;

        //         decimal surfaceMaterialPrice = 0.0M;

        //         // switch (this.Desk.desktopMaterial)
        //         // {
        //         //     case DesktopMaterial.Laminate:
        //         //         surfaceMaterialPrice = LAMINATE_COST;
        //         //         break;
        //         //     case DesktopMaterial.Pine:
        //         //         surfaceMaterialPrice = PINE_COST;
        //         //         break;
        //         //     case DesktopMaterial.Oak:
        //         //         surfaceMaterialPrice = OAK_COST;
        //         //         break;
        //         //     case DesktopMaterial.Rosewood:
        //         //         surfaceMaterialPrice = ROSEWOOD_COST;
        //         //         break;
        //         //     case DesktopMaterial.Veneer:
        //         //         surfaceMaterialPrice = VENEER_COST;
        //         //         break;
        //         // }

        //         decimal shippingPrice = 0.00M;

        //         switch (this.shipping)
        //         {
        //             case ShippingType.Rush3Days:
        //                 if (surfaceArea < 1000)
        //                 {
        //                     shippingPrice = _rushOrderPrices[0, 0];
        //                 }
        //                 else if (surfaceArea <= 2000)
        //                 {
        //                     shippingPrice = _rushOrderPrices[0, 1];
        //                 }
        //                 else
        //                 {
        //                     shippingPrice = _rushOrderPrices[0, 2];
        //                 }
        //                 break;

        //             case ShippingType.Rush5Days:
        //                 if (surfaceArea < 1000)
        //                 {
        //                     shippingPrice = _rushOrderPrices[1, 0];
        //                 }
        //                 else if (surfaceArea <= 2000)
        //                 {
        //                     shippingPrice = _rushOrderPrices[1, 1];
        //                 }
        //                 else
        //                 {
        //                     shippingPrice = _rushOrderPrices[1, 2];
        //                 }
        //                 break;

        //             case ShippingType.Rush7Days:
        //                 if (surfaceArea < 1000)
        //                 {
        //                     shippingPrice = _rushOrderPrices[2, 0];
        //                 }
        //                 else if (surfaceArea <= 2000)
        //                 {
        //                     shippingPrice = _rushOrderPrices[2, 1];
        //                 }
        //                 else
        //                 {
        //                     shippingPrice = _rushOrderPrices[2, 2];
        //                 }
        //                 break;
        //         }

        //         quotePrice = quotePrice + surfacePrice + drawerPrice + surfaceMaterialPrice + shippingPrice;

        //         return quotePrice;
        //     }
        //     public void getRushOrderPrices()
        //     {
        //         _rushOrderPrices = new int[3, 3];

        //         var pricesFile = @"../../rushOrderPrices.txt";

        //         try
        //         {
        //             string[] prices = File.ReadAllLines(pricesFile);
        //             int i = 0, j = 0;

        //             foreach (string price in prices)
        //             {
        //                 _rushOrderPrices[i, j] = int.Parse(price);

        //                 if (j == 2)
        //                 {
        //                     i++;
        //                     j = 0;
        //                 }
        //                 else
        //                 {
        //                     j++;
        //                 }
        //             }
        //         }
        //         catch (Exception)
        //         {
        //             throw;
        //         };
        //     }
        // }
    }
}