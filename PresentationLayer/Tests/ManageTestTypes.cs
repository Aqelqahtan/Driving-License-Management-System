using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
            _LoadTestTypesData();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataView _dvTestTypes;

        private void _LoadTestTypesData()
        {
            DataTable dtTestData = ClsTestType.GetAllTestType();
            _dvTestTypes = dtTestData.DefaultView;
            dataGridView1.DataSource = _dvTestTypes;

            RecoredTestTypeResultLbl.Text = ClsTestType.CountTestType().ToString();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dataGridView1.CurrentRow.Cells["TestTypeID"].Value;
            UpdateTestTypeFrm frm = new UpdateTestTypeFrm(TestTypeID);
            frm.ShowDialog();

            _LoadTestTypesData();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
