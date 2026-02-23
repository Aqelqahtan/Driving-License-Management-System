namespace PresentationLayer
{
    partial class UpdateApplicationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateApplicationType));
            UpdateApplicationTypeLbl = new Label();
            ID = new Label();
            ApplicationTypeIDResultLbl = new Label();
            TitleLbl = new Label();
            TitlepictureBox = new PictureBox();
            FeesLbl = new Label();
            TitleTextBox = new TextBox();
            FeesPictureBox = new PictureBox();
            FeesTextBox = new TextBox();
            SaveBtn = new Button();
            CloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TitlepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeesPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UpdateApplicationTypeLbl
            // 
            UpdateApplicationTypeLbl.AutoSize = true;
            UpdateApplicationTypeLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateApplicationTypeLbl.ForeColor = Color.Red;
            UpdateApplicationTypeLbl.Location = new Point(87, 9);
            UpdateApplicationTypeLbl.Name = "UpdateApplicationTypeLbl";
            UpdateApplicationTypeLbl.Size = new Size(296, 32);
            UpdateApplicationTypeLbl.TabIndex = 3;
            UpdateApplicationTypeLbl.Text = "Update Application Type";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ID.Location = new Point(41, 63);
            ID.Name = "ID";
            ID.Size = new Size(34, 17);
            ID.TabIndex = 72;
            ID.Text = " ID :";
            // 
            // ApplicationTypeIDResultLbl
            // 
            ApplicationTypeIDResultLbl.AutoSize = true;
            ApplicationTypeIDResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationTypeIDResultLbl.Location = new Point(130, 63);
            ApplicationTypeIDResultLbl.Name = "ApplicationTypeIDResultLbl";
            ApplicationTypeIDResultLbl.Size = new Size(0, 17);
            ApplicationTypeIDResultLbl.TabIndex = 83;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            TitleLbl.Location = new Point(30, 122);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(44, 17);
            TitleLbl.TabIndex = 84;
            TitleLbl.Text = "Title :";
            // 
            // TitlepictureBox
            // 
            TitlepictureBox.Image = (Image)resources.GetObject("TitlepictureBox.Image");
            TitlepictureBox.Location = new Point(103, 116);
            TitlepictureBox.Name = "TitlepictureBox";
            TitlepictureBox.Size = new Size(27, 27);
            TitlepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TitlepictureBox.TabIndex = 85;
            TitlepictureBox.TabStop = false;
            // 
            // FeesLbl
            // 
            FeesLbl.AutoSize = true;
            FeesLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            FeesLbl.Location = new Point(31, 175);
            FeesLbl.Name = "FeesLbl";
            FeesLbl.Size = new Size(43, 17);
            FeesLbl.TabIndex = 86;
            FeesLbl.Text = "Fees :";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Enabled = false;
            TitleTextBox.Location = new Point(136, 116);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(256, 23);
            TitleTextBox.TabIndex = 87;
            // 
            // FeesPictureBox
            // 
            FeesPictureBox.Image = (Image)resources.GetObject("FeesPictureBox.Image");
            FeesPictureBox.Location = new Point(103, 165);
            FeesPictureBox.Name = "FeesPictureBox";
            FeesPictureBox.Size = new Size(27, 27);
            FeesPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FeesPictureBox.TabIndex = 88;
            FeesPictureBox.TabStop = false;
            // 
            // FeesTextBox
            // 
            FeesTextBox.Location = new Point(136, 169);
            FeesTextBox.Name = "FeesTextBox";
            FeesTextBox.Size = new Size(256, 23);
            FeesTextBox.TabIndex = 89;
            // 
            // SaveBtn
            // 
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.Image = Properties.Resources.Save_32;
            SaveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SaveBtn.Location = new Point(270, 221);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(122, 37);
            SaveBtn.TabIndex = 91;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(142, 221);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 90;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // UpdateApplicationType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 284);
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
            Controls.Add(UpdateApplicationTypeLbl);
            Name = "UpdateApplicationType";
            Text = "UpdateApplicationType";
            Load += UpdateApplicationType_Load;
            ((System.ComponentModel.ISupportInitialize)TitlepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeesPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateApplicationTypeLbl;
        private Label ID;
        private Label ApplicationTypeIDResultLbl;
        private Label TitleLbl;
        private PictureBox TitlepictureBox;
        private Label FeesLbl;
        private TextBox TitleTextBox;
        private PictureBox FeesPictureBox;
        private TextBox FeesTextBox;
        private Button SaveBtn;
        private Button CloseBtn;
    }
}