using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BusinessTier;

namespace NETChristianAnglo
{
    public partial class frmQuote : Form
    {
        public frmQuote()
        {
            InitializeComponent();

            lnkResetForm.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkResetForm_LinkClicked);
            this.Load += new EventHandler(frmQuote_Load);
            lblSalesTaxDescription.Text = string.Format("Sales Tax ({0}%):", decimal.Parse(ConfigurationManager.AppSettings["GST"]) + decimal.Parse(ConfigurationManager.AppSettings["PST"]));

            hsbNumberOfYears.ValueChanged += new EventHandler(hsbNumberOfYears_ValueChanged);
            hsbInterestRate.ValueChanged += new EventHandler(hsbInterestRate_ValueChanged);

            txtVehicleSalePrice.Validating += new CancelEventHandler(txtVehicleSalePrice_Validating);
            txtVehicleSalePrice.Validated += new EventHandler(textbox_Validated);

            txtTradeinAllowance.Validating += new CancelEventHandler(txtTradeinAllowance_Validating);
            txtTradeinAllowance.Validated += new EventHandler(textbox_Validated);

            btnCalculateQuote.Click += new EventHandler(btnCalculateQuote_Click);

            hsbNumberOfYears.ValueChanged += new EventHandler(inputChange);
            hsbInterestRate.ValueChanged += new EventHandler(inputChange);

            txtVehicleSalePrice.TextChanged += new EventHandler(textBox_TextChanged);
            txtTradeinAllowance.TextChanged += new EventHandler(textBox_TextChanged);

            txtVehicleSalePrice.GotFocus += new EventHandler(txtVehicleSalePrice_GotFocus);
            txtTradeinAllowance.GotFocus += new EventHandler(txtTradeinAllowance_GotFocus);

            CheckBox[] checkBoxes = { chkStereoSystem, chkLeatherInterior, chkComputerNavigation };

            foreach (CheckBox chkBox in checkBoxes)
            {
                chkBox.CheckedChanged += new EventHandler(inputChange);
            }

            RadioButton[] radio = { radStandard, radPearlized, radDetailing };

            foreach (RadioButton rad in radio)
            {
                rad.CheckedChanged += new EventHandler(inputChange);
            }
        }

        /// <summary>
        /// Sets the focus and highlights the textbox trade-in allowance
        /// </summary>
        void txtTradeinAllowance_GotFocus(object sender, EventArgs e)
        {
            txtTradeinAllowance.Focus();
            txtTradeinAllowance.SelectAll();
        }

        /// <summary>
        /// Sets the focus and highlights the textbox vehicles sale price
        /// </summary>
        void txtVehicleSalePrice_GotFocus(object sender, EventArgs e)
        {
            txtVehicleSalePrice.Focus();
            txtVehicleSalePrice.SelectAll();
        }

        /// <summary>
        /// Handles the changes in vehicle sale price and trade-in allowance
        /// </summary>
        void textBox_TextChanged(object sender, EventArgs e)
        {
            clearSummary();

            grpFinance.Enabled = false;

            resetFinance();
        }

        /// <summary>
        /// Handles the changes in Summary and Finance Section when theres a change in radio, checkboxes, interest rate, and number of years
        /// </summary>
        void inputChange(object sender, EventArgs e)
        {
            if (grpFinance.Enabled)
            {
                btnCalculateQuote_Click(sender, e);
            }
        }

        /// <summary>
        /// Handles the event when calculate button is clicked 
        /// </summary>
        void btnCalculateQuote_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int accessories = 0;

                if (chkStereoSystem.Checked)
                {
                    accessories += 1;
                }
                if (chkLeatherInterior.Checked)
                {
                    accessories += 2;
                }
                if (chkComputerNavigation.Checked)
                {
                    accessories += 4;
                }

                RadioButton[] radioButton = { radStandard, radPearlized, radDetailing };
                int index = -1;

                for (int i = 0; i < radioButton.Length && index == -1; i++)
                {
                    if (radioButton[i].Checked)
                    {
                        index = i + 1;
                    }
                }

                decimal taxRate = decimal.Parse(ConfigurationManager.AppSettings["GST"]) + decimal.Parse(ConfigurationManager.AppSettings["PST"]);

                SalesQuote salesQuote = new SalesQuote(decimal.Parse(txtVehicleSalePrice.Text), decimal.Parse(txtTradeinAllowance.Text), taxRate, (Accessories)accessories, (ExteriorFinish)index);

                lblVehicleSalePrice.Text = String.Format("{0:C}", decimal.Parse(txtVehicleSalePrice.Text));

                lblOptions.Text = String.Format("{0:N}", salesQuote.AccessoryCost + salesQuote.FinishCost);

                lblSubtotal.Text = String.Format("{0:C}", salesQuote.SubTotal);

                lblSalesTax.Text = String.Format("{0:N}", salesQuote.SalesTax);

                lblTotal.Text = String.Format("{0:C}", salesQuote.Total);

                lblTradeInAllowance.Text = String.Format("{0:-#0.00}", decimal.Parse(txtTradeinAllowance.Text));

                lblAmountDue.Text = String.Format("{0:C}", salesQuote.AmountDue);

                if (salesQuote.AmountDue > 0.00M)
                {
                    grpFinance.Enabled = true;

                    hsbInterestRate_ValueChanged(sender, e);
                    hsbNumberOfYears_ValueChanged(sender, e);

                    lblMonthlyPayment.Text = String.Format("{0:C}", AutomotiveManager.Payment((hsbInterestRate.Value / 10000M) / 12, hsbNumberOfYears.Value * 12, salesQuote.AmountDue));
                }
                else if (salesQuote.AmountDue < 0)
                {
                    resetFinance();
                    grpFinance.Enabled = false;
                }

                txtVehicleSalePrice.SelectAll();
                txtVehicleSalePrice.Focus();
            }
        }

        /// <summary>
        /// Validating the textbox trade-in allowance
        /// </summary>
        void txtTradeinAllowance_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = string.Empty;

            if (!AutomotiveManager.IsNumeric(txtTradeinAllowance.Text))
            {
                errorMessage = "Please enter a numeric value.";
                txtTradeinAllowance.Focus();
            }
            else if (decimal.Parse(txtTradeinAllowance.Text) < 0)
            {
                errorMessage = "Please enter a value greater than or equal to zero.";
                txtTradeinAllowance.Focus();
            }

            if (errorMessage != string.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTradeinAllowance, errorMessage);
                
            }
        }

        /// <summary>
        /// Handles the validated event after validating
        /// </summary>
        void textbox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        /// <summary>
        /// Validating the textbox vehicle sale price
        /// </summary>
        void txtVehicleSalePrice_Validating(object sender, CancelEventArgs e)
        {
            txtVehicleSalePrice.Text = txtVehicleSalePrice.Text.Trim();

            string errorMessage = string.Empty;

            if (!AutomotiveManager.IsNumeric(txtVehicleSalePrice.Text))
            {
                errorMessage = "Please enter a numeric value.";
                txtVehicleSalePrice.Focus();
            }
            else if (decimal.Parse(txtVehicleSalePrice.Text) <= 0)
            {
                errorMessage = "Please enter a value greater than zero.";
                txtVehicleSalePrice.Focus();
            }
            if (!errorMessage.Equals(string.Empty))
            {
                e.Cancel = true;

                errorProvider.SetError(txtVehicleSalePrice, errorMessage);
            }
        }

        /// <summary>
        /// Matches the value of the interest rate label with the horizontal scrollbar when it's changed
        /// </summary>
        void hsbInterestRate_ValueChanged(object sender, EventArgs e)
        {
            decimal interestRate = hsbInterestRate.Value / 10000M;
            lblInterestRate.Text = interestRate.ToString("P");
        }

        /// <summary>
        /// Matches the value of the number of years label with the horizontal scrollbal when it's changed
        /// </summary>
        void hsbNumberOfYears_ValueChanged(object sender, EventArgs e)
        {
            lblNumberOfYears.Text = hsbNumberOfYears.Value.ToString();
        }

        /// <summary>
        /// Handles the load event of the form
        /// </summary>
        void frmQuote_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        /// <summary>
        /// Handles the reset of the form
        /// </summary>
        void lnkResetForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset this sales quote?", "Sales Quote", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                clearForm();
            }
        }

        #region methods

        /// <summary>
        /// Clears the form
        /// </summary>
        private void clearForm()
        {
            resetFinance();
            txtVehicleSalePrice.Clear();
            txtTradeinAllowance.Text = "0";
            chkComputerNavigation.Checked = false;
            chkLeatherInterior.Checked = false;
            chkStereoSystem.Checked = false;
            radStandard.Checked = true;
            
            clearSummary();

            txtVehicleSalePrice.Focus();
        }

        /// <summary>
        /// Reset the finance section
        /// </summary>
        private void resetFinance()
        {
            hsbNumberOfYears.Value = 3;
            hsbInterestRate.Value = 500;
            lblNumberOfYears.Text = string.Empty;
            lblInterestRate.Text = string.Empty;
            lblMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// Clears the summary section
        /// </summary>
        private void clearSummary()
        {
            lblVehicleSalePrice.Text = string.Empty;
            lblOptions.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblSalesTax.Text = string.Empty;
            lblTotal.Text = string.Empty;
            lblTradeInAllowance.Text = string.Empty;
            lblAmountDue.Text = string.Empty;
        }

        #endregion
        
    }
}
