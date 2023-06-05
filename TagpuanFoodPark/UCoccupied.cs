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
    public partial class UCoccupied : UserControl
    {
        public UCoccupied()
        {
            InitializeComponent();
        }

        private void UCoccupied_Load(object sender, EventArgs e)
        {
            dgvStallOccupied.DataSource = DatabaseCodes.GetStallListOccupied();
        }

        private void btAvailable_Click(object sender, EventArgs e)
        {
            if (dgvStallOccupied.SelectedRows.Count > 0)
            {
                // Access the cell values using column indices instead of column names
                int stallNo = Convert.ToInt32(dgvStallOccupied.SelectedRows[0].Cells[0].Value);
                int price = Convert.ToInt32(dgvStallOccupied.SelectedRows[0].Cells[1].Value);

                DatabaseCodes.MoveStallToAvailable(stallNo, price);

                // Refresh the DataGridView
                dgvStallOccupied.DataSource = DatabaseCodes.GetStallListOccupied();
            }
            else
            {
                MessageBox.Show("Please select a stall to move.", "No stall selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
