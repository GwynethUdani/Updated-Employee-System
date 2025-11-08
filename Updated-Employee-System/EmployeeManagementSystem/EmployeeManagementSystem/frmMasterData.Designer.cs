namespace EmployeeManagementSystem
{
    partial class frmMasterData
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
            this.pnlChildTitle = new System.Windows.Forms.Panel();
            this.lblMasterData = new System.Windows.Forms.Label();
            this.dtgMasterData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.btnEditData = new System.Windows.Forms.Button();
            this.pnlChildTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChildTitle
            // 
            this.pnlChildTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlChildTitle.Controls.Add(this.lblMasterData);
            this.pnlChildTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlChildTitle.Name = "pnlChildTitle";
            this.pnlChildTitle.Size = new System.Drawing.Size(748, 57);
            this.pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            this.lblMasterData.AutoSize = true;
            this.lblMasterData.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterData.ForeColor = System.Drawing.Color.Black;
            this.lblMasterData.Location = new System.Drawing.Point(12, 19);
            this.lblMasterData.Name = "lblMasterData";
            this.lblMasterData.Size = new System.Drawing.Size(133, 23);
            this.lblMasterData.TabIndex = 0;
            this.lblMasterData.Text = "Master Data";
            // 
            // dtgMasterData
            // 
            this.dtgMasterData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dtgMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMasterData.Location = new System.Drawing.Point(0, 57);
            this.dtgMasterData.Name = "dtgMasterData";
            this.dtgMasterData.Size = new System.Drawing.Size(748, 316);
            this.dtgMasterData.TabIndex = 1;
            this.dtgMasterData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMasterData_CellContentClick);
            this.dtgMasterData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMasterData_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTransactionNo);
            this.panel1.Controls.Add(this.btnEditData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.panel1.Size = new System.Drawing.Size(748, 71);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNo.ForeColor = System.Drawing.Color.Black;
            this.lblTransactionNo.Location = new System.Drawing.Point(3, 31);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(231, 19);
            this.lblTransactionNo.TabIndex = 3;
            this.lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            // 
            // btnEditData
            // 
            this.btnEditData.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditData.Location = new System.Drawing.Point(657, 17);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(79, 33);
            this.btnEditData.TabIndex = 0;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = false;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgMasterData);
            this.Controls.Add(this.pnlChildTitle);
            this.Name = "frmMasterData";
            this.Text = "frmMasterData";
            this.Load += new System.EventHandler(this.frmMasterData_Load);
            this.pnlChildTitle.ResumeLayout(false);
            this.pnlChildTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildTitle;
        private System.Windows.Forms.Label lblMasterData;
        private System.Windows.Forms.DataGridView dtgMasterData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Label lblTransactionNo;
    }
}