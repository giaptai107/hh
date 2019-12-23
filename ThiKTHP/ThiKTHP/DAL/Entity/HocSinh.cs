using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiKTHP.DAL.Entity
{
    class HocSinh
    {
        [Key]
        public string MaHS { set; get; }
        public string Ho { set; get; }
        public string Ten { set; get; }
        public string GioiTinh { set; get; }
        public string NoiSinh { set; get; }
        public string QueQuan { set; get; }
        public string Lop { set; get; }
        [ForeignKey("Lop")]
        public virtual LopHoc LopHoc { set; get; }
        public static List<HocSinh> GetHocSinhsDb()
        {
            //return new TestDbContext().HocSinhDbSet.Where(e => e.Lop == Lop).OrderBy(e => e.MaHS).ToList();
            return new TestDbContext().HocSinhDbSet.ToList();
        }
    }
}
