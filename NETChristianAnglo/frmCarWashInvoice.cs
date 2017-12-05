using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessTier;

namespace NETChristianAnglo
{
    public partial class frmCarWashInvoice : NETChristianAnglo.frmInvoice
    {
        /// <summary>
        /// Retrieves the calculated values from the frmCarWash
        /// The values are passed into the car wash invoice labels
        /// </summary>
        /// <param name="carWashInvoice">For referencing the calculated values</param>
        public frmCarWashInvoice(CarwashInvoice invoice)
        {
            InitializeComponent();

            this.Text = "Car Wash Invoice";
            lblPackagePrice.Text = invoice.PackageCost.ToString("C");
            lblFragrancePrice.Text = invoice.FragranceCost.ToString("N2");
            lblSubtotal.Text = invoice.Subtotal.ToString("C");
            lblTaxes.Text = (invoice.PSTCharged + invoice.GSTCharged).ToString("N2");
            lblTotal.Text = invoice.Total.ToString("C");
        }
    }
}
