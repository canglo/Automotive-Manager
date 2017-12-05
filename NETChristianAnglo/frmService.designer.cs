namespace NETChristianAnglo
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPst = new System.Windows.Forms.Label();
            this.lblGst = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvServiceItems = new System.Windows.Forms.DataGridView();
            this.colItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextClear = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceItems)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // txtDescription
            // 
            this.errorProvider.SetIconPadding(this.txtDescription, 5);
            this.txtDescription.Location = new System.Drawing.Point(82, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorProvider.SetIconPadding(this.cboType, 5);
            this.cboType.Items.AddRange(new object[] {
            "Labour",
            "Parts",
            "Materials"});
            this.cboType.Location = new System.Drawing.Point(82, 51);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(134, 21);
            this.cboType.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(433, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "PST:";
            // 
            // lblPst
            // 
            this.lblPst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPst.Location = new System.Drawing.Point(430, 382);
            this.lblPst.Name = "lblPst";
            this.lblPst.Size = new System.Drawing.Size(78, 20);
            this.lblPst.TabIndex = 10;
            this.lblPst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGst
            // 
            this.lblGst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGst.Location = new System.Drawing.Point(430, 412);
            this.lblGst.Name = "lblGst";
            this.lblGst.Size = new System.Drawing.Size(78, 20);
            this.lblGst.TabIndex = 11;
            this.lblGst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(430, 442);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "GST:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtCost
            // 
            this.errorProvider.SetIconPadding(this.txtCost, 5);
            this.txtCost.Location = new System.Drawing.Point(82, 89);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 5;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(430, 353);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(78, 20);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Subtotal:";
            // 
            // dgvServiceItems
            // 
            this.dgvServiceItems.AllowUserToAddRows = false;
            this.dgvServiceItems.AllowUserToDeleteRows = false;
            this.dgvServiceItems.AllowUserToResizeColumns = false;
            this.dgvServiceItems.AllowUserToResizeRows = false;
            this.dgvServiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemNumber,
            this.colDescription,
            this.colType,
            this.colCost});
            this.dgvServiceItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServiceItems.Location = new System.Drawing.Point(12, 125);
            this.dgvServiceItems.MultiSelect = false;
            this.dgvServiceItems.Name = "dgvServiceItems";
            this.dgvServiceItems.ReadOnly = true;
            this.dgvServiceItems.RowHeadersVisible = false;
            this.dgvServiceItems.ShowEditingIcon = false;
            this.dgvServiceItems.Size = new System.Drawing.Size(496, 215);
            this.dgvServiceItems.TabIndex = 22;
            this.dgvServiceItems.TabStop = false;
            // 
            // colItemNumber
            // 
            this.colItemNumber.FillWeight = 40F;
            this.colItemNumber.HeaderText = "#";
            this.colItemNumber.MinimumWidth = 40;
            this.colItemNumber.Name = "colItemNumber";
            this.colItemNumber.ReadOnly = true;
            this.colItemNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItemNumber.Width = 40;
            // 
            // colDescription
            // 
            this.colDescription.FillWeight = 100.5123F;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDescription.Width = 253;
            // 
            // colType
            // 
            this.colType.FillWeight = 120F;
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 120;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colType.Width = 120;
            // 
            // colCost
            // 
            this.colCost.FillWeight = 80F;
            this.colCost.HeaderText = "Cost";
            this.colCost.MinimumWidth = 80;
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            this.colCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCost.Width = 80;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuService});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(520, 24);
            this.menuStrip.TabIndex = 23;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // mnuService
            // 
            this.mnuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServiceGenerateInvoice});
            this.mnuService.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuService.MergeIndex = 1;
            this.mnuService.Name = "mnuService";
            this.mnuService.Size = new System.Drawing.Size(56, 20);
            this.mnuService.Text = "&Service";
            // 
            // mnuServiceGenerateInvoice
            // 
            this.mnuServiceGenerateInvoice.Image = ((System.Drawing.Image)(resources.GetObject("mnuServiceGenerateInvoice.Image")));
            this.mnuServiceGenerateInvoice.Name = "mnuServiceGenerateInvoice";
            this.mnuServiceGenerateInvoice.Size = new System.Drawing.Size(162, 22);
            this.mnuServiceGenerateInvoice.Text = "Generate Invoice";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextClear});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(102, 26);
            // 
            // mnuContextClear
            // 
            this.mnuContextClear.Name = "mnuContextClear";
            this.mnuContextClear.Size = new System.Drawing.Size(101, 22);
            this.mnuContextClear.Text = "Clear";
            // 
            // frmService
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(520, 477);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.dgvServiceItems);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGst);
            this.Controls.Add(this.lblPst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmService";
            this.Text = "Service";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceItems)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPst;
        private System.Windows.Forms.Label lblGst;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.DataGridView dgvServiceItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuService;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceGenerateInvoice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuContextClear;
    }
}