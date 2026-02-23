namespace PresentationLayer
{
    partial class AddUpdatePersonFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdatePersonFrm));
            PersonIDLbl = new Label();
            ModeLbl = new Label();
            AddPersonpictureBox = new PictureBox();
            PersonIDPicture = new PictureBox();
            PersonIDResultLbl = new Label();
            groupBox1 = new GroupBox();
            RemoveLinkLabel = new LinkLabel();
            AddresspictureBox = new PictureBox();
            EmailpictureBox = new PictureBox();
            CountrypictureBox = new PictureBox();
            PhonepictureBox = new PictureBox();
            DateOfBirthpictureBox = new PictureBox();
            NationalNOpictureBox = new PictureBox();
            NamepictureBox = new PictureBox();
            DateOfBirthPaker = new DateTimePicker();
            GendorGroupBox = new GroupBox();
            FemaleButton = new RadioButton();
            FemalePictureBox = new PictureBox();
            MalePictureBox = new PictureBox();
            MaleButton = new RadioButton();
            SetImageLinkLbl = new LinkLabel();
            PersonGendorPicture = new PictureBox();
            SaveBtn = new Button();
            CloseBtn = new Button();
            CountrycomboBox = new ComboBox();
            CountryLbl = new Label();
            PhonetextBox = new TextBox();
            PhoneLbl = new Label();
            DateOfBirthLbl = new Label();
            LastLbl = new Label();
            ThirdLbl = new Label();
            SecondLbl = new Label();
            FirstLbl = new Label();
            AddresstextBox = new TextBox();
            EmailtextBox = new TextBox();
            NationalNOtextBox = new TextBox();
            LastNametextBox = new TextBox();
            ThirdNametextBox = new TextBox();
            SecondNametextBox = new TextBox();
            FirstNametextBox = new TextBox();
            AddressLbl = new Label();
            EmailLbl = new Label();
            GendorLbl = new Label();
            NationalNoLbl = new Label();
            NameLbl = new Label();
            imageList1 = new ImageList(components);
            errorProvider1 = new ErrorProvider(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)AddPersonpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonIDPicture).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountrypictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateOfBirthpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationalNOpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NamepictureBox).BeginInit();
            GendorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FemalePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MalePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonGendorPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // PersonIDLbl
            // 
            PersonIDLbl.AutoSize = true;
            PersonIDLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonIDLbl.Location = new Point(12, 162);
            PersonIDLbl.Name = "PersonIDLbl";
            PersonIDLbl.Size = new Size(85, 20);
            PersonIDLbl.TabIndex = 0;
            PersonIDLbl.Text = "Person ID :";
            // 
            // ModeLbl
            // 
            ModeLbl.AutoSize = true;
            ModeLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModeLbl.ForeColor = Color.Red;
            ModeLbl.Location = new Point(343, 120);
            ModeLbl.Name = "ModeLbl";
            ModeLbl.Size = new Size(0, 30);
            ModeLbl.TabIndex = 1;
            // 
            // AddPersonpictureBox
            // 
            AddPersonpictureBox.Image = Properties.Resources.People_400;
            AddPersonpictureBox.Location = new Point(355, 5);
            AddPersonpictureBox.Name = "AddPersonpictureBox";
            AddPersonpictureBox.Size = new Size(156, 112);
            AddPersonpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AddPersonpictureBox.TabIndex = 2;
            AddPersonpictureBox.TabStop = false;
            // 
            // PersonIDPicture
            // 
            PersonIDPicture.Image = Properties.Resources.Number_32;
            PersonIDPicture.Location = new Point(163, 155);
            PersonIDPicture.Name = "PersonIDPicture";
            PersonIDPicture.Size = new Size(27, 27);
            PersonIDPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PersonIDPicture.TabIndex = 3;
            PersonIDPicture.TabStop = false;
            // 
            // PersonIDResultLbl
            // 
            PersonIDResultLbl.AutoSize = true;
            PersonIDResultLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonIDResultLbl.Location = new Point(196, 162);
            PersonIDResultLbl.Name = "PersonIDResultLbl";
            PersonIDResultLbl.Size = new Size(39, 20);
            PersonIDResultLbl.TabIndex = 4;
            PersonIDResultLbl.Text = "N/A";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RemoveLinkLabel);
            groupBox1.Controls.Add(AddresspictureBox);
            groupBox1.Controls.Add(EmailpictureBox);
            groupBox1.Controls.Add(CountrypictureBox);
            groupBox1.Controls.Add(PhonepictureBox);
            groupBox1.Controls.Add(DateOfBirthpictureBox);
            groupBox1.Controls.Add(NationalNOpictureBox);
            groupBox1.Controls.Add(NamepictureBox);
            groupBox1.Controls.Add(DateOfBirthPaker);
            groupBox1.Controls.Add(GendorGroupBox);
            groupBox1.Controls.Add(SetImageLinkLbl);
            groupBox1.Controls.Add(PersonGendorPicture);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(CountrycomboBox);
            groupBox1.Controls.Add(CountryLbl);
            groupBox1.Controls.Add(PhonetextBox);
            groupBox1.Controls.Add(PhoneLbl);
            groupBox1.Controls.Add(DateOfBirthLbl);
            groupBox1.Controls.Add(LastLbl);
            groupBox1.Controls.Add(ThirdLbl);
            groupBox1.Controls.Add(SecondLbl);
            groupBox1.Controls.Add(FirstLbl);
            groupBox1.Controls.Add(AddresstextBox);
            groupBox1.Controls.Add(EmailtextBox);
            groupBox1.Controls.Add(NationalNOtextBox);
            groupBox1.Controls.Add(LastNametextBox);
            groupBox1.Controls.Add(ThirdNametextBox);
            groupBox1.Controls.Add(SecondNametextBox);
            groupBox1.Controls.Add(FirstNametextBox);
            groupBox1.Controls.Add(AddressLbl);
            groupBox1.Controls.Add(EmailLbl);
            groupBox1.Controls.Add(GendorLbl);
            groupBox1.Controls.Add(NationalNoLbl);
            groupBox1.Controls.Add(NameLbl);
            groupBox1.Location = new Point(12, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(863, 319);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // RemoveLinkLabel
            // 
            RemoveLinkLabel.AutoSize = true;
            RemoveLinkLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveLinkLabel.Location = new Point(719, 275);
            RemoveLinkLabel.Name = "RemoveLinkLabel";
            RemoveLinkLabel.Size = new Size(78, 25);
            RemoveLinkLabel.TabIndex = 35;
            RemoveLinkLabel.TabStop = true;
            RemoveLinkLabel.Text = "Remove";
            RemoveLinkLabel.Visible = false;
            RemoveLinkLabel.MouseClick += RemoveLinkLabel_MouseClick;
            // 
            // AddresspictureBox
            // 
            AddresspictureBox.Image = (Image)resources.GetObject("AddresspictureBox.Image");
            AddresspictureBox.Location = new Point(118, 195);
            AddresspictureBox.Name = "AddresspictureBox";
            AddresspictureBox.Size = new Size(27, 27);
            AddresspictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AddresspictureBox.TabIndex = 34;
            AddresspictureBox.TabStop = false;
            // 
            // EmailpictureBox
            // 
            EmailpictureBox.Image = (Image)resources.GetObject("EmailpictureBox.Image");
            EmailpictureBox.Location = new Point(118, 152);
            EmailpictureBox.Name = "EmailpictureBox";
            EmailpictureBox.Size = new Size(27, 27);
            EmailpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EmailpictureBox.TabIndex = 33;
            EmailpictureBox.TabStop = false;
            // 
            // CountrypictureBox
            // 
            CountrypictureBox.Image = (Image)resources.GetObject("CountrypictureBox.Image");
            CountrypictureBox.Location = new Point(472, 153);
            CountrypictureBox.Name = "CountrypictureBox";
            CountrypictureBox.Size = new Size(27, 27);
            CountrypictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CountrypictureBox.TabIndex = 32;
            CountrypictureBox.TabStop = false;
            // 
            // PhonepictureBox
            // 
            PhonepictureBox.Image = (Image)resources.GetObject("PhonepictureBox.Image");
            PhonepictureBox.Location = new Point(472, 112);
            PhonepictureBox.Name = "PhonepictureBox";
            PhonepictureBox.Size = new Size(27, 27);
            PhonepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PhonepictureBox.TabIndex = 31;
            PhonepictureBox.TabStop = false;
            // 
            // DateOfBirthpictureBox
            // 
            DateOfBirthpictureBox.Image = (Image)resources.GetObject("DateOfBirthpictureBox.Image");
            DateOfBirthpictureBox.Location = new Point(472, 72);
            DateOfBirthpictureBox.Name = "DateOfBirthpictureBox";
            DateOfBirthpictureBox.Size = new Size(27, 27);
            DateOfBirthpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DateOfBirthpictureBox.TabIndex = 30;
            DateOfBirthpictureBox.TabStop = false;
            // 
            // NationalNOpictureBox
            // 
            NationalNOpictureBox.Image = Properties.Resources.Number_32;
            NationalNOpictureBox.Location = new Point(118, 68);
            NationalNOpictureBox.Name = "NationalNOpictureBox";
            NationalNOpictureBox.Size = new Size(27, 27);
            NationalNOpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NationalNOpictureBox.TabIndex = 29;
            NationalNOpictureBox.TabStop = false;
            // 
            // NamepictureBox
            // 
            NamepictureBox.Image = (Image)resources.GetObject("NamepictureBox.Image");
            NamepictureBox.Location = new Point(118, 32);
            NamepictureBox.Name = "NamepictureBox";
            NamepictureBox.Size = new Size(27, 27);
            NamepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NamepictureBox.TabIndex = 28;
            NamepictureBox.TabStop = false;
            // 
            // DateOfBirthPaker
            // 
            DateOfBirthPaker.Location = new Point(505, 74);
            DateOfBirthPaker.MinDate = new DateTime(1900, 1, 15, 0, 0, 0, 0);
            DateOfBirthPaker.Name = "DateOfBirthPaker";
            DateOfBirthPaker.Size = new Size(154, 23);
            DateOfBirthPaker.TabIndex = 27;
            DateOfBirthPaker.Validating += AddNewUser_Validating;
            // 
            // GendorGroupBox
            // 
            GendorGroupBox.Controls.Add(FemaleButton);
            GendorGroupBox.Controls.Add(FemalePictureBox);
            GendorGroupBox.Controls.Add(MalePictureBox);
            GendorGroupBox.Controls.Add(MaleButton);
            GendorGroupBox.Location = new Point(117, 101);
            GendorGroupBox.Name = "GendorGroupBox";
            GendorGroupBox.Size = new Size(198, 45);
            GendorGroupBox.TabIndex = 26;
            GendorGroupBox.TabStop = false;
            // 
            // FemaleButton
            // 
            FemaleButton.AutoSize = true;
            FemaleButton.Location = new Point(124, 19);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(63, 19);
            FemaleButton.TabIndex = 6;
            FemaleButton.TabStop = true;
            FemaleButton.Text = "Female";
            FemaleButton.UseVisualStyleBackColor = true;
            FemaleButton.CheckedChanged += FemaleButton_CheckedChanged;
            // 
            // FemalePictureBox
            // 
            FemalePictureBox.Image = (Image)resources.GetObject("FemalePictureBox.Image");
            FemalePictureBox.Location = new Point(91, 11);
            FemalePictureBox.Name = "FemalePictureBox";
            FemalePictureBox.Size = new Size(27, 27);
            FemalePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FemalePictureBox.TabIndex = 5;
            FemalePictureBox.TabStop = false;
            // 
            // MalePictureBox
            // 
            MalePictureBox.Image = (Image)resources.GetObject("MalePictureBox.Image");
            MalePictureBox.Location = new Point(0, 12);
            MalePictureBox.Name = "MalePictureBox";
            MalePictureBox.Size = new Size(27, 27);
            MalePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MalePictureBox.TabIndex = 4;
            MalePictureBox.TabStop = false;
            // 
            // MaleButton
            // 
            MaleButton.AutoSize = true;
            MaleButton.Location = new Point(34, 20);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(51, 19);
            MaleButton.TabIndex = 0;
            MaleButton.TabStop = true;
            MaleButton.Text = "Male";
            MaleButton.UseVisualStyleBackColor = true;
            MaleButton.CheckedChanged += MaleButton_CheckedChanged;
            // 
            // SetImageLinkLbl
            // 
            SetImageLinkLbl.AutoSize = true;
            SetImageLinkLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SetImageLinkLbl.Location = new Point(719, 250);
            SetImageLinkLbl.Name = "SetImageLinkLbl";
            SetImageLinkLbl.Size = new Size(95, 25);
            SetImageLinkLbl.TabIndex = 25;
            SetImageLinkLbl.TabStop = true;
            SetImageLinkLbl.Text = "Set Image";
            SetImageLinkLbl.LinkClicked += SetImageLinkLbl_LinkClicked;
            // 
            // PersonGendorPicture
            // 
            PersonGendorPicture.Location = new Point(691, 78);
            PersonGendorPicture.Name = "PersonGendorPicture";
            PersonGendorPicture.Size = new Size(148, 161);
            PersonGendorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PersonGendorPicture.TabIndex = 24;
            PersonGendorPicture.TabStop = false;
            // 
            // SaveBtn
            // 
            SaveBtn.Image = Properties.Resources.Save_32;
            SaveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SaveBtn.Location = new Point(549, 281);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(110, 32);
            SaveBtn.TabIndex = 23;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(424, 281);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(110, 32);
            CloseBtn.TabIndex = 22;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // CountrycomboBox
            // 
            CountrycomboBox.FormattingEnabled = true;
            CountrycomboBox.Location = new Point(509, 157);
            CountrycomboBox.Name = "CountrycomboBox";
            CountrycomboBox.Size = new Size(150, 23);
            CountrycomboBox.TabIndex = 21;
            // 
            // CountryLbl
            // 
            CountryLbl.AutoSize = true;
            CountryLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryLbl.Location = new Point(390, 160);
            CountryLbl.Name = "CountryLbl";
            CountryLbl.Size = new Size(74, 20);
            CountryLbl.TabIndex = 20;
            CountryLbl.Text = "Country :";
            // 
            // PhonetextBox
            // 
            PhonetextBox.Location = new Point(508, 112);
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(151, 23);
            PhonetextBox.TabIndex = 19;
            // 
            // PhoneLbl
            // 
            PhoneLbl.AutoSize = true;
            PhoneLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneLbl.Location = new Point(403, 115);
            PhoneLbl.Name = "PhoneLbl";
            PhoneLbl.Size = new Size(61, 20);
            PhoneLbl.TabIndex = 18;
            PhoneLbl.Text = "Phone :";
            // 
            // DateOfBirthLbl
            // 
            DateOfBirthLbl.AutoSize = true;
            DateOfBirthLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateOfBirthLbl.Location = new Point(354, 75);
            DateOfBirthLbl.Name = "DateOfBirthLbl";
            DateOfBirthLbl.Size = new Size(110, 20);
            DateOfBirthLbl.TabIndex = 17;
            DateOfBirthLbl.Text = "Date Of Birth :";
            // 
            // LastLbl
            // 
            LastLbl.AutoSize = true;
            LastLbl.Location = new Point(752, 14);
            LastLbl.Name = "LastLbl";
            LastLbl.Size = new Size(28, 15);
            LastLbl.TabIndex = 16;
            LastLbl.Text = "Last";
            // 
            // ThirdLbl
            // 
            ThirdLbl.AutoSize = true;
            ThirdLbl.Location = new Point(569, 14);
            ThirdLbl.Name = "ThirdLbl";
            ThirdLbl.Size = new Size(35, 15);
            ThirdLbl.TabIndex = 15;
            ThirdLbl.Text = "Third";
            // 
            // SecondLbl
            // 
            SecondLbl.AutoSize = true;
            SecondLbl.Location = new Point(390, 14);
            SecondLbl.Name = "SecondLbl";
            SecondLbl.Size = new Size(46, 15);
            SecondLbl.TabIndex = 14;
            SecondLbl.Text = "Second";
            // 
            // FirstLbl
            // 
            FirstLbl.AutoSize = true;
            FirstLbl.Location = new Point(207, 14);
            FirstLbl.Name = "FirstLbl";
            FirstLbl.Size = new Size(29, 15);
            FirstLbl.TabIndex = 13;
            FirstLbl.Text = "First";
            // 
            // AddresstextBox
            // 
            AddresstextBox.Location = new Point(151, 195);
            AddresstextBox.Multiline = true;
            AddresstextBox.Name = "AddresstextBox";
            AddresstextBox.Size = new Size(508, 80);
            AddresstextBox.TabIndex = 12;
            AddresstextBox.Validating += AddresstextBox_Validating;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(151, 152);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(151, 23);
            EmailtextBox.TabIndex = 11;
            EmailtextBox.Validating += EmailtextBox_Validating;
            // 
            // NationalNOtextBox
            // 
            NationalNOtextBox.Location = new Point(151, 72);
            NationalNOtextBox.Name = "NationalNOtextBox";
            NationalNOtextBox.Size = new Size(151, 23);
            NationalNOtextBox.TabIndex = 10;
            NationalNOtextBox.Validating += NationalNOtextBox_Validating;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(688, 32);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(151, 23);
            LastNametextBox.TabIndex = 9;
            // 
            // ThirdNametextBox
            // 
            ThirdNametextBox.Location = new Point(508, 32);
            ThirdNametextBox.Name = "ThirdNametextBox";
            ThirdNametextBox.Size = new Size(151, 23);
            ThirdNametextBox.TabIndex = 8;
            // 
            // SecondNametextBox
            // 
            SecondNametextBox.Location = new Point(331, 32);
            SecondNametextBox.Name = "SecondNametextBox";
            SecondNametextBox.Size = new Size(151, 23);
            SecondNametextBox.TabIndex = 7;
            // 
            // FirstNametextBox
            // 
            FirstNametextBox.Location = new Point(151, 32);
            FirstNametextBox.Name = "FirstNametextBox";
            FirstNametextBox.Size = new Size(151, 23);
            FirstNametextBox.TabIndex = 6;
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLbl.Location = new Point(6, 195);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(74, 20);
            AddressLbl.TabIndex = 5;
            AddressLbl.Text = "Address :";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLbl.Location = new Point(6, 155);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(55, 20);
            EmailLbl.TabIndex = 4;
            EmailLbl.Text = "Email :";
            // 
            // GendorLbl
            // 
            GendorLbl.AutoSize = true;
            GendorLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GendorLbl.Location = new Point(6, 115);
            GendorLbl.Name = "GendorLbl";
            GendorLbl.Size = new Size(69, 20);
            GendorLbl.TabIndex = 3;
            GendorLbl.Text = "Gendor :";
            // 
            // NationalNoLbl
            // 
            NationalNoLbl.AutoSize = true;
            NationalNoLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NationalNoLbl.Location = new Point(6, 75);
            NationalNoLbl.Name = "NationalNoLbl";
            NationalNoLbl.Size = new Size(104, 20);
            NationalNoLbl.TabIndex = 2;
            NationalNoLbl.Text = "National NO :";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLbl.Location = new Point(6, 35);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(59, 20);
            NameLbl.TabIndex = 1;
            NameLbl.Text = "Name :";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddUpdatePersonFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 571);
            Controls.Add(groupBox1);
            Controls.Add(PersonIDResultLbl);
            Controls.Add(PersonIDPicture);
            Controls.Add(AddPersonpictureBox);
            Controls.Add(ModeLbl);
            Controls.Add(PersonIDLbl);
            Name = "AddUpdatePersonFrm";
            Text = "AddNewUser";
            Load += AddNewUser_Load;
            Validating += AddNewUser_Validating;
            ((System.ComponentModel.ISupportInitialize)AddPersonpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonIDPicture).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountrypictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateOfBirthpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationalNOpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NamepictureBox).EndInit();
            GendorGroupBox.ResumeLayout(false);
            GendorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FemalePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MalePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonGendorPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonIDLbl;
        private Label ModeLbl;
        private PictureBox AddPersonpictureBox;
        private PictureBox PersonIDPicture;
        private Label PersonIDResultLbl;
        private GroupBox groupBox1;
        private Label NationalNoLbl;
        private Label NameLbl;
        private TextBox LastNametextBox;
        private TextBox ThirdNametextBox;
        private TextBox SecondNametextBox;
        private TextBox FirstNametextBox;
        private Label AddressLbl;
        private Label EmailLbl;
        private Label GendorLbl;
        private Label DateOfBirthLbl;
        private Label LastLbl;
        private Label ThirdLbl;
        private Label SecondLbl;
        private Label FirstLbl;
        private TextBox AddresstextBox;
        private TextBox EmailtextBox;
        private TextBox NationalNOtextBox;
        private Label CountryLbl;
        private TextBox PhonetextBox;
        private Label PhoneLbl;
        private Button SaveBtn;
        private Button CloseBtn;
        private ComboBox CountrycomboBox;
        private LinkLabel SetImageLinkLbl;
        private PictureBox PersonGendorPicture;
        private GroupBox GendorGroupBox;
        private RadioButton MaleButton;
        private PictureBox MalePictureBox;
        private ImageList imageList1;
        private PictureBox FemalePictureBox;
        private RadioButton FemaleButton;
        private PictureBox NamepictureBox;
        private DateTimePicker DateOfBirthPaker;
        private PictureBox CountrypictureBox;
        private PictureBox PhonepictureBox;
        private PictureBox DateOfBirthpictureBox;
        private PictureBox NationalNOpictureBox;
        private PictureBox EmailpictureBox;
        private PictureBox AddresspictureBox;
        private ErrorProvider errorProvider1;
        private LinkLabel RemoveLinkLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}