using QLNV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void loadListDepartment(List<PhongBan> listDepartment)
		{
			cmbDepartment.DataSource = listDepartment;
			cmbDepartment.DisplayMember = "TenPB";
			cmbDepartment.ValueMember = "MaPB";
		}

		void loadListStaff(List<NhanVien> listStaff)
		{
			dgvStaff.Rows.Clear();
			foreach (var staff in listStaff)
			{
				int index = dgvStaff.Rows.Add();
				dgvStaff.Rows[index].Cells[0].Value = staff.MaNV;
				dgvStaff.Rows[index].Cells[1].Value = staff.TenNV;
				dgvStaff.Rows[index].Cells[2].Value = staff.NgaySinh;
				dgvStaff.Rows[index].Cells[3].Value = staff.PhongBan.TenPB;
			}
		}

		#region Events
		private void Form1_Load(object sender, EventArgs e)
		{
			DatabaseStaff db = new DatabaseStaff();
			List<PhongBan> listDepartment = db.PhongBan.ToList();
			List<NhanVien> listStaff = db.NhanVien.ToList();
			loadListDepartment(listDepartment);
			loadListStaff(listStaff);
		}
		private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if(index != -1)
			{
				txtID.Text = dgvStaff.Rows[index].Cells[0].Value.ToString();
				txtName.Text = dgvStaff.Rows[index].Cells[1].Value.ToString();
				dtpBirth.Text = dgvStaff.Rows[index].Cells[2].Value.ToString();
				cmbDepartment.Text = dgvStaff.Rows[index].Cells[3].Value.ToString();
			}
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvStaff.SelectedRows.Count < 1)
				MessageBox.Show("Bạn chưa chọn vào người cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				DatabaseStaff db = new DatabaseStaff();
				NhanVien staff = db.NhanVien.FirstOrDefault(p => p.MaNV == txtID.Text);
				if (staff != null)
				{
					staff.TenNV = txtName.Text;
					staff.NgaySinh = dtpBirth.Text;
					staff.MaPB = db.PhongBan.FirstOrDefault(p => p.TenPB == cmbDepartment.Text).MaPB;

					db.SaveChanges();
					loadListStaff(db.NhanVien.ToList());
				}
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "" || txtName.Text == "")
				MessageBox.Show("Bạn chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (txtID.Text.Length != 6)
				MessageBox.Show("Mã nhân viên phải đầy đủ 6 kí tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (txtID.Text.Substring(0, 2) != "NV")
				MessageBox.Show("Mã nhân viên phải có kí tự NV đầu tiên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				DatabaseStaff db = new DatabaseStaff();
				List<NhanVien> listStaff = db.NhanVien.ToList();
				NhanVien staff = listStaff.FirstOrDefault(p => p.MaNV == txtID.Text);

				if (staff != null)
					MessageBox.Show("Nhân viên này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					staff = new NhanVien() { MaNV = txtID.Text, TenNV = txtName.Text, NgaySinh = dtpBirth.Text, MaPB = db.PhongBan.FirstOrDefault(p => p.TenPB == cmbDepartment.Text).MaPB };

					db.NhanVien.Add(staff);
					db.SaveChanges();
					loadListStaff(db.NhanVien.ToList());
				}
			}
		}
		private void btnDel_Click(object sender, EventArgs e)
		{
			if (dgvStaff.SelectedRows.Count < 1)
				MessageBox.Show("Bạn chưa chọn vào người cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dl == DialogResult.Yes)
				{
					DatabaseStaff db = new DatabaseStaff();
					db.NhanVien.Remove(db.NhanVien.FirstOrDefault(p => p.MaNV == txtID.Text));
					db.SaveChanges();
					loadListStaff(db.NhanVien.ToList());
				}
			}
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult dl = MessageBox.Show("Bạn có chắc muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dl == DialogResult.OK)
				Application.Exit();
		}
		#endregion


	}
}
