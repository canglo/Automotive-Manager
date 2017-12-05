using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    /// <summary>
    /// Models a generic Invoice
    /// </summary>
    public abstract class Invoice
    {
        /// <summary>
        /// The PST rate 
        /// </summary>
        public decimal PSTRate { get; private set; }

        /// <summary>
        /// The GST rate
        /// </summary>
        public decimal GSTRate { get; private set; }

        /// <summary>
        /// Retrieves the PST charged value
        /// </summary>
        public abstract decimal PSTCharged { get; }

        /// <summary>
        /// Retrives the GST charged value
        /// </summary>
        public abstract decimal GSTCharged { get; }

        /// <summary>
        /// Retrieves the Subtotal value
        /// </summary>
        public abstract decimal Subtotal { get; }

        /// <summary>
        /// Retrives the Total value
        /// </summary>
        public abstract decimal Total { get; }

        /// <summary>
        /// Construct an Invoice 
        /// </summary>
        /// <param name="pstRate">The pst rate</param>
        /// <param name="gstRate">The gst rate</param>
        public Invoice(decimal pstRate, decimal gstRate)
        {
            this.PSTRate = pstRate;
            this.GSTRate = gstRate;
        }
    }
}
