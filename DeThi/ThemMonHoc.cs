using DeThi.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThi
{
    public partial class ThemMonHoc : Form
    {
        private List<MonHoc> dsmh;
        private List<HocPhan> dshp;
        public ThemMonHoc()
        {
            InitializeComponent();
            dsmh = MonHoc.GetMonHocFromDB();
            foreach(MonHoc i in dsmh)
            {
                cbtmh.Items.Add(i.TenMh);
            }
            cbtmh.SelectedIndex = 0;
            
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int i = cbtmh.SelectedIndex;
            dshp = HocPhan.GetHocPhanFromDB();
            if (!txtmhp.Text.Equals("") && !txtthp.Text.Equals("")&&!txtgvpt.Text.Equals(""))
            {
                int k = 0;
                foreach(HocPhan h in dshp)
                {
                    if (h.MaHp.Trim().ToLower().Equals(txtmhp.Text.Trim().ToLower()))
                    {
                        MessageBox.Show("Mã học phần đã tồn tại ở ngành khác :v");
                        k++;
                        break;
                    }
                }
                if (k == 0) {
                    HocPhan hp = new HocPhan
                    {
                        MaHp = txtmhp.Text,
                        TenHp = txtthp.Text,
                        MaMh = dsmh[i].MaMh,
                        GiaoVienPhuTrach = txtgvpt.Text,
                        DinhMucSv = int.Parse(nbdmsv.Value.ToString())
                    };
                    HocPhan.ThemHP(hp);
                    MessageBox.Show("Đã thêm học phần: " + txtthp.Text);
                    DialogResult = DialogResult.OK;
                }
            }
            else
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo!");
        }

       
    }
}
