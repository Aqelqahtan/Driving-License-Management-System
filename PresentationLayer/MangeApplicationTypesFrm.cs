using BusinessLayer;
using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PresentationLayer
{
    public partial class MangeApplicationTypesFrm : Form
    {
        public MangeApplicationTypesFrm()
        {
            InitializeComponent();
            _LoadDataApplicationTypes();

        }
        private DataView _DVApplicationTypes;
        private void _LoadDataApplicationTypes()
        {
            DataTable DTApplicationTypes = ClsApplicationTypes.GetAllApplicationTypes();
            _DVApplicationTypes = DTApplicationTypes.DefaultView;
            dataGridView1.DataSource = _DVApplicationTypes;
            RecoredTypeResultLbl.Text = ClsApplicationTypes.GetApplicationNumbers().ToString();

        }
        private void MangeApplicationTypesFrm_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1)
                {
                    object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (cellValue != null)
                    {
                        e.ToolTipText = cellValue.ToString();
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = (int)dataGridView1.CurrentRow.Cells["ApplicationTypeID"].Value;
            UpdateApplicationType frm = new UpdateApplicationType(ApplicationTypeID);
            frm.ShowDialog();

            _LoadDataApplicationTypes();
        }

        
    }
}
