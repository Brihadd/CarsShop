﻿namespace Pricing.PricingSmallForms
{
    partial class PricingForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastBuyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastSallerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPricerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCarBuyerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carRegNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requaredPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLuxuryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dealStateDataGridViewTextBoxColumn,
            this.lastBuyerNameDataGridViewTextBoxColumn,
            this.lastSallerNameDataGridViewTextBoxColumn,
            this.lastPricerNameDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.clientCarBuyerIdDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.carRegNumberDataGridViewTextBoxColumn,
            this.carYearDataGridViewTextBoxColumn,
            this.fuelDataGridViewTextBoxColumn,
            this.kilometersDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.engineNameDataGridViewTextBoxColumn,
            this.enginePowerDataGridViewTextBoxColumn,
            this.engineVolumeDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.requaredPriceDataGridViewTextBoxColumn,
            this.buyPriceDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.isLuxuryDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(934, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dealStateDataGridViewTextBoxColumn
            // 
            this.dealStateDataGridViewTextBoxColumn.DataPropertyName = "DealState";
            this.dealStateDataGridViewTextBoxColumn.HeaderText = "DealState";
            this.dealStateDataGridViewTextBoxColumn.Name = "dealStateDataGridViewTextBoxColumn";
            this.dealStateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dealStateDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastBuyerNameDataGridViewTextBoxColumn
            // 
            this.lastBuyerNameDataGridViewTextBoxColumn.DataPropertyName = "LastBuyerName";
            this.lastBuyerNameDataGridViewTextBoxColumn.HeaderText = "LastBuyerName";
            this.lastBuyerNameDataGridViewTextBoxColumn.Name = "lastBuyerNameDataGridViewTextBoxColumn";
            this.lastBuyerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastSallerNameDataGridViewTextBoxColumn
            // 
            this.lastSallerNameDataGridViewTextBoxColumn.DataPropertyName = "LastSallerName";
            this.lastSallerNameDataGridViewTextBoxColumn.HeaderText = "LastSallerName";
            this.lastSallerNameDataGridViewTextBoxColumn.Name = "lastSallerNameDataGridViewTextBoxColumn";
            this.lastSallerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastSallerNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastPricerNameDataGridViewTextBoxColumn
            // 
            this.lastPricerNameDataGridViewTextBoxColumn.DataPropertyName = "LastPricerName";
            this.lastPricerNameDataGridViewTextBoxColumn.HeaderText = "LastPricerName";
            this.lastPricerNameDataGridViewTextBoxColumn.Name = "lastPricerNameDataGridViewTextBoxColumn";
            this.lastPricerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientCarBuyerIdDataGridViewTextBoxColumn
            // 
            this.clientCarBuyerIdDataGridViewTextBoxColumn.DataPropertyName = "ClientCarBuyerId";
            this.clientCarBuyerIdDataGridViewTextBoxColumn.HeaderText = "ClientCarBuyerId";
            this.clientCarBuyerIdDataGridViewTextBoxColumn.Name = "clientCarBuyerIdDataGridViewTextBoxColumn";
            this.clientCarBuyerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientCarBuyerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Visible = false;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carRegNumberDataGridViewTextBoxColumn
            // 
            this.carRegNumberDataGridViewTextBoxColumn.DataPropertyName = "CarRegNumber";
            this.carRegNumberDataGridViewTextBoxColumn.HeaderText = "CarRegNumber";
            this.carRegNumberDataGridViewTextBoxColumn.Name = "carRegNumberDataGridViewTextBoxColumn";
            this.carRegNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carYearDataGridViewTextBoxColumn
            // 
            this.carYearDataGridViewTextBoxColumn.DataPropertyName = "CarYear";
            this.carYearDataGridViewTextBoxColumn.HeaderText = "CarYear";
            this.carYearDataGridViewTextBoxColumn.Name = "carYearDataGridViewTextBoxColumn";
            this.carYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.carYearDataGridViewTextBoxColumn.Visible = false;
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            this.fuelDataGridViewTextBoxColumn.DataPropertyName = "Fuel";
            this.fuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            this.fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            this.fuelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilometersDataGridViewTextBoxColumn
            // 
            this.kilometersDataGridViewTextBoxColumn.DataPropertyName = "Kilometers";
            this.kilometersDataGridViewTextBoxColumn.HeaderText = "Kilometers";
            this.kilometersDataGridViewTextBoxColumn.Name = "kilometersDataGridViewTextBoxColumn";
            this.kilometersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineNameDataGridViewTextBoxColumn
            // 
            this.engineNameDataGridViewTextBoxColumn.DataPropertyName = "EngineName";
            this.engineNameDataGridViewTextBoxColumn.HeaderText = "EngineName";
            this.engineNameDataGridViewTextBoxColumn.Name = "engineNameDataGridViewTextBoxColumn";
            this.engineNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // enginePowerDataGridViewTextBoxColumn
            // 
            this.enginePowerDataGridViewTextBoxColumn.DataPropertyName = "EnginePower";
            this.enginePowerDataGridViewTextBoxColumn.HeaderText = "EnginePower";
            this.enginePowerDataGridViewTextBoxColumn.Name = "enginePowerDataGridViewTextBoxColumn";
            this.enginePowerDataGridViewTextBoxColumn.ReadOnly = true;
            this.enginePowerDataGridViewTextBoxColumn.Visible = false;
            // 
            // engineVolumeDataGridViewTextBoxColumn
            // 
            this.engineVolumeDataGridViewTextBoxColumn.DataPropertyName = "EngineVolume";
            this.engineVolumeDataGridViewTextBoxColumn.HeaderText = "EngineVolume";
            this.engineVolumeDataGridViewTextBoxColumn.Name = "engineVolumeDataGridViewTextBoxColumn";
            this.engineVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineVolumeDataGridViewTextBoxColumn.Visible = false;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Visible = false;
            // 
            // requaredPriceDataGridViewTextBoxColumn
            // 
            this.requaredPriceDataGridViewTextBoxColumn.DataPropertyName = "RequaredPrice";
            this.requaredPriceDataGridViewTextBoxColumn.HeaderText = "RequaredPrice";
            this.requaredPriceDataGridViewTextBoxColumn.Name = "requaredPriceDataGridViewTextBoxColumn";
            this.requaredPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.requaredPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // buyPriceDataGridViewTextBoxColumn
            // 
            this.buyPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyPrice";
            this.buyPriceDataGridViewTextBoxColumn.HeaderText = "BuyPrice";
            this.buyPriceDataGridViewTextBoxColumn.Name = "buyPriceDataGridViewTextBoxColumn";
            this.buyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // sellPriceDataGridViewTextBoxColumn
            // 
            this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "SellPrice";
            this.sellPriceDataGridViewTextBoxColumn.HeaderText = "SellPrice";
            this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
            this.sellPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // isLuxuryDataGridViewCheckBoxColumn
            // 
            this.isLuxuryDataGridViewCheckBoxColumn.DataPropertyName = "IsLuxury";
            this.isLuxuryDataGridViewCheckBoxColumn.HeaderText = "IsLuxury";
            this.isLuxuryDataGridViewCheckBoxColumn.Name = "isLuxuryDataGridViewCheckBoxColumn";
            this.isLuxuryDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(Models.Car);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(61, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Luxury";
            // 
            // PricingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PricingForm";
            this.Text = "Pricing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PricingForm_FormClosing);
            this.Load += new System.EventHandler(this.PricingForm_Load);
            this.Resize += new System.EventHandler(this.PricingForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastBuyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastSallerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPricerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCarBuyerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carRegNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requaredPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLuxuryDataGridViewCheckBoxColumn;
    }
}