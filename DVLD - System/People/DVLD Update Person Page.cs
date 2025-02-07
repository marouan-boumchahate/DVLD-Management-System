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
    public partial class UpdatePerson_Form : Form
    {
        private int PersonID { get; set; }
        public UpdatePerson_Form(int personID)
        {
            InitializeComponent();
            PersonID = personID;
        }


        private void UpdatePerson_Form_Load(object sender, EventArgs e)
        {
            PC_UpdatePerson.LoadPerson(PersonID);
        }
    }
}
