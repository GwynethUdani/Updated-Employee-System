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
	public partial class frmAddEmployee : Form
	{
		private static string Email;
        internal string TransactionNo;
        private object txtSection;

		public frmAddEmployee()
		{
			InitializeComponent();
		}

		public frmAddEmployee(string text)
		{
			Text = text;
		}

		public static string EmailAddress { get; private set; }
        public static string RequestorEmail { get; private set; }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            // ✅ Universal validation (works for both Insert and Update)
            if (string.IsNullOrWhiteSpace(txtEmpID.Text) ||
                string.IsNullOrWhiteSpace(txtRequestorName.Text) ||
                string.IsNullOrWhiteSpace(txtLocalNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) ||
                string.IsNullOrWhiteSpace(cmbSection.Text))
            {
                MessageBox.Show("Please fill up all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validate email domain (case-insensitive)
            if (!txtEmailAddress.Text.EndsWith("@firstasia.edu.ph", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validate local number (4 digits only)
            if (txtLocalNumber.Text.Length != 4 || !txtLocalNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 4-digit local number.", "Invalid Local Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Now check if record already exists
            string EMS_data = "SELECT * FROM [tbl_EmployeeData] WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'";
            bool exists = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (exists)
            {
                DialogResult result = MessageBox.Show(
                    "This account '" + txtRequestorName.Text + "' already exists. Do you want to update?",
                    "Already Exists",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE [tbl_EmployeeData] SET " +
                                         "[RequestorName] = '" + txtRequestorName.Text + "', " +
                                         "[RequestorEmail] = '" + txtEmailAddress.Text + "', " +
                                         "[Section] = '" + cmbSection.Text + "', " +
                                         "[LocalNumber] = '" + txtLocalNumber.Text + "' " +
                                         "WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'";

                    CRUD.CRUD.CUD(updateQuery);
                    MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Close();
                    return;
                }
            }
            else
            {
                string insertQuery = "INSERT INTO [tbl_EmployeeData] " +
                                     "([EmployeeNumber],[RequestorName],[RequestorEmail],[Section],[LocalNumber]) " +
                                     "VALUES ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";

                CRUD.CRUD.CUD(insertQuery);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // ✅ Refresh master data after any action
            Form masterForm = Application.OpenForms["frmMasterData"];
            if (masterForm != null)
            {
                ((frmMasterData)masterForm).RefreshData();
            }

            this.Close();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
		{
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.Email;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            txtEmpID.Text = frmMasterData.EmployeeID;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if EmployeeNumber is filled in
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please enter or select an Employee Number to delete.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Optional: Check if record actually exists before deleting
                bool exists = CRUD.CRUD.RETRIEVESINGLE(
                    "SELECT * FROM [tbl_EmployeeData] WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'");

                if (!exists)
                {
                    MessageBox.Show("No record found with that Employee Number.",
                                    "Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                // Delete record from table
                string deleteQuery = "DELETE FROM [tbl_EmployeeData] WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'";
                CRUD.CRUD.CUD(deleteQuery);

                MessageBox.Show("Record deleted successfully!",
                                "Deleted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Refresh frmMasterData after delete
                Form masterForm = Application.OpenForms["frmMasterData"];
                if (masterForm != null)
                {
                    ((frmMasterData)masterForm).RefreshData();
                }

                // Clear all fields after delete
                txtEmpID.Clear();
                txtRequestorName.Clear();
                txtEmailAddress.Clear();
                txtLocalNumber.Clear();
                cmbSection.SelectedIndex = -1;

                // Optional: refresh DataGridView if you have one
                // CRUD.CRUD.RETRIEVEDTG(yourDataGridView, "SELECT * FROM [tbl_EmployeeData]");
            }
        }
    }
}
