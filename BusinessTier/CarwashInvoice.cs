using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    public class CarwashInvoice : Invoice
    {
        /// <summary>
        /// The package cost for the car wash
        /// </summary>
        public decimal PackageCost { get; private set; }

        /// <summary>
        /// The fragrance cost for the car wash
        /// </summary>
        public decimal FragranceCost { get; private set; }

        /// <summary>
        /// Overrides PSTCharged which get and return the PSTCharged amount
        /// </summary>
        public override decimal PSTCharged
        {
            get { return (PackageCost + FragranceCost) * (PSTRate / 100); }
        }

        /// <summary>
        /// Overrides GSTCharged which get and return the GSTCharged amount
        /// </summary>
        public override decimal GSTCharged
        {
            get { return (PackageCost + FragranceCost) * (GSTRate / 100); }
        }

        /// <summary>
        /// Overrides Subtotal which get and return the Subtotal amount
        /// </summary>
        public override decimal Subtotal
        {
            get { return PackageCost + FragranceCost; }
        }

        /// <summary>
        /// Overrides Total which get and return the Total amount
        /// </summary>
        public override decimal Total
        {
            get { return Subtotal + GSTCharged + PSTCharged; }
        }

        /// <summary>
        /// Construct a CarWashInvoice passing PST and GST rate
        /// </summary>
        /// <param name="pstRate">Assign the pst rate in the base class</param>
        /// <param name="gstRate">Assign the gst rate in the base class</param>
        public CarwashInvoice(decimal pstRate, decimal gstRate) : base(pstRate, gstRate) { }


        /// <summary>
        /// Construct a CarWashInvoice 
        /// </summary>
        /// <param name="pstRate">Assign the pst rate</param>
        /// <param name="gstRate">Assign the gst rate</param>
        /// <param name="packageCost">Sets the package chosen</param>
        /// <param name="fragranceCost">Sets the fragrance chosen</param>
        public CarwashInvoice(decimal pstRate, decimal gstRate, decimal packageCost, decimal fragranceCost)
            : base(pstRate, gstRate)
        {
            PackageCost = packageCost;
            FragranceCost = fragranceCost;
        }
    }
}
