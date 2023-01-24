namespace Pricing.PricingSmallForms
{
    partial class HistoryForm
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
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carRegNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
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
            this.carIdDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn,
            this.carMakeDataGridViewTextBoxColumn,
            this.carModelDataGridViewTextBoxColumn,
            this.carRegNumberDataGridViewTextBoxColumn,
            this.dealTimeDataGridViewTextBoxColumn,
            this.dealStateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(943, 387);
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
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientSurnameDataGridViewTextBoxColumn
            // 
            this.clientSurnameDataGridViewTextBoxColumn.DataPropertyName = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.HeaderText = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.Name = "clientSurnameDataGridViewTextBoxColumn";
            this.clientSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carMakeDataGridViewTextBoxColumn
            // 
            this.carMakeDataGridViewTextBoxColumn.DataPropertyName = "CarMake";
            this.carMakeDataGridViewTextBoxColumn.HeaderText = "CarMake";
            this.carMakeDataGridViewTextBoxColumn.Name = "carMakeDataGridViewTextBoxColumn";
            this.carMakeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "CarModel";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            this.carModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carRegNumberDataGridViewTextBoxColumn
            // 
            this.carRegNumberDataGridViewTextBoxColumn.DataPropertyName = "CarRegNumber";
            this.carRegNumberDataGridViewTextBoxColumn.HeaderText = "CarRegNumber";
            this.carRegNumberDataGridViewTextBoxColumn.Name = "carRegNumberDataGridViewTextBoxColumn";
            this.carRegNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealTimeDataGridViewTextBoxColumn
            // 
            this.dealTimeDataGridViewTextBoxColumn.DataPropertyName = "DealTime";
            this.dealTimeDataGridViewTextBoxColumn.HeaderText = "DealTime";
            this.dealTimeDataGridViewTextBoxColumn.Name = "dealTimeDataGridViewTextBoxColumn";
            this.dealTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealStateDataGridViewTextBoxColumn
            // 
            this.dealStateDataGridViewTextBoxColumn.DataPropertyName = "DealState";
            this.dealStateDataGridViewTextBoxColumn.HeaderText = "DealState";
            this.dealStateDataGridViewTextBoxColumn.Name = "dealStateDataGridViewTextBoxColumn";
            this.dealStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataSource = typeof(Models.History);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 417);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistoryForm";
            this.Text = "History";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.Resize += new System.EventHandler(this.HistoryForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carRegNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealStateDataGridViewTextBoxColumn;
    }
}