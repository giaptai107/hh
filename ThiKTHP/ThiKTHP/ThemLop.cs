using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiKTHP.DAL.Entity;

namespace ThiKTHP
{
    public partial class ThemLop : Form
    {
        private List<LopHoc> dslh;
        private List<HocSinh> dshs;
        public ThemLop()
        {
            InitializeComponent();

        }

        private void BtnOKLOP_Click(object sender, EventArgs e)
        {
            dslh = LopHoc.GetLopHocsDb();
            if (!tbLop.Text.Equals("") && !tbKhoi.Text.Equals("") && !tbKhoa.Text.Equals(""))
            {
                int k = 0;
                foreach (LopHoc h in dslh)
                {
                    if (h.Lop.Trim().ToLower().Equals(tbLop.Text.Trim().ToLower()))
                    {
                        MessageBox.Show("Mã học phần đã tồn tại ở ngành khác ");
                        k++;
                        break;
                    }
                }
                if (k == 0)
                {
                    LopHoc hp = new LopHoc
                    {
                        Lop = tbLop.Text,
                        PhongHoc = tbPhong.Text,
                        Khoi = tbKhoi.Text,
                        NamHoc = tbKhoa.Text,
                        SiSo = tbSiSo.Text
                    };
                    LopHoc.ThemLop(hp);
                    MessageBox.Show("Đã thêm: " + tbLop.Text);
                    DialogResult = DialogResult.OK;
                }
            }
            else
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo!");
        }
    }
}
