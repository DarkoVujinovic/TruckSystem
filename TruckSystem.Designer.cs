
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDrivers = new System.Windows.Forms.TabPage();
            this.AddDriver_button = new System.Windows.Forms.Button();
            this.UpdateDriver_button = new System.Windows.Forms.Button();
            this.LoadDrivers_button = new System.Windows.Forms.Button();
            this.dataGridView_Drivers = new System.Windows.Forms.DataGridView();
            this.tabPageVehicles = new System.Windows.Forms.TabPage();
            this.AddNewVehicle_button = new System.Windows.Forms.Button();
            this.EditVehicle_button = new System.Windows.Forms.Button();
            this.LoadVehicles_button = new System.Windows.Forms.Button();
            this.dataGridView_Vehicles = new System.Windows.Forms.DataGridView();
            this.tabPageInvoices = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drivers)).BeginInit();
            this.tabPageVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 536);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDrivers
            // 
            this.tabPageDrivers.Controls.Add(this.AddDriver_button);
            this.tabPageDrivers.Controls.Add(this.UpdateDriver_button);
            this.tabPageDrivers.Controls.Add(this.LoadDrivers_button);
            this.tabPageDrivers.Controls.Add(this.dataGridView_Drivers);
            this.tabPageDrivers.Location = new System.Drawing.Point(4, 24);
            this.tabPageDrivers.Name = "tabPageDrivers";
            this.tabPageDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrivers.Size = new System.Drawing.Size(1112, 508);
            this.tabPageDrivers.TabIndex = 0;
            this.tabPageDrivers.Text = "Vozači";
            this.tabPageDrivers.UseVisualStyleBackColor = true;
            // 
            // AddDriver_button
            // 
            this.AddDriver_button.Location = new System.Drawing.Point(3, 196);
            this.AddDriver_button.Name = "AddDriver_button";
            this.AddDriver_button.Size = new System.Drawing.Size(147, 66);
            this.AddDriver_button.TabIndex = 3;
            this.AddDriver_button.Text = "Dodaj Vozača";
            this.AddDriver_button.UseVisualStyleBackColor = true;
            this.AddDriver_button.Click += new System.EventHandler(this.AddDriver_button_Click);
            // 
            // UpdateDriver_button
            // 
            this.UpdateDriver_button.Location = new System.Drawing.Point(3, 112);
            this.UpdateDriver_button.Name = "UpdateDriver_button";
            this.UpdateDriver_button.Size = new System.Drawing.Size(147, 66);
            this.UpdateDriver_button.TabIndex = 2;
            this.UpdateDriver_button.Text = "Izmeni Vozača";
            this.UpdateDriver_button.UseVisualStyleBackColor = true;
            this.UpdateDriver_button.Click += new System.EventHandler(this.UpdateDriver_button_Click);
            // 
            // LoadDrivers_button
            // 
            this.LoadDrivers_button.Location = new System.Drawing.Point(3, 28);
            this.LoadDrivers_button.Name = "LoadDrivers_button";
            this.LoadDrivers_button.Size = new System.Drawing.Size(147, 66);
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
            this.tabPageVehicles.Controls.Add(this.AddNewVehicle_button);
            this.tabPageVehicles.Controls.Add(this.EditVehicle_button);
            this.tabPageVehicles.Controls.Add(this.LoadVehicles_button);
            this.tabPageVehicles.Controls.Add(this.dataGridView_Vehicles);
            this.tabPageVehicles.Location = new System.Drawing.Point(4, 24);
            this.tabPageVehicles.Name = "tabPageVehicles";
            this.tabPageVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehicles.Size = new System.Drawing.Size(1112, 508);
            this.tabPageVehicles.TabIndex = 1;
            this.tabPageVehicles.Text = "Vozila";
            this.tabPageVehicles.UseVisualStyleBackColor = true;
            // 
            // AddNewVehicle_button
            // 
            this.AddNewVehicle_button.Location = new System.Drawing.Point(3, 196);
            this.AddNewVehicle_button.Name = "AddNewVehicle_button";
            this.AddNewVehicle_button.Size = new System.Drawing.Size(147, 66);
            this.AddNewVehicle_button.TabIndex = 7;
            this.AddNewVehicle_button.Text = "Dodaj Novo Vozilo";
            this.AddNewVehicle_button.UseVisualStyleBackColor = true;
            this.AddNewVehicle_button.Click += new System.EventHandler(this.AddNewVehicle_button_Click);
            // 
            // EditVehicle_button
            // 
            this.EditVehicle_button.Location = new System.Drawing.Point(3, 112);
            this.EditVehicle_button.Name = "EditVehicle_button";
            this.EditVehicle_button.Size = new System.Drawing.Size(147, 66);
            this.EditVehicle_button.TabIndex = 6;
            this.EditVehicle_button.Text = "Izmeni Vozilo";
            this.EditVehicle_button.UseVisualStyleBackColor = true;
            this.EditVehicle_button.Click += new System.EventHandler(this.EditVehicle_button_Click);
            // 
            // LoadVehicles_button
            // 
            this.LoadVehicles_button.Location = new System.Drawing.Point(3, 28);
            this.LoadVehicles_button.Name = "LoadVehicles_button";
            this.LoadVehicles_button.Size = new System.Drawing.Size(147, 66);
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
            this.tabPageInvoices.Location = new System.Drawing.Point(4, 24);
            this.tabPageInvoices.Name = "tabPageInvoices";
            this.tabPageInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInvoices.Size = new System.Drawing.Size(1112, 508);
            this.tabPageInvoices.TabIndex = 2;
            this.tabPageInvoices.Text = "Fakture";
            this.tabPageInvoices.UseVisualStyleBackColor = true;
            // 
            // TruckSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "TruckSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruckSystem";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Drivers)).EndInit();
            this.tabPageVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

