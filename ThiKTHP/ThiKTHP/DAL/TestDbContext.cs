using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiKTHP.DAL.Entity;

namespace ThiKTHP.DAL
{
    class TestDbContext: DbContext
    {
        public TestDbContext() : base("Data Source=.;Initial Catalog=QuanLyHocSinh;Persist Security Info=True;User ID=sa;Password=123")
        {
        }
        public DbSet<HocSinh> HocSinhDbSet { get; set; }
        public DbSet<LopHoc> LopHocDbSet { get; set; }
    }
}
