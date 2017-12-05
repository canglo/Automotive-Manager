namespace NETChristianAnglo
{
    partial class frmQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehicleSalePrice = new System.Windows.Forms.TextBox();
            this.txtTradeinAllowance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.lnkResetForm = new System.Windows.Forms.LinkLabel();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeInAllowance = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSalesTaxDescription = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.hsbInterestRate = new System.Windows.Forms.HScrollBar();
            this.hsbNumberOfYears = new System.Windows.Forms.HScrollBar();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle\'s S&ale Price:";
            // 
            // txtVehicleSalePrice
            // 
            this.errorProvider.SetIconPadding(this.txtVehicleSalePrice, 3);
            this.txtVehicleSalePrice.Location = new System.Drawing.Point(135, 21);
            this.txtVehicleSalePrice.Name = "txtVehicleSalePrice";
            this.txtVehicleSalePrice.Size = new System.Drawing.Size(130, 20);
            this.txtVehicleSalePrice.TabIndex = 1;
            this.txtVehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTradeinAllowance
            // 
            this.errorProvider.SetIconPadding(this.txtTradeinAllowance, 3);
            this.txtTradeinAllowance.Location = new System.Drawing.Point(135, 55);
            this.txtTradeinAllowance.Name = "txtTradeinAllowance";
            this.txtTradeinAllowance.Size = new System.Drawing.Size(130, 20);
            this.txtTradeinAllowance.TabIndex = 2;
            this.txtTradeinAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "T&rade-in Allowance:";
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(29, 96);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(236, 135);
            this.grpAccessories.TabIndex = 4;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(20, 95);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.chkComputerNavigation.TabIndex = 2;
            this.chkComputerNavigation.Text = "Computer &Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(20, 62);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkLeatherInterior.TabIndex = 1;
            this.chkLeatherInterior.Text = "Leather &Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(20, 29);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.chkStereoSystem.TabIndex = 0;
            this.chkStereoSystem.Text = "Ste&reo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(29, 252);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(236, 137);
            this.grpExteriorFinish.TabIndex = 5;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radDetailing
            // 
            this.radDetailing.AutoSize = true;
            this.radDetailing.Location = new System.Drawing.Point(20, 95);
            this.radDetailing.Name = "radDetailing";
            this.radDetailing.Size = new System.Drawing.Size(123, 17);
            this.radDetailing.TabIndex = 2;
            this.radDetailing.TabStop = true;
            this.radDetailing.Text = "Customized &Detailing";
            this.radDetailing.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(20, 62);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(68, 17);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.TabStop = true;
            this.radPearlized.Text = "Pearli&zed";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(20, 29);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "&Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // lnkResetForm
            // 
            this.lnkResetForm.AutoSize = true;
            this.lnkResetForm.Location = new System.Drawing.Point(26, 418);
            this.lnkResetForm.Name = "lnkResetForm";
            this.lnkResetForm.Size = new System.Drawing.Size(61, 13);
            this.lnkResetForm.TabIndex = 6;
            this.lnkResetForm.TabStop = true;
            this.lnkResetForm.Text = "Reset Form";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(159, 413);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(106, 23);
            this.btnCalculateQuote.TabIndex = 7;
            this.btnCalculateQuote.Text = "&Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(299, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 415);
            this.label3.TabIndex = 8;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblTradeInAllowance);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.label12);
            this.grpSummary.Controls.Add(this.label11);
            this.grpSummary.Controls.Add(this.label10);
            this.grpSummary.Controls.Add(this.lblSalesTaxDescription);
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.lblVehicleSalePrice);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Location = new System.Drawing.Point(326, 12);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(310, 286);
            this.grpSummary.TabIndex = 9;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.Location = new System.Drawing.Point(145, 235);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(127, 20);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeInAllowance
            // 
            this.lblTradeInAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeInAllowance.Location = new System.Drawing.Point(145, 202);
            this.lblTradeInAllowance.Name = "lblTradeInAllowance";
            this.lblTradeInAllowance.Size = new System.Drawing.Size(127, 20);
            this.lblTradeInAllowance.TabIndex = 12;
            this.lblTradeInAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(145, 168);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(127, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTax.Location = new System.Drawing.Point(145, 136);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(127, 20);
            this.lblSalesTax.TabIndex = 10;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(145, 104);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(127, 20);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Amount Due:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Trade-in Allowance:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total:";
            // 
            // lblSalesTaxDescription
            // 
            this.lblSalesTaxDescription.AutoSize = true;
            this.lblSalesTaxDescription.Location = new System.Drawing.Point(53, 137);
            this.lblSalesTaxDescription.Name = "lblSalesTaxDescription";
            this.lblSalesTaxDescription.Size = new System.Drawing.Size(54, 13);
            this.lblSalesTaxDescription.TabIndex = 5;
            this.lblSalesTaxDescription.Text = "Sales Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Subtotal:";
            // 
            // lblOptions
            // 
            this.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptions.Location = new System.Drawing.Point(145, 71);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(127, 20);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Options:";
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(145, 38);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(127, 20);
            this.lblVehicleSalePrice.TabIndex = 1;
            this.lblVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vehicle\'s Sale Price:";
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.hsbInterestRate);
            this.grpFinance.Controls.Add(this.hsbNumberOfYears);
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.lblInterestRate);
            this.grpFinance.Controls.Add(this.lblNumberOfYears);
            this.grpFinance.Controls.Add(this.label15);
            this.grpFinance.Controls.Add(this.label14);
            this.grpFinance.Controls.Add(this.label13);
            this.grpFinance.Enabled = false;
            this.grpFinance.Location = new System.Drawing.Point(326, 314);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(310, 122);
            this.grpFinance.TabIndex = 10;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // hsbInterestRate
            // 
            this.hsbInterestRate.LargeChange = 25;
            this.hsbInterestRate.Location = new System.Drawing.Point(116, 86);
            this.hsbInterestRate.Maximum = 2524;
            this.hsbInterestRate.Name = "hsbInterestRate";
            this.hsbInterestRate.Size = new System.Drawing.Size(63, 17);
            this.hsbInterestRate.TabIndex = 7;
            // 
            // hsbNumberOfYears
            // 
            this.hsbNumberOfYears.LargeChange = 3;
            this.hsbNumberOfYears.Location = new System.Drawing.Point(23, 86);
            this.hsbNumberOfYears.Maximum = 12;
            this.hsbNumberOfYears.Minimum = 1;
            this.hsbNumberOfYears.Name = "hsbNumberOfYears";
            this.hsbNumberOfYears.Size = new System.Drawing.Size(63, 17);
            this.hsbNumberOfYears.TabIndex = 6;
            this.hsbNumberOfYears.Value = 1;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(209, 55);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 20);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.Location = new System.Drawing.Point(114, 55);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(65, 20);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.Text = "value";
            this.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.Location = new System.Drawing.Point(20, 55);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(66, 20);
            this.lblNumberOfYears.TabIndex = 3;
            this.lblNumberOfYears.Text = "value";
            this.lblNumberOfYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(209, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Monthly Payment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(114, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Interest Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "No. of Years";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmQuote
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(662, 466);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.lnkResetForm);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTradeinAllowance);
            this.Controls.Add(this.txtVehicleSalePrice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuote";
            this.Text = "Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehicleSalePrice;
        private System.Windows.Forms.TextBox txtTradeinAllowance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radDetailing;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.LinkLabel lnkResetForm;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSalesTaxDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTradeInAllowance;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.HScrollBar hsbInterestRate;
        private System.Windows.Forms.HScrollBar hsbNumberOfYears;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}