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
    public partial class ListDriverFrm : Form
    {
        private DataView _DVDriver;

        public ListDriverFrm()
        {
            InitializeComponent();
            _LoadData();
            SearchTextBox.Visible = false;
            FilterByComboBox.SelectedIndex = 0;
        }
        private void _LoadData()
        {
            DataTable DTDriver = ClsDriver.GetAllDrivers();
            if (DTDriver == null)
            {
                MessageBox.Show("There is No Data");
                return;
            }
            dataGridView1.DataSource = DTDriver;
            _DVDriver = DTDriver.DefaultView;
            RecoredResultLbl.Text = dataGridView1.Rows.Count.ToString();



        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByComboBox.Text == "None")
            {
                SearchTextBox.Visible = false;
                SearchTextBox.Clear();
                if (_DVDriver != null)
                {
                    _DVDriver.RowFilter = "";
                    RecoredResultLbl.Text = _DVDriver.Count.ToString();
                }



            }
            else
            {
                SearchTextBox.Visible = true;
                SearchTextBox.Clear();
                SearchTextBox.Focus();

            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_DVDriver == null)
            {
                return;
            }

            string FilterColumn = "";

            switch (FilterByComboBox.Text)
            {
                case "Driver ID": FilterColumn = "DriverID"; break;
                case "Person ID": FilterColumn = "PersonID"; break;
                case "National No": FilterColumn = "NationalNo"; break;
                case "Full Name": FilterColumn = "FullName"; break;
                default: FilterColumn = "None"; break;
            }

            if (string.IsNullOrEmpty(FilterByComboBox.Text) || FilterColumn == "None")
            {
                _DVDriver.RowFilter = "";
                RecoredResultLbl.Text = _DVDriver.Count.ToString();
                return;

            }

            try
            {
                string SearchValue = SearchTextBox.Text.Trim();
                if (FilterByComboBox.Text == "Driver ID" || FilterByComboBox.Text == "Person ID")
                {
                    if (string.IsNullOrEmpty(SearchValue))
                    {
                        _DVDriver.RowFilter = "";
                    }
                    else if (int.TryParse(SearchValue, out int value))
                    {
                        _DVDriver.RowFilter = string.Format("[{0}] = {1}", FilterColumn, SearchValue);
                    }
                }
                else
                {
                    SearchValue = SearchTextBox.Text.Trim().Replace("'", "''");
                    _DVDriver.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, SearchValue);
                }

                RecoredResultLbl.Text = _DVDriver.Count.ToString();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FilterByComboBox.Text == "Driver ID" || FilterByComboBox.Text == "PersonID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

      
    }
}
