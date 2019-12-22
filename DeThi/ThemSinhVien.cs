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
    public partial class ThemSinhVien : Form
    {
        private String mahp;
        private String tenhp;
        public ThemSinhVien(String hp="",String thp="")
        {
            InitializeComponent();
            mahp = hp;
            tenhp = thp;
        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btndk_Click(object sender, EventArgs e)
        {
            if (!txtmsv.Text.Equals("") && !txthodem.Text.Equals("") && !txtten.Text.Equals("") && !txtqq.Text.Equals(""))
            {
                SinhVien sv = new SinhVien
                {
                    MaHp = mahp,
                    MaSV=txtmsv.Text,
                    HoDem = txthodem.Text,
                    Ten = txtten.Text,
                    NgaySinh = dtns.Value,
                    QueQuan = txtqq.Text
                };
                SinhVien.ThemSV(sv);
                MessageBox.Show("Đã đăng ký học phần: " + tenhp);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
                MessageBox.Show("Dữ liệu k được để trống", "Thông báo!");
            //MessageBox.Show(mahp + tenhp);
        }
    }
}
