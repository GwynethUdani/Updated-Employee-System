namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.txtLocalNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtRequestorName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.pnlAddEmployee.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlAddEmployee.Controls.Add(this.lblAddEmployee);
            this.pnlAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(800, 60);
            this.pnlAddEmployee.TabIndex = 0;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 19);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(148, 24);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GroupBox.Controls.Add(this.btnDelete);
            this.GroupBox.Controls.Add(this.btnInsertUpdate);
            this.GroupBox.Controls.Add(this.cmbSection);
            this.GroupBox.Controls.Add(this.txtLocalNumber);
            this.GroupBox.Controls.Add(this.txtEmailAddress);
            this.GroupBox.Controls.Add(this.txtRequestorName);
            this.GroupBox.Controls.Add(this.btnSearch);
            this.GroupBox.Controls.Add(this.txtEmpID);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.lblEmployeeNumber);
            this.GroupBox.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(0, 66);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(800, 202);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Employee Details Manual Insert and Update";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(444, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnInsertUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertUpdate.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertUpdate.Location = new System.Drawing.Point(152, 160);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(145, 23);
            this.btnInsertUpdate.TabIndex = 11;
            this.btnInsertUpdate.Text = "INSERT / UPDATE";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.BackColor = System.Drawing.Color.SteelBlue;
            this.cmbSection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSection.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(152, 131);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(262, 23);
            this.cmbSection.TabIndex = 10;
            // 
            // txtLocalNumber
            // 
            this.txtLocalNumber.AcceptsReturn = true;
            this.txtLocalNumber.BackColor = System.Drawing.Color.SteelBlue;
            this.txtLocalNumber.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalNumber.Location = new System.Drawing.Point(152, 105);
            this.txtLocalNumber.Name = "txtLocalNumber";
            this.txtLocalNumber.Size = new System.Drawing.Size(262, 21);
            this.txtLocalNumber.TabIndex = 9;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.AcceptsReturn = true;
            this.txtEmailAddress.BackColor = System.Drawing.Color.SteelBlue;
            this.txtEmailAddress.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(152, 79);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(384, 21);
            this.txtEmailAddress.TabIndex = 8;
            // 
            // txtRequestorName
            // 
            this.txtRequestorName.AcceptsReturn = true;
            this.txtRequestorName.BackColor = System.Drawing.Color.SteelBlue;
            this.txtRequestorName.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestorName.Location = new System.Drawing.Point(152, 53);
            this.txtRequestorName.Name = "txtRequestorName";
            this.txtRequestorName.Size = new System.Drawing.Size(384, 21);
            this.txtRequestorName.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(339, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.Color.SteelBlue;
            this.txtEmpID.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(152, 27);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(181, 21);
            this.txtEmpID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(86, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Section :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Local Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requestor Name :";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(12, 29);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(141, 16);
            this.lblEmployeeNumber.TabIndex = 0;
            this.lblEmployeeNumber.Text = "Employee Number :";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.pnlAddEmployee);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.TextBox txtLocalNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtRequestorName;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}