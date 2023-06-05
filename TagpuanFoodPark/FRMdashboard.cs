using Guna.UI2.WinForms;
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
    public partial class FRMdashboard : Form
    {
        
        public FRMdashboard()
        {

            InitializeComponent();
           
        }



        private void btDashboardClose_Click(object sender, EventArgs e)
        {
            FRMmain mainForm = (FRMmain)this.Parent.Parent;
            mainForm.CloseActiveForm();
            this.Close();
        }

        private void FRMdashboard_Load(object sender, EventArgs e)
        {

        }



        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
