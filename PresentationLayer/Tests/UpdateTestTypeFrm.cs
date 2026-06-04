using BusinessLayer;
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
    public partial class UpdateTestTypeFrm : Form
    {

        private int TypeTestID;
        private ClsTestType _TestType;
        public UpdateTestTypeFrm(int TypeTestID)
        {
            InitializeComponent();
            _TestType = ClsTestType.Find(TypeTestID);
            if (_TestType == null)
            {
                MessageBox.Show("There is no TestType");
                this.Close();
                return;
            }
            else
            {
                _LoadTestTypeData();
            }
            TitleTextBox.Enabled = false;

        }



        private void _LoadTestTypeData()
        {

            ApplicationTypeIDResultLbl.Text = _TestType.TestTypeID.ToString();
            TitleTextBox.Text = _TestType.TestTypeTitle;
            DescriptionTextBox.Text = _TestType.TestTypeDescription;
            FeesTextBox.Text = _TestType.TestTypeFees.ToString();


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTestTypeFrm_Load(object sender, EventArgs e)
        {
            _LoadTestTypeData();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeFees = decimal.Parse(FeesTextBox.Text);
            _TestType.TestTypeDescription = DescriptionTextBox.Text;
            if (_TestType.Save())
            {
                MessageBox.Show("Saved Successfully");
                FeesTextBox.Enabled = false;
                DescriptionTextBox.Enabled = false;
                SaveBtn.Enabled = false;
            }else
            {

                MessageBox.Show("Error", "Falied Operation !");
            }
        }
    }
}
