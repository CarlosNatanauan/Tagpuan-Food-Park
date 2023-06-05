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
    public partial class FRMpayment : Form
    {
        public FRMpayment()
        {
            InitializeComponent();
        }

        private void btPaymentClose_Click(object sender, EventArgs e)
        {
            FRMmain mainForm = (FRMmain)this.Parent.Parent;
            mainForm.CloseActiveForm();
            this.Close();
        }

        private void FRMpayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tagpuanFoodParkDataSet4.paymentsInfo' table. You can move, or remove it, as needed.
            this.paymentsInfoTableAdapter.Fill(this.tagpuanFoodParkDataSet4.paymentsInfo);
            dgvPayment.DataSource = DatabaseCodes.GetListPayment();

            foreach (int stallNo in DatabaseCodes.GetAllStallNumbers())
            {
                DatabaseCodes.UpdateDebt(stallNo);
            }
        }
    }
}
