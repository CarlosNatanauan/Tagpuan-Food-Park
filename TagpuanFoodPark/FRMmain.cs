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
    public partial class FRMmain : Form
    {
        private Form activeForm = null;
        public FRMmain()
        {
            InitializeComponent();
        }

        private void FRMmain_Load(object sender, EventArgs e)
        {

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            callPanel.Controls.Add(childForm);
            callPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void CloseActiveForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            FRMdashboard f = new FRMdashboard();
            openChildForm(f);
            f.TopLevel = false;
            callPanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btManagement_Click(object sender, EventArgs e)
        {
            FRMstallManagement f = new FRMstallManagement();
            openChildForm(f);
            f.TopLevel = false;
            callPanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            FRMinfo f = new FRMinfo();
            openChildForm(f);
            f.TopLevel = false;
            callPanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btPayments_Click(object sender, EventArgs e)
        {
            FRMpayment f = new FRMpayment();
            openChildForm(f);
            f.TopLevel = false;
            callPanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
