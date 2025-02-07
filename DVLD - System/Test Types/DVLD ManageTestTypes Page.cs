using DVLD___System.Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Test_Types
{
    public partial class ManageTestTypes_Form : Form
    {
        public ManageTestTypes_Form()
        {
            InitializeComponent();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadTestTypes()
        {
            DataTable TestTypes = Business_Layer.TestType.FindAllTestTypes();

            DGV_TestTypesData.DataSource = TestTypes;

            DGV_TestTypesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ManageTestTypes_Form_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestID = Convert.ToInt32(DGV_TestTypesData.CurrentRow.Cells["TestTypeID"].Value);

            UpdateTestType_Form updateTestType_Form = new UpdateTestType_Form(TestID);
            updateTestType_Form.ShowDialog();

            LoadTestTypes();
        }

        private void CMS_ManageTestTypesShortcuts_Opening(object sender, CancelEventArgs e)
        {
            if(DGV_TestTypesData.CurrentRow == null || DGV_TestTypesData.CurrentRow.IsNewRow)
                e.Cancel = true;
        }
    }
}
