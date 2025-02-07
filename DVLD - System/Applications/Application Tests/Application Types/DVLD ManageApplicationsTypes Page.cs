using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Applications
{
    public partial class ManageApplicationsTypes_Form : Form
    {
        public ManageApplicationsTypes_Form()
        {
            InitializeComponent();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadApplicationTypes()
        {
            DataTable AppTypes = Business_Layer.ApplicationType.FindAllApplicationTypes();

            DGV_ApplicationTypesData.DataSource = AppTypes;

            DGV_ApplicationTypesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ManageApplicationsTypes_Form_Load(object sender, EventArgs e)
        {
            LoadApplicationTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(DGV_ApplicationTypesData.CurrentRow.Cells["ApplicationTypeID"].Value);

            UpdateApplicationType_Form updateApplicationType_Form = new UpdateApplicationType_Form(AppID);
            updateApplicationType_Form.ShowDialog();

            LoadApplicationTypes();
        }

        private void CMS_ManageAppTypesShortcuts_Opening(object sender, CancelEventArgs e)
        {
            if(DGV_ApplicationTypesData.CurrentRow == null || DGV_ApplicationTypesData.CurrentRow.IsNewRow)
                e.Cancel = true;
        }
    }
}
