namespace PresentationLayer
{
    partial class ManageUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserFrm));
            ManagePeopleLbl = new Label();
            pictureBox1 = new PictureBox();
            FilterByLbl = new Label();
            FilterByComboBox = new ComboBox();
            DataGridUsers = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            PersonID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            CloseBtn = new Button();
            RecoredUserLbl = new Label();
            RecordTextLbl = new Label();
            AddUserBtn = new Button();
            SearchTextBox = new TextBox();
            IsActiveComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ManagePeopleLbl
            // 
            ManagePeopleLbl.AutoSize = true;
            ManagePeopleLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagePeopleLbl.ForeColor = Color.Red;
            ManagePeopleLbl.Location = new Point(320, 153);
            ManagePeopleLbl.Name = "ManagePeopleLbl";
            ManagePeopleLbl.Size = new Size(231, 45);
            ManagePeopleLbl.TabIndex = 2;
            ManagePeopleLbl.Text = "Manage Users";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(355, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FilterByLbl
            // 
            FilterByLbl.AutoSize = true;
            FilterByLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterByLbl.Location = new Point(24, 208);
            FilterByLbl.Name = "FilterByLbl";
            FilterByLbl.Size = new Size(80, 18);
            FilterByLbl.TabIndex = 4;
            FilterByLbl.Text = "Filter By :";
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "None", "User ID", "Person ID", "Full Name", "User Name", "Is Active" });
            FilterByComboBox.Location = new Point(110, 203);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(181, 23);
            FilterByComboBox.TabIndex = 5;
            FilterByComboBox.SelectedIndexChanged += FilterByComboBox_SelectedIndexChanged;
            // 
            // DataGridUsers
            // 
            DataGridUsers.AllowUserToAddRows = false;
            DataGridUsers.AllowUserToDeleteRows = false;
            DataGridUsers.AllowUserToResizeRows = false;
            DataGridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, PersonID, FullName, UserName, IsActive });
            DataGridUsers.ContextMenuStrip = contextMenuStrip1;
            DataGridUsers.Location = new Point(25, 232);
            DataGridUsers.Name = "DataGridUsers";
            DataGridUsers.ReadOnly = true;
            DataGridUsers.Size = new Size(840, 344);
            DataGridUsers.TabIndex = 6;
            DataGridUsers.CellMouseDown += DataGridUsers_CellMouseDown;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "User ID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "Person ID";
            PersonID.Name = "PersonID";
            PersonID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.FillWeight = 200F;
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "User Name";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "Is Active";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Resizable = DataGridViewTriState.True;
            IsActive.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewUserToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(194, 270);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(193, 38);
            showDetailsToolStripMenuItem.Text = "Show Details ";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewUserToolStripMenuItem.Image = Properties.Resources.Add_New_User_32;
            addNewUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(193, 38);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(193, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(193, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(193, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(193, 38);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_321;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(193, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(743, 582);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 8;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // RecoredUserLbl
            // 
            RecoredUserLbl.AutoSize = true;
            RecoredUserLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredUserLbl.Location = new Point(144, 583);
            RecoredUserLbl.Name = "RecoredUserLbl";
            RecoredUserLbl.Size = new Size(0, 37);
            RecoredUserLbl.TabIndex = 11;
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(25, 587);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 10;
            RecordTextLbl.Text = "Records :";
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackgroundImage = Properties.Resources.Add_New_User_72;
            AddUserBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AddUserBtn.Cursor = Cursors.Hand;
            AddUserBtn.Location = new Point(806, 177);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(59, 49);
            AddUserBtn.TabIndex = 12;
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(297, 203);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(181, 23);
            SearchTextBox.TabIndex = 13;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            SearchTextBox.KeyPress += SearchTextBox_KeyPress;
            // 
            // IsActiveComboBox
            // 
            IsActiveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IsActiveComboBox.FormattingEnabled = true;
            IsActiveComboBox.Items.AddRange(new object[] { "All", "Yes", "No" });
            IsActiveComboBox.Location = new Point(297, 203);
            IsActiveComboBox.Name = "IsActiveComboBox";
            IsActiveComboBox.Size = new Size(181, 23);
            IsActiveComboBox.TabIndex = 14;
            IsActiveComboBox.SelectedIndexChanged += IsActiveComboBox_SelectedIndexChanged;
            // 
            // ManageUserFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 626);
            Controls.Add(IsActiveComboBox);
            Controls.Add(SearchTextBox);
            Controls.Add(AddUserBtn);
            Controls.Add(RecoredUserLbl);
            Controls.Add(RecordTextLbl);
            Controls.Add(CloseBtn);
            Controls.Add(DataGridUsers);
            Controls.Add(FilterByComboBox);
            Controls.Add(FilterByLbl);
            Controls.Add(pictureBox1);
            Controls.Add(ManagePeopleLbl);
            Name = "ManageUserFrm";
            Text = "ManageUserFrm";
            Load += ManageUserFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ManagePeopleLbl;
        private PictureBox pictureBox1;
        private Label FilterByLbl;
        private ComboBox FilterByComboBox;
        private DataGridView DataGridUsers;
        private Button CloseBtn;
        private Label RecoredUserLbl;
        private Label RecordTextLbl;
        private Button AddUserBtn;
        private TextBox SearchTextBox;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewCheckBoxColumn IsActive;
        private ComboBox IsActiveComboBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}