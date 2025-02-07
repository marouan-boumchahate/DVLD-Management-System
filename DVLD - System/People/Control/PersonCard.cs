using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DVLD___System.Global;
using System.Diagnostics;

namespace DVLD___System
{
    public partial class PersonCard : UserControl
    {
        Business_Layer.Person person = new Business_Layer.Person();

        public PersonCard()
        {
            InitializeComponent();

            CB_Country.SelectedItem = "Morocco";
        }

        public int GetPersonID()
        {
            return person.PersonID;
        }

        Dictionary<string, int> Countries = new Dictionary<string, int>();
        private void SetCountryComBox()
        {
            if (Countries.Count > 0) return;

            Countries = Business_Layer.Country.FindAllCountries();
            CB_Country.DataSource = new BindingSource(Countries.Keys, null);
        }
        private void setImage()
        {
            if (ImageProcess.isImagePathExist(person.ImagePath))
            {
                PB_ProfilePicture.ImageLocation = person.ImagePath;
                LL_RemoveImage.Visible = true;
            }

            PB_ProfilePicture.Image = (person.Gender == 'M') ? Properties.Resources.Male_Profile_1 : Properties.Resources.Female_Profile_1;
        }
        public void initialPersonCard()
        {
            L_ID.Text = person.PersonID == -1 ? "N/A" : person.PersonID.ToString();

            setImage();

            TB_FirstName.Text = person.FirstName;
            TB_SecondName.Text = person.SecondName;
            TB_ThirdName.Text = person.ThirdName;
            TB_LastName.Text = person.LastName;
            TB_Email.Text = person.Email;
            TB_Phone.Text = person.Phone;

            SetCountryComBox();
            if (person.CountryInformation.CountryID != -1)
                CB_Country.SelectedItem = person.CountryInformation.CountryName;
            else CB_Country.SelectedItem = "Morocco";

            TB_NationalNo.Text = person.NationalNo;
            
            if(person.Gender == 'M') RB_Male.Checked = true;
            else RB_Female.Checked = true;

            RB_Address.Text = person.Address;

            DT_DateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            DT_DateOfBirth.MinDate = DateTime.Today.AddYears(-150);

            DT_DateOfBirth.Value = person.DateOfBirth == DateTime.MinValue ? DT_DateOfBirth.MaxDate : person.DateOfBirth;

        }
        public void LoadPerson(int ID)
        {
            person = Business_Layer.Person.FindPersonByID(ID);

            if(person == null)
            {
                MessageBox.Show("The Person Card couldn't be Found", "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            initialPersonCard();
        }
        private void loadDataToPerson()
        {
            person.FirstName = TB_FirstName.Text;
            person.SecondName = TB_SecondName.Text;
            person.ThirdName = TB_ThirdName.Text;
            person.LastName = TB_LastName.Text;
            person.NationalNo = TB_NationalNo.Text;
            person.Gender = RB_Female.Checked ? 'F' : 'M';
            person.Address = RB_Address.Text;
            person.DateOfBirth = DT_DateOfBirth.Value;
            person.Email = TB_Email.Text;
            person.Phone = TB_Phone.Text;
            person.CountryInformation.CountryID = Countries[CB_Country.SelectedItem.ToString()];
            person.ImagePath = PB_ProfilePicture.ImageLocation;
        }
        
        private bool VerifyEmail()
        {
            string Code = Generate.GenerateCode(6);

            if(!Business_Layer.Email.SendEmail(Settings.SystemEmail, Settings.SystemEmailPass, TB_Email.Text, "Verify Email", $"Your verification code is {Code}"))
                return false;

            VerifyCode_Form verifyCode_Form = new VerifyCode_Form("Email", Code);
            verifyCode_Form.ShowDialog();

            return verifyCode_Form.Verified;
        }
        private bool ValidateChild(object target)
        {
            return string.IsNullOrEmpty(EP_Error.GetError((TextBox)target));
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if(person.Mode == Business_Layer.Person.enMode.Add && !ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!!", "Validity Issues", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(person.Mode == Business_Layer.Person.enMode.Edit && !ValidateChild(TB_Phone) && !ValidateChild(TB_Email) && !string.IsNullOrEmpty(EP_Error.GetError(RB_Address)))
            {
                MessageBox.Show("Some fields are not valid!!", "Validity Issues", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (person.Email != TB_Email.Text && !VerifyEmail()) return;

            if (!SaveProfileImage()) return;

            string PosBody = string.Empty, PosCaption = string.Empty;
            string NegBody = string.Empty, NegCaption = string.Empty;

            loadDataToPerson();

            if (person.Mode == Business_Layer.Person.enMode.Add)
            {
                PosCaption = "Success: New Person Added";
                PosBody = "The new person has been successfully added to the system";

                NegCaption = "Error: Unable to Add New Person";
                NegBody = "We encountered an issue and couldn't add the new person to the system. Please check the provided information and try again.";
            }
            else
            {
                PosCaption = "Success: Person's Information Updated";
                PosBody = "The person's information has been successfully updated.";

                NegCaption = "Error: Unable to Update Person's Information";
                NegBody = "We were unable to update the person's information. Please verify the details and try again.";
            }


            if (person.Save())
                MessageBox.Show(PosBody, PosCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(NegBody, NegCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);


            initialPersonCard();
        }


        private void RB_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PB_ProfilePicture.ImageLocation)) return;

            if (RB_Male.Checked) PB_ProfilePicture.Image = Properties.Resources.Male_Profile_1;
            else PB_ProfilePicture.Image = Properties.Resources.Female_Profile_1;
        }

        private bool SaveProfileImage()
        {
            if (person.ImagePath == PB_ProfilePicture.ImageLocation) return true;

            // Delete Image
            if (!string.IsNullOrEmpty(person.ImagePath))
                ImageProcess.DeleteImage(person.ImagePath);
            
            if(string.IsNullOrEmpty(PB_ProfilePicture.ImageLocation)) return true;

            string sourceFile = PB_ProfilePicture.ImageLocation;

            // Set The new Image
            if (!ImageProcess.CopyImageToSystemFolder(ref sourceFile))
            {
                MessageBox.Show("There was an issue while setting the image!", "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            PB_ProfilePicture.ImageLocation = sourceFile;
            return true;
        }
        private void LL_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OFD_ChooseImage.Title = "Choose Image";
            OFD_ChooseImage.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            OFD_ChooseImage.InitialDirectory = @"C:\";

            if(OFD_ChooseImage.ShowDialog() == DialogResult.OK)
            {
                PB_ProfilePicture.ImageLocation = OFD_ChooseImage.FileName;
                LL_RemoveImage.Visible = true;
            }
        }
        private void LL_RemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PB_ProfilePicture.ImageLocation = "";
            RB_Male_CheckedChanged(sender, e);
            LL_RemoveImage.Visible = false;
        }

        private void TB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (string.IsNullOrEmpty(tb.Text))
            {
                EP_Error.SetError(tb, "Must Be field");
                e.Cancel = true;
            }
            else EP_Error.SetError(tb, null);
        }
        private void TB_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Email.Text))
            {
                if (!Global.Validate.EmailFormat(TB_Email.Text))
                {
                    EP_Error.SetError(TB_Email, "Email Format: example@example.com");
                    e.Cancel= true;
                }
                else EP_Error.SetError(TB_Email, null);
            }
        }
        private void RB_Address_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RichTextBox tb = (RichTextBox)sender;

            if (tb.Text == "")
            {
                EP_Error.SetError(tb, "Must Be field");
                e.Cancel = true;
            }
            else EP_Error.SetError(tb, "");
        }
        private void TB_NationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TB_Validating(sender, e);
            if (!string.IsNullOrEmpty(TB_NationalNo.Text) && Business_Layer.Person.isPersonExist(TB_NationalNo.Text))
            {
                EP_Error.SetError(TB_NationalNo, "This NationalNo already exist in the system");
                e.Cancel = true;
            }
            else EP_Error.SetError(TB_NationalNo, null);
        }
    }
}
