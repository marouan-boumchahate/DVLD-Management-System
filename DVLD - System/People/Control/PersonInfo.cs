using DVLD___System.Global;
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
    public partial class PersonInfo : UserControl
    {
        public PersonInfo()
        {
            InitializeComponent();
        }

        public int GetPersonID()
        {
            if(int.TryParse(L_ID.Text, out _))
                return Convert.ToInt32(L_ID.Text);

            return -1;
        }
        private void setImage(ref Business_Layer.Person person)
        {
            if (ImageProcess.isImagePathExist(person.ImagePath)) PB_ProfilePicture.ImageLocation = person.ImagePath;

            PB_ProfilePicture.Image = (person.Gender == 'M') ? Properties.Resources.Male_Profile_1 : Properties.Resources.Female_Profile_1;
        }
        public void LoadPersonInfo(int PersonID)
        {
            Business_Layer.Person person = Business_Layer.Person.FindPersonByID(PersonID);

            setImage(ref person);

            L_ID.Text = person.PersonID.ToString();
            L_Name.Text = person.FirstName + ' ' + person.SecondName + ' ' + person.ThirdName + ' ' + person.LastName;
            L_Gender.Text = person.Gender.ToString();
            L_Email.Text = person.Email;
            L_Phone.Text = person.Phone;
            L_NationalNo.Text = person.NationalNo;
            L_DateOfBirth.Text = person.DateOfBirth.ToString("dd MMMM yyyy");
            L_Country.Text = person.CountryInformation.CountryName;
            L_Address.Text = person.Address;
            

            LL_EditPersonInfo.Enabled = true;
        }

        private void LL_EditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdatePerson_Form updatePerson_Form = new UpdatePerson_Form(Convert.ToInt32(L_ID.Text));
            updatePerson_Form.ShowDialog();

            LoadPersonInfo(Convert.ToInt32(L_ID.Text));
        }

        public bool isEditLinkEnabled()
        {
            return LL_EditPersonInfo.Enabled;
        }
    }
}
