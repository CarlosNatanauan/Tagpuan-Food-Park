using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagpuanFoodPark
{
    public partial class FRMinfo : Form
    {
        public FRMinfo()
        {
            InitializeComponent();
        }

        private void btInfoClose_Click(object sender, EventArgs e)
        {
            FRMmain mainForm = (FRMmain)this.Parent.Parent;
            mainForm.CloseActiveForm();
            this.Close();
        }

        private void FRMinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tagpuanFoodParkDataSet3.tenantInfo' table. You can move, or remove it, as needed.
            this.tenantInfoTableAdapter.Fill(this.tagpuanFoodParkDataSet3.tenantInfo);
            dgvTenantInfo.DataSource = DatabaseCodes.GetStallTenantInfo();

        }
    }
}
