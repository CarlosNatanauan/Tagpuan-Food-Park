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
    public partial class FRMsetInfo : Form
    {
        public FRMsetInfo()
        {
            InitializeComponent();
            btInfoCancel.Click += btInfoCancel_Click;
        }
        public string StallName => tbStallName.Text;
        public string TenantName => tbTenantName.Text;
        public string Contact => tbContact.Text;
        public DateTime DateOccupied => dtpDateOccupied.Value;
        public int NoMonthsPaid => (int)nudNoMonthsPaid.Value;

       // public DialogResult DialogResult { get; set; } = DialogResult.Cancel;

        private void btInfoOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbStallName.Text) || string.IsNullOrWhiteSpace(tbTenantName.Text) || string.IsNullOrWhiteSpace(tbContact.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK; // Set the DialogResult to OK
                this.Close();
            }
        }

        private void btInfoCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbStallName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenantName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateOccupied_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudNoMonthsPaid_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FRMsetInfo_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
