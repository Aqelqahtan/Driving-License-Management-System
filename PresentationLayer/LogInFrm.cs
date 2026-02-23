using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer; 

namespace PresentationLayer
{
    public partial class LogInFrm : Form
    {

        public LogInFrm()
        {
            InitializeComponent();

        }
        private void LogInFrm_Load(object sender, EventArgs e)
        {
          
            
          
            string UserName = Properties.Settings.Default.UserName;
            bool RememmberMe = Properties.Settings.Default.RememberMe;

            if (RememmberMe)
            {
                UserNameTextBox.Text = UserName;
                RememberMeCheckBox.Checked = true;
            }
            else
            {
                RememberMeCheckBox.Checked = false; 
            }
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (ClsUsers.IsLogInCorrect(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                ClsUsers User = ClsUsers.Find(UserNameTextBox.Text);
                if (User != null)
                {
                    ClsGlobal.CurrentUser = User;


                    if (RememberMeCheckBox.Checked)
                    {
                        Properties.Settings.Default.UserName = UserNameTextBox.Text;
                        Properties.Settings.Default.RememberMe = true;
                     
                    }
                    else
                    {
                        Properties.Settings.Default.UserName = "";
                        Properties.Settings.Default.RememberMe = false;
                      
                    }
                    Properties.Settings.Default.Save();

                    this.Hide();
                    MainFrm frm = new MainFrm();
                    frm.ShowDialog();
                    this.Close();
                
                } else
                {
                    MessageBox.Show("User data not found despite correct login!", "Error");
                }


            }
            else
            {
                MessageBox.Show("Invalid UserName/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
