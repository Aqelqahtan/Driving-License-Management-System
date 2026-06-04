namespace PresentationLayer
{
    partial class AddUpdateUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateUserFrm));
            ManagePeopleLbl = new Label();
            CloseBtn = new Button();
            SaveBtn = new Button();
            tabControl1 = new TabControl();
            PersonalInfo = new TabPage();
            NextBtn = new Button();
            PersonInfoGroupBox = new GroupBox();
            GendorResultLbl = new Label();
            EditPersinInfoBtn = new LinkLabel();
            CountryResultLbl = new Label();
            PhoneResultLbl = new Label();
            DateOfBirthResultLbl = new Label();
            AddressResultLbl = new Label();
            EmailResultLbl = new Label();
            NationalNOResultLbl = new Label();
            NameResultLbl = new Label();
            PersonIDResultLbl = new Label();
            CountrypictureBox = new PictureBox();
            PhonepictureBox = new PictureBox();
            DateOfBirthpictureBox = new PictureBox();
            label2 = new Label();
            AddresspictureBox = new PictureBox();
            EmailpictureBox = new PictureBox();
            MalePictureBox = new PictureBox();
            NationalNOpictureBox = new PictureBox();
            NamepictureBox = new PictureBox();
            label1 = new Label();
            Email = new Label();
            PersonPictureBox = new PictureBox();
            CountryLbl = new Label();
            PhoneLbl = new Label();
            DateOfBirthLbl = new Label();
            LastLbl = new Label();
            ThirdLbl = new Label();
            SecondLbl = new Label();
            FirstLbl = new Label();
            AddressLbl = new Label();
            EmailLbl = new Label();
            GendorLbl = new Label();
            NationalNoLbl = new Label();
            NameLbl = new Label();
            FilterGroupBox = new GroupBox();
            FindUserPictureBox = new PictureBox();
            AddUserPictureBox = new PictureBox();
            SearchTextBox = new TextBox();
            FilterByComboBox = new ComboBox();
            FindByLbl = new Label();
            LoginInfo = new TabPage();
            UserIDLbl = new Label();
            IsActiveCheckBox = new CheckBox();
            ConfrimPasswordTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            PersonalInfo.SuspendLayout();
            PersonInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CountrypictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateOfBirthpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MalePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NationalNOpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NamepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).BeginInit();
            FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FindUserPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUserPictureBox).BeginInit();
            LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ManagePeopleLbl
            // 
            ManagePeopleLbl.AutoSize = true;
            ManagePeopleLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagePeopleLbl.ForeColor = Color.Red;
            ManagePeopleLbl.Location = new Point(277, 51);
            ManagePeopleLbl.Name = "ManagePeopleLbl";
            ManagePeopleLbl.Size = new Size(236, 45);
            ManagePeopleLbl.TabIndex = 3;
            ManagePeopleLbl.Text = "Add New User";
            // 
            // CloseBtn
            // 
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = Properties.Resources.Close_32;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(538, 526);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 37);
            CloseBtn.TabIndex = 9;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.Image = Properties.Resources.Save_32;
            SaveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SaveBtn.Location = new Point(666, 526);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(122, 37);
            SaveBtn.TabIndex = 10;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PersonalInfo);
            tabControl1.Controls.Add(LoginInfo);
            tabControl1.Location = new Point(13, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(775, 391);
            tabControl1.TabIndex = 11;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // PersonalInfo
            // 
            PersonalInfo.Controls.Add(NextBtn);
            PersonalInfo.Controls.Add(PersonInfoGroupBox);
            PersonalInfo.Controls.Add(FilterGroupBox);
            PersonalInfo.Location = new Point(4, 24);
            PersonalInfo.Name = "PersonalInfo";
            PersonalInfo.Padding = new Padding(3);
            PersonalInfo.Size = new Size(767, 363);
            PersonalInfo.TabIndex = 0;
            PersonalInfo.Text = "Personal Info";
            PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            NextBtn.Cursor = Cursors.Hand;
            NextBtn.Image = Properties.Resources.Next_32;
            NextBtn.ImageAlign = ContentAlignment.MiddleRight;
            NextBtn.Location = new Point(624, 320);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(122, 37);
            NextBtn.TabIndex = 11;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += NextBtn_Click;
            // 
            // PersonInfoGroupBox
            // 
            PersonInfoGroupBox.Controls.Add(GendorResultLbl);
            PersonInfoGroupBox.Controls.Add(EditPersinInfoBtn);
            PersonInfoGroupBox.Controls.Add(CountryResultLbl);
            PersonInfoGroupBox.Controls.Add(PhoneResultLbl);
            PersonInfoGroupBox.Controls.Add(DateOfBirthResultLbl);
            PersonInfoGroupBox.Controls.Add(AddressResultLbl);
            PersonInfoGroupBox.Controls.Add(EmailResultLbl);
            PersonInfoGroupBox.Controls.Add(NationalNOResultLbl);
            PersonInfoGroupBox.Controls.Add(NameResultLbl);
            PersonInfoGroupBox.Controls.Add(PersonIDResultLbl);
            PersonInfoGroupBox.Controls.Add(CountrypictureBox);
            PersonInfoGroupBox.Controls.Add(PhonepictureBox);
            PersonInfoGroupBox.Controls.Add(DateOfBirthpictureBox);
            PersonInfoGroupBox.Controls.Add(label2);
            PersonInfoGroupBox.Controls.Add(AddresspictureBox);
            PersonInfoGroupBox.Controls.Add(EmailpictureBox);
            PersonInfoGroupBox.Controls.Add(MalePictureBox);
            PersonInfoGroupBox.Controls.Add(NationalNOpictureBox);
            PersonInfoGroupBox.Controls.Add(NamepictureBox);
            PersonInfoGroupBox.Controls.Add(label1);
            PersonInfoGroupBox.Controls.Add(Email);
            PersonInfoGroupBox.Controls.Add(PersonPictureBox);
            PersonInfoGroupBox.Controls.Add(CountryLbl);
            PersonInfoGroupBox.Controls.Add(PhoneLbl);
            PersonInfoGroupBox.Controls.Add(DateOfBirthLbl);
            PersonInfoGroupBox.Controls.Add(LastLbl);
            PersonInfoGroupBox.Controls.Add(ThirdLbl);
            PersonInfoGroupBox.Controls.Add(SecondLbl);
            PersonInfoGroupBox.Controls.Add(FirstLbl);
            PersonInfoGroupBox.Controls.Add(AddressLbl);
            PersonInfoGroupBox.Controls.Add(EmailLbl);
            PersonInfoGroupBox.Controls.Add(GendorLbl);
            PersonInfoGroupBox.Controls.Add(NationalNoLbl);
            PersonInfoGroupBox.Controls.Add(NameLbl);
            PersonInfoGroupBox.Location = new Point(20, 98);
            PersonInfoGroupBox.Name = "PersonInfoGroupBox";
            PersonInfoGroupBox.Size = new Size(726, 216);
            PersonInfoGroupBox.TabIndex = 1;
            PersonInfoGroupBox.TabStop = false;
            PersonInfoGroupBox.Text = "Person Information";
            // 
            // GendorResultLbl
            // 
            GendorResultLbl.AutoSize = true;
            GendorResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GendorResultLbl.Location = new Point(141, 114);
            GendorResultLbl.Name = "GendorResultLbl";
            GendorResultLbl.Size = new Size(0, 17);
            GendorResultLbl.TabIndex = 93;
            // 
            // EditPersinInfoBtn
            // 
            EditPersinInfoBtn.AutoSize = true;
            EditPersinInfoBtn.Cursor = Cursors.Hand;
            EditPersinInfoBtn.Location = new Point(604, 26);
            EditPersinInfoBtn.Name = "EditPersinInfoBtn";
            EditPersinInfoBtn.Size = new Size(90, 15);
            EditPersinInfoBtn.TabIndex = 92;
            EditPersinInfoBtn.TabStop = true;
            EditPersinInfoBtn.Text = "Edit Person Info";
            EditPersinInfoBtn.LinkClicked += EditPersinInfoBtn_LinkClicked;
            // 
            // CountryResultLbl
            // 
            CountryResultLbl.AutoSize = true;
            CountryResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CountryResultLbl.Location = new Point(416, 169);
            CountryResultLbl.Name = "CountryResultLbl";
            CountryResultLbl.Size = new Size(0, 17);
            CountryResultLbl.TabIndex = 91;
            // 
            // PhoneResultLbl
            // 
            PhoneResultLbl.AutoSize = true;
            PhoneResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneResultLbl.Location = new Point(416, 130);
            PhoneResultLbl.Name = "PhoneResultLbl";
            PhoneResultLbl.Size = new Size(0, 17);
            PhoneResultLbl.TabIndex = 90;
            // 
            // DateOfBirthResultLbl
            // 
            DateOfBirthResultLbl.AutoSize = true;
            DateOfBirthResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateOfBirthResultLbl.Location = new Point(416, 91);
            DateOfBirthResultLbl.Name = "DateOfBirthResultLbl";
            DateOfBirthResultLbl.Size = new Size(0, 17);
            DateOfBirthResultLbl.TabIndex = 89;
            // 
            // AddressResultLbl
            // 
            AddressResultLbl.AutoSize = true;
            AddressResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressResultLbl.Location = new Point(141, 190);
            AddressResultLbl.Name = "AddressResultLbl";
            AddressResultLbl.Size = new Size(0, 17);
            AddressResultLbl.TabIndex = 88;
            // 
            // EmailResultLbl
            // 
            EmailResultLbl.AutoSize = true;
            EmailResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailResultLbl.Location = new Point(141, 150);
            EmailResultLbl.Name = "EmailResultLbl";
            EmailResultLbl.Size = new Size(0, 17);
            EmailResultLbl.TabIndex = 87;
            // 
            // NationalNOResultLbl
            // 
            NationalNOResultLbl.AutoSize = true;
            NationalNOResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NationalNOResultLbl.Location = new Point(141, 74);
            NationalNOResultLbl.Name = "NationalNOResultLbl";
            NationalNOResultLbl.Size = new Size(0, 17);
            NationalNOResultLbl.TabIndex = 84;
            // 
            // NameResultLbl
            // 
            NameResultLbl.AutoSize = true;
            NameResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameResultLbl.ForeColor = Color.Red;
            NameResultLbl.Location = new Point(141, 40);
            NameResultLbl.Name = "NameResultLbl";
            NameResultLbl.Size = new Size(0, 17);
            NameResultLbl.TabIndex = 83;
            // 
            // PersonIDResultLbl
            // 
            PersonIDResultLbl.AutoSize = true;
            PersonIDResultLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PersonIDResultLbl.Location = new Point(108, 15);
            PersonIDResultLbl.Name = "PersonIDResultLbl";
            PersonIDResultLbl.Size = new Size(0, 17);
            PersonIDResultLbl.TabIndex = 82;
            // 
            // CountrypictureBox
            // 
            CountrypictureBox.Image = (Image)resources.GetObject("CountrypictureBox.Image");
            CountrypictureBox.Location = new Point(383, 162);
            CountrypictureBox.Name = "CountrypictureBox";
            CountrypictureBox.Size = new Size(27, 27);
            CountrypictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CountrypictureBox.TabIndex = 81;
            CountrypictureBox.TabStop = false;
            // 
            // PhonepictureBox
            // 
            PhonepictureBox.Image = (Image)resources.GetObject("PhonepictureBox.Image");
            PhonepictureBox.Location = new Point(383, 121);
            PhonepictureBox.Name = "PhonepictureBox";
            PhonepictureBox.Size = new Size(27, 27);
            PhonepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PhonepictureBox.TabIndex = 80;
            PhonepictureBox.TabStop = false;
            // 
            // DateOfBirthpictureBox
            // 
            DateOfBirthpictureBox.Image = (Image)resources.GetObject("DateOfBirthpictureBox.Image");
            DateOfBirthpictureBox.Location = new Point(383, 81);
            DateOfBirthpictureBox.Name = "DateOfBirthpictureBox";
            DateOfBirthpictureBox.Size = new Size(27, 27);
            DateOfBirthpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DateOfBirthpictureBox.TabIndex = 79;
            DateOfBirthpictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(9, 43);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 78;
            label2.Text = "Name :";
            // 
            // AddresspictureBox
            // 
            AddresspictureBox.Image = (Image)resources.GetObject("AddresspictureBox.Image");
            AddresspictureBox.Location = new Point(108, 187);
            AddresspictureBox.Name = "AddresspictureBox";
            AddresspictureBox.Size = new Size(27, 27);
            AddresspictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AddresspictureBox.TabIndex = 77;
            AddresspictureBox.TabStop = false;
            // 
            // EmailpictureBox
            // 
            EmailpictureBox.Image = (Image)resources.GetObject("EmailpictureBox.Image");
            EmailpictureBox.Location = new Point(108, 149);
            EmailpictureBox.Name = "EmailpictureBox";
            EmailpictureBox.Size = new Size(27, 27);
            EmailpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EmailpictureBox.TabIndex = 76;
            EmailpictureBox.TabStop = false;
            // 
            // MalePictureBox
            // 
            MalePictureBox.Image = (Image)resources.GetObject("MalePictureBox.Image");
            MalePictureBox.Location = new Point(108, 112);
            MalePictureBox.Name = "MalePictureBox";
            MalePictureBox.Size = new Size(27, 27);
            MalePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MalePictureBox.TabIndex = 4;
            MalePictureBox.TabStop = false;
            // 
            // NationalNOpictureBox
            // 
            NationalNOpictureBox.Image = Properties.Resources.Number_32;
            NationalNOpictureBox.Location = new Point(108, 72);
            NationalNOpictureBox.Name = "NationalNOpictureBox";
            NationalNOpictureBox.Size = new Size(27, 27);
            NationalNOpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NationalNOpictureBox.TabIndex = 75;
            NationalNOpictureBox.TabStop = false;
            // 
            // NamepictureBox
            // 
            NamepictureBox.Image = (Image)resources.GetObject("NamepictureBox.Image");
            NamepictureBox.Location = new Point(108, 39);
            NamepictureBox.Name = "NamepictureBox";
            NamepictureBox.Size = new Size(27, 27);
            NamepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NamepictureBox.TabIndex = 74;
            NamepictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 71;
            label1.Text = "Person ID :";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Email.Location = new Point(9, 153);
            Email.Name = "Email";
            Email.Size = new Size(50, 17);
            Email.TabIndex = 70;
            Email.Text = "Email :";
            // 
            // PersonPictureBox
            // 
            PersonPictureBox.Location = new Point(593, 56);
            PersonPictureBox.Name = "PersonPictureBox";
            PersonPictureBox.Size = new Size(127, 128);
            PersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PersonPictureBox.TabIndex = 59;
            PersonPictureBox.TabStop = false;
            // 
            // CountryLbl
            // 
            CountryLbl.AutoSize = true;
            CountryLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            CountryLbl.Location = new Point(311, 170);
            CountryLbl.Name = "CountryLbl";
            CountryLbl.Size = new Size(66, 17);
            CountryLbl.TabIndex = 55;
            CountryLbl.Text = "Country :";
            // 
            // PhoneLbl
            // 
            PhoneLbl.AutoSize = true;
            PhoneLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            PhoneLbl.Location = new Point(322, 129);
            PhoneLbl.Name = "PhoneLbl";
            PhoneLbl.Size = new Size(55, 17);
            PhoneLbl.TabIndex = 53;
            PhoneLbl.Text = "Phone :";
            // 
            // DateOfBirthLbl
            // 
            DateOfBirthLbl.AutoSize = true;
            DateOfBirthLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            DateOfBirthLbl.Location = new Point(279, 91);
            DateOfBirthLbl.Name = "DateOfBirthLbl";
            DateOfBirthLbl.Size = new Size(98, 17);
            DateOfBirthLbl.TabIndex = 52;
            DateOfBirthLbl.Text = "Date Of Birth :";
            // 
            // LastLbl
            // 
            LastLbl.AutoSize = true;
            LastLbl.Location = new Point(693, -25);
            LastLbl.Name = "LastLbl";
            LastLbl.Size = new Size(28, 15);
            LastLbl.TabIndex = 51;
            LastLbl.Text = "Last";
            // 
            // ThirdLbl
            // 
            ThirdLbl.AutoSize = true;
            ThirdLbl.Location = new Point(510, -25);
            ThirdLbl.Name = "ThirdLbl";
            ThirdLbl.Size = new Size(35, 15);
            ThirdLbl.TabIndex = 50;
            ThirdLbl.Text = "Third";
            // 
            // SecondLbl
            // 
            SecondLbl.AutoSize = true;
            SecondLbl.Location = new Point(331, -25);
            SecondLbl.Name = "SecondLbl";
            SecondLbl.Size = new Size(46, 15);
            SecondLbl.TabIndex = 49;
            SecondLbl.Text = "Second";
            // 
            // FirstLbl
            // 
            FirstLbl.AutoSize = true;
            FirstLbl.Location = new Point(148, -25);
            FirstLbl.Name = "FirstLbl";
            FirstLbl.Size = new Size(29, 15);
            FirstLbl.TabIndex = 48;
            FirstLbl.Text = "First";
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            AddressLbl.Location = new Point(6, 196);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(65, 17);
            AddressLbl.TabIndex = 40;
            AddressLbl.Text = "Address :";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLbl.Location = new Point(-53, 116);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(55, 20);
            EmailLbl.TabIndex = 39;
            EmailLbl.Text = "Email :";
            // 
            // GendorLbl
            // 
            GendorLbl.AutoSize = true;
            GendorLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            GendorLbl.Location = new Point(9, 116);
            GendorLbl.Name = "GendorLbl";
            GendorLbl.Size = new Size(61, 17);
            GendorLbl.TabIndex = 38;
            GendorLbl.Text = "Gendor :";
            // 
            // NationalNoLbl
            // 
            NationalNoLbl.AutoSize = true;
            NationalNoLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            NationalNoLbl.Location = new Point(9, 76);
            NationalNoLbl.Name = "NationalNoLbl";
            NationalNoLbl.Size = new Size(93, 17);
            NationalNoLbl.TabIndex = 37;
            NationalNoLbl.Text = "National NO :";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLbl.Location = new Point(-53, -4);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(59, 20);
            NameLbl.TabIndex = 36;
            NameLbl.Text = "Name :";
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(FindUserPictureBox);
            FilterGroupBox.Controls.Add(AddUserPictureBox);
            FilterGroupBox.Controls.Add(SearchTextBox);
            FilterGroupBox.Controls.Add(FilterByComboBox);
            FilterGroupBox.Controls.Add(FindByLbl);
            FilterGroupBox.Location = new Point(20, 24);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(726, 68);
            FilterGroupBox.TabIndex = 0;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter";
            // 
            // FindUserPictureBox
            // 
            FindUserPictureBox.BorderStyle = BorderStyle.Fixed3D;
            FindUserPictureBox.Cursor = Cursors.Hand;
            FindUserPictureBox.Image = Properties.Resources.SearchPerson;
            FindUserPictureBox.Location = new Point(491, 12);
            FindUserPictureBox.Name = "FindUserPictureBox";
            FindUserPictureBox.Size = new Size(34, 33);
            FindUserPictureBox.TabIndex = 18;
            FindUserPictureBox.TabStop = false;
            FindUserPictureBox.Click += FindUserPictureBox_Click;
            // 
            // AddUserPictureBox
            // 
            AddUserPictureBox.BorderStyle = BorderStyle.Fixed3D;
            AddUserPictureBox.Cursor = Cursors.Hand;
            AddUserPictureBox.Image = Properties.Resources.AddPerson_32;
            AddUserPictureBox.Location = new Point(531, 12);
            AddUserPictureBox.Name = "AddUserPictureBox";
            AddUserPictureBox.Size = new Size(34, 33);
            AddUserPictureBox.TabIndex = 17;
            AddUserPictureBox.TabStop = false;
            AddUserPictureBox.Click += AddUserPictureBox_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(293, 22);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(181, 23);
            SearchTextBox.TabIndex = 16;
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.Enabled = false;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "National No" });
            FilterByComboBox.Location = new Point(106, 22);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(181, 23);
            FilterByComboBox.TabIndex = 1;
            FilterByComboBox.Text = "National No";
            FilterByComboBox.SelectedIndexChanged += FilterByComboBox_SelectedIndexChanged;
            // 
            // FindByLbl
            // 
            FindByLbl.AutoSize = true;
            FindByLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FindByLbl.Location = new Point(20, 27);
            FindByLbl.Name = "FindByLbl";
            FindByLbl.Size = new Size(74, 18);
            FindByLbl.TabIndex = 14;
            FindByLbl.Text = "Find By :";
            // 
            // LoginInfo
            // 
            LoginInfo.Controls.Add(UserIDLbl);
            LoginInfo.Controls.Add(IsActiveCheckBox);
            LoginInfo.Controls.Add(ConfrimPasswordTextBox);
            LoginInfo.Controls.Add(PasswordTextBox);
            LoginInfo.Controls.Add(UserNameTextBox);
            LoginInfo.Controls.Add(pictureBox4);
            LoginInfo.Controls.Add(pictureBox3);
            LoginInfo.Controls.Add(pictureBox1);
            LoginInfo.Controls.Add(pictureBox2);
            LoginInfo.Controls.Add(label6);
            LoginInfo.Controls.Add(label5);
            LoginInfo.Controls.Add(label4);
            LoginInfo.Controls.Add(label3);
            LoginInfo.Location = new Point(4, 24);
            LoginInfo.Name = "LoginInfo";
            LoginInfo.Padding = new Padding(3);
            LoginInfo.Size = new Size(767, 363);
            LoginInfo.TabIndex = 1;
            LoginInfo.Text = "Login Info";
            LoginInfo.UseVisualStyleBackColor = true;
            // 
            // UserIDLbl
            // 
            UserIDLbl.AutoSize = true;
            UserIDLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIDLbl.ForeColor = Color.Black;
            UserIDLbl.Location = new Point(279, 77);
            UserIDLbl.Name = "UserIDLbl";
            UserIDLbl.Size = new Size(32, 17);
            UserIDLbl.TabIndex = 92;
            UserIDLbl.Text = "????";
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(260, 246);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(70, 19);
            IsActiveCheckBox.TabIndex = 91;
            IsActiveCheckBox.Tag = "3";
            IsActiveCheckBox.Text = "Is Active";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfrimPasswordTextBox
            // 
            ConfrimPasswordTextBox.Location = new Point(260, 201);
            ConfrimPasswordTextBox.Name = "ConfrimPasswordTextBox";
            ConfrimPasswordTextBox.PasswordChar = '*';
            ConfrimPasswordTextBox.Size = new Size(145, 23);
            ConfrimPasswordTextBox.TabIndex = 90;
            ConfrimPasswordTextBox.Tag = "2";
            ConfrimPasswordTextBox.Validating += ConfrimPasswordTextBox_Validating;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(260, 158);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(145, 23);
            PasswordTextBox.TabIndex = 89;
            PasswordTextBox.Tag = "1";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(260, 115);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(145, 23);
            UserNameTextBox.TabIndex = 88;
            UserNameTextBox.Tag = "0";
            UserNameTextBox.Validating += UserNameTextBox_Validating;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_32;
            pictureBox4.Location = new Point(215, 68);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 87;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(215, 197);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 86;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(215, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(215, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 83;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 204);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 82;
            label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(102, 161);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 81;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 118);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 80;
            label4.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 75);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 79;
            label3.Text = "UserID:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddUpdateUserFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 569);
            Controls.Add(tabControl1);
            Controls.Add(SaveBtn);
            Controls.Add(CloseBtn);
            Controls.Add(ManagePeopleLbl);
            Name = "AddUpdateUserFrm";
            Text = "AddNewUserFrm";
            Load += AddNewUserFrm_Load;
            tabControl1.ResumeLayout(false);
            PersonalInfo.ResumeLayout(false);
            PersonInfoGroupBox.ResumeLayout(false);
            PersonInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CountrypictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateOfBirthpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MalePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NationalNOpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NamepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonPictureBox).EndInit();
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FindUserPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUserPictureBox).EndInit();
            LoginInfo.ResumeLayout(false);
            LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ManagePeopleLbl;
        private Button CloseBtn;
        private Button SaveBtn;
        private TabControl tabControl1;
        private TabPage PersonalInfo;
        private GroupBox FilterGroupBox;
        private TextBox SearchTextBox;
        private ComboBox FilterByComboBox;
        private Label FindByLbl;
        private PictureBox FindUserPictureBox;
        private PictureBox AddUserPictureBox;
        private Button NextBtn;
        private TabPage LoginInfo;
        private TextBox ConfrimPasswordTextBox;
        private TextBox PasswordTextBox;
        private TextBox UserNameTextBox;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox IsActiveCheckBox;
        private GroupBox PersonInfoGroupBox;
        private Label GendorResultLbl;
        private LinkLabel EditPersinInfoBtn;
        private Label CountryResultLbl;
        private Label PhoneResultLbl;
        private Label DateOfBirthResultLbl;
        private Label AddressResultLbl;
        private Label EmailResultLbl;
        private Label NationalNOResultLbl;
        private Label NameResultLbl;
        private Label PersonIDResultLbl;
        private PictureBox CountrypictureBox;
        private PictureBox PhonepictureBox;
        private PictureBox DateOfBirthpictureBox;
        private Label label2;
        private PictureBox AddresspictureBox;
        private PictureBox EmailpictureBox;
        private PictureBox MalePictureBox;
        private PictureBox NationalNOpictureBox;
        private PictureBox NamepictureBox;
        private Label label1;
        private Label Email;
        private PictureBox PersonPictureBox;
        private Label CountryLbl;
        private Label PhoneLbl;
        private Label DateOfBirthLbl;
        private Label LastLbl;
        private Label ThirdLbl;
        private Label SecondLbl;
        private Label FirstLbl;
        private Label AddressLbl;
        private Label EmailLbl;
        private Label GendorLbl;
        private Label NationalNoLbl;
        private Label NameLbl;
        private Label UserIDLbl;
        private ErrorProvider errorProvider1;
    }
}