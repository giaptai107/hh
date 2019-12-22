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
    public partial class Form1 : Form
    {
        private List<MonHoc> dsmh;
        private List<HocPhan> dshp;
        private List<SinhVien> dssv;
        public Form1()
        {
            InitializeComponent();
            dsmh = MonHoc.GetMonHocFromDB();
            if (dsmh.Count > 0) { 
                foreach(MonHoc i in dsmh)
                {
                    cbMonHoc.Items.Add(i.TenMh);
                }
                cbMonHoc.SelectedIndex = 0;
            }
            gvhp.AutoGenerateColumns = false;
            for (int i = 0; i < gvhp.Columns.Count; i++)
                if (i == 1)
                    gvhp.Columns[i].Visible = true;
                else
                    gvhp.Columns[i].Visible = false;

            gvsv.AutoGenerateColumns = false;
            for (int i = 0; i < gvsv.Columns.Count; i++)
            {
                if (i <= 4)
                    gvsv.Columns[i].Visible = true;
                else
                    gvsv.Columns[i].Visible = false;
            }
            dshp = HocPhan.GetHocPhanFromDB(dsmh[0].MaMh);
            bds1.DataSource = dshp;
            gvhp.DataSource = bds1;
            dssv = SinhVien.GetSinhVienFromDB(dshp[0].MaHp);
            bds2.DataSource = dssv;
            gvsv.DataSource = bds2;
            Load();
        }
        private void Load()
        {
            int i = cbMonHoc.SelectedIndex;
            dshp = HocPhan.GetHocPhanFromDB(dsmh[i].MaMh);
            bds1.DataSource = dshp;
            gvhp.DataSource = bds1;
            HocPhan cr = (HocPhan)bds1.Current;
            dssv = SinhVien.GetSinhVienFromDB(cr.MaHp);
            bds2.DataSource = dssv;
            gvsv.DataSource = bds2;
            lblMhp.Text = cr.MaHp;
            lblDmsv.Value = cr.DinhMucSv;
            //lblSlsvdk.Text = cr.SoLuongSv.ToString();
            lblSlsvdk.Text = gvsv.Rows.Count.ToString();
            lblGvpt.Text = cr.GiaoVienPhuTrach;
        }

        private void CbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void Gvhp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load();
        }
        private void BtnThemMh_Click_1(object sender, EventArgs e)
        {
            var f = new ThemMonHoc();
            f.ShowDialog();
            Load();
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            var hpc = (HocPhan)bds1.Current;
            if (MessageBox.Show("Bạn có chắc muốn xóa học phần: " + hpc.TenHp, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                HocPhan.XoaHP(hpc);
                MessageBox.Show("Đã xóa học phần " + hpc.TenHp);
                Load();
            }
        }

        private void ToolStripButton5_Click_1(object sender, EventArgs e)
        {
            var f = new ThemSinhVien(lblMhp.Text, gvhp.CurrentRow.Cells[1].Value.ToString());
            f.ShowDialog();
            Load();
        }

        private void ToolStripButton4_Click_1(object sender, EventArgs e)
        {
            var svc = (SinhVien)bds2.Current;
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên: " + svc.HoDem + " " + svc.Ten, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                SinhVien.XoaSV(svc);
                MessageBox.Show("Đã xóa sinh viên " + svc.HoDem + " " + svc.Ten);
                Load();
            }
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            var f = new EditSv(gvsv.CurrentRow.Cells[0].Value.ToString());
            f.ShowDialog();
            Load();
        }

        private void BtnSuaMh_Click(object sender, EventArgs e)
        {
            if (!lblMhp.Text.Equals("") && !lblGvpt.Text.Equals(""))
            {
                HocPhan ehp = new HocPhan
                {
                    MaHp = lblMhp.Text,
                    GiaoVienPhuTrach = lblGvpt.Text,
                    DinhMucSv = int.Parse(lblDmsv.Value.ToString())
                };
                HocPhan.SuaHP(ehp);
                MessageBox.Show("Đã sửa" + ehp.MaHp);
            }
            else
                MessageBox.Show("Các trường không được để trống");
        }
    }
}
