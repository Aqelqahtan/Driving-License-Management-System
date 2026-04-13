namespace PresentationLayer
{
    partial class LocalDrivingLicenseApplicationsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseApplicationsFrm));
            SearchTextBox = new TextBox();
            RecoredLocalDrivingResultLbl = new Label();
            CloseBtn = new Button();
            RecordTextLbl = new Label();
            dataGridView1 = new DataGridView();
            LDLAppID = new DataGridViewTextBoxColumn();
            DrivingClass = new DataGridViewTextBoxColumn();
            NationalNo = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            ApplicationDate = new DataGridViewTextBoxColumn();
            PassedTests = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showAppliciationDetailsToolStripMenuItem = new ToolStripMenuItem();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            sechduleTestsToolStripMenuItem = new ToolStripMenuItem();
            scheduleTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWritenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            AddPersonBtn = new Button();
            FilterByComboBox = new ComboBox();
            FilterByLbl = new Label();
            LocalDrivingLicenseApplicationsLbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(281, 213);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(181, 23);
            SearchTextBox.TabIndex = 20;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // RecoredLocalDrivingResultLbl
            // 
            RecoredLocalDrivingResultLbl.AutoSize = true;
            RecoredLocalDrivingResultLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredLocalDrivingResultLbl.Location = new Point(131, 530);
            RecoredLocalDrivingResultLbl.Name = "RecoredLocalDrivingResultLbl";
            RecoredLocalDrivingResultLbl.Size = new Size(0, 37);
            RecoredLocalDrivingResultLbl.TabIndex = 19;
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(817, 529);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 18;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(12, 535);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 17;
            RecordTextLbl.Text = "Records :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { LDLAppID, DrivingClass, NationalNo, FullName, ApplicationDate, PassedTests, Status });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 242);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(927, 281);
            dataGridView1.TabIndex = 16;
            // 
            // LDLAppID
            // 
            LDLAppID.DataPropertyName = "L.D.L.AppID";
            LDLAppID.HeaderText = "L.D.L.AppID";
            LDLAppID.Name = "LDLAppID";
            // 
            // DrivingClass
            // 
            DrivingClass.DataPropertyName = "Driving Class";
            DrivingClass.HeaderText = "Driving Class ";
            DrivingClass.Name = "DrivingClass";
            // 
            // NationalNo
            // 
            NationalNo.DataPropertyName = "National No";
            NationalNo.HeaderText = "National No";
            NationalNo.Name = "NationalNo";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "Full Name";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.Width = 300;
            // 
            // ApplicationDate
            // 
            ApplicationDate.DataPropertyName = "Application Date";
            ApplicationDate.HeaderText = "Application Date";
            ApplicationDate.Name = "ApplicationDate";
            // 
            // PassedTests
            // 
            PassedTests.DataPropertyName = "Passed Tests";
            PassedTests.HeaderText = "Passed Tests";
            PassedTests.Name = "PassedTests";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showAppliciationDetailsToolStripMenuItem, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, cancelApplicationToolStripMenuItem, sechduleTestsToolStripMenuItem, issueDrivingLicenseFirstTimToolStripMenuItem, eToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(260, 308);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showAppliciationDetailsToolStripMenuItem
            // 
            showAppliciationDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_322;
            showAppliciationDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showAppliciationDetailsToolStripMenuItem.Name = "showAppliciationDetailsToolStripMenuItem";
            showAppliciationDetailsToolStripMenuItem.Size = new Size(259, 38);
            showAppliciationDetailsToolStripMenuItem.Text = "Show Appliciation Details";
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Image = Properties.Resources.edit_323;
            editApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(259, 38);
            editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(259, 38);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Image = Properties.Resources.Delete_321;
            cancelApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(259, 38);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // sechduleTestsToolStripMenuItem
            // 
            sechduleTestsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleTestToolStripMenuItem, scheduleWritenTestToolStripMenuItem, scheduleStreetTestToolStripMenuItem });
            sechduleTestsToolStripMenuItem.Image = Properties.Resources.Schedule_Test_32;
            sechduleTestsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            sechduleTestsToolStripMenuItem.Size = new Size(259, 38);
            sechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // scheduleTestToolStripMenuItem
            // 
            scheduleTestToolStripMenuItem.Image = Properties.Resources.Vision_Test_32;
            scheduleTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            scheduleTestToolStripMenuItem.Size = new Size(200, 38);
            scheduleTestToolStripMenuItem.Text = "Schedule Test";
            scheduleTestToolStripMenuItem.Click += scheduleTestToolStripMenuItem_Click;
            // 
            // scheduleWritenTestToolStripMenuItem
            // 
            scheduleWritenTestToolStripMenuItem.Image = Properties.Resources.Written_Test_32_Sechdule;
            scheduleWritenTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleWritenTestToolStripMenuItem.Name = "scheduleWritenTestToolStripMenuItem";
            scheduleWritenTestToolStripMenuItem.Size = new Size(200, 38);
            scheduleWritenTestToolStripMenuItem.Text = "Schedule Writen Test";
            scheduleWritenTestToolStripMenuItem.Click += scheduleWritenTestToolStripMenuItem_Click;
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            scheduleStreetTestToolStripMenuItem.Image = Properties.Resources.Test_32;
            scheduleStreetTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(200, 38);
            scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            scheduleStreetTestToolStripMenuItem.Click += scheduleStreetTestToolStripMenuItem_Click;
            // 
            // issueDrivingLicenseFirstTimToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimToolStripMenuItem.Image = Properties.Resources.IssueDrivingLicense_32;
            issueDrivingLicenseFirstTimToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueDrivingLicenseFirstTimToolStripMenuItem.Name = "issueDrivingLicenseFirstTimToolStripMenuItem";
            issueDrivingLicenseFirstTimToolStripMenuItem.Size = new Size(259, 38);
            issueDrivingLicenseFirstTimToolStripMenuItem.Text = "Issue Driving License(First Time)";
            issueDrivingLicenseFirstTimToolStripMenuItem.Click += issueDrivingLicenseFirstTimToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Enabled = false;
            eToolStripMenuItem.Image = Properties.Resources.License_View_32;
            eToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(259, 38);
            eToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(259, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // AddPersonBtn
            // 
            AddPersonBtn.BackgroundImage = Properties.Resources.New_Application_64;
            AddPersonBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AddPersonBtn.Location = new Point(880, 184);
            AddPersonBtn.Name = "AddPersonBtn";
            AddPersonBtn.Size = new Size(59, 52);
            AddPersonBtn.TabIndex = 15;
            AddPersonBtn.UseVisualStyleBackColor = true;
            AddPersonBtn.Click += AddPersonBtn_Click;
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "None", "L.D.L.AppID", "National No", "Full Name", "Status" });
            FilterByComboBox.Location = new Point(94, 213);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(181, 23);
            FilterByComboBox.TabIndex = 14;
            FilterByComboBox.SelectedIndexChanged += FilterByComboBox_SelectedIndexChanged;
            // 
            // FilterByLbl
            // 
            FilterByLbl.AutoSize = true;
            FilterByLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterByLbl.Location = new Point(8, 213);
            FilterByLbl.Name = "FilterByLbl";
            FilterByLbl.Size = new Size(80, 18);
            FilterByLbl.TabIndex = 13;
            FilterByLbl.Text = "Filter By :";
            // 
            // LocalDrivingLicenseApplicationsLbl
            // 
            LocalDrivingLicenseApplicationsLbl.AutoSize = true;
            LocalDrivingLicenseApplicationsLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocalDrivingLicenseApplicationsLbl.ForeColor = Color.Red;
            LocalDrivingLicenseApplicationsLbl.Location = new Point(232, 173);
            LocalDrivingLicenseApplicationsLbl.Name = "LocalDrivingLicenseApplicationsLbl";
            LocalDrivingLicenseApplicationsLbl.Size = new Size(454, 37);
            LocalDrivingLicenseApplicationsLbl.TabIndex = 12;
            LocalDrivingLicenseApplicationsLbl.Text = "Local Driving License Applications";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Local_321;
            pictureBox2.Location = new Point(539, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // LocalDrivingLicenseApplicationsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 602);
            Controls.Add(pictureBox2);
            Controls.Add(SearchTextBox);
            Controls.Add(RecoredLocalDrivingResultLbl);
            Controls.Add(CloseBtn);
            Controls.Add(RecordTextLbl);
            Controls.Add(dataGridView1);
            Controls.Add(AddPersonBtn);
            Controls.Add(FilterByComboBox);
            Controls.Add(FilterByLbl);
            Controls.Add(LocalDrivingLicenseApplicationsLbl);
            Controls.Add(pictureBox1);
            Name = "LocalDrivingLicenseApplicationsFrm";
            Text = "LocalDrivingLicenseApplicationsFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private Label RecoredLocalDrivingResultLbl;
        private Button CloseBtn;
        private Label RecordTextLbl;
        private DataGridView dataGridView1;
        private Button AddPersonBtn;
        private ComboBox FilterByComboBox;
        private Label FilterByLbl;
        private Label LocalDrivingLicenseApplicationsLbl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn LDLAppID;
        private DataGridViewTextBoxColumn DrivingClass;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ApplicationDate;
        private DataGridViewTextBoxColumn PassedTests;
        private DataGridViewTextBoxColumn Status;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showAppliciationDetailsToolStripMenuItem;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private ToolStripMenuItem issueDrivingLicenseFirstTimToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem scheduleTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWritenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}