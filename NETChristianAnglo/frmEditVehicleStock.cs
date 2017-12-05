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
    public partial class frmEditVehicleStock : Form
    {
        /// <summary>
        /// Defines the edit type for editing the Contact
        /// </summary>
        public enum EditType
        {
            New,
            UpdateExisting
        }

        #region Fields

        private BindingSource _bindingSource;
        private VehicleStockData _vehicleStockData;
        private EditType _editType;
        private DialogResult _result;

        #endregion

        public frmEditVehicleStock(EditType editType, BindingSource bindingSource, VehicleStockData vehicleStockData)
        {
            InitializeComponent();

            _editType = editType;
            _bindingSource = bindingSource;
            _vehicleStockData = vehicleStockData;

            this.Load += new EventHandler(frmEditVehicleStock_Load);

            btnSave.Click += new EventHandler(btnSave_Click);

            this.FormClosing += new FormClosingEventHandler(frmEditVehicleStock_FormClosing);

            txtStockNumber.Validating += new CancelEventHandler(txtStockNumber_Validating);
            txtStockNumber.Validated += new EventHandler(txtBox_Validated);

        }

        void txtBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        void txtStockNumber_Validating(object sender, CancelEventArgs e)
        {
            txtStockNumber.Text = txtStockNumber.Text.Trim();

            string errorMessage = string.Empty;

            if (txtStockNumber.Text.Equals(string.Empty))
            {
                errorMessage = "Please enter a value for this field.";
            }
            else if (_editType == EditType.New && _vehicleStockData.IsDuplicateStockNumber(txtStockNumber.Text))
            {
                errorMessage = "This stock number is used by another vehicle. Please enter another stock number.";
            }

            if (errorMessage != string.Empty)
            {
                txtStockNumber.Focus();
                e.Cancel = true;
                errorProvider.SetError(txtStockNumber, errorMessage);
            }
        }

        void frmEditVehicleStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            _bindingSource.EndEdit();

            string formTitle = "Edit Vehicle Stock";

            if (_editType == EditType.New)
            {
                formTitle = "New Vehicle Stock";
            }

            if (_editType == EditType.New || ((DataRowView)_bindingSource.Current).Row.RowState == DataRowState.Modified)
            {
                if (_result == DialogResult.None)
                {
                    _result = MessageBox.Show("Save changes?", formTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3);
                }


                switch (_result)
                {
                    case DialogResult.Yes:
                        e.Cancel = !saveNewVehicle();
                        break;
                    case DialogResult.No:
                        ((DataTable)_bindingSource.DataSource).RejectChanges();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;

                }
                _result = DialogResult.None;
            }
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            this.Close();
        }

        void frmEditVehicleStock_Load(object sender, EventArgs e)
        {
            this.Text = "New Vehicle";

            if (_editType == EditType.New)
            {
                radAutomatic.Checked = true;
            }
            else if (_editType == EditType.UpdateExisting)
            {
                this.Text = "Edit Vehicle";

                txtStockNumber.Enabled = false;
                BindControls();
            }
        }

        #region Methods

        private bool saveNewVehicle()
        {
            bool isSaveSuccessful = false;

            if (this.ValidateChildren())
            {
                if (_editType == EditType.New)
                {
                    DataTable dataTable = (DataTable)_bindingSource.DataSource;
                    DataRow row = dataTable.NewRow();

                    row["StockNumber"] = txtStockNumber.Text.Trim();
                    row["ManufacturedYear"] = txtYear.Text.Trim();
                    row["Make"] = txtMake.Text.Trim();
                    row["Model"] = txtModel.Text.Trim();
                    row["Mileage"] = txtMileage.Text.Trim();
                    row["Automatic"] = radAutomatic.Checked ? "True" : "False";
                    row["Colour"] = txtColour.Text.Trim();
                    row["BasePrice"] = txtBasePrice.Text.Trim();
                    row["SoldBy"] = "0";
                    dataTable.Rows.Add(row);
                }

                _vehicleStockData.Update();
                isSaveSuccessful = true;
            }
            return isSaveSuccessful;
        }

        private void BindControls()
        {
            txtStockNumber.DataBindings.Add("Text", this._bindingSource, "StockNumber");
            txtStockNumber.Enabled = false;
            txtYear.DataBindings.Add("Text", this._bindingSource, "ManufacturedYear");
            txtMake.DataBindings.Add("Text", this._bindingSource, "Make");
            txtModel.DataBindings.Add("Text", this._bindingSource, "Model");
            radAutomatic.DataBindings.Add("Checked", this._bindingSource, "Automatic");
            txtMileage.DataBindings.Add("Text", this._bindingSource, "Mileage");
            txtColour.DataBindings.Add("Text", this._bindingSource, "Colour");
            txtBasePrice.DataBindings.Add("Text", this._bindingSource, "BasePrice");
            
        }

        /// <summary>
        /// A method for writing into the log file
        /// </summary>
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
