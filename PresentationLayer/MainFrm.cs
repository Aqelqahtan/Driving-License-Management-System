using BusinessLayer;
using PresentationLayer.User;

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
            
            
                ManagePeopleFrm frm = new ManagePeopleFrm();
                frm.ShowDialog();
           
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

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDriverFrm frm = new ListDriverFrm();
            frm.ShowDialog();
        }

        private void internationalLicesnseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplicationFrm newInternationalLicenseApplicationFrm = new NewInternationalLicenseApplicationFrm();
            newInternationalLicenseApplicationFrm.ShowDialog();

        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListInternationalLicenseApplicationsFrm frm = new ListInternationalLicenseApplicationsFrm();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLocalDrivingLicenseFrm frm = new RenewLocalDrivingLicenseFrm();
            frm.ShowDialog();
        }

        private void replacementForLostDamgedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementForDamagedLicenseFrm frm = new ReplacementForDamagedLicenseFrm();
            frm.ShowDialog();

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicenseFrm frm = new DetainLicenseFrm();
            frm.ShowDialog();

        }

        private void relaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFrm frm = new ReleaseDetainedLicenseFrm();
            frm.ShowDialog();

        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListDetainedLicenseFrm frm = new ListDetainedLicenseFrm();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFrm frm = new ReleaseDetainedLicenseFrm();
            frm.ShowDialog();
        }
    }
}
