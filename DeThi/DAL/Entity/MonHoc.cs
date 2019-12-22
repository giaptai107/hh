using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi.DAL.Entity
{
    class MonHoc
    {
        [Key]
        public String MaMh { get; set; }
        public String TenMh { get; set; }

        public static List<MonHoc> GetMonHocFromDB()
        {
            return new KetNoiDBContext().MonHocDbSet.ToList();
        }
    }
}
