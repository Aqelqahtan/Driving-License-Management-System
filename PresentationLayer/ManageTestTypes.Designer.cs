namespace PresentationLayer
{
    partial class ManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTestTypes));
            ManageAppTypesLbl = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editTestTypeToolStripMenuItem = new ToolStripMenuItem();
            RecoredTestTypeResultLbl = new Label();
            RecordTextLbl = new Label();
            CloseBtn = new Button();
            TestTypeID = new DataGridViewTextBoxColumn();
            TestTypeTitle = new DataGridViewTextBoxColumn();
            TestTypeDescription = new DataGridViewTextBoxColumn();
            TestTypeFees = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ManageAppTypesLbl
            // 
            ManageAppTypesLbl.AutoSize = true;
            ManageAppTypesLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageAppTypesLbl.ForeColor = Color.Red;
            ManageAppTypesLbl.Location = new Point(284, 153);
            ManageAppTypesLbl.Name = "ManageAppTypesLbl";
            ManageAppTypesLbl.Size = new Size(197, 30);
            ManageAppTypesLbl.TabIndex = 4;
            ManageAppTypesLbl.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 199);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(769, 239);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editTestTypeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 42);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // editTestTypeToolStripMenuItem
            // 
            editTestTypeToolStripMenuItem.Image = Properties.Resources.edit_322;
            editTestTypeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            editTestTypeToolStripMenuItem.Size = new Size(162, 38);
            editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            editTestTypeToolStripMenuItem.Click += editTestTypeToolStripMenuItem_Click;
            // 
            // RecoredTestTypeResultLbl
            // 
            RecoredTestTypeResultLbl.AutoSize = true;
            RecoredTestTypeResultLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredTestTypeResultLbl.Location = new Point(131, 450);
            RecoredTestTypeResultLbl.Name = "RecoredTestTypeResultLbl";
            RecoredTestTypeResultLbl.Size = new Size(0, 37);
            RecoredTestTypeResultLbl.TabIndex = 14;
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(12, 455);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 13;
            RecordTextLbl.Text = "Records :";
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(659, 455);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 12;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // TestTypeID
            // 
            TestTypeID.DataPropertyName = "TestTypeID";
            TestTypeID.FillWeight = 101.522842F;
            TestTypeID.HeaderText = "ID";
            TestTypeID.Name = "TestTypeID";
            TestTypeID.Width = 40;
            // 
            // TestTypeTitle
            // 
            TestTypeTitle.DataPropertyName = "TestTypeTitle";
            TestTypeTitle.FillWeight = 99.4923859F;
            TestTypeTitle.HeaderText = "Title";
            TestTypeTitle.Name = "TestTypeTitle";
            // 
            // TestTypeDescription
            // 
            TestTypeDescription.DataPropertyName = "TestTypeDescription";
            TestTypeDescription.FillWeight = 99.4923859F;
            TestTypeDescription.HeaderText = "Description";
            TestTypeDescription.Name = "TestTypeDescription";
            TestTypeDescription.Width = 500;
            // 
            // TestTypeFees
            // 
            TestTypeFees.DataPropertyName = "TestTypeFees";
            TestTypeFees.FillWeight = 99.4923859F;
            TestTypeFees.HeaderText = "Fees";
            TestTypeFees.Name = "TestTypeFees";
            // 
            // ManageTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 504);
            Controls.Add(RecoredTestTypeResultLbl);
            Controls.Add(RecordTextLbl);
            Controls.Add(CloseBtn);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(ManageAppTypesLbl);
            Name = "ManageTestTypes";
            Text = "ManageTestTypes";
            Load += ManageTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ManageAppTypesLbl;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label RecoredTestTypeResultLbl;
        private Label RecordTextLbl;
        private Button CloseBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editTestTypeToolStripMenuItem;
        private DataGridViewTextBoxColumn TestTypeID;
        private DataGridViewTextBoxColumn TestTypeTitle;
        private DataGridViewTextBoxColumn TestTypeDescription;
        private DataGridViewTextBoxColumn TestTypeFees;
    }
}