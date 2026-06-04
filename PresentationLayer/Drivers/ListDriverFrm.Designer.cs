namespace PresentationLayer
{
    partial class ListDriverFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDriverFrm));
            SearchTextBox = new TextBox();
            RecoredResultLbl = new Label();
            CloseBtn = new Button();
            RecordTextLbl = new Label();
            dataGridView1 = new DataGridView();
            DriverID = new DataGridViewTextBoxColumn();
            PersonID = new DataGridViewTextBoxColumn();
            NationalNo = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            FilterByComboBox = new ComboBox();
            FilterByLbl = new Label();
            LocalDrivingLicenseApplicationsLbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(286, 204);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(181, 23);
            SearchTextBox.TabIndex = 31;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            SearchTextBox.KeyPress += SearchTextBox_KeyPress;
            // 
            // RecoredResultLbl
            // 
            RecoredResultLbl.AutoSize = true;
            RecoredResultLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredResultLbl.Location = new Point(127, 511);
            RecoredResultLbl.Name = "RecoredResultLbl";
            RecoredResultLbl.Size = new Size(0, 37);
            RecoredResultLbl.TabIndex = 30;
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(739, 520);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 29;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(8, 516);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 28;
            RecordTextLbl.Text = "Records :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DriverID, PersonID, NationalNo, FullName, CreatedDate, IsActive });
            dataGridView1.Location = new Point(14, 233);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(846, 281);
            dataGridView1.TabIndex = 27;
            // 
            // DriverID
            // 
            DriverID.DataPropertyName = "DriverID";
            DriverID.HeaderText = "Driver ID";
            DriverID.Name = "DriverID";
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "Person ID";
            PersonID.Name = "PersonID";
            // 
            // NationalNo
            // 
            NationalNo.DataPropertyName = "NationalNo";
            NationalNo.HeaderText = "National No";
            NationalNo.Name = "NationalNo";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.Width = 250;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "Date";
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Width = 200;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "Active Licenses";
            IsActive.Name = "IsActive";
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No", "Full Name" });
            FilterByComboBox.Location = new Point(99, 204);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(181, 23);
            FilterByComboBox.TabIndex = 25;
            FilterByComboBox.SelectedIndexChanged += FilterByComboBox_SelectedIndexChanged;
            // 
            // FilterByLbl
            // 
            FilterByLbl.AutoSize = true;
            FilterByLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterByLbl.Location = new Point(13, 204);
            FilterByLbl.Name = "FilterByLbl";
            FilterByLbl.Size = new Size(80, 18);
            FilterByLbl.TabIndex = 24;
            FilterByLbl.Text = "Filter By :";
            // 
            // LocalDrivingLicenseApplicationsLbl
            // 
            LocalDrivingLicenseApplicationsLbl.AutoSize = true;
            LocalDrivingLicenseApplicationsLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocalDrivingLicenseApplicationsLbl.ForeColor = Color.Red;
            LocalDrivingLicenseApplicationsLbl.Location = new Point(294, 152);
            LocalDrivingLicenseApplicationsLbl.Name = "LocalDrivingLicenseApplicationsLbl";
            LocalDrivingLicenseApplicationsLbl.Size = new Size(220, 37);
            LocalDrivingLicenseApplicationsLbl.TabIndex = 23;
            LocalDrivingLicenseApplicationsLbl.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(319, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // ListDriverFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 621);
            Controls.Add(SearchTextBox);
            Controls.Add(RecoredResultLbl);
            Controls.Add(CloseBtn);
            Controls.Add(RecordTextLbl);
            Controls.Add(dataGridView1);
            Controls.Add(FilterByComboBox);
            Controls.Add(FilterByLbl);
            Controls.Add(LocalDrivingLicenseApplicationsLbl);
            Controls.Add(pictureBox1);
            Name = "ListDriverFrm";
            Text = "ListDriverFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SearchTextBox;
        private Label RecoredResultLbl;
        private Button CloseBtn;
        private Label RecordTextLbl;
        private DataGridView dataGridView1;
        private ComboBox FilterByComboBox;
        private Label FilterByLbl;
        private Label LocalDrivingLicenseApplicationsLbl;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn DriverID;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn IsActive;
    }
}