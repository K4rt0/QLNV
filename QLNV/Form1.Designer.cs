namespace QLNV
{
	partial class Form1
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
			this.dgvStaff = new System.Windows.Forms.DataGridView();
			this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StaffBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpBirth = new System.Windows.Forms.DateTimePicker();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvStaff
			// 
			this.dgvStaff.AllowUserToAddRows = false;
			this.dgvStaff.AllowUserToDeleteRows = false;
			this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.StaffBirth,
            this.Department});
			this.dgvStaff.Location = new System.Drawing.Point(12, 12);
			this.dgvStaff.Name = "dgvStaff";
			this.dgvStaff.ReadOnly = true;
			this.dgvStaff.RowHeadersWidth = 51;
			this.dgvStaff.RowTemplate.Height = 24;
			this.dgvStaff.Size = new System.Drawing.Size(670, 281);
			this.dgvStaff.TabIndex = 0;
			this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
			// 
			// StaffID
			// 
			this.StaffID.HeaderText = "Mã NV";
			this.StaffID.MinimumWidth = 6;
			this.StaffID.Name = "StaffID";
			this.StaffID.ReadOnly = true;
			this.StaffID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.StaffID.Width = 80;
			// 
			// StaffName
			// 
			this.StaffName.HeaderText = "Tên NV";
			this.StaffName.MinimumWidth = 6;
			this.StaffName.Name = "StaffName";
			this.StaffName.ReadOnly = true;
			this.StaffName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.StaffName.Width = 150;
			// 
			// StaffBirth
			// 
			this.StaffBirth.HeaderText = "Ngày sinh";
			this.StaffBirth.MinimumWidth = 6;
			this.StaffBirth.Name = "StaffBirth";
			this.StaffBirth.ReadOnly = true;
			this.StaffBirth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.StaffBirth.Width = 125;
			// 
			// Department
			// 
			this.Department.HeaderText = "Phòng ban";
			this.Department.MinimumWidth = 6;
			this.Department.Name = "Department";
			this.Department.ReadOnly = true;
			this.Department.Width = 150;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 305);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã nhân viên:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(156, 306);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(220, 22);
			this.txtID.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 333);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên nhân viên:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(156, 334);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(220, 22);
			this.txtName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 361);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Ngày sinh:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 389);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Phòng ban:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpBirth
			// 
			this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirth.Location = new System.Drawing.Point(156, 362);
			this.dtpBirth.Name = "dtpBirth";
			this.dtpBirth.Size = new System.Drawing.Size(220, 22);
			this.dtpBirth.TabIndex = 4;
			// 
			// cmbDepartment
			// 
			this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Items.AddRange(new object[] {
            ""});
			this.cmbDepartment.Location = new System.Drawing.Point(157, 387);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(219, 24);
			this.cmbDepartment.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(385, 306);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(144, 52);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(385, 359);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(144, 52);
			this.btnDel.TabIndex = 8;
			this.btnDel.Text = "Xoá";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(528, 306);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(144, 52);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(528, 359);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(144, 52);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 438);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cmbDepartment);
			this.Controls.Add(this.dtpBirth);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvStaff);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvStaff;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtID;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpBirth;
		private System.Windows.Forms.ComboBox cmbDepartment;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn Department;
	}
}

