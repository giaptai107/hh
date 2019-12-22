using DeThi.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi.DAL
{
    class KetNoiDBContext:DbContext
    {
        public KetNoiDBContext() : base("Data Source=.;Initial Catalog=DeCuongDB;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<SinhVien> SinhVienDbSet { get; set; }
        public DbSet<MonHoc> MonHocDbSet { get; set; }
        public DbSet<HocPhan> HocPhanDbSet{ get; set; }
    }
}
