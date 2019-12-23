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
    public partial class Form1 : Form
    {
        private List<LopHoc> dslh;
        private List<HocSinh> dshs;
        public Form1()
        {
                InitializeComponent();
                Load();
           

        }
        public void Load()
        {
            dshs = HocSinh.GetHocSinhsDb();
            dslh = LopHoc.GetLopHocsDb();
            dgvLop.AutoGenerateColumns = false;
            for (int i = 0; i < dgvLop.Columns.Count; i++)
                if (i == 1 || i == 2 || i == 0)
                    dgvLop.Columns[i].Visible = true;
                else
                    dgvLop.Columns[i].Visible = false;
            bdsLop.DataSource = dslh;
            dgvLop.DataSource = bdsLop.DataSource;

            dgvHs.AutoGenerateColumns = false;
            for (int i = 0; i < dgvHs.Columns.Count; i++)
                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 0)
                    dgvHs.Columns[i].Visible = true;
                else
                    dgvHs.Columns[i].Visible = false;
            bdsHs.DataSource = dshs;
            dgvHs.DataSource = bdsHs.DataSource;

           
            //dslh = LopHoc.GetLopHocsDb(cbKhoiHoc.SelectedItem.ToString(), cbNamHoc.SelectedItem.ToString());
            //bdsLop.DataSource = dslh;
            //dgvLop.DataSource = bdsLop;
        }

        private void CbKhoiHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void CbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var f = new ThemLop();
            f.ShowDialog();
            Load();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var hpc = (LopHoc)bdsLop.Current;
            if (MessageBox.Show("Bạn có chắc muốn xóa học phần: " + hpc.Lop, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                LopHoc.XoaLop(hpc);
                MessageBox.Show("Đã xóa học phần " + hpc.Lop);
                Load();
            }
        }
    }
}
