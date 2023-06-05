using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace TagpuanFoodPark
{
    public partial class FRMstallManagement : Form
    {
        public FRMstallManagement()
        {
            InitializeComponent();
            UCavailable uc = new UCavailable();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btDashboardClose_Click(object sender, EventArgs e)
        {

        }

        private void btSManClose_Click(object sender, EventArgs e)
        {
            FRMmain mainForm = (FRMmain)this.Parent.Parent;
            mainForm.CloseActiveForm();
            this.Close();
        }

        private void FRMstallManagement_Load(object sender, EventArgs e)
        {


        }

        private void btOccupied_Click(object sender, EventArgs e)
        {

   
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }


        private void btPanelAvailable_Click(object sender, EventArgs e)
        {
            UCavailable uc = new UCavailable();
            addUserControl(uc);
        }

        private void btPanelOccupied_Click(object sender, EventArgs e)
        {
            UCoccupied uc = new UCoccupied();
            addUserControl(uc);
        }
    }
}
