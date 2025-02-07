using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.People
{
    public partial class PersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonFound;
        protected virtual void PersonFound(int PersonID)
        {
            Action<int> handler = OnPersonFound;

            if (handler != null)
            {
                handler(PersonID);
            }
        }
        public PersonCardWithFilter()
        {
            InitializeComponent();

            CB_FindPersonBy.SelectedIndex = 0;
        }

        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FindPersonBy.SelectedItem.ToString() == "PersonID")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;

                e.Handled = true;
            }
        }

        private void PB_SearchForEmployee_Click(object sender, EventArgs e)
        {
            if (TB_TextFilter.Text == "")
            {
                EP_AddUserErrors.SetError(TB_TextFilter, "Must Be filled first!!");
                TB_TextFilter.Focus();

                return;
            }
            else EP_AddUserErrors.SetError(TB_TextFilter, "");

            Business_Layer.Person per;

            switch (CB_FindPersonBy.SelectedItem.ToString())
            {
                case "PersonID":
                    per = Business_Layer.Person.FindPersonByID(Convert.ToInt32(TB_TextFilter.Text));
                    break;
                default:
                    per = Business_Layer.Person.FindPersonByNationalNo(TB_TextFilter.Text);
                    break;
            }

            if (per == null)
            {
                MessageBox.Show($"There is no user by this {CB_FindPersonBy.SelectedItem.ToString()}: {TB_TextFilter.Text}", "Incorrect User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PI_PersonData.LoadPersonInfo(per.PersonID);
            if(OnPersonFound != null)
                PersonFound(per.PersonID);
        }

        private void PB_AddNewPerson_Click(object sender, EventArgs e)
        {
            AddPerson_Form addPerson_Form = new AddPerson_Form();
            addPerson_Form.PersonBack += HoldPerson;
            addPerson_Form.ShowDialog();

            int PersonID = PI_PersonData.GetPersonID();

            if (PersonID != -1)
            {
                if (OnPersonFound != null)
                    PersonFound(PersonID);
            }
        }

        private void HoldPerson(object sender, int PersonID)
        {
            if (PersonID == -1) return;

            CB_FindPersonBy.SelectedIndex = 0;
            TB_TextFilter.Text = PersonID.ToString();

            PB_SearchForEmployee_Click(sender, new EventArgs());
        }

        public bool FilterState()
        {
            return P_Filter.Enabled;
        }
        public void DisableFilter()
        {
            P_Filter.Enabled = false;
        }
        public bool isEditLinkEnabled()
        {
            return PI_PersonData.isEditLinkEnabled();
        }

        public int GetPersonID()
        {
            return PI_PersonData.GetPersonID();
        }

        public void LoadPersonInfo(int PersonID)
        {
            CB_FindPersonBy.SelectedIndex = 0;
            TB_TextFilter.Text = PersonID.ToString();

            PB_SearchForEmployee_Click(new object(), new EventArgs());
        }

        private void TB_TextFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                PB_SearchForEmployee_Click(new object(), new EventArgs());
        }
    }
}
