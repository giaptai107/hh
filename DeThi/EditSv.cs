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
    public partial class EditSv : Form
    {
        
        public EditSv(String msv)
        {
            InitializeComponent();
            SinhVien nsv = new SinhVien();
            List<SinhVien> sv= SinhVien.GetSinhVienFromDB();
            foreach(SinhVien i in sv)
            {
                if (i.MaSV.Equals(msv))
                {
                    nsv = i;
                }
            }
            txtmsv.Text = nsv.MaSV;
            txthd.Text = nsv.HoDem;
            txtten.Text = nsv.Ten;
            dtns.Value = nsv.NgaySinh;
            txtqq.Text = nsv.QueQuan;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!txtmsv.Text.Equals("") && !txthd.Text.Equals("") && !txtten.Text.Equals("") && !txtqq.Text.Equals(""))
            {
                SinhVien sv = new SinhVien
                {
                    MaSV = txtmsv.Text,
                    HoDem = txthd.Text,
                    Ten = txtten.Text,
                    NgaySinh = dtns.Value,
                    QueQuan = txtqq.Text
                };
                SinhVien.SuaSV(sv);
                MessageBox.Show("Đã sửa!");
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Các trường không được để trống!");
        }
    }
}
