using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace EmployeeManagementSystem
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Export feature disabled. Excel not installed on this machine.");

            //    string TemplatePath = @"C:\Users\John Eubert Manalo\Downloads\Employee_Details_Template.xlsx";
            //    string SavePath = @"C:\Users\John Eubert Manalo\Downloads\Employee_Details_Template.xlsx";

            //    ExportCellFromDgv.ExportFromTemplate(TemplatePath,
            //SavePath,
            //"B1", dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value,
            //"H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value,
            //"B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value,
            //"H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value,
            //"A32", LoginPage.fullname,
            //"A33", DateTime.Now.ToString("yyyy-MM-dd")
            //);

            //}
            //}
        }
    }
}

