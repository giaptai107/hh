using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiKTHP.DAL.Entity
{
    class LopHoc
    {
        [Key]
        public string Lop { set; get; }
        public string PhongHoc { set; get; }
        public string SiSo { set; get; }
        public string Khoi { set; get; }
        public string NamHoc { set; get; }
        public static List<LopHoc> GetLopHocsDb()
        {
            return new TestDbContext().LopHocDbSet.ToList();
            
        }

        public static void ThemLop(LopHoc lh)
        {
            var db = new TestDbContext();
            db.LopHocDbSet.Add(lh);
            db.SaveChanges();
        }
        public static void XoaLop(LopHoc sv)
        {
            var db = new TestDbContext();
            var obj = db.LopHocDbSet.Where(e => e.Lop == sv.Lop).FirstOrDefault();
            if (obj != null)
            {
                db.LopHocDbSet.Remove(obj);
            }
            db.SaveChanges();
        }
        public static void SuaLop(LopHoc sv)
        {
            var db = new TestDbContext();
            var obj = db.LopHocDbSet.Where(e => e.Lop == sv.Lop).FirstOrDefault();
            if (obj != null)
            {
                obj.Lop = sv.Lop;
                obj.Khoi = sv.Khoi;
                obj.NamHoc = sv.NamHoc;
                obj.SiSo = sv.SiSo;
                obj.PhongHoc = sv.PhongHoc;
            }
            db.SaveChanges();
        }
    }
 
}
