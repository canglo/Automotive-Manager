using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    /// <summary>
    /// This class contains functionality that specifically supports the business process of determining a vehicle sales quote for the RRC Automotive Group.
    /// </summary>
    public class SalesQuote
    {
        private decimal _vehicleSalePrice;
        private decimal _tradeInValue;
        private decimal _salesTaxRate;
        private Accessories _accessoriesChosen;
        private ExteriorFinish _exteriorFinishChosen;

        /// <summary>
        /// Gets a decimal representation of the AccessoryCost and switch to its appropriate value
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                decimal cost = 0;

                switch (_accessoriesChosen)
                {
                    case Accessories.None:
                        cost = Accessory.NONE;
                        break;
                    case Accessories.StereoSystem:
                        cost = Accessory.STEREO_SYSTEM;
                        break;
                    case Accessories.LeatherInterior:
                        cost = Accessory.LEATHER_INTERIOR;
                        break;
                    case Accessories.StereoAndLeather:
                        cost = Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR;
                        break;
                    case Accessories.ComputerNavigation:
                        cost = Accessory.COMPUTER_NAVIGATION;
                        break;
                    case Accessories.StereoAndNavigation:
                        cost = Accessory.STEREO_SYSTEM + Accessory.COMPUTER_NAVIGATION;
                        break;
                    case Accessories.LeatherAndNavigation:
                        cost = Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION;
                        break;
                    case Accessories.All:
                        cost = Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION;
                        break;
                }
                return cost;
            }
        }

        /// <summary>
        /// Gets a decimal representation of the FinishCost and switch to its appropriate value
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                decimal cost = 0;

                switch (_exteriorFinishChosen)
                {
                    case ExteriorFinish.None:
                        cost = Finish.NONE;
                        break;
                    case ExteriorFinish.Standard:
                        cost = Finish.STANDARD;
                        break;
                    case ExteriorFinish.Pearlized:
                        cost = Finish.PEARLIZED;
                        break;
                    case ExteriorFinish.Custom:
                        cost = Finish.CUSTOM;
                        break;
                }
                return cost;
            }
        }

        /// <summary>
        /// Gets the Subtotal value
        /// </summary>
        public decimal SubTotal
        {
            get { return _vehicleSalePrice + AccessoryCost + FinishCost; }
        }

        /// <summary>
        /// Gets the SalesTax value
        /// </summary>
        public decimal SalesTax
        {
            get { return (_salesTaxRate / 100) * SubTotal; }
        }

        /// <summary>
        /// Gets the Total value
        /// </summary>
        public decimal Total
        {
            get { return SubTotal + SalesTax; }
        }

        /// <summary>
        /// Gets the AmountDue value
        /// </summary>
        public decimal AmountDue
        {
            get { return Total - _tradeInValue; }
        }

        /// <summary>
        /// Construct a new SalesQuote
        /// </summary>
        /// <param name="vehicleSalePrice">The vehicle sale price</param>
        /// <param name="tradeInValue">The trade in value</param>
        /// <param name="salesTaxRate">The sales tax rate</param>
        /// <param name="accessoriesChosen">The accessories chosen</param>
        /// <param name="exteriorFinishChosen">The exterior finish chosen</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInValue, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            _vehicleSalePrice = vehicleSalePrice;
            _tradeInValue = tradeInValue;
            _salesTaxRate = salesTaxRate;
            _accessoriesChosen = accessoriesChosen;
            _exteriorFinishChosen = exteriorFinishChosen;
        }
    }
}
