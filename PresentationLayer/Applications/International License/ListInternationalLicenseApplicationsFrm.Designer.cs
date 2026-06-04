namespace PresentationLayer
{
    partial class ListInternationalLicenseApplicationsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListInternationalLicenseApplicationsFrm));
            SearchTextBox = new TextBox();
            RecoredResultLbl = new Label();
            CloseBtn = new Button();
            RecordTextLbl = new Label();
            dataGridView1 = new DataGridView();
            IntLisenceID = new DataGridViewTextBoxColumn();
            ApplicationID = new DataGridViewTextBoxColumn();
            DriverID = new DataGridViewTextBoxColumn();
            IssuedUsingLocalLicenseID = new DataGridViewTextBoxColumn();
            IssueDate = new DataGridViewTextBoxColumn();
            ExpirationDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            FilterByComboBox = new ComboBox();
            FilterByLbl = new Label();
            LocalDrivingLicenseApplicationsLbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox18 = new PictureBox();
            FilterByActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(300, 190);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(181, 23);
            SearchTextBox.TabIndex = 40;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // RecoredResultLbl
            // 
            RecoredResultLbl.AutoSize = true;
            RecoredResultLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredResultLbl.Location = new Point(141, 500);
            RecoredResultLbl.Name = "RecoredResultLbl";
            RecoredResultLbl.Size = new Size(0, 37);
            RecoredResultLbl.TabIndex = 39;
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(753, 506);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 38;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(22, 505);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 37;
            RecordTextLbl.Text = "Records :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IntLisenceID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(28, 219);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(846, 281);
            dataGridView1.TabIndex = 36;
            // 
            // IntLisenceID
            // 
            IntLisenceID.DataPropertyName = "InternationalLicenseID";
            IntLisenceID.HeaderText = "Int License ID";
            IntLisenceID.Name = "IntLisenceID";
            IntLisenceID.ReadOnly = true;
            // 
            // ApplicationID
            // 
            ApplicationID.DataPropertyName = "ApplicationID";
            ApplicationID.HeaderText = "Application ID";
            ApplicationID.Name = "ApplicationID";
            ApplicationID.ReadOnly = true;
            // 
            // DriverID
            // 
            DriverID.DataPropertyName = "DriverID";
            DriverID.HeaderText = "Driver ID";
            DriverID.Name = "DriverID";
            DriverID.ReadOnly = true;
            // 
            // IssuedUsingLocalLicenseID
            // 
            IssuedUsingLocalLicenseID.DataPropertyName = "IssuedUsingLocalLicenseID";
            IssuedUsingLocalLicenseID.HeaderText = "L Lisence ID";
            IssuedUsingLocalLicenseID.Name = "IssuedUsingLocalLicenseID";
            IssuedUsingLocalLicenseID.ReadOnly = true;
            // 
            // IssueDate
            // 
            IssueDate.DataPropertyName = "IssueDate";
            IssueDate.HeaderText = "Issue Date";
            IssueDate.Name = "IssueDate";
            IssueDate.ReadOnly = true;
            IssueDate.Width = 200;
            // 
            // ExpirationDate
            // 
            ExpirationDate.DataPropertyName = "ExpirationDate";
            ExpirationDate.HeaderText = "ExpirationDate";
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "Is Active ";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Resizable = DataGridViewTriState.True;
            IsActive.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(242, 118);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_323;
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(241, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.License_View_321;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(241, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_321;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(241, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "None", "Int License ID", "Application ID", "Driver ID", "L License ID", "Is Active" });
            FilterByComboBox.Location = new Point(113, 190);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(181, 23);
            FilterByComboBox.TabIndex = 35;
            FilterByComboBox.SelectedIndexChanged += FilterByComboBox_SelectedIndexChanged;
            // 
            // FilterByLbl
            // 
            FilterByLbl.AutoSize = true;
            FilterByLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterByLbl.Location = new Point(27, 190);
            FilterByLbl.Name = "FilterByLbl";
            FilterByLbl.Size = new Size(80, 18);
            FilterByLbl.TabIndex = 34;
            FilterByLbl.Text = "Filter By :";
            // 
            // LocalDrivingLicenseApplicationsLbl
            // 
            LocalDrivingLicenseApplicationsLbl.AutoSize = true;
            LocalDrivingLicenseApplicationsLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocalDrivingLicenseApplicationsLbl.ForeColor = Color.Red;
            LocalDrivingLicenseApplicationsLbl.Location = new Point(266, 142);
            LocalDrivingLicenseApplicationsLbl.Name = "LocalDrivingLicenseApplicationsLbl";
            LocalDrivingLicenseApplicationsLbl.Size = new Size(448, 37);
            LocalDrivingLicenseApplicationsLbl.TabIndex = 33;
            LocalDrivingLicenseApplicationsLbl.Text = "International License Application ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = (Image)resources.GetObject("pictureBox18.Image");
            pictureBox18.Location = new Point(549, 28);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(27, 27);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 136;
            pictureBox18.TabStop = false;
            // 
            // FilterByActive
            // 
            FilterByActive.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByActive.FormattingEnabled = true;
            FilterByActive.Items.AddRange(new object[] { "All", "Active", "Non-Active" });
            FilterByActive.Location = new Point(300, 190);
            FilterByActive.Name = "FilterByActive";
            FilterByActive.Size = new Size(181, 23);
            FilterByActive.TabIndex = 137;
            FilterByActive.SelectedIndexChanged += FilterByActive_SelectedIndexChanged;
            // 
            // ListInternationalLicenseApplicationsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 560);
            Controls.Add(FilterByActive);
            Controls.Add(pictureBox18);
            Controls.Add(SearchTextBox);
            Controls.Add(RecoredResultLbl);
            Controls.Add(CloseBtn);
            Controls.Add(RecordTextLbl);
            Controls.Add(dataGridView1);
            Controls.Add(FilterByComboBox);
            Controls.Add(FilterByLbl);
            Controls.Add(LocalDrivingLicenseApplicationsLbl);
            Controls.Add(pictureBox1);
            Name = "ListInternationalLicenseApplicationsFrm";
            Text = "ListInternationalLicenseApplicationsFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
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
        private PictureBox pictureBox18;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private DataGridViewTextBoxColumn IntLisenceID;
        private DataGridViewTextBoxColumn ApplicationID;
        private DataGridViewTextBoxColumn DriverID;
        private DataGridViewTextBoxColumn IssuedUsingLocalLicenseID;
        private DataGridViewTextBoxColumn IssueDate;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewCheckBoxColumn IsActive;
        private ComboBox FilterByActive;
    }
}