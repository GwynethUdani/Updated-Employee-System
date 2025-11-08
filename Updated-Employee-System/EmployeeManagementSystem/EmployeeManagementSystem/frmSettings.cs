using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;


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

            string TemplatePath = @"C:\Users\GwynethCrystalAnneUd\Downloads\Employee_Details_Template";
            string SavePath = @"C:\Users\GwynethCrystalAnneUd\Downloads\Employee_Details_Template";

            ExportCellFromDgv.ExportFromTemplate(TemplatePath,
        SavePath,
        "B1", dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value,
        "H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value,
        "B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value,
        "H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value,
        "A32", LoginForm.fullname,
        "A33", DateTime.Now.ToString("yyyy-MM-dd")
        );

        }
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }

        private void Match()
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "✓ Match";
                lblMatch.ForeColor = Color.Green;
            }
            else
            {
                lblMatch.Text = "❌ Match";
                lblMatch.ForeColor = Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                lblMatch.Text = "✓ Number";
                lblMatch.ForeColor = Color.Green;
            }
            else
            {
                lblMatch.Text = "❌ Number";
                lblMatch.ForeColor = Color.Red;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void lblMatch_Click(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to register?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "INSERT INTO [Users] ([Username], [Password], [Section], [Age], [FullName]) " +
                    "VALUES ('" + txtUserName.Text + "', '" + txtPassword.Text + "', '" +
                    cmbSection.Text + "', '" + txtAge.Text + "', '" + txtFullName.Text + "')";


                CRUD.CRUD.CUD(query);

                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [Users]");
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
           Exportdgv.ExportToExcel(dgvUsers, "ExportedData..." + DateTime.Now.ToString("MM-dd-yyyy"));
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from Users ORDER BY ID DESC";
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, select_tblrequestorlist);

            CRUD.CRUD.RETRIEVECBO(cmbSection, "SELECT [ID], [Section] FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [Users]");
            cmbSection.SelectedIndex = -1;

            lblMatch.Text = "MATCH";
            lblMatch.ForeColor = Color.Black;
            lblNumber.Text = "NUMBER";
            lblNumber.ForeColor = Color.Black;


        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string TemplatePath = @"C:\Users\GwynethCrystalAnneUd\Documents\EmployeeDetailsTemplate.xlsx";
            string SavePath = @"C:\Users\GwynethCrystalAnneUd\Documents\EmployeeDetailsTemplate.xlsx";

            ExportCellFromDgv.ExportFromTemplate(TemplatePath,
                SavePath,
                "B1", dgvUsers.Rows[e.RowIndex].Cells["FullName"].Value,
                "H1", dgvUsers.Rows[e.RowIndex].Cells["Section"].Value,
                "B2", dgvUsers.Rows[e.RowIndex].Cells["Username"].Value,
                "H2", dgvUsers.Rows[e.RowIndex].Cells["Age"].Value,
                "A32", LoginForm.fullname,
                "A33", DateTime.Now.ToString("yyyy-MM-dd")
            );
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

