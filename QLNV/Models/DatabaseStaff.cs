using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLNV.Models
{
	public partial class DatabaseStaff : DbContext
	{
		public DatabaseStaff()
			: base("name=DatabaseStaff1")
		{
		}

		public virtual DbSet<NhanVien> NhanVien { get; set; }
		public virtual DbSet<PhongBan> PhongBan { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<NhanVien>()
				.Property(e => e.MaNV)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<NhanVien>()
				.Property(e => e.NgaySinh)
				.IsUnicode(false);

			modelBuilder.Entity<NhanVien>()
				.Property(e => e.MaPB)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<PhongBan>()
				.Property(e => e.MaPB)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<PhongBan>()
				.HasMany(e => e.NhanVien)
				.WithRequired(e => e.PhongBan)
				.HasForeignKey(e => e.MaPB)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PhongBan>()
				.HasMany(e => e.NhanVien1)
				.WithRequired(e => e.PhongBan1)
				.HasForeignKey(e => e.MaPB)
				.WillCascadeOnDelete(false);
		}
	}
}
