using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{

    public partial class ManagePeopleFrm : Form
    {
        public ManagePeopleFrm()
        {
            InitializeComponent();
            _RefreshPeopleList();
        }

        private DataView _dvPeopleView;


        private void _RefreshPeopleList()
        {
            DataTable dtPeople = ClsPeople.GetAllPerson();
            _dvPeopleView = dtPeople.DefaultView;
            dataGridView1.DataSource = _dvPeopleView;

            RecoredPersonLbl.Text = ClsPeople.GetTotalPerson().ToString();
        }
        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            int UserID = -1;
            AddUpdatePersonFrm frm = new AddUpdatePersonFrm(UserID);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void ManagePeopleFrm_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
            SearchTextBox.Visible = false;
            SearchTextBox.Clear();

            if (FilterByComboBox.Items.Count > 0)
            {
                FilterByComboBox.SelectedIndex = 0;
            }

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = -1;
            AddUpdatePersonFrm frm = new AddUpdatePersonFrm(UserID);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                int PersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (ClsPeople.DeletePerson(PersonID))
                {
                    MessageBox.Show("Deleted successfuly");
                    _RefreshPeopleList();
                }
                else
                {
                    MessageBox.Show("Error this person realeted with other data !!");
                }
            }
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;
            PersonDetailsFrm frm = new PersonDetailsFrm(PersonID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int PersonID = (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;
                AddUpdatePersonFrm frm = new AddUpdatePersonFrm(PersonID);
                frm.ShowDialog();

            }
            _RefreshPeopleList();
        }

        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByComboBox.Text == "None")
            {
                SearchTextBox.Visible = false;
                SearchTextBox.Clear();

                if (_dvPeopleView != null)
                {
                    _dvPeopleView.RowFilter = "";
                    RecoredPersonLbl.Text = _dvPeopleView.Count.ToString();
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
            if (_dvPeopleView == null)
                return;
            string FilterColumn = "";
            switch (FilterByComboBox.Text)
            {
                case "Person ID": FilterColumn = "PersonID"; break;
                case "National NO": FilterColumn = "NationalNO"; break;
                case "First Name": FilterColumn = "FirstName"; break;
                case "Second Name": FilterColumn = "SecondName"; break;
                case "Third Name": FilterColumn = "ThirdName"; break;
                case "Last Name ": FilterColumn = "LastName"; break;
                case "Gendor": FilterColumn = "Gendor"; break;
                case "Date Of Birth": FilterColumn = "DateOfBirth"; break;
                case "Nationality": FilterColumn = "CountryName"; break;
                case "Phone": FilterColumn = "Phone"; break;
                case "Email": FilterColumn = "Email"; break;
                default: FilterColumn = "None"; break;
            }

            if (string.IsNullOrWhiteSpace(SearchTextBox.Text) || FilterColumn == "None")
            {
                _dvPeopleView.RowFilter = "";
                RecoredPersonLbl.Text = _dvPeopleView.Count.ToString();
                return;
            }

            try
            {
                if (FilterColumn == "PersonID")
                {
                    if (int.TryParse(SearchTextBox.Text.Trim(), out int PersonID))
                    {
                        _dvPeopleView.RowFilter = string.Format("Convert([{0}] , 'System.String') Like '{1}%' ", FilterColumn, PersonID);

                    }
                    else
                    {
                        _dvPeopleView.RowFilter = "[PersonID] = -999999";
                    }
                }
                else
                {
                    string SearchValue = SearchTextBox.Text.Trim().Replace("'", "''");
                    _dvPeopleView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, SearchValue);
                }

                RecoredPersonLbl.Text = _dvPeopleView.Count.ToString();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error applying filter : " + ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _dvPeopleView.RowFilter = "";
                RecoredPersonLbl.Text = _dvPeopleView.Count.ToString();

            }
        }

      
    }

}
