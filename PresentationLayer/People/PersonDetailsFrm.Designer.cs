namespace PresentationLayer
{
    partial class PersonDetailsFrm
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
            PersonDetailsLbl = new Label();
            groupBox1 = new GroupBox();
            NameResultLbl = new Label();
            EditPersinInfoBtn = new LinkLabel();
            CountryResultLbl = new Label();
            PhoneResultLbl = new Label();
            DateOfBirthResultLbl = new Label();
            AddressResultLbl = new Label();
            EmailResultLbl = new Label();
            GendorResultLbl = new Label();
            NationalNOResultLbl = new Label();
            PersonIDResultLbl = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            PicturePersonPictureBox = new PictureBox();
            CountryLbl = new Label();
            PhoneLbl = new Label();
            DateOfBirthLbl = new Label();
            AddressLbl = new Label();
            EmailLbl = new Label();
            GendorLbl = new Label();
            NationalNoLbl = new Label();
            NameLbl = new Label();
            PersonIDlbl = new Label();
            CloseBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicturePersonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // PersonDetailsLbl
            // 
            PersonDetailsLbl.AutoSize = true;
            PersonDetailsLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonDetailsLbl.ForeColor = Color.Red;
            PersonDetailsLbl.Location = new Point(373, 29);
            PersonDetailsLbl.Name = "PersonDetailsLbl";
            PersonDetailsLbl.Size = new Size(233, 45);
            PersonDetailsLbl.TabIndex = 0;
            PersonDetailsLbl.Text = "Person Details";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NameResultLbl);
            groupBox1.Controls.Add(EditPersinInfoBtn);
            groupBox1.Controls.Add(CountryResultLbl);
            groupBox1.Controls.Add(PhoneResultLbl);
            groupBox1.Controls.Add(DateOfBirthResultLbl);
            groupBox1.Controls.Add(AddressResultLbl);
            groupBox1.Controls.Add(EmailResultLbl);
            groupBox1.Controls.Add(GendorResultLbl);
            groupBox1.Controls.Add(NationalNOResultLbl);
            groupBox1.Controls.Add(PersonIDResultLbl);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(PicturePersonPictureBox);
            groupBox1.Controls.Add(CountryLbl);
            groupBox1.Controls.Add(PhoneLbl);
            groupBox1.Controls.Add(DateOfBirthLbl);
            groupBox1.Controls.Add(AddressLbl);
            groupBox1.Controls.Add(EmailLbl);
            groupBox1.Controls.Add(GendorLbl);
            groupBox1.Controls.Add(NationalNoLbl);
            groupBox1.Controls.Add(NameLbl);
            groupBox1.Controls.Add(PersonIDlbl);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(976, 409);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // NameResultLbl
            // 
            NameResultLbl.AutoSize = true;
            NameResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameResultLbl.ForeColor = Color.Red;
            NameResultLbl.Location = new Point(191, 105);
            NameResultLbl.Name = "NameResultLbl";
            NameResultLbl.Size = new Size(0, 25);
            NameResultLbl.TabIndex = 27;
            // 
            // EditPersinInfoBtn
            // 
            EditPersinInfoBtn.AutoSize = true;
            EditPersinInfoBtn.Location = new Point(755, 55);
            EditPersinInfoBtn.Name = "EditPersinInfoBtn";
            EditPersinInfoBtn.Size = new Size(181, 32);
            EditPersinInfoBtn.TabIndex = 26;
            EditPersinInfoBtn.TabStop = true;
            EditPersinInfoBtn.Text = "Edit Person Info";
            EditPersinInfoBtn.LinkClicked += EditPersinInfoBtn_LinkClicked;
            // 
            // CountryResultLbl
            // 
            CountryResultLbl.AutoSize = true;
            CountryResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CountryResultLbl.Location = new Point(615, 322);
            CountryResultLbl.Name = "CountryResultLbl";
            CountryResultLbl.Size = new Size(0, 25);
            CountryResultLbl.TabIndex = 25;
            // 
            // PhoneResultLbl
            // 
            PhoneResultLbl.AutoSize = true;
            PhoneResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneResultLbl.Location = new Point(615, 252);
            PhoneResultLbl.Name = "PhoneResultLbl";
            PhoneResultLbl.Size = new Size(0, 25);
            PhoneResultLbl.TabIndex = 24;
            // 
            // DateOfBirthResultLbl
            // 
            DateOfBirthResultLbl.AutoSize = true;
            DateOfBirthResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateOfBirthResultLbl.Location = new Point(615, 172);
            DateOfBirthResultLbl.Name = "DateOfBirthResultLbl";
            DateOfBirthResultLbl.Size = new Size(0, 25);
            DateOfBirthResultLbl.TabIndex = 23;
            // 
            // AddressResultLbl
            // 
            AddressResultLbl.AutoSize = true;
            AddressResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressResultLbl.Location = new Point(191, 325);
            AddressResultLbl.Name = "AddressResultLbl";
            AddressResultLbl.Size = new Size(0, 25);
            AddressResultLbl.TabIndex = 22;
            // 
            // EmailResultLbl
            // 
            EmailResultLbl.AutoSize = true;
            EmailResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailResultLbl.Location = new Point(191, 266);
            EmailResultLbl.Name = "EmailResultLbl";
            EmailResultLbl.Size = new Size(0, 25);
            EmailResultLbl.TabIndex = 21;
            // 
            // GendorResultLbl
            // 
            GendorResultLbl.AutoSize = true;
            GendorResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GendorResultLbl.Location = new Point(191, 210);
            GendorResultLbl.Name = "GendorResultLbl";
            GendorResultLbl.Size = new Size(0, 25);
            GendorResultLbl.TabIndex = 20;
            // 
            // NationalNOResultLbl
            // 
            NationalNOResultLbl.AutoSize = true;
            NationalNOResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NationalNOResultLbl.Location = new Point(191, 160);
            NationalNOResultLbl.Name = "NationalNOResultLbl";
            NationalNOResultLbl.Size = new Size(0, 25);
            NationalNOResultLbl.TabIndex = 19;
            // 
            // PersonIDResultLbl
            // 
            PersonIDResultLbl.AutoSize = true;
            PersonIDResultLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PersonIDResultLbl.Location = new Point(145, 50);
            PersonIDResultLbl.Name = "PersonIDResultLbl";
            PersonIDResultLbl.Size = new Size(0, 25);
            PersonIDResultLbl.TabIndex = 18;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Country_32;
            pictureBox9.Location = new Point(563, 317);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.TabIndex = 17;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Phone_32;
            pictureBox8.Location = new Point(563, 247);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Calendar_32;
            pictureBox7.Location = new Point(563, 167);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Address_32;
            pictureBox6.Location = new Point(145, 320);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(145, 261);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Man_32;
            pictureBox4.Location = new Point(145, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(145, 155);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_32;
            pictureBox2.Location = new Point(145, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // PicturePersonPictureBox
            // 
            PicturePersonPictureBox.Location = new Point(736, 112);
            PicturePersonPictureBox.Name = "PicturePersonPictureBox";
            PicturePersonPictureBox.Size = new Size(220, 203);
            PicturePersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PicturePersonPictureBox.TabIndex = 9;
            PicturePersonPictureBox.TabStop = false;
            // 
            // CountryLbl
            // 
            CountryLbl.AutoSize = true;
            CountryLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryLbl.Location = new Point(413, 322);
            CountryLbl.Name = "CountryLbl";
            CountryLbl.Size = new Size(96, 25);
            CountryLbl.TabIndex = 8;
            CountryLbl.Text = "Country :";
            // 
            // PhoneLbl
            // 
            PhoneLbl.AutoSize = true;
            PhoneLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneLbl.Location = new Point(413, 247);
            PhoneLbl.Name = "PhoneLbl";
            PhoneLbl.Size = new Size(79, 25);
            PhoneLbl.TabIndex = 7;
            PhoneLbl.Text = "Phone :";
            // 
            // DateOfBirthLbl
            // 
            DateOfBirthLbl.AutoSize = true;
            DateOfBirthLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateOfBirthLbl.Location = new Point(412, 172);
            DateOfBirthLbl.Name = "DateOfBirthLbl";
            DateOfBirthLbl.Size = new Size(138, 25);
            DateOfBirthLbl.TabIndex = 6;
            DateOfBirthLbl.Text = "Date Of Birth :";
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLbl.Location = new Point(11, 325);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(98, 25);
            AddressLbl.TabIndex = 5;
            AddressLbl.Text = "Address  :";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLbl.Location = new Point(11, 270);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(69, 25);
            EmailLbl.TabIndex = 4;
            EmailLbl.Text = "Email :";
            // 
            // GendorLbl
            // 
            GendorLbl.AutoSize = true;
            GendorLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GendorLbl.Location = new Point(6, 215);
            GendorLbl.Name = "GendorLbl";
            GendorLbl.Size = new Size(90, 25);
            GendorLbl.TabIndex = 3;
            GendorLbl.Text = "Gendor :";
            // 
            // NationalNoLbl
            // 
            NationalNoLbl.AutoSize = true;
            NationalNoLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NationalNoLbl.Location = new Point(6, 160);
            NationalNoLbl.Name = "NationalNoLbl";
            NationalNoLbl.Size = new Size(130, 25);
            NationalNoLbl.TabIndex = 2;
            NationalNoLbl.Text = "National No :";
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLbl.Location = new Point(6, 105);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(74, 25);
            NameLbl.TabIndex = 1;
            NameLbl.Text = "Name :";
            // 
            // PersonIDlbl
            // 
            PersonIDlbl.AutoSize = true;
            PersonIDlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonIDlbl.Location = new Point(6, 50);
            PersonIDlbl.Name = "PersonIDlbl";
            PersonIDlbl.Size = new Size(108, 25);
            PersonIDlbl.TabIndex = 0;
            PersonIDlbl.Text = "Person ID :";
            // 
            // CloseBtn
            // 
            CloseBtn.Image = Properties.Resources.Close_322;
            CloseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CloseBtn.Location = new Point(868, 529);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(118, 36);
            CloseBtn.TabIndex = 2;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // PersonDetailsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 577);
            Controls.Add(CloseBtn);
            Controls.Add(groupBox1);
            Controls.Add(PersonDetailsLbl);
            Name = "PersonDetailsFrm";
            Text = "PersonDetailsFrm";
            Load += PersonDetailsFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicturePersonPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonDetailsLbl;
        private GroupBox groupBox1;
        private Label AddressLbl;
        private Label EmailLbl;
        private Label GendorLbl;
        private Label NationalNoLbl;
        private Label NameLbl;
        private Label PersonIDlbl;
        private PictureBox PicturePersonPictureBox;
        private Label CountryLbl;
        private Label PhoneLbl;
        private Label DateOfBirthLbl;
        private PictureBox pictureBox2;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label CountryResultLbl;
        private Label PhoneResultLbl;
        private Label DateOfBirthResultLbl;
        private Label AddressResultLbl;
        private Label EmailResultLbl;
        private Label GendorResultLbl;
        private Label NationalNOResultLbl;
        private Label PersonIDResultLbl;
        private LinkLabel EditPersinInfoBtn;
        private Button CloseBtn;
        private Label NameResultLbl;
    }
}