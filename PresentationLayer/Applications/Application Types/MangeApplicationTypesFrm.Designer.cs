namespace PresentationLayer
{
    partial class MangeApplicationTypesFrm
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
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ApplicationTypeID = new DataGridViewTextBoxColumn();
            ApplicationTypeTitle = new DataGridViewTextBoxColumn();
            ApplicationFees = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ManageAppTypesLbl = new Label();
            CloseBtn = new Button();
            RecoredTypeResultLbl = new Label();
            RecordTextLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Application_Types_512;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(207, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ApplicationTypeID, ApplicationTypeTitle, ApplicationFees });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(29, 194);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(515, 312);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellToolTipTextNeeded += dataGridView1_CellToolTipTextNeeded;
            // 
            // ApplicationTypeID
            // 
            ApplicationTypeID.DataPropertyName = "ApplicationTypeID";
            ApplicationTypeID.FillWeight = 49.86183F;
            ApplicationTypeID.HeaderText = "ID";
            ApplicationTypeID.Name = "ApplicationTypeID";
            ApplicationTypeID.ReadOnly = true;
            ApplicationTypeID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ApplicationTypeTitle
            // 
            ApplicationTypeTitle.DataPropertyName = "ApplicationTypeTitle";
            ApplicationTypeTitle.FillWeight = 152.28421F;
            ApplicationTypeTitle.HeaderText = "Title";
            ApplicationTypeTitle.Name = "ApplicationTypeTitle";
            ApplicationTypeTitle.ReadOnly = true;
            ApplicationTypeTitle.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ApplicationFees
            // 
            ApplicationFees.DataPropertyName = "ApplicationFees";
            ApplicationFees.FillWeight = 97.85387F;
            ApplicationFees.HeaderText = "Fees";
            ApplicationFees.Name = "ApplicationFees";
            ApplicationFees.ReadOnly = true;
            ApplicationFees.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(203, 64);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_321;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(202, 38);
            editToolStripMenuItem.Text = "Edit Application Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // ManageAppTypesLbl
            // 
            ManageAppTypesLbl.AutoSize = true;
            ManageAppTypesLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageAppTypesLbl.ForeColor = Color.Red;
            ManageAppTypesLbl.Location = new Point(148, 149);
            ManageAppTypesLbl.Name = "ManageAppTypesLbl";
            ManageAppTypesLbl.Size = new Size(273, 30);
            ManageAppTypesLbl.TabIndex = 3;
            ManageAppTypesLbl.Text = "Manage Application Types";
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(422, 512);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 8;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // RecoredTypeResultLbl
            // 
            RecoredTypeResultLbl.AutoSize = true;
            RecoredTypeResultLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoredTypeResultLbl.Location = new Point(148, 513);
            RecoredTypeResultLbl.Name = "RecoredTypeResultLbl";
            RecoredTypeResultLbl.Size = new Size(0, 37);
            RecoredTypeResultLbl.TabIndex = 11;
            // 
            // RecordTextLbl
            // 
            RecordTextLbl.AutoSize = true;
            RecordTextLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordTextLbl.Location = new Point(29, 518);
            RecordTextLbl.Name = "RecordTextLbl";
            RecordTextLbl.Size = new Size(119, 32);
            RecordTextLbl.TabIndex = 10;
            RecordTextLbl.Text = "Records :";
            // 
            // MangeApplicationTypesFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 569);
            Controls.Add(RecoredTypeResultLbl);
            Controls.Add(RecordTextLbl);
            Controls.Add(CloseBtn);
            Controls.Add(ManageAppTypesLbl);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "MangeApplicationTypesFrm";
            Text = "MangeApplicationTypesFrm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label ManageAppTypesLbl;
        private Button CloseBtn;
        private Label RecoredTypeResultLbl;
        private Label RecordTextLbl;
        private DataGridViewTextBoxColumn ApplicationTypeID;
        private DataGridViewTextBoxColumn ApplicationTypeTitle;
        private DataGridViewTextBoxColumn ApplicationFees;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}