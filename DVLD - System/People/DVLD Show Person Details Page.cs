using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System
{
    public partial class ShowPersonDetails_Form : Form
    {
        private int PersonID { get; set; }

        public ShowPersonDetails_Form(int personID)
        {
            InitializeComponent();
            this.PersonID = personID;
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowDetails_Form_Load(object sender, EventArgs e)
        {
            PI_PersonCardDetails.LoadPersonInfo(PersonID);
        }
        private void LL_EditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePerson_Form updatePerson_Form = new UpdatePerson_Form(PersonID);
            updatePerson_Form.ShowDialog();

            ShowDetails_Form_Load(sender, e);    
        }
    }
}
