
namespace TruckSystem
{
    partial class TruckSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckSystem));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDrivers = new System.Windows.Forms.TabPage();
            this.DeleteDriver_button = new System.Windows.Forms.Button();
            this.AddDriver_button = new System.Windows.Forms.Button();
            this.UpdateDriver_button = new System.Windows.Forms.Button();
            this.LoadDrivers_button = new System.Windows.Forms.Button();
            this.dataGridView_Drivers = new System.Windows.Forms.DataGridView();
            this.tabPageVehicles = new System.Windows.Forms.TabPage();
            this.DeleteVehicle_button = new System.Windows.Forms.Button();
            this.AddNewVehicle_button = new System.Windows.Forms.Button();
            this.EditVehicle_button = new System.Windows.Forms.Button();
            this.LoadVehicles_button = new System.Windows.Forms.Button();
            this.dataGridView_Vehicles = new System.Windows.Forms.DataGridView();
            this.tabPageInvoices = new System.Windows.Forms.TabPage();
            this.DeleteInvoice_button = new System.Windows.Forms.Button();
            this.AddNewInvoice_button = new System.Windows.Forms.Button();
            this.EditInvoice_button = new System.Windows.Forms.Button();
            this.LoadInvoices_button = new System.Windows.Forms.Button();
            this.dataGridView_Invoices = new System.Windows.Forms.DataGridView();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.tabPageExpenses = new System.Windows.Forms.TabPage();
            this.tabPageReminder = new System.Windows.Forms.TabPage();
            this.tabPageCompanies = new System.Windows.Forms.TabPage();
            this.dataGridView_Companies = new System.Windows.Forms.DataGridView();
            this.DeleteCompany_button = new System.Windows.Forms.Button();
            this.AddNewCompany_button = new System.Windows.Forms.Button();
            this.EditCompany_button = new System.Windows.Forms.Button();
            this.LoadCompanies_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drivers)).BeginInit();
            this.tabPageVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).BeginInit();
            this.tabPageInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Invoices)).BeginInit();
            this.tabPageCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageDrivers);
            this.tabControl1.Controls.Add(this.tabPageVehicles);
            this.tabControl1.Controls.Add(this.tabPageInvoices);
            this.tabControl1.Controls.Add(this.tabPageStatistics);
            this.tabControl1.Controls.Add(this.tabPageExpenses);
            this.tabControl1.Controls.Add(this.tabPageReminder);
            this.tabControl1.Controls.Add(this.tabPageCompanies);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 730);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDrivers
            // 
            this.tabPageDrivers.Controls.Add(this.DeleteDriver_button);
            this.tabPageDrivers.Controls.Add(this.AddDriver_button);
            this.tabPageDrivers.Controls.Add(this.UpdateDriver_button);
            this.tabPageDrivers.Controls.Add(this.LoadDrivers_button);
            this.tabPageDrivers.Controls.Add(this.dataGridView_Drivers);
            this.tabPageDrivers.Location = new System.Drawing.Point(4, 24);
            this.tabPageDrivers.Name = "tabPageDrivers";
            this.tabPageDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrivers.Size = new System.Drawing.Size(1112, 702);
            this.tabPageDrivers.TabIndex = 0;
            this.tabPageDrivers.Text = "Vozači";
            this.tabPageDrivers.UseVisualStyleBackColor = true;
            // 
            // DeleteDriver_button
            // 
            this.DeleteDriver_button.Location = new System.Drawing.Point(3, 171);
            this.DeleteDriver_button.Name = "DeleteDriver_button";
            this.DeleteDriver_button.Size = new System.Drawing.Size(147, 50);
            this.DeleteDriver_button.TabIndex = 4;
            this.DeleteDriver_button.Text = "Obriši Vozača";
            this.DeleteDriver_button.UseVisualStyleBackColor = true;
            this.DeleteDriver_button.Click += new System.EventHandler(this.DeleteDriver_button_Click);
            // 
            // AddDriver_button
            // 
            this.AddDriver_button.Location = new System.Drawing.Point(3, 115);
            this.AddDriver_button.Name = "AddDriver_button";
            this.AddDriver_button.Size = new System.Drawing.Size(147, 50);
            this.AddDriver_button.TabIndex = 3;
            this.AddDriver_button.Text = "Dodaj Novog Vozača";
            this.AddDriver_button.UseVisualStyleBackColor = true;
            this.AddDriver_button.Click += new System.EventHandler(this.AddDriver_button_Click);
            // 
            // UpdateDriver_button
            // 
            this.UpdateDriver_button.Location = new System.Drawing.Point(3, 59);
            this.UpdateDriver_button.Name = "UpdateDriver_button";
            this.UpdateDriver_button.Size = new System.Drawing.Size(147, 50);
            this.UpdateDriver_button.TabIndex = 2;
            this.UpdateDriver_button.Text = "Izmeni Vozača";
            this.UpdateDriver_button.UseVisualStyleBackColor = true;
            this.UpdateDriver_button.Click += new System.EventHandler(this.UpdateDriver_button_Click);
            // 
            // LoadDrivers_button
            // 
            this.LoadDrivers_button.Location = new System.Drawing.Point(3, 3);
            this.LoadDrivers_button.Name = "LoadDrivers_button";
            this.LoadDrivers_button.Size = new System.Drawing.Size(147, 50);
            this.LoadDrivers_button.TabIndex = 1;
            this.LoadDrivers_button.Text = "Učitaj Vozače";
            this.LoadDrivers_button.UseVisualStyleBackColor = true;
            this.LoadDrivers_button.Click += new System.EventHandler(this.LoadDrivers_button_Click);
            // 
            // dataGridView_Drivers
            // 
            this.dataGridView_Drivers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Drivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Drivers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Drivers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Drivers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Drivers.Location = new System.Drawing.Point(156, 3);
            this.dataGridView_Drivers.Name = "dataGridView_Drivers";
            this.dataGridView_Drivers.ReadOnly = true;
            this.dataGridView_Drivers.RowTemplate.Height = 25;
            this.dataGridView_Drivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Drivers.Size = new System.Drawing.Size(953, 259);
            this.dataGridView_Drivers.TabIndex = 0;
            // 
            // tabPageVehicles
            // 
            this.tabPageVehicles.Controls.Add(this.DeleteVehicle_button);
            this.tabPageVehicles.Controls.Add(this.AddNewVehicle_button);
            this.tabPageVehicles.Controls.Add(this.EditVehicle_button);
            this.tabPageVehicles.Controls.Add(this.LoadVehicles_button);
            this.tabPageVehicles.Controls.Add(this.dataGridView_Vehicles);
            this.tabPageVehicles.Location = new System.Drawing.Point(4, 24);
            this.tabPageVehicles.Name = "tabPageVehicles";
            this.tabPageVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehicles.Size = new System.Drawing.Size(1112, 702);
            this.tabPageVehicles.TabIndex = 1;
            this.tabPageVehicles.Text = "Vozila";
            this.tabPageVehicles.UseVisualStyleBackColor = true;
            // 
            // DeleteVehicle_button
            // 
            this.DeleteVehicle_button.Location = new System.Drawing.Point(3, 171);
            this.DeleteVehicle_button.Name = "DeleteVehicle_button";
            this.DeleteVehicle_button.Size = new System.Drawing.Size(147, 50);
            this.DeleteVehicle_button.TabIndex = 8;
            this.DeleteVehicle_button.Text = "Obriši Vozilo";
            this.DeleteVehicle_button.UseVisualStyleBackColor = true;
            this.DeleteVehicle_button.Click += new System.EventHandler(this.DeleteVehicle_button_Click);
            // 
            // AddNewVehicle_button
            // 
            this.AddNewVehicle_button.Location = new System.Drawing.Point(3, 115);
            this.AddNewVehicle_button.Name = "AddNewVehicle_button";
            this.AddNewVehicle_button.Size = new System.Drawing.Size(147, 50);
            this.AddNewVehicle_button.TabIndex = 7;
            this.AddNewVehicle_button.Text = "Dodaj Novo Vozilo";
            this.AddNewVehicle_button.UseVisualStyleBackColor = true;
            this.AddNewVehicle_button.Click += new System.EventHandler(this.AddNewVehicle_button_Click);
            // 
            // EditVehicle_button
            // 
            this.EditVehicle_button.Location = new System.Drawing.Point(3, 59);
            this.EditVehicle_button.Name = "EditVehicle_button";
            this.EditVehicle_button.Size = new System.Drawing.Size(147, 50);
            this.EditVehicle_button.TabIndex = 6;
            this.EditVehicle_button.Text = "Izmeni Vozilo";
            this.EditVehicle_button.UseVisualStyleBackColor = true;
            this.EditVehicle_button.Click += new System.EventHandler(this.EditVehicle_button_Click);
            // 
            // LoadVehicles_button
            // 
            this.LoadVehicles_button.Location = new System.Drawing.Point(3, 3);
            this.LoadVehicles_button.Name = "LoadVehicles_button";
            this.LoadVehicles_button.Size = new System.Drawing.Size(147, 50);
            this.LoadVehicles_button.TabIndex = 5;
            this.LoadVehicles_button.Text = "Učitaj Vozila";
            this.LoadVehicles_button.UseVisualStyleBackColor = true;
            this.LoadVehicles_button.Click += new System.EventHandler(this.LoadVehicles_button_Click);
            // 
            // dataGridView_Vehicles
            // 
            this.dataGridView_Vehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Vehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Vehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Vehicles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vehicles.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Vehicles.Location = new System.Drawing.Point(156, 3);
            this.dataGridView_Vehicles.Name = "dataGridView_Vehicles";
            this.dataGridView_Vehicles.ReadOnly = true;
            this.dataGridView_Vehicles.RowTemplate.Height = 25;
            this.dataGridView_Vehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Vehicles.Size = new System.Drawing.Size(953, 259);
            this.dataGridView_Vehicles.TabIndex = 4;
            // 
            // tabPageInvoices
            // 
            this.tabPageInvoices.Controls.Add(this.DeleteInvoice_button);
            this.tabPageInvoices.Controls.Add(this.AddNewInvoice_button);
            this.tabPageInvoices.Controls.Add(this.EditInvoice_button);
            this.tabPageInvoices.Controls.Add(this.LoadInvoices_button);
            this.tabPageInvoices.Controls.Add(this.dataGridView_Invoices);
            this.tabPageInvoices.Location = new System.Drawing.Point(4, 24);
            this.tabPageInvoices.Name = "tabPageInvoices";
            this.tabPageInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInvoices.Size = new System.Drawing.Size(1112, 702);
            this.tabPageInvoices.TabIndex = 2;
            this.tabPageInvoices.Text = "Fakture";
            this.tabPageInvoices.UseVisualStyleBackColor = true;
            // 
            // DeleteInvoice_button
            // 
            this.DeleteInvoice_button.Location = new System.Drawing.Point(3, 171);
            this.DeleteInvoice_button.Name = "DeleteInvoice_button";
            this.DeleteInvoice_button.Size = new System.Drawing.Size(147, 50);
            this.DeleteInvoice_button.TabIndex = 12;
            this.DeleteInvoice_button.Text = "Obriši Fakturu";
            this.DeleteInvoice_button.UseVisualStyleBackColor = true;
            this.DeleteInvoice_button.Click += new System.EventHandler(this.DeleteInvoice_button_Click);
            // 
            // AddNewInvoice_button
            // 
            this.AddNewInvoice_button.Location = new System.Drawing.Point(3, 115);
            this.AddNewInvoice_button.Name = "AddNewInvoice_button";
            this.AddNewInvoice_button.Size = new System.Drawing.Size(147, 50);
            this.AddNewInvoice_button.TabIndex = 11;
            this.AddNewInvoice_button.Text = "Dodaj Novu Fakturu";
            this.AddNewInvoice_button.UseVisualStyleBackColor = true;
            this.AddNewInvoice_button.Click += new System.EventHandler(this.AddNewInvoice_button_Click);
            // 
            // EditInvoice_button
            // 
            this.EditInvoice_button.Location = new System.Drawing.Point(3, 59);
            this.EditInvoice_button.Name = "EditInvoice_button";
            this.EditInvoice_button.Size = new System.Drawing.Size(147, 50);
            this.EditInvoice_button.TabIndex = 10;
            this.EditInvoice_button.Text = "Izmeni Fakturu";
            this.EditInvoice_button.UseVisualStyleBackColor = true;
            this.EditInvoice_button.Click += new System.EventHandler(this.EditInvoice_button_Click);
            // 
            // LoadInvoices_button
            // 
            this.LoadInvoices_button.Location = new System.Drawing.Point(3, 3);
            this.LoadInvoices_button.Name = "LoadInvoices_button";
            this.LoadInvoices_button.Size = new System.Drawing.Size(147, 50);
            this.LoadInvoices_button.TabIndex = 9;
            this.LoadInvoices_button.Text = "Učitaj Fakture";
            this.LoadInvoices_button.UseVisualStyleBackColor = true;
            this.LoadInvoices_button.Click += new System.EventHandler(this.LoadInvoices_button_Click);
            // 
            // dataGridView_Invoices
            // 
            this.dataGridView_Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Invoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Invoices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Invoices.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Invoices.Location = new System.Drawing.Point(156, 3);
            this.dataGridView_Invoices.Name = "dataGridView_Invoices";
            this.dataGridView_Invoices.ReadOnly = true;
            this.dataGridView_Invoices.RowTemplate.Height = 25;
            this.dataGridView_Invoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Invoices.Size = new System.Drawing.Size(953, 696);
            this.dataGridView_Invoices.TabIndex = 8;
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 24);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistics.Size = new System.Drawing.Size(1112, 702);
            this.tabPageStatistics.TabIndex = 3;
            this.tabPageStatistics.Text = "Statistika";
            this.tabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // tabPageExpenses
            // 
            this.tabPageExpenses.Location = new System.Drawing.Point(4, 24);
            this.tabPageExpenses.Name = "tabPageExpenses";
            this.tabPageExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpenses.Size = new System.Drawing.Size(1112, 702);
            this.tabPageExpenses.TabIndex = 4;
            this.tabPageExpenses.Text = "Troškovnik";
            this.tabPageExpenses.UseVisualStyleBackColor = true;
            // 
            // tabPageReminder
            // 
            this.tabPageReminder.Location = new System.Drawing.Point(4, 24);
            this.tabPageReminder.Name = "tabPageReminder";
            this.tabPageReminder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReminder.Size = new System.Drawing.Size(1112, 702);
            this.tabPageReminder.TabIndex = 5;
            this.tabPageReminder.Text = "Podsetnik";
            this.tabPageReminder.UseVisualStyleBackColor = true;
            // 
            // tabPageCompanies
            // 
            this.tabPageCompanies.Controls.Add(this.dataGridView_Companies);
            this.tabPageCompanies.Controls.Add(this.DeleteCompany_button);
            this.tabPageCompanies.Controls.Add(this.AddNewCompany_button);
            this.tabPageCompanies.Controls.Add(this.EditCompany_button);
            this.tabPageCompanies.Controls.Add(this.LoadCompanies_button);
            this.tabPageCompanies.Location = new System.Drawing.Point(4, 24);
            this.tabPageCompanies.Name = "tabPageCompanies";
            this.tabPageCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompanies.Size = new System.Drawing.Size(1112, 702);
            this.tabPageCompanies.TabIndex = 6;
            this.tabPageCompanies.Text = "Firme";
            this.tabPageCompanies.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Companies
            // 
            this.dataGridView_Companies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Companies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Companies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Companies.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Companies.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Companies.Location = new System.Drawing.Point(156, 3);
            this.dataGridView_Companies.Name = "dataGridView_Companies";
            this.dataGridView_Companies.ReadOnly = true;
            this.dataGridView_Companies.RowTemplate.Height = 25;
            this.dataGridView_Companies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Companies.Size = new System.Drawing.Size(953, 259);
            this.dataGridView_Companies.TabIndex = 4;
            // 
            // DeleteCompany_button
            // 
            this.DeleteCompany_button.Location = new System.Drawing.Point(3, 171);
            this.DeleteCompany_button.Name = "DeleteCompany_button";
            this.DeleteCompany_button.Size = new System.Drawing.Size(147, 50);
            this.DeleteCompany_button.TabIndex = 3;
            this.DeleteCompany_button.Text = "Obriši Firmu";
            this.DeleteCompany_button.UseVisualStyleBackColor = true;
            this.DeleteCompany_button.Click += new System.EventHandler(this.DeleteCompany_button_Click);
            // 
            // AddNewCompany_button
            // 
            this.AddNewCompany_button.Location = new System.Drawing.Point(3, 115);
            this.AddNewCompany_button.Name = "AddNewCompany_button";
            this.AddNewCompany_button.Size = new System.Drawing.Size(147, 50);
            this.AddNewCompany_button.TabIndex = 2;
            this.AddNewCompany_button.Text = "Dodaj Novu Firmu";
            this.AddNewCompany_button.UseVisualStyleBackColor = true;
            this.AddNewCompany_button.Click += new System.EventHandler(this.AddNewCompany_button_Click);
            // 
            // EditCompany_button
            // 
            this.EditCompany_button.Location = new System.Drawing.Point(3, 59);
            this.EditCompany_button.Name = "EditCompany_button";
            this.EditCompany_button.Size = new System.Drawing.Size(147, 50);
            this.EditCompany_button.TabIndex = 1;
            this.EditCompany_button.Text = "Izmeni Firmu";
            this.EditCompany_button.UseVisualStyleBackColor = true;
            this.EditCompany_button.Click += new System.EventHandler(this.EditCompany_button_Click);
            // 
            // LoadCompanies_button
            // 
            this.LoadCompanies_button.Location = new System.Drawing.Point(3, 3);
            this.LoadCompanies_button.Name = "LoadCompanies_button";
            this.LoadCompanies_button.Size = new System.Drawing.Size(147, 50);
            this.LoadCompanies_button.TabIndex = 0;
            this.LoadCompanies_button.Text = "Učitaj Firme\r\n";
            this.LoadCompanies_button.UseVisualStyleBackColor = true;
            this.LoadCompanies_button.Click += new System.EventHandler(this.LoadCompanies_button_Click);
            // 
            // TruckSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 755);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TruckSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruckSystem";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drivers)).EndInit();
            this.tabPageVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).EndInit();
            this.tabPageInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Invoices)).EndInit();
            this.tabPageCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageDrivers;
        private System.Windows.Forms.TabPage tabPageVehicles;
        private System.Windows.Forms.TabPage tabPageInvoices;

        private System.Windows.Forms.DataGridView dataGridView_Drivers;
        private System.Windows.Forms.Button LoadDrivers_button;
        private System.Windows.Forms.Button UpdateDriver_button;
        private System.Windows.Forms.Button AddDriver_button;

        private System.Windows.Forms.DataGridView dataGridView_Vehicles;
        private System.Windows.Forms.Button EditVehicle_button;
        private System.Windows.Forms.Button LoadVehicles_button;
        private System.Windows.Forms.Button AddNewVehicle_button;
        private System.Windows.Forms.DataGridView dataGridView_Invoices;
        private System.Windows.Forms.Button LoadInvoices_button;
        private System.Windows.Forms.Button AddNewInvoice_button;
        private System.Windows.Forms.Button EditInvoice_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageReminder;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.TabPage tabPageExpenses;
        private System.Windows.Forms.Button DeleteInvoice_button;
        private System.Windows.Forms.Button DeleteVehicle_button;
        private System.Windows.Forms.Button DeleteDriver_button;
        private System.Windows.Forms.TabPage tabPageCompanies;
        private System.Windows.Forms.Button DeleteCompany_button;
        private System.Windows.Forms.Button AddNewCompany_button;
        private System.Windows.Forms.Button EditCompany_button;
        private System.Windows.Forms.Button LoadCompanies_button;
        private System.Windows.Forms.DataGridView dataGridView_Companies;
    }
}

