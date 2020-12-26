﻿
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddDriver_button = new System.Windows.Forms.Button();
            this.UpdateDriver_button = new System.Windows.Forms.Button();
            this.LoadDrivers_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 536);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddDriver_button);
            this.tabPage1.Controls.Add(this.UpdateDriver_button);
            this.tabPage1.Controls.Add(this.LoadDrivers_button);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vozači";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddDriver_button
            // 
            this.AddDriver_button.Location = new System.Drawing.Point(12, 193);
            this.AddDriver_button.Name = "AddDriver_button";
            this.AddDriver_button.Size = new System.Drawing.Size(147, 66);
            this.AddDriver_button.TabIndex = 3;
            this.AddDriver_button.Text = "Dodaj Vozača";
            this.AddDriver_button.UseVisualStyleBackColor = true;
            this.AddDriver_button.Click += new System.EventHandler(this.AddDriver_button_Click);
            // 
            // UpdateDriver_button
            // 
            this.UpdateDriver_button.Location = new System.Drawing.Point(12, 109);
            this.UpdateDriver_button.Name = "UpdateDriver_button";
            this.UpdateDriver_button.Size = new System.Drawing.Size(147, 66);
            this.UpdateDriver_button.TabIndex = 2;
            this.UpdateDriver_button.Text = "Izmeni Vozača";
            this.UpdateDriver_button.UseVisualStyleBackColor = true;
            this.UpdateDriver_button.Click += new System.EventHandler(this.UpdateDriver_button_Click);
            // 
            // LoadDrivers_button
            // 
            this.LoadDrivers_button.Location = new System.Drawing.Point(12, 25);
            this.LoadDrivers_button.Name = "LoadDrivers_button";
            this.LoadDrivers_button.Size = new System.Drawing.Size(147, 66);
            this.LoadDrivers_button.TabIndex = 1;
            this.LoadDrivers_button.Text = "Učitaj Vozače";
            this.LoadDrivers_button.UseVisualStyleBackColor = true;
            this.LoadDrivers_button.Click += new System.EventHandler(this.LoadDrivers_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(165, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(944, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kamioni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1104, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fakture";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadDrivers_button;
        private System.Windows.Forms.Button UpdateDriver_button;
        private System.Windows.Forms.Button AddDriver_button;
    }
}

