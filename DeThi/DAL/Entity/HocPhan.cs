using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThi.DAL.Entity
{
    class HocPhan
    {
        [Key]
        public String MaHp { get; set; }
        public String TenHp { get; set; }
        public int DinhMucSv { get; set; }
        public int SoLuongSv { get; set ; }
        public String GiaoVienPhuTrach { get; set; }
        public String MaMh { get; set; }
        [ForeignKey("MaMh")]
        public virtual MonHoc MonHoc { get; set; }

        public static List<HocPhan> GetHocPhanFromDB(String mamh="")
        {
            if (!mamh.Equals(""))
            {
                List<HocPhan> dshppp = new KetNoiDBContext().HocPhanDbSet.ToList();
                List<HocPhan> hp = new List<HocPhan>();
                foreach (HocPhan i in dshppp)
                {
                    if (i.MaMh.Equals(mamh))
                    {
                        hp.Add(i);
                    }
                }
                return hp;
            }
            else
                return new KetNoiDBContext().HocPhanDbSet.ToList();
        }
        public static void ThemHP(HocPhan hp)
        {
            var db = new KetNoiDBContext();
            db.HocPhanDbSet.Add(hp);
            db.SaveChanges();
        }
        public static void XoaHP(HocPhan hp)
        {
            var db = new KetNoiDBContext();
            var obj = db.HocPhanDbSet.Where(e=>e.MaHp==hp.MaHp).FirstOrDefault();
            if (obj != null)
            {
                db.HocPhanDbSet.Remove(obj);
            }
            db.SaveChanges();
        }
        public static void SuaHP(HocPhan hp)
        {
            var db = new KetNoiDBContext();
            var obj = db.HocPhanDbSet.Where(e => e.MaHp == hp.MaHp).FirstOrDefault();
            if (obj != null)
            {
                obj.MaHp = hp.MaHp;
                obj.GiaoVienPhuTrach = hp.GiaoVienPhuTrach;
                obj.DinhMucSv = hp.DinhMucSv;
                MessageBox.Show(obj.MaHp + hp.MaHp);
            }
            db.SaveChanges();
        }
    }
}
