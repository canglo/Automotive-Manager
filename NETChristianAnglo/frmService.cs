using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessTier;
using System.Configuration;

namespace NETChristianAnglo
{
    public partial class frmService : Form
    {
        private ServiceInvoice invoice;

        public frmService()
        {
            InitializeComponent();

            this.Load += new EventHandler(frmService_Load);

            txtDescription.GotFocus += new EventHandler(txtDescription_GotFocus);

            txtDescription.Validating += new CancelEventHandler(txtDescription_Validating);
            txtDescription.Validated += new EventHandler(control_Validated);

            // cboType.DataSource = Enum.GetNames(typeof(CostType));
            cboType.Validating += new CancelEventHandler(cboType_Validating);
            cboType.Validated += new EventHandler(control_Validated);

            txtCost.Validating += new CancelEventHandler(txtCost_Validating);
            txtCost.Validated += new EventHandler(control_Validated);

            btnAdd.Click += new EventHandler(btnAdd_Click);

            mnuContextClear.Click += new EventHandler(mnuContextClear_Click);

            dgvServiceItems.SelectionChanged += new EventHandler(dgvServiceItems_SelectionChanged);

            mnuServiceGenerateInvoice.Click += new EventHandler(mnuServiceGenerateInvoice_Click);
        }

        /// <summary>
        /// Handles the event when the generate invoice is clicked
        /// </summary>
        void mnuServiceGenerateInvoice_Click(object sender, EventArgs e)
        {
            frmServiceInvoice service = new frmServiceInvoice(invoice);
            service.MdiParent = this.ParentForm;
            service.Show();
            clearForm();
        }

        /// <summary>
        /// Removes the selection highligh in the data grid view
        /// </summary>
        void dgvServiceItems_SelectionChanged(object sender, EventArgs e)
        {
            dgvServiceItems.ClearSelection();
        }

        /// <summary>
        /// Handles the event when clear is clicked
        /// </summary>
        void mnuContextClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        /// <summary>
        /// Handles the event when the add button is clicked
        /// </summary>
        void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                dgvServiceItems.Rows.Add(new[] { dgvServiceItems.RowCount + 1, txtDescription.Text, cboType.SelectedItem, decimal.Parse(txtCost.Text).ToString("C") });

                invoice.AddCost((CostType)cboType.SelectedIndex, decimal.Parse(txtCost.Text));

                // A method that outputs the value for the Subtotal, PST and GST charged, and total cost
                serviceCalculation(invoice);

                mnuServiceGenerateInvoice.Enabled = true;
                mnuContextClear.Enabled = true;

                // Clear the user input
                defaultState();
            }
        }

        /// <summary>
        /// Handles the validating of the cboType
        /// </summary>
        void cboType_Validating(object sender, CancelEventArgs e)
        {
            if (cboType.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cboType, "Please select a service type.");
            }
        }

        /// <summary>
        /// Handles the validating of the txtCost
        /// </summary>
        void txtCost_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            if (!AutomotiveManager.IsNumeric(txtCost.Text))
            {
                errorMessage = "Please enter a numeric value.";
            }
            else if (decimal.Parse(txtCost.Text) <= 0)
            {
                errorMessage = "Please enter a value greater than zero.";
            }

            if (errorMessage != string.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCost, errorMessage);
                txtCost.Focus();
                txtCost.SelectAll();
            }
        }

        /// <summary>
        /// Handles the validated for the controls
        /// </summary>
        void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        /// <summary>
        /// Handles the validating of the txtDescription
        /// </summary>
        void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            txtDescription.Text = txtDescription.Text.Trim();

            if (txtDescription.Text.Equals(string.Empty))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDescription, "Please enter a description.");
                txtDescription.Focus();
            }
        }

        /// <summary>
        /// Selects the text when focus is on this control
        /// </summary>
        void txtDescription_GotFocus(object sender, EventArgs e)
        {
            txtDescription.SelectAll();
        }

        /// <summary>
        /// Handles the load event of the form
        /// </summary>
        void frmService_Load(object sender, EventArgs e)
        {
            defaultState();
            clearForm();
        }

        #region Methods

        /// <summary>
        /// Print out the calculation for the Subtotal, PST and GST charged, and total cost
        /// </summary>
        /// <param name="invoice">Use as a reference for the ServiceInvoice</param>
        private void serviceCalculation(ServiceInvoice invoice)
        {
            lblSubtotal.Text = invoice.Subtotal.ToString("C");
            lblPst.Text = invoice.PSTCharged.ToString("N2");
            lblGst.Text = invoice.GSTCharged.ToString("N2");
            lblTotal.Text = invoice.Total.ToString("C");
        }

        /// <summary>
        /// A method to clear the user input
        /// </summary>
        private void defaultState()
        {
            txtDescription.Focus();
            txtDescription.Clear();
            txtCost.Clear();
            cboType.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears the form
        /// </summary>
        private void clearForm()
        {
            defaultState();

            dgvServiceItems.Rows.Clear();
            lblSubtotal.Text = string.Empty;
            lblGst.Text = string.Empty;
            lblPst.Text = string.Empty;
            lblTotal.Text = string.Empty;
            mnuServiceGenerateInvoice.Enabled = false;
            mnuContextClear.Enabled = false;
            errorProvider.Clear();

            // Creates a new service invoice.
            invoice = new ServiceInvoice(decimal.Parse(ConfigurationManager.AppSettings["PST"]) / 100,
                                         decimal.Parse(ConfigurationManager.AppSettings["GST"]) / 100);
        }

        #endregion

        
    }
}
