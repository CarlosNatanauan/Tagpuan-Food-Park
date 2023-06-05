namespace TagpuanFoodPark
{
    partial class UCavailable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStallList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.stallNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stallManBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagpuanFoodParkDataSet1 = new TagpuanFoodPark.TagpuanFoodParkDataSet1();
            this.stallManTableAdapter = new TagpuanFoodPark.TagpuanFoodParkDataSet1TableAdapters.StallManTableAdapter();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btAddStall = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btOccupied = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStallList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallManBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStallList
            // 
            this.dgvStallList.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvStallList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStallList.AutoGenerateColumns = false;
            this.dgvStallList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStallList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStallList.ColumnHeadersHeight = 32;
            this.dgvStallList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stallNoDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvStallList.DataSource = this.stallManBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStallList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStallList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvStallList.Location = new System.Drawing.Point(18, 90);
            this.dgvStallList.Name = "dgvStallList";
            this.dgvStallList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStallList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStallList.RowHeadersVisible = false;
            this.dgvStallList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(174)))));
            this.dgvStallList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStallList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStallList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.dgvStallList.RowTemplate.Height = 28;
            this.dgvStallList.Size = new System.Drawing.Size(859, 288);
            this.dgvStallList.TabIndex = 19;
            this.dgvStallList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStallList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStallList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStallList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStallList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStallList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvStallList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.dgvStallList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dgvStallList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStallList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStallList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStallList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStallList.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvStallList.ThemeStyle.ReadOnly = true;
            this.dgvStallList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStallList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStallList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStallList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStallList.ThemeStyle.RowsStyle.Height = 28;
            this.dgvStallList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStallList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStallList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStallList_CellClick);
            this.dgvStallList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStallList_CellContentClick);
            // 
            // stallNoDataGridViewTextBoxColumn
            // 
            this.stallNoDataGridViewTextBoxColumn.DataPropertyName = "stallNo";
            this.stallNoDataGridViewTextBoxColumn.HeaderText = "stallNo";
            this.stallNoDataGridViewTextBoxColumn.Name = "stallNoDataGridViewTextBoxColumn";
            this.stallNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stallManBindingSource
            // 
            this.stallManBindingSource.DataMember = "StallMan";
            this.stallManBindingSource.DataSource = this.tagpuanFoodParkDataSet1;
            // 
            // tagpuanFoodParkDataSet1
            // 
            this.tagpuanFoodParkDataSet1.DataSetName = "TagpuanFoodParkDataSet1";
            this.tagpuanFoodParkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stallManTableAdapter
            // 
            this.stallManTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(18, 5);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(90, 19);
            this.guna2HtmlLabel2.TabIndex = 24;
            this.guna2HtmlLabel2.Text = "Add New Stall";
            // 
            // tbPrice
            // 
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Location = new System.Drawing.Point(18, 32);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "Monthly Rent";
            this.tbPrice.SelectedText = "";
            this.tbPrice.Size = new System.Drawing.Size(118, 36);
            this.tbPrice.TabIndex = 22;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // btAddStall
            // 
            this.btAddStall.BorderRadius = 5;
            this.btAddStall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddStall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddStall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddStall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddStall.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.btAddStall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btAddStall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btAddStall.Location = new System.Drawing.Point(142, 32);
            this.btAddStall.Name = "btAddStall";
            this.btAddStall.Size = new System.Drawing.Size(67, 36);
            this.btAddStall.TabIndex = 21;
            this.btAddStall.Text = "ADD";
            this.btAddStall.Click += new System.EventHandler(this.btAddStall_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(725, 5);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(100, 19);
            this.guna2HtmlLabel3.TabIndex = 27;
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
            this.guna2TextBox1.Location = new System.Drawing.Point(725, 32);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(72, 36);
            this.guna2TextBox1.TabIndex = 26;
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
            this.guna2Button3.Location = new System.Drawing.Point(803, 32);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(72, 36);
            this.guna2Button3.TabIndex = 25;
            this.guna2Button3.Text = "SEARCH";
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
            this.guna2Button2.Location = new System.Drawing.Point(679, 413);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(95, 36);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.Text = "DELETE";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.guna2Button1.Location = new System.Drawing.Point(780, 413);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 36);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "UPDATE";
            // 
            // btOccupied
            // 
            this.btOccupied.BorderRadius = 5;
            this.btOccupied.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btOccupied.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btOccupied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btOccupied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btOccupied.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.btOccupied.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btOccupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btOccupied.Location = new System.Drawing.Point(18, 413);
            this.btOccupied.Name = "btOccupied";
            this.btOccupied.Size = new System.Drawing.Size(112, 36);
            this.btOccupied.TabIndex = 29;
            this.btOccupied.Text = "OCCUPIED";
            this.btOccupied.Click += new System.EventHandler(this.btOccupied_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 386);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(127, 19);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "Set Stall Availability";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(679, 386);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(107, 19);
            this.guna2HtmlLabel4.TabIndex = 32;
            this.guna2HtmlLabel4.Text = "Modify Stall Info";
            // 
            // UCavailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btOccupied);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btAddStall);
            this.Controls.Add(this.dgvStallList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UCavailable";
            this.Size = new System.Drawing.Size(902, 465);
            this.Load += new System.EventHandler(this.UCavailable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStallList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallManBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvStallList;
        private System.Windows.Forms.BindingSource stallManBindingSource;
        private TagpuanFoodParkDataSet1 tagpuanFoodParkDataSet1;
        private TagpuanFoodParkDataSet1TableAdapters.StallManTableAdapter stallManTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private Guna.UI2.WinForms.Guna2Button btAddStall;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btOccupied;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stallNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}
