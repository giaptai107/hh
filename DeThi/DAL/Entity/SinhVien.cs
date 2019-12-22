using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi.DAL.Entity
{
    class SinhVien
    {
        [Key]
        public String MaSV { get; set; }
        public String HoDem { get; set; }
        public String Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public String QueQuan { get; set; }
        public String MaHp { get; set; }
        [ForeignKey("MaHp")]
        public virtual HocPhan HocPhan { get; set; }
        public static List<SinhVien> GetSinhVienFromDB(String mahp="")
        {
            if (!mahp.Equals(""))
            {
                List<SinhVien> dssv = new KetNoiDBContext().SinhVienDbSet.ToList();
                List<SinhVien> sv = new List<SinhVien>();
                foreach (SinhVien i in dssv)
                {
                    if (i.MaHp.Equals(mahp))
                    {
                        sv.Add(i);
                    }
                }
                return sv;
            }
            else
                return new KetNoiDBContext().SinhVienDbSet.ToList();
        }
        public static void ThemSV(SinhVien sv)
        {
            var db = new KetNoiDBContext();
            db.SinhVienDbSet.Add(sv);
            db.SaveChanges();
        }
        public static void XoaSV(SinhVien sv)
        {
            var db = new KetNoiDBContext();
            var obj = db.SinhVienDbSet.Where(e => e.MaSV == sv.MaSV).FirstOrDefault();
            if (obj != null)
            {
                db.SinhVienDbSet.Remove(obj);
            }
            db.SaveChanges();
        }
        public static void SuaSV (SinhVien sv)
        {
            var db = new KetNoiDBContext();
            var obj = db.SinhVienDbSet.Where(e => e.MaSV == sv.MaSV).FirstOrDefault();
            if (obj != null)
            {
                obj.MaSV = sv.MaSV;
                obj.HoDem = sv.HoDem;
                obj.Ten = sv.Ten;
                obj.NgaySinh = sv.NgaySinh;
                obj.QueQuan = sv.QueQuan;
            }
            db.SaveChanges();
        }
    }
}
