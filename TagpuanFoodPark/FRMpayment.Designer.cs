namespace TagpuanFoodPark
{
    partial class FRMpayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btPaymentClose = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPayment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tagpuanFoodParkDataSet4 = new TagpuanFoodPark.TagpuanFoodParkDataSet4();
            this.paymentsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsInfoTableAdapter = new TagpuanFoodPark.TagpuanFoodParkDataSet4TableAdapters.paymentsInfoTableAdapter();
            this.stallNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stallNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btPaymentClose
            // 
            this.btPaymentClose.BorderRadius = 5;
            this.btPaymentClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPaymentClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPaymentClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPaymentClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPaymentClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.btPaymentClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPaymentClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(209)))));
            this.btPaymentClose.Location = new System.Drawing.Point(853, 6);
            this.btPaymentClose.Name = "btPaymentClose";
            this.btPaymentClose.Size = new System.Drawing.Size(72, 24);
            this.btPaymentClose.TabIndex = 9;
            this.btPaymentClose.Text = "CLOSE";
            this.btPaymentClose.Click += new System.EventHandler(this.btPaymentClose_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.AutoGenerateColumns = false;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.ColumnHeadersHeight = 32;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stallNumberDataGridViewTextBoxColumn,
            this.stallNameDataGridViewTextBoxColumn,
            this.tenantNameDataGridViewTextBoxColumn,
            this.rentDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn});
            this.dgvPayment.DataSource = this.paymentsInfoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dgvPayment.Location = new System.Drawing.Point(13, 114);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayment.RowHeadersVisible = false;
            this.dgvPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(174)))));
            this.dgvPayment.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayment.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.dgvPayment.RowTemplate.Height = 28;
            this.dgvPayment.Size = new System.Drawing.Size(902, 392);
            this.dgvPayment.TabIndex = 33;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvPayment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dgvPayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dgvPayment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayment.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvPayment.ThemeStyle.ReadOnly = true;
            this.dgvPayment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 20);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(120, 22);
            this.guna2HtmlLabel2.TabIndex = 32;
            this.guna2HtmlLabel2.Text = "Payment Section";
            // 
            // tagpuanFoodParkDataSet4
            // 
            this.tagpuanFoodParkDataSet4.DataSetName = "TagpuanFoodParkDataSet4";
            this.tagpuanFoodParkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsInfoBindingSource
            // 
            this.paymentsInfoBindingSource.DataMember = "paymentsInfo";
            this.paymentsInfoBindingSource.DataSource = this.tagpuanFoodParkDataSet4;
            // 
            // paymentsInfoTableAdapter
            // 
            this.paymentsInfoTableAdapter.ClearBeforeFill = true;
            // 
            // stallNumberDataGridViewTextBoxColumn
            // 
            this.stallNumberDataGridViewTextBoxColumn.DataPropertyName = "stallNumber";
            this.stallNumberDataGridViewTextBoxColumn.HeaderText = "stallNumber";
            this.stallNumberDataGridViewTextBoxColumn.Name = "stallNumberDataGridViewTextBoxColumn";
            this.stallNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stallNameDataGridViewTextBoxColumn
            // 
            this.stallNameDataGridViewTextBoxColumn.DataPropertyName = "stallName";
            this.stallNameDataGridViewTextBoxColumn.HeaderText = "stallName";
            this.stallNameDataGridViewTextBoxColumn.Name = "stallNameDataGridViewTextBoxColumn";
            this.stallNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantNameDataGridViewTextBoxColumn
            // 
            this.tenantNameDataGridViewTextBoxColumn.DataPropertyName = "tenantName";
            this.tenantNameDataGridViewTextBoxColumn.HeaderText = "tenantName";
            this.tenantNameDataGridViewTextBoxColumn.Name = "tenantNameDataGridViewTextBoxColumn";
            this.tenantNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentDataGridViewTextBoxColumn
            // 
            this.rentDataGridViewTextBoxColumn.DataPropertyName = "rent";
            this.rentDataGridViewTextBoxColumn.HeaderText = "rent";
            this.rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            this.rentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "debt";
            this.debtDataGridViewTextBoxColumn.HeaderText = "debt";
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FRMpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(929, 598);
            this.ControlBox = false;
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btPaymentClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRMpayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMpayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btPaymentClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayment;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private TagpuanFoodParkDataSet4 tagpuanFoodParkDataSet4;
        private System.Windows.Forms.BindingSource paymentsInfoBindingSource;
        private TagpuanFoodParkDataSet4TableAdapters.paymentsInfoTableAdapter paymentsInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stallNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
    }
}