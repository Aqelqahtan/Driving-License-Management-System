using BusinessLayer;
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

namespace PresentationLayer
{
    public partial class UpdateApplicationType : Form
    {

        private ClsApplicationTypes ApplicationTypes;
        public UpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            ApplicationTypes = ClsApplicationTypes.Find(ApplicationTypeID);
            if (ApplicationTypes != null)
            {
                _LoadDataApplicationTypes();
            }else
            { MessageBox.Show("Error", "There is no ApplicationTypeID number :["+ ApplicationTypeID+ " ]with that number  ");
               
            }

        }

        private void _LoadDataApplicationTypes()
        {
            ApplicationTypeIDResultLbl.Text = ApplicationTypes.ApplicationTypeID.ToString();
            TitleTextBox.Text = ApplicationTypes.ApplicationTypeTitle;
            FeesTextBox.Text = ApplicationTypes.ApplicationFees.ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ApplicationTypes.ApplicationFees = decimal.Parse(FeesTextBox.Text); 
            if (ApplicationTypes.Save())
            {
                FeesTextBox.Enabled = false;

                MessageBox.Show("Saved Successfully"); 
                SaveBtn.Enabled = false;

            }
            else
            {
                MessageBox.Show("Error", "Falied Operation !");
            }

        }

        private void UpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadDataApplicationTypes();
        }
    }
}
