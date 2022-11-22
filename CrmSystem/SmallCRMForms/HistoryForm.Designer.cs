namespace CrmSystem.SmallCRMForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(945, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientSurnameDataGridViewTextBoxColumn
            // 
            this.clientSurnameDataGridViewTextBoxColumn.DataPropertyName = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.HeaderText = "ClientSurname";
            this.clientSurnameDataGridViewTextBoxColumn.Name = "clientSurnameDataGridViewTextBoxColumn";
            // 
            // carMakeDataGridViewTextBoxColumn
            // 
            this.carMakeDataGridViewTextBoxColumn.DataPropertyName = "CarMake";
            this.carMakeDataGridViewTextBoxColumn.HeaderText = "CarMake";
            this.carMakeDataGridViewTextBoxColumn.Name = "carMakeDataGridViewTextBoxColumn";
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "CarModel";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            // 
            // carRegNumberDataGridViewTextBoxColumn
            // 
            this.carRegNumberDataGridViewTextBoxColumn.DataPropertyName = "CarRegNumber";
            this.carRegNumberDataGridViewTextBoxColumn.HeaderText = "CarRegNumber";
            this.carRegNumberDataGridViewTextBoxColumn.Name = "carRegNumberDataGridViewTextBoxColumn";
            // 
            // dealTimeDataGridViewTextBoxColumn
            // 
            this.dealTimeDataGridViewTextBoxColumn.DataPropertyName = "DealTime";
            this.dealTimeDataGridViewTextBoxColumn.HeaderText = "DealTime";
            this.dealTimeDataGridViewTextBoxColumn.Name = "dealTimeDataGridViewTextBoxColumn";
            // 
            // dealStateDataGridViewTextBoxColumn
            // 
            this.dealStateDataGridViewTextBoxColumn.DataPropertyName = "DealState";
            this.dealStateDataGridViewTextBoxColumn.HeaderText = "DealState";
            this.dealStateDataGridViewTextBoxColumn.Name = "dealStateDataGridViewTextBoxColumn";
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataSource = typeof(Models.History);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Column";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CarId",
            "ClientId",
            "ClientName",
            "ClientSurname",
            "CarMake",
            "CarModel",
            "CarRegNumber",
            "DealTime",
            "DealState"});
            this.comboBox1.Location = new System.Drawing.Point(78, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}