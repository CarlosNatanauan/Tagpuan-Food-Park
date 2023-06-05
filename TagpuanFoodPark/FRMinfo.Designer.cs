namespace TagpuanFoodPark
{
    partial class FRMinfo
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
            this.btInfoClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tenantInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagpuanFoodParkDataSet3 = new TagpuanFoodPark.TagpuanFoodParkDataSet3();
            this.tenantInfoTableAdapter = new TagpuanFoodPark.TagpuanFoodParkDataSet3TableAdapters.tenantInfoTableAdapter();
            this.dgvTenantInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.stallNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stallNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tenantInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btInfoClose
            // 
            this.btInfoClose.BorderRadius = 5;
            this.btInfoClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btInfoClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btInfoClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btInfoClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btInfoClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.btInfoClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfoClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(209)))));
            this.btInfoClose.Location = new System.Drawing.Point(853, 6);
            this.btInfoClose.Name = "btInfoClose";
            this.btInfoClose.Size = new System.Drawing.Size(72, 24);
            this.btInfoClose.TabIndex = 11;
            this.btInfoClose.Text = "CLOSE";
            this.btInfoClose.Click += new System.EventHandler(this.btInfoClose_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(60, 80);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(152, 22);
            this.guna2HtmlLabel2.TabIndex = 30;
            this.guna2HtmlLabel2.Text = "Tenant\'s Information";
            // 
            // tenantInfoBindingSource
            // 
            this.tenantInfoBindingSource.DataMember = "tenantInfo";
            this.tenantInfoBindingSource.DataSource = this.tagpuanFoodParkDataSet3;
            // 
            // tagpuanFoodParkDataSet3
            // 
            this.tagpuanFoodParkDataSet3.DataSetName = "TagpuanFoodParkDataSet3";
            this.tagpuanFoodParkDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenantInfoTableAdapter
            // 
            this.tenantInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTenantInfo
            // 
            this.dgvTenantInfo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvTenantInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTenantInfo.AutoGenerateColumns = false;
            this.dgvTenantInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTenantInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTenantInfo.ColumnHeadersHeight = 32;
            this.dgvTenantInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stallNoDataGridViewTextBoxColumn,
            this.stallNameDataGridViewTextBoxColumn,
            this.tenantNameDataGridViewTextBoxColumn});
            this.dgvTenantInfo.DataSource = this.tenantInfoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTenantInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTenantInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dgvTenantInfo.Location = new System.Drawing.Point(60, 121);
            this.dgvTenantInfo.Name = "dgvTenantInfo";
            this.dgvTenantInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTenantInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTenantInfo.RowHeadersVisible = false;
            this.dgvTenantInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(174)))));
            this.dgvTenantInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTenantInfo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTenantInfo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.dgvTenantInfo.RowTemplate.Height = 28;
            this.dgvTenantInfo.Size = new System.Drawing.Size(808, 396);
            this.dgvTenantInfo.TabIndex = 31;
            this.dgvTenantInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTenantInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTenantInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTenantInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTenantInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTenantInfo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvTenantInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dgvTenantInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dgvTenantInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTenantInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTenantInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTenantInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTenantInfo.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvTenantInfo.ThemeStyle.ReadOnly = true;
            this.dgvTenantInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTenantInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTenantInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTenantInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTenantInfo.ThemeStyle.RowsStyle.Height = 28;
            this.dgvTenantInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTenantInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // stallNoDataGridViewTextBoxColumn
            // 
            this.stallNoDataGridViewTextBoxColumn.DataPropertyName = "stallNo";
            this.stallNoDataGridViewTextBoxColumn.HeaderText = "stallNo";
            this.stallNoDataGridViewTextBoxColumn.Name = "stallNoDataGridViewTextBoxColumn";
            this.stallNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.guna2Button2.Location = new System.Drawing.Point(774, 539);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(95, 36);
            this.guna2Button2.TabIndex = 32;
            this.guna2Button2.Text = "DETAILS";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(719, 39);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(100, 19);
            this.guna2HtmlLabel3.TabIndex = 35;
            this.guna2HtmlLabel3.Text = "Search Stall No.";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(719, 66);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(72, 36);
            this.guna2TextBox1.TabIndex = 34;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(209)))));
            this.guna2Button3.Location = new System.Drawing.Point(797, 66);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(72, 36);
            this.guna2Button3.TabIndex = 33;
            this.guna2Button3.Text = "SEARCH";
            // 
            // FRMinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(929, 598);
            this.ControlBox = false;
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.dgvTenantInfo);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btInfoClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRMinfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenantInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btInfoClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private TagpuanFoodParkDataSet3 tagpuanFoodParkDataSet3;
        private System.Windows.Forms.BindingSource tenantInfoBindingSource;
        private TagpuanFoodParkDataSet3TableAdapters.tenantInfoTableAdapter tenantInfoTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTenantInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stallNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantNameDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}