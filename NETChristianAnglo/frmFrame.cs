using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NETChristianAnglo
{
    public partial class frmFrame : Form
    {
        public frmFrame()
        {
            InitializeComponent();

            mnuFileOpenSalesQuote.Click += new EventHandler(mnuFileOpenSalesQuote_Click);
            tsiOpenSalesQuote.Click += new EventHandler(mnuFileOpenSalesQuote_Click);

            mnuWindowTile.Click += new EventHandler(mnuWindowTile_Click);
            tsiTile.Click += new EventHandler(mnuWindowTile_Click);

            mnuWindowLayer.Click += new EventHandler(mnuWindowLayer_Click);
            tsiLayer.Click += new EventHandler(mnuWindowLayer_Click);

            mnuWindowCascade.Click += new EventHandler(mnuWindowCascade_Click);
            tsiCascade.Click += new EventHandler(mnuWindowCascade_Click);

            mnuHelpAbout.Click += new EventHandler(mnuHelpAbout_Click);
            tsiAbout.Click += new EventHandler(mnuHelpAbout_Click);

            mnuFileExit.Click += new EventHandler(mnuFileExit_Click);
            tsiExit.Click += new EventHandler(mnuFileExit_Click);

            mnuFileOpenServices.Click += new EventHandler(mnuFileOpenServices_Click);
            tsiOpenServices.Click += new EventHandler(mnuFileOpenServices_Click);

            mnuFileOpenCarWash.Click += new EventHandler(mnuFileOpenCarWash_Click);
            tsiOpenCarWash.Click +=new EventHandler(mnuFileOpenCarWash_Click);

            mnuDataVehicleStock.Click += new EventHandler(mnuDataVehicleStock_Click);
        }

        void mnuDataVehicleStock_Click(object sender, EventArgs e)
        {
            frmVehicleStock frm = new frmVehicleStock();
            frm.MdiParent = this;
            frm.Show();

        }

        /// <summary>
        /// Handles the opening of the car wash form
        /// </summary>
        void mnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            frmCarWash carWash = new frmCarWash();
            carWash.MdiParent = this;
            carWash.Show();

        }

        /// <summary>
        /// Open the services form
        /// </summary>
        void mnuFileOpenServices_Click(object sender, EventArgs e)
        {
            frmService frmService = new frmService();
            frmService.MdiParent = this;
            frmService.Show();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the About form
        /// </summary>
        void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();

            form.ShowDialog();
        }

        /// <summary>
        /// Cascade all open forms
        /// </summary>
        void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Layer all open forms horizontally
        /// </summary>
        void mnuWindowLayer_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Tile all open forms Vertically
        /// </summary>
        void mnuWindowTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Opens the Sales Quote form
        /// </summary>
        void mnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            frmQuote form = new frmQuote();

            form.MdiParent = this;

            form.Show();
        }
    }
}
