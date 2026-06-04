namespace PresentationLayer
{
    partial class ListDetainedLicenseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDetainedLicenseFrm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            FilterByReleased = new ComboBox();
            SearchTextBox = new TextBox();
            RecoredResultLbl = new Label();
            CloseBtn = new Button();
            RecordTextLbl = new Label();
            DetainedLicenseDataGrid = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            FilterByComboBox = new ComboBox();
            FilterByLbl = new Label();
            ListDetainedLicenseApplicationsLbl = new Label();
            pictureBox1 = new PictureBox();
            ReleaseBtn = new PictureBox();
            DetainedBtn = new PictureBox();
            DetainID = new DataGridViewTextBoxColumn();
            LicenseID = new DataGridViewTextBoxColumn();
            DetainDate = new DataGridViewTextBoxColumn();
            IsReleased = new DataGridViewCheckBoxColumn();
            FineFees = new DataGridViewTextBoxColumn();
            ReleaseDate = new DataGridViewTextBoxColumn();
            NationalNo = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            ReleaseApplicationID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DetainedLicenseDataGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReleaseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetainedBtn).BeginInit();
            SuspendLayout();
            // 
            // FilterByReleased
            // 
            FilterByReleased.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByReleased.FormattingEnabled = true;
            FilterByReleased.Items.AddRange(new object[] { "All", "Is Released", "Not Released" });
            FilterByReleased.Location = new Point(280, 200);
            FilterByReleased.Name = "FilterByReleased";
            FilterByReleased.Size = new Size(181, 23);
            FilterByReleased.TabIndex = 148;
            FilterByReleased.SelectedIndexChanged += FilterByReleased_SelectedIndexChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(280, 200);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(181, 23);
            SearchTextBox.TabIndex = 146;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // RecoredResultLbl
            // 
            RecoredResultLbl.AutoSize = true;
            RecoredResultLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredResultLbl.Location = new Point(121, 510);
            RecoredResultLbl.Name = "RecoredResultLbl";
            RecoredResultLbl.Size = new Size(0, 37);
            RecoredResultLbl.TabIndex = 145;
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(733, 516);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 144;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(6, 515);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 143;
            RecordTextLbl.Text = "Records :";
            // 
            // DetainedLicenseDataGrid
            // 
            DetainedLicenseDataGrid.AllowUserToAddRows = false;
            DetainedLicenseDataGrid.AllowUserToDeleteRows = false;
            DetainedLicenseDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetainedLicenseDataGrid.Columns.AddRange(new DataGridViewColumn[] { DetainID, LicenseID, DetainDate, IsReleased, FineFees, ReleaseDate, NationalNo, FullName, ReleaseApplicationID });
            DetainedLicenseDataGrid.ContextMenuStrip = contextMenuStrip1;
            DetainedLicenseDataGrid.Location = new Point(8, 229);
            DetainedLicenseDataGrid.MultiSelect = false;
            DetainedLicenseDataGrid.Name = "DetainedLicenseDataGrid";
            DetainedLicenseDataGrid.ReadOnly = true;
            DetainedLicenseDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DetainedLicenseDataGrid.Size = new Size(846, 281);
            DetainedLicenseDataGrid.TabIndex = 142;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(242, 156);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_326;
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(241, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.License_View_324;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(241, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_324;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(241, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = Properties.Resources.Release_Detained_License_321;
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(241, 38);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National No.", "Full Name", "Release Application ID" });
            FilterByComboBox.Location = new Point(93, 200);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(181, 23);
            FilterByComboBox.TabIndex = 141;
            FilterByComboBox.SelectedIndexChanged += FilterByComboBox_SelectedIndexChanged;
            // 
            // FilterByLbl
            // 
            FilterByLbl.AutoSize = true;
            FilterByLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterByLbl.Location = new Point(7, 200);
            FilterByLbl.Name = "FilterByLbl";
            FilterByLbl.Size = new Size(80, 18);
            FilterByLbl.TabIndex = 140;
            FilterByLbl.Text = "Filter By :";
            // 
            // ListDetainedLicenseApplicationsLbl
            // 
            ListDetainedLicenseApplicationsLbl.AutoSize = true;
            ListDetainedLicenseApplicationsLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListDetainedLicenseApplicationsLbl.ForeColor = Color.Red;
            ListDetainedLicenseApplicationsLbl.Location = new Point(312, 152);
            ListDetainedLicenseApplicationsLbl.Name = "ListDetainedLicenseApplicationsLbl";
            ListDetainedLicenseApplicationsLbl.Size = new Size(286, 37);
            ListDetainedLicenseApplicationsLbl.TabIndex = 139;
            ListDetainedLicenseApplicationsLbl.Text = "List Detained License";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 138;
            pictureBox1.TabStop = false;
            // 
            // ReleaseBtn
            // 
            ReleaseBtn.Cursor = Cursors.Hand;
            ReleaseBtn.Image = (Image)resources.GetObject("ReleaseBtn.Image");
            ReleaseBtn.Location = new Point(794, 196);
            ReleaseBtn.Name = "ReleaseBtn";
            ReleaseBtn.Size = new Size(27, 27);
            ReleaseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ReleaseBtn.TabIndex = 149;
            ReleaseBtn.TabStop = false;
            ReleaseBtn.Click += ReleaseBtn_Click;
            // 
            // DetainedBtn
            // 
            DetainedBtn.Cursor = Cursors.Hand;
            DetainedBtn.Image = (Image)resources.GetObject("DetainedBtn.Image");
            DetainedBtn.Location = new Point(827, 196);
            DetainedBtn.Name = "DetainedBtn";
            DetainedBtn.Size = new Size(27, 27);
            DetainedBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            DetainedBtn.TabIndex = 150;
            DetainedBtn.TabStop = false;
            DetainedBtn.Click += DetainedBtn_Click;
            // 
            // DetainID
            // 
            DetainID.DataPropertyName = "DetainID";
            DetainID.HeaderText = "D.ID";
            DetainID.Name = "DetainID";
            DetainID.ReadOnly = true;
            DetainID.Width = 50;
            // 
            // LicenseID
            // 
            LicenseID.DataPropertyName = "LicenseID";
            LicenseID.HeaderText = "L.ID";
            LicenseID.Name = "LicenseID";
            LicenseID.ReadOnly = true;
            LicenseID.Width = 50;
            // 
            // DetainDate
            // 
            DetainDate.DataPropertyName = "DetainDate";
            DetainDate.HeaderText = "D.Date";
            DetainDate.Name = "DetainDate";
            DetainDate.ReadOnly = true;
            // 
            // IsReleased
            // 
            IsReleased.DataPropertyName = "IsReleased";
            IsReleased.HeaderText = "Is Released";
            IsReleased.Name = "IsReleased";
            IsReleased.ReadOnly = true;
            IsReleased.Resizable = DataGridViewTriState.True;
            IsReleased.SortMode = DataGridViewColumnSortMode.Automatic;
            IsReleased.Width = 70;
            // 
            // FineFees
            // 
            FineFees.DataPropertyName = "FineFees";
            dataGridViewCellStyle1.Format = "0.##";
            FineFees.DefaultCellStyle = dataGridViewCellStyle1;
            FineFees.HeaderText = "Fine Fees";
            FineFees.Name = "FineFees";
            FineFees.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            ReleaseDate.DataPropertyName = "ReleaseDate";
            ReleaseDate.HeaderText = "Release Date";
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.ReadOnly = true;
            // 
            // NationalNo
            // 
            NationalNo.DataPropertyName = "NationalNo";
            NationalNo.HeaderText = "N.NO.";
            NationalNo.Name = "NationalNo";
            NationalNo.ReadOnly = true;
            NationalNo.Resizable = DataGridViewTriState.True;
            NationalNo.Width = 70;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 200;
            // 
            // ReleaseApplicationID
            // 
            ReleaseApplicationID.DataPropertyName = "ReleaseApplicationID";
            ReleaseApplicationID.HeaderText = "Rlease App.ID";
            ReleaseApplicationID.Name = "ReleaseApplicationID";
            ReleaseApplicationID.ReadOnly = true;
            ReleaseApplicationID.Width = 50;
            // 
            // ListDetainedLicenseFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 566);
            Controls.Add(DetainedBtn);
            Controls.Add(ReleaseBtn);
            Controls.Add(FilterByReleased);
            Controls.Add(SearchTextBox);
            Controls.Add(RecoredResultLbl);
            Controls.Add(CloseBtn);
            Controls.Add(RecordTextLbl);
            Controls.Add(DetainedLicenseDataGrid);
            Controls.Add(FilterByComboBox);
            Controls.Add(FilterByLbl);
            Controls.Add(ListDetainedLicenseApplicationsLbl);
            Controls.Add(pictureBox1);
            Name = "ListDetainedLicenseFrm";
            Text = "ListDetainedLicenseFrm1cs";
            ((System.ComponentModel.ISupportInitialize)DetainedLicenseDataGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReleaseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetainedBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FilterByReleased;
        private TextBox SearchTextBox;
        private Label RecoredResultLbl;
        private Button CloseBtn;
        private Label RecordTextLbl;
        private DataGridView DetainedLicenseDataGrid;
        private ComboBox FilterByComboBox;
        private Label FilterByLbl;
        private Label ListDetainedLicenseApplicationsLbl;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private PictureBox ReleaseBtn;
        private PictureBox DetainedBtn;
        private DataGridViewTextBoxColumn DetainID;
        private DataGridViewTextBoxColumn LicenseID;
        private DataGridViewTextBoxColumn DetainDate;
        private DataGridViewCheckBoxColumn IsReleased;
        private DataGridViewTextBoxColumn FineFees;
        private DataGridViewTextBoxColumn ReleaseDate;
        private DataGridViewTextBoxColumn NationalNo;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ReleaseApplicationID;
    }
}