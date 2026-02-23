using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ManageUserFrm : Form
    {
         public ManageUserFrm()
        {
            InitializeComponent();
            _RefreshScreenUsers();
           
            
        }

        private DataView _dvUsers;

        private void _RefreshScreenUsers()
        {
            DataTable dtUsers = ClsUsers.GetAllUsers(); // define new DataTable
            _dvUsers = dtUsers.DefaultView;
            DataGridUsers.DataSource = _dvUsers;
            RecoredUserLbl.Text = ClsUsers.CalculateUsers().ToString();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageUserFrm_Load(object sender, EventArgs e)
        {
            _RefreshScreenUsers();
            SearchTextBox.Visible = false;
            SearchTextBox.Clear();
            FilterByComboBox.SelectedIndex = 0;

            IsActiveComboBox.Items.Clear();
            IsActiveComboBox.Items.Add("All");
            IsActiveComboBox.Items.Add("Yes");
            IsActiveComboBox.Items.Add("No");
            IsActiveComboBox.SelectedIndex = 0;
            IsActiveComboBox.Visible = false;


        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
  
        }

        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByComboBox.Text == "None")
            {
                SearchTextBox.Visible = false;
                IsActiveComboBox.Visible = false;
                SearchTextBox.Clear();


                if (FilterByComboBox.Text != null)
                {

                    _dvUsers.RowFilter = "";
                    RecoredUserLbl.Text = _dvUsers.Count.ToString();

                }

            }
            else if (FilterByComboBox.Text == "Is Active")
            {
                SearchTextBox.Visible = false;
                IsActiveComboBox.Visible = true;
                IsActiveComboBox.Focus();

            }
            else
            {
                SearchTextBox.Visible = true;
                SearchTextBox.Clear();
                SearchTextBox.Focus();
                IsActiveComboBox.Visible = false;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            if (_dvUsers == null)
                return;



            switch (FilterByComboBox.Text)
            {
                case "User ID": FilterColumn = "UserID"; break;
                case "Person ID": FilterColumn = "PersonID"; break;
                case "Full Name": FilterColumn = "FullName"; break;
                case "User Name": FilterColumn = "UserName"; break;
                case "UserName": FilterColumn = "UserName"; break;
                case "Is Active": FilterColumn = "IsActive"; break;
                default: FilterColumn = "None"; break;
            }

            if (string.IsNullOrWhiteSpace(SearchTextBox.Text) || FilterColumn == "None")
            {
                _dvUsers.RowFilter = "";
                RecoredUserLbl.Text = _dvUsers.Count.ToString();
                return;
            }
            try
            {

                if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                {

                    IsActiveComboBox.Visible = false;
                    SearchTextBox.Visible = true;

                    //c
                    _dvUsers.RowFilter = string.Format("Convert([{0}]  , 'System.String') LIKE '{1}%' ", FilterColumn, SearchTextBox.Text.Trim());

                }
                else if (FilterColumn == "IsActive")
                {

                    IsActiveComboBox.Visible = true;
                    SearchTextBox.Visible = false;


                }
                else
                {

                    SearchTextBox.Visible = true;

                    string SearchValue = SearchTextBox.Text.Trim().Replace("'", "''");
                    _dvUsers.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, SearchValue);
                }


                RecoredUserLbl.Text = _dvUsers.Count.ToString();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error Applying Filter :" + ex.Message, "Filter Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _dvUsers.RowFilter = "";
                RecoredUserLbl.Text = _dvUsers.Count.ToString();
            }
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedColumn = FilterByComboBox.Text;
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                if (selectedColumn == "User ID" || selectedColumn == "Person ID")
                {
                    e.Handled = true;
                }
            }
        }

        private void IsActiveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterExpression = ""; // define filter 

            switch (IsActiveComboBox.Text)
            {
                case "All":
                    FilterExpression = "";
                    break;

                case "Yes":
                    FilterExpression = "IsActive = 1";
                    break;

                default:
                    FilterExpression = "IsActive = 0";
                    break;
            }

            if (FilterByComboBox.Text == "Is Active")
            {
                _dvUsers.RowFilter = FilterExpression;
                RecoredUserLbl.Text = _dvUsers.Count.ToString();
            }

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateUserFrm frm = new AddUpdateUserFrm();
            frm.ShowDialog();

        }

        private void DataGridUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridUsers.CurrentCell = DataGridUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridUsers.Rows[e.RowIndex].Selected = true;
                DataGridUsers.Focus();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)DataGridUsers.CurrentRow.Cells["UserID"].Value;
            int PersonID = (int)DataGridUsers.CurrentRow.Cells["PersonID"].Value;
            ChangePasswordfrm frm = new ChangePasswordfrm(PersonID, UserID);
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)DataGridUsers.CurrentRow.Cells["UserID"].Value;
            int PersonID = (int)DataGridUsers.CurrentRow.Cells["PersonID"].Value;

            UserInfoFrm frm = new UserInfoFrm(PersonID, UserID);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)DataGridUsers.CurrentRow.Cells["UserID"].Value;

            if (DataGridUsers.CurrentRow != null)
            {
                if (ClsUsers.DeleteUser(UserID))
                {
                    MessageBox.Show("Deleted successfuly");
                    _RefreshScreenUsers();
                }
                else
                {
                    MessageBox.Show("Error this user realeted with other data !!");

                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AddUpdateUserFrm frm = new AddUpdateUserFrm();
                frm.ShowDialog();
                _RefreshScreenUsers(); 
            
        }
        
    }
}
