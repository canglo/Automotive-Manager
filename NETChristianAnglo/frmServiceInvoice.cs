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
    public partial class frmServiceInvoice : NETChristianAnglo.frmInvoice
    {
        /// <summary>
        /// Retrieves the invoice values which are passed to the labels in the service invoice form.
        /// </summary>
        /// <param name="serviceInvoice">For referencing the calculated values</param>
        public frmServiceInvoice(ServiceInvoice invoice)
        {
            InitializeComponent();

            // Sets the values of each individual label
            lblInvoiceTitle.Text = "Service Invoice";
            lblLabourCost.Text = invoice.LabourCost.ToString("C");
            lblPartsCost.Text = invoice.PartsCost.ToString("N2");
            lblMaterialsCost.Text = invoice.MaterialsCost.ToString("N2");
            lblSubtotal.Text = invoice.Subtotal.ToString("C");
            lblPst.Text = invoice.PSTCharged.ToString("N2");
            lblGst.Text = invoice.GSTCharged.ToString("N2");
            lblTotal.Text = invoice.Total.ToString("C");

        }
    }
}
