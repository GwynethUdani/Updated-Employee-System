using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from tbl_EmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }
        public static string selectedTransaction;
        public static string LocalNumber;
        public static string Email;
        public static string EmployeeID;
        public static string Course;
        public static string lblIdentifier;
        public static string Section;
        public static string RequestorName;

        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString(); 
            frmMasterData.selectedTransaction = lblTransactionNo.Text;
            frmMasterData.RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            frmMasterData.Email = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString(); 
            frmMasterData.Section = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString(); 
            frmMasterData.LocalNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString(); 
            frmMasterData.EmployeeID = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();

        }

        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure a valid row is clicked
            {
                DataGridViewRow row = dtgMasterData.Rows[e.RowIndex];
                frmMasterData.selectedTransaction = row.Cells["ID"].Value.ToString();
                frmMasterData.EmployeeID = row.Cells["EmployeeNumber"].Value.ToString();
                frmMasterData.RequestorName = row.Cells["RequestorName"].Value.ToString();
                frmMasterData.Email = row.Cells["RequestorEmail"].Value.ToString();
                frmMasterData.Section = row.Cells["Section"].Value.ToString();
                frmMasterData.LocalNumber = row.Cells["LocalNumber"].Value.ToString();
            }
        }
        private static string requestorName;

        public static string GetRequestorName()
        {
            return requestorName;
        }

        internal static void SetRequestorName(string value)
        {
            requestorName = value;
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (lblTransactionNo.Text == "<TRANSACTION NUMBER>")

                {
                MessageBox.Show("Please select a corresponding data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }


            frmAddEmployee OpenfrmAddEmployee = new frmAddEmployee();
            OpenfrmAddEmployee.TransactionNo = lblTransactionNo.Text;  // <-- add this line
            OpenfrmAddEmployee.ShowDialog();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RefreshData()
        {
            string select_tblrequestorlist = "SELECT * FROM tbl_EmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }


    }
}
