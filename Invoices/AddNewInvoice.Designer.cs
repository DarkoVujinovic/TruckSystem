
namespace TruckSystem
{
    partial class AddNewInvoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_InvoiceDriver = new System.Windows.Forms.ComboBox();
            this.comboBox_InvoiceVehicle = new System.Windows.Forms.ComboBox();
            this.textBox_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_InvoiceDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_InvoiceBaseValue = new System.Windows.Forms.TextBox();
            this.textBox_InvoiceVAT = new System.Windows.Forms.TextBox();
            this.textBox_InvoiceFinalValue = new System.Windows.Forms.TextBox();
            this.AddInvoice_CancelButton = new System.Windows.Forms.Button();
            this.AddInvoice_ApplyButton = new System.Windows.Forms.Button();
            this.comboBox_InvoiceCompanyName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_InvoiceCompanyName);
            this.groupBox1.Controls.Add(this.comboBox_InvoiceDriver);
            this.groupBox1.Controls.Add(this.comboBox_InvoiceVehicle);
            this.groupBox1.Controls.Add(this.textBox_InvoiceNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker_InvoiceDeliveryDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_InvoiceBaseValue);
            this.groupBox1.Controls.Add(this.textBox_InvoiceVAT);
            this.groupBox1.Controls.Add(this.textBox_InvoiceFinalValue);
            this.groupBox1.Controls.Add(this.AddInvoice_CancelButton);
            this.groupBox1.Controls.Add(this.AddInvoice_ApplyButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 401);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o fakturi";
            // 
            // comboBox_InvoiceDriver
            // 
            this.comboBox_InvoiceDriver.FormattingEnabled = true;
            this.comboBox_InvoiceDriver.Location = new System.Drawing.Point(144, 295);
            this.comboBox_InvoiceDriver.Name = "comboBox_InvoiceDriver";
            this.comboBox_InvoiceDriver.Size = new System.Drawing.Size(186, 23);
            this.comboBox_InvoiceDriver.TabIndex = 48;
            // 
            // comboBox_InvoiceVehicle
            // 
            this.comboBox_InvoiceVehicle.FormattingEnabled = true;
            this.comboBox_InvoiceVehicle.Location = new System.Drawing.Point(144, 250);
            this.comboBox_InvoiceVehicle.Name = "comboBox_InvoiceVehicle";
            this.comboBox_InvoiceVehicle.Size = new System.Drawing.Size(186, 23);
            this.comboBox_InvoiceVehicle.TabIndex = 47;
            // 
            // textBox_InvoiceNumber
            // 
            this.textBox_InvoiceNumber.Location = new System.Drawing.Point(146, 336);
            this.textBox_InvoiceNumber.Name = "textBox_InvoiceNumber";
            this.textBox_InvoiceNumber.Size = new System.Drawing.Size(184, 23);
            this.textBox_InvoiceNumber.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Broj fakture:";
            // 
            // dateTimePicker_InvoiceDeliveryDate
            // 
            this.dateTimePicker_InvoiceDeliveryDate.CustomFormat = "";
            this.dateTimePicker_InvoiceDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_InvoiceDeliveryDate.Location = new System.Drawing.Point(146, 76);
            this.dateTimePicker_InvoiceDeliveryDate.Name = "dateTimePicker_InvoiceDeliveryDate";
            this.dateTimePicker_InvoiceDeliveryDate.Size = new System.Drawing.Size(109, 23);
            this.dateTimePicker_InvoiceDeliveryDate.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Datum isporuke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naziv firme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Osnovna cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "PDV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Konačna cena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Vozilo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Vozač:";
            // 
            // textBox_InvoiceBaseValue
            // 
            this.textBox_InvoiceBaseValue.Location = new System.Drawing.Point(146, 119);
            this.textBox_InvoiceBaseValue.Name = "textBox_InvoiceBaseValue";
            this.textBox_InvoiceBaseValue.Size = new System.Drawing.Size(184, 23);
            this.textBox_InvoiceBaseValue.TabIndex = 28;
            // 
            // textBox_InvoiceVAT
            // 
            this.textBox_InvoiceVAT.Location = new System.Drawing.Point(146, 162);
            this.textBox_InvoiceVAT.Name = "textBox_InvoiceVAT";
            this.textBox_InvoiceVAT.Size = new System.Drawing.Size(184, 23);
            this.textBox_InvoiceVAT.TabIndex = 29;
            // 
            // textBox_InvoiceFinalValue
            // 
            this.textBox_InvoiceFinalValue.Location = new System.Drawing.Point(146, 207);
            this.textBox_InvoiceFinalValue.Name = "textBox_InvoiceFinalValue";
            this.textBox_InvoiceFinalValue.Size = new System.Drawing.Size(184, 23);
            this.textBox_InvoiceFinalValue.TabIndex = 30;
            // 
            // AddInvoice_CancelButton
            // 
            this.AddInvoice_CancelButton.Location = new System.Drawing.Point(255, 372);
            this.AddInvoice_CancelButton.Name = "AddInvoice_CancelButton";
            this.AddInvoice_CancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddInvoice_CancelButton.TabIndex = 1;
            this.AddInvoice_CancelButton.Text = "Otkaži";
            this.AddInvoice_CancelButton.UseVisualStyleBackColor = true;
            this.AddInvoice_CancelButton.Click += new System.EventHandler(this.AddInvoice_CancelButton_Click);
            // 
            // AddInvoice_ApplyButton
            // 
            this.AddInvoice_ApplyButton.Location = new System.Drawing.Point(160, 372);
            this.AddInvoice_ApplyButton.Name = "AddInvoice_ApplyButton";
            this.AddInvoice_ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.AddInvoice_ApplyButton.TabIndex = 0;
            this.AddInvoice_ApplyButton.Text = "Dodaj";
            this.AddInvoice_ApplyButton.UseVisualStyleBackColor = true;
            this.AddInvoice_ApplyButton.Click += new System.EventHandler(this.AddInvoice_ApplyButton_Click);
            // 
            // comboBox_InvoiceCompanyName
            // 
            this.comboBox_InvoiceCompanyName.FormattingEnabled = true;
            this.comboBox_InvoiceCompanyName.Location = new System.Drawing.Point(146, 33);
            this.comboBox_InvoiceCompanyName.Name = "comboBox_InvoiceCompanyName";
            this.comboBox_InvoiceCompanyName.Size = new System.Drawing.Size(184, 23);
            this.comboBox_InvoiceCompanyName.TabIndex = 49;
            // 
            // AddNewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 423);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewInvoice";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodajNovuFakturu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_InvoiceDeliveryDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddInvoice_ApplyButton;
        private System.Windows.Forms.Button AddInvoice_CancelButton;
        private System.Windows.Forms.TextBox textBox_InvoiceFinalValue;
        private System.Windows.Forms.TextBox textBox_InvoiceBaseValue;
        private System.Windows.Forms.TextBox textBox_InvoiceVAT;
        private System.Windows.Forms.TextBox textBox_InvoiceNumber;
        private System.Windows.Forms.ComboBox comboBox_InvoiceVehicle;
        private System.Windows.Forms.ComboBox comboBox_InvoiceDriver;
        private System.Windows.Forms.ComboBox comboBox_InvoiceCompanyName;
    }
}