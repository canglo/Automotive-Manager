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
using System.IO;

namespace NETChristianAnglo
{
    public partial class frmCarWash : Form
    {
        #region Structures

        /// <summary>
        /// Models a PackageItem type
        /// </summary>
        private struct PackageItem
        {
            public string Package { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return this.Package;
            }
        }

        /// <summary>
        /// Models a FragranceItem type
        /// </summary>
        private struct FragranceItem
        {
            public string Fragrance { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return this.Fragrance;
            }
        }

        /// <summary>
        /// Models a InteriorOptions type
        /// </summary>
        private struct InteriorOptions
        {
            public string Interior { get; set; }
            public override string ToString()
            {
                return this.Interior;
            }
        }

        /// <summary>
        /// Models a ExteriorOptions type
        /// </summary>
        private struct ExteriorOptions
        {
            public string Exterior { get; set; }
            public override string ToString()
            {
                return this.Exterior;
            }
        }


        #endregion

        #region Fields

        private List<PackageItem> _packageItems;
        private List<FragranceItem> _fragranceItems;
        private List<InteriorOptions> _interiorOptions;
        private List<ExteriorOptions> _exteriorOptions;
        private FragranceItem fragranceItem;
        private PackageItem packageItem;
        private CarwashInvoice _carWashInvoice;

        #endregion

        public frmCarWash()
        {
            InitializeComponent();

            try
            {
                loadDataPackageItemsFromFile();
                loadDataFragranceItemsFromFile();
                LoadInteriorOptionsFromFile();
                loadExteriorOptionsFromFile();

                this.Load += new EventHandler(frmCarWash_Load);

                foreach (PackageItem packageItem in _packageItems)
                {
                    cboPackage.Items.Add(packageItem.ToString());
                }

                foreach (FragranceItem fragranceItem in _fragranceItems)
                {
                    cboFragrance.Items.Add(fragranceItem.ToString());
                }
            }
            catch (FileNotFoundException exception)
            {
                AutomotiveManager.ErrorLog(exception, "Error reading from car wash data file.");
                showError();
            }
            catch (IOException exception)
            {
                AutomotiveManager.ErrorLog(exception, "Error reading from car wash data file.");
                showError();
            }

            cboPackage.SelectedIndexChanged += new EventHandler(cboPackage_SelectedIndexChanged);
            cboFragrance.SelectedIndexChanged += new EventHandler(cboFragrance_SelectedIndexChanged);
            mnuGenerateInvoice.Click += new EventHandler(mnuGenerateInvoice_Click);
        }

        #region EventHandlers

        /// <summary>
        /// Handles the opening of the invoice
        /// </summary>
        void mnuGenerateInvoice_Click(object sender, EventArgs e)
        {
            frmCarWashInvoice invoice = new frmCarWashInvoice(_carWashInvoice);
            invoice.MdiParent = this.ParentForm;
            invoice.Show();
            defaultState();
        }

        /// <summary>
        /// Handles the event when fragrance selection changes
        /// </summary>
        void cboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            fragranceItem = _fragranceItems[cboFragrance.SelectedIndex];
            calculate();
        }

        /// <summary>
        /// Handles the event when package selection changes
        /// </summary>
        void cboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            packageItem = _packageItems[cboPackage.SelectedIndex];
            calculate();
        }

        /// <summary>
        /// Handles the load event
        /// </summary>
        void frmCarWash_Load(object sender, EventArgs e)
        {
            defaultState();
        }


        #endregion

        #region Methods

        /// <summary>
        /// Calculates and prints out the subtotal, pst and gst charged, taxes, and total
        /// </summary>
        private void calculate()
        {
            _carWashInvoice = new CarwashInvoice(decimal.Parse(ConfigurationManager.AppSettings["PST"]),
                                                 decimal.Parse(ConfigurationManager.AppSettings["GST"]),
                                                 packageItem.Price, fragranceItem.Price);

            printSummary();
        }

        /// <summary>
        /// Updates the labels and the summary section of the form
        /// </summary>
        private void printSummary()
        {
            lstInterior.Items.Clear();
            lstExterior.Items.Clear();

            lstInterior.Items.Add(string.Format("{0} - {1}", _interiorOptions[0].ToString(), fragranceItem.Fragrance));

            for (int i = 0; i < cboPackage.SelectedIndex + 1; i++)
            {
                if (i != 0)
                {
                    lstInterior.Items.Add(_interiorOptions[i]);
                }
                lstExterior.Items.Add(_exteriorOptions[i]);
            }

            lblSubtotal.Text = _carWashInvoice.Subtotal.ToString("C");
            lblPST.Text = _carWashInvoice.PSTCharged.ToString("N2");
            lblGST.Text = _carWashInvoice.GSTCharged.ToString("N2");
            lblTotal.Text = _carWashInvoice.Total.ToString("C");

            if (_carWashInvoice.Total > 0)
            {
                mnuGenerateInvoice.Enabled = true;
            }
        }

        /// <summary>
        /// The default state of the form
        /// </summary>
        private void defaultState()
        {
            cboPackage.SelectedIndex = 0;
            cboFragrance.SelectedIndex = 2;
            mnuGenerateInvoice.Enabled = false;
            lblSubtotal.Text = string.Empty;
            lblGST.Text = string.Empty;
            lblPST.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

        /// <summary>
        /// Shows the error message box
        /// </summary>
        private void showError()
        {
            MessageBox.Show("An error occurred while loading car wash data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Shown += new EventHandler(delegate(object sender, EventArgs e)
            {
                this.Close();
            });
        }

        /// <summary>
        /// Loads the data from the PackageData.txt 
        /// </summary>
        private void loadDataPackageItemsFromFile()
        {
            _packageItems = new List<PackageItem>();

            string record = string.Empty;
            string filepath = @"Data\PackageData.txt";

            FileStream stream = new FileStream(filepath, FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            try
            {
                while ((record = reader.ReadLine()) != null)
                {
                    string[] field = record.Split(',');

                    // Creating an instance and set the properties of the object
                    PackageItem package = new PackageItem()
                    {
                        Package = field[0],
                        Price = decimal.Parse(field[1])
                    };
                    _packageItems.Add(package);
                }
            }
            catch (FileNotFoundException exception)
            {
                AutomotiveManager.ErrorLog(exception, "Error reading from car wash data file.");
                showError();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        /// <summary>
        /// Loads the data from the FragranceData.txt into a list
        /// </summary>
        private void loadDataFragranceItemsFromFile()
        {
            _fragranceItems = new List<FragranceItem>();

            string record = string.Empty;
            string filepath = @"Data\FragranceData.txt";

            FileStream stream = new FileStream(filepath, FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            try
            {
                while ((record = reader.ReadLine()) != null)
                {
                    string[] field = record.Split(',');

                    // Creating an instance and set the properties of the object
                    FragranceItem fragrance = new FragranceItem()
                    {
                        Fragrance = field[0],
                        Price = decimal.Parse(field[1])
                    };
                    _fragranceItems.Add(fragrance);
                }
            }
            catch (FileNotFoundException exception)
            {
                AutomotiveManager.ErrorLog(exception, "Error reading from car wash data file.");
                showError();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        /// <summary>
        /// Loads the Interior data from the Interior.txt into a list
        /// </summary>
        private void LoadInteriorOptionsFromFile()
        {
            _interiorOptions = new List<InteriorOptions>();
            string record = string.Empty;
            string filepath = @"Data\Interior.txt";

            FileStream stream = new FileStream(filepath, FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            try
            {
                while ((record = reader.ReadLine()) != null)
                {
                    // Creating an instance and set the properties of the object
                    InteriorOptions interior = new InteriorOptions()
                    {
                        Interior = record
                    };
                    _interiorOptions.Add(interior);
                }
            }
            catch (FileNotFoundException exception)
            {
                AutomotiveManager.ErrorLog(exception, "Error reading from car wash data file.");
                showError();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        /// <summary>
        /// Loads the Exterior data from the Exterior.txt into a list
        /// </summary>
        private void loadExteriorOptionsFromFile()
        {
            _exteriorOptions = new List<ExteriorOptions>();

            string record = string.Empty;
            string filepath = @"Data\Exterior.txt";

            FileStream stream = new FileStream(filepath, FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            try
            {
                while ((record = reader.ReadLine()) != null)
                {
                    // Creating an instance and set the properties of the object
                    ExteriorOptions exterior = new ExteriorOptions()
                    {
                        Exterior = record
                    };
                    _exteriorOptions.Add(exterior);
                }
            }
            catch (FileNotFoundException exception)
            {
                AutomotiveManager.ErrorLog(exception, "Error reading from car wash data file.");
                showError();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        

        #endregion
    }
}
