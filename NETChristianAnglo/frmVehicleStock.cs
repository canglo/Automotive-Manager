using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTier;

namespace NETChristianAnglo
{
    public partial class frmVehicleStock : Form
    {
        private VehicleStockData _vehicleStockData;
        private BindingSource _bindingSource;

        public frmVehicleStock()
        {
            InitializeComponent();

            try
            {
                this.Load += new EventHandler(frmVehicleStock_Load);

                mnuFileNewVehicle.Click += new EventHandler(mnuFileNewVehicle_Click);

                dgvVehicles.RowsAdded += new DataGridViewRowsAddedEventHandler(dgvVehicles_RowsAdded);

                mnuEdit.Click += new EventHandler(mnuEdit_Click);


            }
            catch (Exception exception)
            {
                errorLog(exception);
            }
        }

        void mnuEdit_Click(object sender, EventArgs e)
        {
            openEditVehicle(frmEditVehicleStock.EditType.UpdateExisting);
            this.dgvVehicles.EndEdit();
        }

        void dgvVehicles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        void mnuFileNewVehicle_Click(object sender, EventArgs e)
        {
            openEditVehicle(frmEditVehicleStock.EditType.New);
        }

        void frmVehicleStock_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data//AMDatabase.mdb";
            string tableName = "VehicleStock";
            string selectQuery = "SELECT * FROM VehicleStock";

            try
            {
                _vehicleStockData = new VehicleStockData(connectionString, tableName, selectQuery);

                _bindingSource = new BindingSource();

                _bindingSource.DataSource = _vehicleStockData.GetAllRows();

                _bindingSource.Filter = "SoldBy = 0";

                dgvVehicles.DataSource = _bindingSource;

                dgvVehicles.Columns["ID"].Visible = false;

                dgvVehicles.Columns["SoldBy"].Visible = false;

                dgvVehicles.Columns["OptionsPrice"].Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred fetching vehicle stock data.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorLog(exception);
            }
        }

        #region Methods

        private void openEditVehicle(frmEditVehicleStock.EditType editMode)
        {
            this.Enabled = false;

            frmEditVehicleStock editVehicleStock = new frmEditVehicleStock(editMode, _bindingSource, _vehicleStockData);
            editVehicleStock.MdiParent = this.ParentForm;

            editVehicleStock.FormClosed += new FormClosedEventHandler(delegate(object sender, FormClosedEventArgs e)
                {
                    this.Enabled = true;
                });

            editVehicleStock.Show();
        }

        /// <summary>
        /// A method for writing into the log file
        /// </summary>
        /// <param name="exception"></param>
        private void errorLog(Exception exception)
        {
            AutomotiveManager.ErrorLog(exception, "Error reading form file.");
            this.Shown += new EventHandler(delegate(object s, EventArgs evt)
            {
                this.Close();
            });
        }

        #endregion
    }
}
