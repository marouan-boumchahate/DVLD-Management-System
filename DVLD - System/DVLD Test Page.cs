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
    public partial class Testing_Form : Form
    {
        public Testing_Form()
        {
            InitializeComponent();
        }

        private void Testing_Form_Load(object sender, EventArgs e)
        {
            //DLA_LocalApplication.LoadDrivingLicense(33);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string forWhat = "Email";
            string Code = "123456";

            VerifyCode_Form verifyCode_Form = new VerifyCode_Form(forWhat, Code);
            verifyCode_Form.ShowDialog();

            textBox1.Text = verifyCode_Form.Verified ? "Passed" : "Failed";
        }
    }
}
