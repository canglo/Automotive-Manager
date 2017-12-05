using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessTier
{
    /// <summary>
    /// Models an invoice that is a Service invoice
    /// </summary>
    public class ServiceInvoice : Invoice
    {
        /// <summary>
        /// The service labour cost
        /// </summary>
        public decimal LabourCost { get; private set; }

        /// <summary>
        /// The service parts cost
        /// </summary>
        public decimal PartsCost { get; private set; }

        /// <summary>
        /// The service material cost
        /// </summary>
        public decimal MaterialsCost { get; private set; }

        /// <summary>
        /// Overrides the method PSTCharged which return the PSTCharged amount
        /// </summary>
        public override decimal PSTCharged
        {
            get { return (PartsCost + MaterialsCost) * PSTRate; }
        }

        /// <summary>
        /// Overrides the method GSTCharged which return the GSTCharged amount
        /// </summary>
        public override decimal GSTCharged
        {
            get { return (LabourCost + PartsCost + MaterialsCost) * GSTRate; }
        }

        /// <summary>
        /// Overrides the method Subtotal which return the Subtotal amount
        /// </summary>
        public override decimal Subtotal
        {
            get { return LabourCost + PartsCost + MaterialsCost; }
        }

        /// <summary>
        /// Overrides the method Total which return the Total amount
        /// </summary>
        public override decimal Total
        {
            get { return Subtotal + GSTCharged + PSTCharged; }
        }

        public ServiceInvoice(decimal pstRate, decimal gstRate) : base(pstRate, gstRate) { }

        /// <summary>
        /// Adds cost to their cost types
        /// </summary>
        /// <param name="costType">For setting the cost type</param>
        /// <param name="cost">For setting the cost to their respective type</param>
        public void AddCost(CostType costType, decimal cost)
        {
            switch (costType)
            {
                case CostType.Labour:
                    LabourCost += cost;
                    break;
                case CostType.Parts:
                    PartsCost += cost;
                    break;
                case CostType.Materials:
                    MaterialsCost += cost;
                    break;
            }
        }
    }
}
