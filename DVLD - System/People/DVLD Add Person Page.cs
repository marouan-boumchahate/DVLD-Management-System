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
    public partial class AddPerson_Form : Form
    {
        public delegate void SendPersonDataBack(object sender, int personID);
        public event SendPersonDataBack PersonBack;

        public AddPerson_Form()
        {
            InitializeComponent();
        }

        private void AddPerson_Form_Load(object sender, EventArgs e)
        {
            personCard_AddPerson.initialPersonCard();
        }

        private void AddPerson_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonBack?.Invoke(this, personCard_AddPerson.GetPersonID());
        }
    }
}
