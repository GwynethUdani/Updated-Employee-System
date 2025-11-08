namespace EmployeeManagementSystem
{
    partial class frmSettings
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
            this.TabPage = new System.Windows.Forms.TabControl();
            this.tpageUserRegistration = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConPas = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tpageSectionRegistration = new System.Windows.Forms.TabPage();
            this.TabPage.SuspendLayout();
            this.tpageUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.tpageUserRegistration);
            this.TabPage.Controls.Add(this.tpageSectionRegistration);
            this.TabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPage.Location = new System.Drawing.Point(0, 0);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(1162, 499);
            this.TabPage.TabIndex = 0;
            // 
            // tpageUserRegistration
            // 
            this.tpageUserRegistration.Controls.Add(this.dgvUsers);
            this.tpageUserRegistration.Controls.Add(this.panel1);
            this.tpageUserRegistration.Location = new System.Drawing.Point(4, 22);
            this.tpageUserRegistration.Name = "tpageUserRegistration";
            this.tpageUserRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tpageUserRegistration.Size = new System.Drawing.Size(1154, 473);
            this.tpageUserRegistration.TabIndex = 0;
            this.tpageUserRegistration.Text = "User Registration";
            this.tpageUserRegistration.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(203, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(948, 467);
            this.dgvUsers.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExecute);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.lblMatch);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.lblConPas);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.cbSection);
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 467);
            this.panel1.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(107, 408);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 15;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(14, 390);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 14;
            this.lblNumber.Text = "Number";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Location = new System.Drawing.Point(14, 364);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(37, 13);
            this.lblMatch.TabIndex = 13;
            this.lblMatch.Text = "Match";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(17, 311);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(121, 20);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // lblConPas
            // 
            this.lblConPas.AutoSize = true;
            this.lblConPas.Location = new System.Drawing.Point(18, 295);
            this.lblConPas.Name = "lblConPas";
            this.lblConPas.Size = new System.Drawing.Size(114, 13);
            this.lblConPas.TabIndex = 11;
            this.lblConPas.Text = "Password Confirmation";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(17, 208);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 20);
            this.txtAge.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 244);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(17, 192);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // cbSection
            // 
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(17, 158);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(121, 21);
            this.cbSection.TabIndex = 6;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(14, 142);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 4;
            this.lblSection.Text = "Section";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(17, 108);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(121, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(17, 59);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(14, 92);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(14, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // tpageSectionRegistration
            // 
            this.tpageSectionRegistration.Location = new System.Drawing.Point(4, 22);
            this.tpageSectionRegistration.Name = "tpageSectionRegistration";
            this.tpageSectionRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tpageSectionRegistration.Size = new System.Drawing.Size(1154, 473);
            this.tpageSectionRegistration.TabIndex = 1;
            this.tpageSectionRegistration.Text = "Section Registration";
            this.tpageSectionRegistration.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 499);
            this.Controls.Add(this.TabPage);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.TabPage.ResumeLayout(false);
            this.tpageUserRegistration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPage;
        private System.Windows.Forms.TabPage tpageUserRegistration;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tpageSectionRegistration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConPas;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMatch;
    }
}