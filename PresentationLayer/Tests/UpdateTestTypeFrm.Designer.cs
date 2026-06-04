namespace PresentationLayer
{
    partial class UpdateTestTypeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTestTypeFrm));
            ManageAppTypesLbl = new Label();
            SaveBtn = new Button();
            CloseBtn = new Button();
            FeesTextBox = new TextBox();
            FeesPictureBox = new PictureBox();
            TitleTextBox = new TextBox();
            FeesLbl = new Label();
            TitlepictureBox = new PictureBox();
            TitleLbl = new Label();
            ApplicationTypeIDResultLbl = new Label();
            ID = new Label();
            Description = new Label();
            pictureBox1 = new PictureBox();
            DescriptionTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FeesPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TitlepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ManageAppTypesLbl
            // 
            ManageAppTypesLbl.AutoSize = true;
            ManageAppTypesLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageAppTypesLbl.ForeColor = Color.Red;
            ManageAppTypesLbl.Location = new Point(106, 50);
            ManageAppTypesLbl.Name = "ManageAppTypesLbl";
            ManageAppTypesLbl.Size = new Size(189, 30);
            ManageAppTypesLbl.TabIndex = 5;
            ManageAppTypesLbl.Text = "Update Test Types";
            // 
            // SaveBtn
            // 
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.Image = Properties.Resources.Save_32;
            SaveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SaveBtn.Location = new Point(276, 326);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(122, 37);
            SaveBtn.TabIndex = 101;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(148, 326);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 100;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // FeesTextBox
            // 
            FeesTextBox.Location = new Point(142, 274);
            FeesTextBox.Name = "FeesTextBox";
            FeesTextBox.Size = new Size(256, 23);
            FeesTextBox.TabIndex = 99;
            // 
            // FeesPictureBox
            // 
            FeesPictureBox.Image = (Image)resources.GetObject("FeesPictureBox.Image");
            FeesPictureBox.Location = new Point(109, 270);
            FeesPictureBox.Name = "FeesPictureBox";
            FeesPictureBox.Size = new Size(27, 27);
            FeesPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FeesPictureBox.TabIndex = 98;
            FeesPictureBox.TabStop = false;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Enabled = false;
            TitleTextBox.Location = new Point(142, 134);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(256, 23);
            TitleTextBox.TabIndex = 97;
            // 
            // FeesLbl
            // 
            FeesLbl.AutoSize = true;
            FeesLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            FeesLbl.Location = new Point(50, 280);
            FeesLbl.Name = "FeesLbl";
            FeesLbl.Size = new Size(43, 17);
            FeesLbl.TabIndex = 96;
            FeesLbl.Text = "Fees :";
            // 
            // TitlepictureBox
            // 
            TitlepictureBox.Image = (Image)resources.GetObject("TitlepictureBox.Image");
            TitlepictureBox.Location = new Point(109, 134);
            TitlepictureBox.Name = "TitlepictureBox";
            TitlepictureBox.Size = new Size(27, 27);
            TitlepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TitlepictureBox.TabIndex = 95;
            TitlepictureBox.TabStop = false;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            TitleLbl.Location = new Point(50, 140);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(44, 17);
            TitleLbl.TabIndex = 94;
            TitleLbl.Text = "Title :";
            // 
            // ApplicationTypeIDResultLbl
            // 
            ApplicationTypeIDResultLbl.AutoSize = true;
            ApplicationTypeIDResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationTypeIDResultLbl.Location = new Point(136, 99);
            ApplicationTypeIDResultLbl.Name = "ApplicationTypeIDResultLbl";
            ApplicationTypeIDResultLbl.Size = new Size(0, 17);
            ApplicationTypeIDResultLbl.TabIndex = 93;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ID.Location = new Point(60, 99);
            ID.Name = "ID";
            ID.Size = new Size(34, 17);
            ID.TabIndex = 92;
            ID.Text = " ID :";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Description.Location = new Point(7, 178);
            Description.Name = "Description";
            Description.Size = new Size(87, 17);
            Description.TabIndex = 102;
            Description.Text = "Description :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 103;
            pictureBox1.TabStop = false;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(142, 172);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(256, 85);
            DescriptionTextBox.TabIndex = 104;
            // 
            // UpdateTestTypeFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 395);
            Controls.Add(DescriptionTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(Description);
            Controls.Add(SaveBtn);
            Controls.Add(CloseBtn);
            Controls.Add(FeesTextBox);
            Controls.Add(FeesPictureBox);
            Controls.Add(TitleTextBox);
            Controls.Add(FeesLbl);
            Controls.Add(TitlepictureBox);
            Controls.Add(TitleLbl);
            Controls.Add(ApplicationTypeIDResultLbl);
            Controls.Add(ID);
            Controls.Add(ManageAppTypesLbl);
            Name = "UpdateTestTypeFrm";
            Text = "UpdateTestTypeFrm";
            Load += UpdateTestTypeFrm_Load;
            ((System.ComponentModel.ISupportInitialize)FeesPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TitlepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ManageAppTypesLbl;
        private Button SaveBtn;
        private Button CloseBtn;
        private TextBox FeesTextBox;
        private PictureBox FeesPictureBox;
        private TextBox TitleTextBox;
        private Label FeesLbl;
        private PictureBox TitlepictureBox;
        private Label TitleLbl;
        private Label ApplicationTypeIDResultLbl;
        private Label ID;
        private Label Description;
        private PictureBox pictureBox1;
        private TextBox DescriptionTextBox;
    }
}