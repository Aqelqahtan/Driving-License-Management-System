namespace PresentationLayer
{
    partial class ManagePeopleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeopleFrm));
            pictureBox1 = new PictureBox();
            ManagePeopleLbl = new Label();
            FilterByLbl = new Label();
            FilterByComboBox = new ComboBox();
            AddPersonBtn = new Button();
            dataGridView1 = new DataGridView();
            PersonID = new DataGridViewTextBoxColumn();
            NationalNO = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            SecondName = new DataGridViewTextBoxColumn();
            ThirdName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gendor = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            RecordTextLbl = new Label();
            CloseBtn = new Button();
            RecoredPersonLbl = new Label();
            SearchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(469, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ManagePeopleLbl
            // 
            ManagePeopleLbl.AutoSize = true;
            ManagePeopleLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagePeopleLbl.ForeColor = Color.Red;
            ManagePeopleLbl.Location = new Point(434, 137);
            ManagePeopleLbl.Name = "ManagePeopleLbl";
            ManagePeopleLbl.Size = new Size(252, 45);
            ManagePeopleLbl.TabIndex = 1;
            ManagePeopleLbl.Text = "Manage People";
            // 
            // FilterByLbl
            // 
            FilterByLbl.AutoSize = true;
            FilterByLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterByLbl.Location = new Point(12, 202);
            FilterByLbl.Name = "FilterByLbl";
            FilterByLbl.Size = new Size(80, 18);
            FilterByLbl.TabIndex = 2;
            FilterByLbl.Text = "Filter By :";
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "None", "Person ID", "National No ", "First Name", "Second Name", "Third Name ", "Last Name ", "Nationality", "Gendor", "Phone", "Email" });
            FilterByComboBox.Location = new Point(98, 202);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(181, 23);
            FilterByComboBox.TabIndex = 3;
            FilterByComboBox.SelectedIndexChanged += FilterByComboBox_SelectedIndexChanged;
            // 
            // AddPersonBtn
            // 
            AddPersonBtn.Image = Properties.Resources.AddPerson_32;
            AddPersonBtn.Location = new Point(1086, 184);
            AddPersonBtn.Name = "AddPersonBtn";
            AddPersonBtn.Size = new Size(59, 41);
            AddPersonBtn.TabIndex = 4;
            AddPersonBtn.UseVisualStyleBackColor = true;
            AddPersonBtn.Click += AddPersonBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PersonID, NationalNO, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, Nationality, Phone, Email });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 231);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1133, 354);
            dataGridView1.TabIndex = 5;
            // 
            // PersonID
            // 
            PersonID.DataPropertyName = "PersonID";
            PersonID.HeaderText = "Person ID";
            PersonID.Name = "PersonID";
            // 
            // NationalNO
            // 
            NationalNO.DataPropertyName = "NationalNo";
            NationalNO.HeaderText = "National NO";
            NationalNO.Name = "NationalNO";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            // 
            // SecondName
            // 
            SecondName.DataPropertyName = "SecondName";
            SecondName.HeaderText = "Second Name";
            SecondName.Name = "SecondName";
            // 
            // ThirdName
            // 
            ThirdName.DataPropertyName = "ThirdName";
            ThirdName.HeaderText = "Third Name";
            ThirdName.Name = "ThirdName";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            // 
            // Gendor
            // 
            Gendor.DataPropertyName = "Gendor";
            Gendor.HeaderText = "Gendor";
            Gendor.Name = "Gendor";
            // 
            // DateOfBirth
            // 
            DateOfBirth.DataPropertyName = "DateOfBirth";
            DateOfBirth.HeaderText = "Date Of Birth";
            DateOfBirth.Name = "DateOfBirth";
            // 
            // Nationality
            // 
            Nationality.DataPropertyName = "CountryName";
            Nationality.HeaderText = "Nationality";
            Nationality.Name = "Nationality";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(265, 220);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(264, 36);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(264, 36);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(264, 36);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(264, 36);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(264, 36);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(264, 36);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(12, 596);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 6;
            RecordTextLbl.Text = "Records :";
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(1023, 591);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 7;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click_1;
            // 
            // RecoredPersonLbl
            // 
            RecoredPersonLbl.AutoSize = true;
            RecoredPersonLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredPersonLbl.Location = new Point(131, 592);
            RecoredPersonLbl.Name = "RecoredPersonLbl";
            RecoredPersonLbl.Size = new Size(0, 37);
            RecoredPersonLbl.TabIndex = 9;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(285, 202);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(181, 23);
            SearchTextBox.TabIndex = 10;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // ManagePeopleFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 652);
            Controls.Add(SearchTextBox);
            Controls.Add(RecoredPersonLbl);
            Controls.Add(CloseBtn);
            Controls.Add(RecordTextLbl);
            Controls.Add(dataGridView1);
            Controls.Add(AddPersonBtn);
            Controls.Add(FilterByComboBox);
            Controls.Add(FilterByLbl);
            Controls.Add(ManagePeopleLbl);
            Controls.Add(pictureBox1);
            Name = "ManagePeopleFrm";
            Text = "ManagePeople";
            Load += ManagePeopleFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label ManagePeopleLbl;
        private Label FilterByLbl;
        private ComboBox FilterByComboBox;
        private Button AddPersonBtn;
        private DataGridView dataGridView1;
        private Label RecordTextLbl;
        private Button CloseBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private Label RecoredPersonLbl;
        private TextBox SearchTextBox;
        private DataGridViewTextBoxColumn PersonID;
        private DataGridViewTextBoxColumn NationalNO;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn ThirdName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gendor;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
    }
}