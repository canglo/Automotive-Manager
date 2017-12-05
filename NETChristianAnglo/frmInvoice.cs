using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace NETChristianAnglo
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();

            lblDate.Text = DateTime.Today.ToString("M'/'dd'/'yyyy");
            lblCompanyName.Text = ConfigurationManager.AppSettings["CompanyName"];
            lblAddress.Text = ConfigurationManager.AppSettings["CompanyAddress"];
            lblCity.Text = string.Format("{0}, {1} {2}", ConfigurationManager.AppSettings["CompanyCity"],
                                                         ConfigurationManager.AppSettings["CompanyProvince"],
                                                         ConfigurationManager.AppSettings["CompanyPostal"]);
            lblPhone.Text = ConfigurationManager.AppSettings["CompanyPhone"];

            mnuFilePrint.Click += new EventHandler(mnuFilePrint_Click);
        }

        /// <summary>
        /// Handles the event when print is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mnuFilePrint_Click(object sender, EventArgs e)
        {
            printForm.Print(this, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly);
        }
    }
}
