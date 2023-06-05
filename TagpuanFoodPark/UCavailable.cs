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
        

        public partial class UCavailable : UserControl
        {
        public event EventHandler ProgressBarUpdateRequested;
        public UCavailable()
            {
                InitializeComponent();
            }

            public event EventHandler<int> StallSelected;



            private void btAddStall_Click(object sender, EventArgs e)
            {
                //string type = cbType.SelectedItem.ToString();
                int price = int.Parse(tbPrice.Text);

                DatabaseCodes.AddStall(price);

                // Refresh the DataGridView
                dgvStallList.DataSource = DatabaseCodes.GetStallList();
            }

            private void UCavailable_Load(object sender, EventArgs e)
            {
                dgvStallList.DataSource = DatabaseCodes.GetStallList();

            }

            private void bindingSource1_CurrentChanged(object sender, EventArgs e)
            {

            }

            private void dgvStallList_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void dgvStallList_CellClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void btOccupied_Click(object sender, EventArgs e)
            {
            if (dgvStallList.SelectedRows.Count > 0)
            {
                int stallNo = Convert.ToInt32(dgvStallList.SelectedRows[0].Cells[0].Value);
                int price = Convert.ToInt32(dgvStallList.SelectedRows[0].Cells[1].Value);

                // Show FRMsetInfo form and get user input
                using (var frmSetInfo = new FRMsetInfo())
                {
                    if (frmSetInfo.ShowDialog() == DialogResult.OK)
                    {
                        string stallName = frmSetInfo.StallName;
                        string tenantName = frmSetInfo.TenantName;
                        string contact = frmSetInfo.Contact;
                        DateTime dateOccupied = frmSetInfo.DateOccupied;
                        int noMonthsPaid = frmSetInfo.NoMonthsPaid;

                        // Calculate balance
                        int balance = 0;

                        // Insert tenant info into the database
                        DatabaseCodes.InsertTenantInfo(stallNo, stallName, tenantName, contact, dateOccupied, price, noMonthsPaid);
                        // Move to stall occupied table
                        DatabaseCodes.MoveStallToOccupied(stallNo, price);

                        // Refresh the DataGridView
                        dgvStallList.DataSource = DatabaseCodes.GetStallList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a stall to move.", "No stall selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
