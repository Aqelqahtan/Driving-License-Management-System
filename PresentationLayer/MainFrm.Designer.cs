namespace PresentationLayer
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicesnseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replacementForLostDamgedLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            peoplToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            currentToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, peoplToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1221, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, manageApplicationsToolStripMenuItem, detainLicensesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageToolStripMenuItem });
            aToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            aToolStripMenuItem.Image = Properties.Resources.Applications_64;
            aToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(233, 68);
            aToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replacementForLostDamgedLicenseToolStripMenuItem, releaseDetainedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            drivingLicensesServicesToolStripMenuItem.Image = Properties.Resources.LocalDriving_License;
            drivingLicensesServicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(292, 38);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicesnseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Image = Properties.Resources.New_Driving_License_32;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(355, 26);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Image = Properties.Resources.Local_32;
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(238, 26);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicesnseToolStripMenuItem
            // 
            internationalLicesnseToolStripMenuItem.Image = Properties.Resources.International_32;
            internationalLicesnseToolStripMenuItem.Name = "internationalLicesnseToolStripMenuItem";
            internationalLicesnseToolStripMenuItem.Size = new Size(238, 26);
            internationalLicesnseToolStripMenuItem.Text = "International Licesnse";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(355, 26);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replacementForLostDamgedLicenseToolStripMenuItem
            // 
            replacementForLostDamgedLicenseToolStripMenuItem.Image = Properties.Resources.Damaged_Driving_License_32;
            replacementForLostDamgedLicenseToolStripMenuItem.Name = "replacementForLostDamgedLicenseToolStripMenuItem";
            replacementForLostDamgedLicenseToolStripMenuItem.Size = new Size(355, 26);
            replacementForLostDamgedLicenseToolStripMenuItem.Text = "Replacement For Lost Damged License";
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Detained_Driving_License_32;
            releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            releaseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(355, 26);
            releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Image = Properties.Resources.Retake_Test_32;
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(355, 26);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationsToolStripMenuItem, internationalLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            manageApplicationsToolStripMenuItem.Image = Properties.Resources.Manage_Applications_32;
            manageApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(292, 38);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            localDrivingLicenseApplicationsToolStripMenuItem.Image = Properties.Resources.LocalDriving_License1;
            localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            localDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(327, 26);
            localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            localDrivingLicenseApplicationsToolStripMenuItem.Click += localDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            internationalLicenseApplicationsToolStripMenuItem.Image = Properties.Resources.International_321;
            internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            internationalLicenseApplicationsToolStripMenuItem.Size = new Size(327, 26);
            internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            detainLicensesToolStripMenuItem.Image = Properties.Resources.Detain_32;
            detainLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(292, 38);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            manageApplicationTypesToolStripMenuItem.Image = Properties.Resources.Application_Types_64;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(292, 38);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            manageToolStripMenuItem.Image = Properties.Resources.TestType_32;
            manageToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(292, 38);
            manageToolStripMenuItem.Text = "Manage Application Types";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // peoplToolStripMenuItem
            // 
            peoplToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            peoplToolStripMenuItem.Image = (Image)resources.GetObject("peoplToolStripMenuItem.Image");
            peoplToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peoplToolStripMenuItem.Name = "peoplToolStripMenuItem";
            peoplToolStripMenuItem.Size = new Size(167, 68);
            peoplToolStripMenuItem.Text = "People";
            peoplToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Image = Properties.Resources.Drivers_64;
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(157, 68);
            driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Image = Properties.Resources.Users_2_64;
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(141, 68);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            accountSettingsToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(257, 68);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentToolStripMenuItem
            // 
            currentToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            currentToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            currentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            currentToolStripMenuItem.Size = new Size(226, 38);
            currentToolStripMenuItem.Text = "Current User Info";
            currentToolStripMenuItem.Click += currentToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_321;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(226, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            signOutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(226, 38);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.Logo_Final;
            ClientSize = new Size(1221, 631);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainFrm";
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem peoplToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem accountSettingsToolStripMenuItem;
        private ToolStripMenuItem currentToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem replacementForLostDamgedLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicesnseToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
    }
}
