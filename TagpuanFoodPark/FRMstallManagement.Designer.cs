namespace TagpuanFoodPark
{
    partial class FRMstallManagement
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
            this.btSManClose = new Guna.UI2.WinForms.Guna2Button();
            this.tagpuanFoodParkDataSet = new TagpuanFoodPark.TagpuanFoodParkDataSet();
            this.stallManBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stallManTableAdapter = new TagpuanFoodPark.TagpuanFoodParkDataSetTableAdapters.StallManTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btPanelAvailable = new Guna.UI2.WinForms.Guna2Button();
            this.btPanelOccupied = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallManBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSManClose
            // 
            this.btSManClose.BorderRadius = 5;
            this.btSManClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSManClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSManClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSManClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSManClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.btSManClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSManClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(209)))));
            this.btSManClose.Location = new System.Drawing.Point(845, 12);
            this.btSManClose.Name = "btSManClose";
            this.btSManClose.Size = new System.Drawing.Size(72, 24);
            this.btSManClose.TabIndex = 10;
            this.btSManClose.Text = "CLOSE";
            this.btSManClose.Click += new System.EventHandler(this.btSManClose_Click);
            // 
            // tagpuanFoodParkDataSet
            // 
            this.tagpuanFoodParkDataSet.DataSetName = "TagpuanFoodParkDataSet";
            this.tagpuanFoodParkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stallManBindingSource
            // 
            this.stallManBindingSource.DataMember = "StallMan";
            this.stallManBindingSource.DataSource = this.tagpuanFoodParkDataSet;
            // 
            // stallManTableAdapter
            // 
            this.stallManTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panelContainer);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(15, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(902, 513);
            this.guna2Panel1.TabIndex = 22;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 48);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(902, 465);
            this.panelContainer.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btPanelAvailable);
            this.guna2Panel2.Controls.Add(this.btPanelOccupied);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(902, 48);
            this.guna2Panel2.TabIndex = 5;
            // 
            // btPanelAvailable
            // 
            this.btPanelAvailable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btPanelAvailable.Checked = true;
            this.btPanelAvailable.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(209)))));
            this.btPanelAvailable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.btPanelAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelAvailable.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btPanelAvailable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPanelAvailable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPanelAvailable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPanelAvailable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPanelAvailable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.btPanelAvailable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btPanelAvailable.ForeColor = System.Drawing.Color.Gray;
            this.btPanelAvailable.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btPanelAvailable.Location = new System.Drawing.Point(3, 4);
            this.btPanelAvailable.Name = "btPanelAvailable";
            this.btPanelAvailable.Size = new System.Drawing.Size(446, 40);
            this.btPanelAvailable.TabIndex = 3;
            this.btPanelAvailable.Text = "AVAILABLE STALL";
            this.btPanelAvailable.Click += new System.EventHandler(this.btPanelAvailable_Click);
            // 
            // btPanelOccupied
            // 
            this.btPanelOccupied.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btPanelOccupied.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(209)))));
            this.btPanelOccupied.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.btPanelOccupied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelOccupied.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btPanelOccupied.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPanelOccupied.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPanelOccupied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPanelOccupied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPanelOccupied.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.btPanelOccupied.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPanelOccupied.ForeColor = System.Drawing.Color.Gray;
            this.btPanelOccupied.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btPanelOccupied.Location = new System.Drawing.Point(453, 4);
            this.btPanelOccupied.Name = "btPanelOccupied";
            this.btPanelOccupied.Size = new System.Drawing.Size(446, 40);
            this.btPanelOccupied.TabIndex = 4;
            this.btPanelOccupied.Text = "OCCUPIED STALL";
            this.btPanelOccupied.Click += new System.EventHandler(this.btPanelOccupied_Click);
            // 
            // FRMstallManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(929, 598);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btSManClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRMstallManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMstallManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagpuanFoodParkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallManBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btSManClose;
        private TagpuanFoodParkDataSet tagpuanFoodParkDataSet;
        private System.Windows.Forms.BindingSource stallManBindingSource;
        private TagpuanFoodParkDataSetTableAdapters.StallManTableAdapter stallManTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btPanelAvailable;
        private Guna.UI2.WinForms.Guna2Button btPanelOccupied;
    }
}