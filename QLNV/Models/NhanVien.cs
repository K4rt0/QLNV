namespace QLNV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(6)]
        public string MaNV { get; set; }

        [StringLength(20)]
        public string TenNV { get; set; }

        [StringLength(11)]
        public string NgaySinh { get; set; }

        [Required]
        [StringLength(2)]
        public string MaPB { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        public virtual PhongBan PhongBan1 { get; set; }
    }
}
