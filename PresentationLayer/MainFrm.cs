using BusinessLayer;

namespace PresentationLayer
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        public ClsPeople Person;
        public ClsUsers User;
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ManagePeopleFrm frm = new ManagePeopleFrm();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء فتح الشاشة:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInFrm frm = new LogInFrm();
            this.Hide();
            this.Close();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUserFrm frm = new ManageUserFrm();
            frm.ShowDialog();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUserInfofrm frm = new CurrentUserInfofrm();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm frm = new ChangePasswordfrm(ClsGlobal.CurrentUser.PersonID, ClsGlobal.CurrentUser.UserID);
            frm.ShowDialog();

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeApplicationTypesFrm frm = new MangeApplicationTypesFrm();
            frm.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes frm = new ManageTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplicationFrm frm = new NewLocalDrivingLicenseApplicationFrm();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationsFrm frm = new LocalDrivingLicenseApplicationsFrm();
            frm.ShowDialog();
        }
    }
}
