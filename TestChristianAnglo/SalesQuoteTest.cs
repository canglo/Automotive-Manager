using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTier;

namespace TestChristianAnglo
{
    [TestClass]
    public class SalesQuoteTest
    {
        [TestMethod]
        public void SalesQuoteConstructorTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Expected result
            decimal expectedVehicleSalePrice = 10000M;
            decimal expectedTradeInValue = 5000M;
            decimal expectedSalesTaxRate = .1M;
            Accessories expectedAccessoryChosen = Accessories.StereoSystem;
            ExteriorFinish expectedExteriorFinishChosen = ExteriorFinish.Standard;

            // 5. Actual
            decimal actualVehicleSalePrice = (decimal)privateObject.GetField("_vehicleSalePrice");
            decimal actualTradeInValue = (decimal)privateObject.GetField("_tradeInValue");
            decimal actualSalesTaxRate = (decimal)privateObject.GetField("_salesTaxRate");
            Accessories actualAccessoryChosen = (Accessories)privateObject.GetField("_accessoriesChosen");
            ExteriorFinish actualExteriorFinishChosen = (ExteriorFinish)privateObject.GetField("_exteriorFinishChosen");

            // 6. Evaluate test result
            Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            Assert.AreEqual(expectedTradeInValue, actualTradeInValue);
            Assert.AreEqual(expectedSalesTaxRate, actualSalesTaxRate);
            Assert.AreEqual(expectedAccessoryChosen, actualAccessoryChosen);
            Assert.AreEqual(expectedExteriorFinishChosen, actualExteriorFinishChosen);
        }

        [TestMethod]
        public void GetAccessoryCostNoneTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.NONE;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);

        }

        [TestMethod]
        public void GetAccessoryCostStereoSystemTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.STEREO_SYSTEM;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetAccessoryCostLeatherInteriorTest()
        { 
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.LeatherInterior;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.LEATHER_INTERIOR;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetAccessoryCostStereoAndLeatherTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoAndLeather;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetAccessoryCostComputerNavigationTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.ComputerNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.COMPUTER_NAVIGATION;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetAccessoryCostStereoAndNavigationTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoAndNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.STEREO_SYSTEM + Accessory.COMPUTER_NAVIGATION;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetAccessoryCostLeatherAndNavigationTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.LeatherAndNavigation;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetAccessoryCostAllTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.All;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            // 4. Invokes the unit being tested
            decimal actual = salesQuote.AccessoryCost;

            // 5. Expected result
            decimal expectedCost = Accessory.STEREO_SYSTEM + Accessory.LEATHER_INTERIOR + Accessory.COMPUTER_NAVIGATION;

            // 6. Evaluate test result
            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetFinishCostNoneTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.FinishCost;

            decimal expectedCost = Finish.NONE;

            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetFinishCostStandardTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.FinishCost;

            decimal expectedCost = Finish.STANDARD;

            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetFinishCostPearlizedTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.FinishCost;

            decimal expectedCost = Finish.PEARLIZED;

            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetFinishCostCustomTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.None;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Custom;

            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.FinishCost;

            decimal expectedCost = Finish.CUSTOM;

            Assert.AreEqual(expectedCost, actual);
        }

        [TestMethod]
        public void GetSubtotalTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Pearlized;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.SubTotal;

            decimal expected = (decimal)privateObject.GetField("_vehicleSalePrice") + 
                               (decimal)privateObject.GetFieldOrProperty("AccessoryCost") + 
                               (decimal)privateObject.GetFieldOrProperty("FinishCost");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSalesTaxTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.SalesTax;

            decimal expected = (decimal)privateObject.GetField("_salesTaxRate") *
                               (decimal)privateObject.GetFieldOrProperty("SubTotal");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.Total;

            decimal expected = (decimal)privateObject.GetFieldOrProperty("SalesTax") +
                               (decimal)privateObject.GetFieldOrProperty("SubTotal");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAmountDueTest()
        {
            // 1. Test Value
            decimal vehicleSalePrice = 10000M;
            decimal tradeInValue = 5000M;
            decimal salesTaxRate = .1M;
            Accessories accessoryChosen = Accessories.StereoSystem;
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            // 2. Invoke unit to be tested
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, salesTaxRate, accessoryChosen, exteriorFinishChosen);

            // 3. Object to get to private members
            PrivateObject privateObject = new PrivateObject(salesQuote);

            decimal actual = salesQuote.AmountDue;

            decimal expected = (decimal)privateObject.GetFieldOrProperty("Total") -
                               (decimal)privateObject.GetField("_tradeInValue");

            Assert.AreEqual(expected, actual);
        }
    }
}
