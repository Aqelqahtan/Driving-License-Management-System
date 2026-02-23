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
            AddPersonBtn = new Button();
            FilterByComboBox = new ComboBox();
            FilterByLbl = new Label();
            LocalDrivingLicenseApplicationsLbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            NationalNo.HeaderText = "National No.";
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
            FilterByComboBox.Items.AddRange(new object[] { "None", "L.D.LAppID", "Driving Class", "National No", "Full Name", "Application Date", "Passed Tests", "Status" });
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
    }
}