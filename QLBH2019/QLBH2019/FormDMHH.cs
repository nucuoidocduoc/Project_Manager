using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;





namespace QLBH2019
{
    public partial class FormDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        bool addnewFlag= false;

        public FormDMHH()
        {
            InitializeComponent();
        }
       
        private void FormDMHH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ktqd2019DataSet.tblDMHH' table. You can move, or remove it, as needed.
            //this.tblDMHHTableAdapter.Fill(this.ktqd2019DataSet.tblDMHH);
            constr = "Data Source=113.190.234.205,1433;Initial Catalog=ktqd2019;Persist Security Info=True;User ID=ktqd;Password=Ktqd-2019";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
            conn.Close();
        }
        public void NapCT()
        {
            int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());//lấy dữ liệu dòng hiện thời
            txtMaNhom.Text = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
            txtTenHang.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDonVi.Text = grdData.Rows[i].Cells["Dvt"].Value.ToString();
            txtDonGia.Text = grdData.Rows[i].Cells["DGvnd"].Value.ToString();
            txtNuocSX.Text = grdData.Rows[i].Cells["SanXuat"].Value.ToString();
            txtMaHang.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();

        }
        public void NapLai()
        {
            dt.Clear();
            sql = " Select * from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
        }
       /*public void NewR()
        {
            btnCapNhat.PerformClick();
            txtMaNhom.Text = "";
            txtTenHang.Text = "";
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtMaHang.Text = "";
        }*/

       private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           NapCT();
       }

       private void btnDau_Click(object sender, EventArgs e)
       {
           grdData.ClearSelection();
           grdData.CurrentCell = grdData[0, 0];
          // grdData.Rows[0].Selected = true;
           NapCT();
       }

       private void btnSau_Click(object sender, EventArgs e)
       {
           int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
           if (i<grdData.RowCount-1)
           {
               grdData.CurrentCell = grdData[0, i + 1];
               NapCT();

           }
       }

       private void btnTruoc_Click(object sender, EventArgs e)
       {
           int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
           if (i >0)
           {
               grdData.CurrentCell = grdData[0, i-1];
               NapCT();
           }
       }

       private void btnCuoi_Click(object sender, EventArgs e)
       {
           grdData.ClearSelection();
           grdData.CurrentCell = grdData[0, grdData.RowCount-1];
           NapCT();
       }

       private void cbmTruong_SelectedIndexChanged(object sender, EventArgs e)
       {
           sql = " Select Distinct " + cbmTruong.Text + " From tblDMHH";
           DataTable comtb = new DataTable();
           da = new SqlDataAdapter(sql, conn);
           da.Fill(comtb);
           cbmGiaTri.DataSource = comtb;
           cbmGiaTri.DisplayMember = cbmTruong.Text;
           cbmGiaTri.ValueMember = cbmTruong.Text;
       }

       private void btnLocDL_Click(object sender, EventArgs e)
       {
           dt.Clear();
           sql = "Select * From tblDMHH where " + cbmTruong.Text+ " ='" + cbmGiaTri.Text + " '";
           da = new SqlDataAdapter(sql, conn);
           da.Fill(dt);
           grdData.DataSource = dt;
           grdData.Refresh();
           NapCT();
       }

       private void btnXoa_Click(object sender, EventArgs e)
       {
           string mahang;
           if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu",MessageBoxButtons.YesNo)==DialogResult.Yes)
           {
               int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
               mahang = grdData.Rows[i].Cells[1].Value.ToString();
               sql = "Delete from tblDMHH where maHH= '" + mahang + "'";
               //cmd = new SqlCommand(sql, conn);
               //cmd.CommandText= sql;
               // cmd.ExecuteNonQuery();
               clsMain.DoSQL(sql);
               dt.Clear();
               sql= "Select * From tblDMHH";
               da= new SqlDataAdapter(sql, conn);
               da.Fill(dt);
               grdData.DataSource= dt;

           }
       }

       private void btnThemMoi_Click(object sender, EventArgs e)
       {
           //btnCapNhat.PerformClick();
           txtMaNhom.Text = "";
           txtTenHang.Text = "";
           txtDonVi.Text = "";
           txtDonGia.Text = "";
           txtNuocSX.Text = "";
           txtMaHang.Text = "";
           txtMaNhom.Focus();
           addnewFlag = true;
       }

       private void btnCapNhat_Click(object sender, EventArgs e)
       {
           string tMaNhom, tTenHH, tDonGia, tSanXuat, tMaHang, tDvt;
          // int i = Convert.ToInt16(grdData.CurrentRow.Index.ToString());
           int i, n;
           if(addnewFlag == false)
           {
               n = Convert.ToInt16(grdData.RowCount.ToString());
               for(i = 0; i < n-1; i++)
               {
                   tMaNhom = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
                   tTenHH = grdData.Rows[i].Cells["TenHH"].Value.ToString();
                   tDonGia = grdData.Rows[i].Cells["DGvnd"].Value.ToString();
                   tSanXuat = grdData.Rows[i].Cells["SanXuat"].Value.ToString();
                   tMaHang = grdData.Rows[i].Cells["MaHH"].Value.ToString();
                   tDvt = grdData.Rows[i].Cells["Dvt"].Value.ToString();

                   sql = "Update tblDMHH set MaNHom= '" + tMaNhom + "' ,TenHH=N'" + tTenHH +"' ,DGvnd=N'" + tDonGia+ "', SanXuat=N'" + tSanXuat + "', Dvt=N'"+tDvt+"' where MaHH= N'" + tMaHang + "'";
                   clsMain.DoSQL(sql);
               };
               MessageBox.Show("Đã cập nhật thành công!");
           }
           else
           {
               tMaNhom = txtMaNhom.Text;
               tTenHH = txtTenHang.Text;
               tDonGia = txtDonGia.Text;
               tSanXuat = txtNuocSX.Text;
               tMaHang = txtMaHang.Text;
               tDvt = txtDonVi.Text;
               sql = "Insert into tblDMHH (MaNhom, MaHH, TenHH, Dvt, DGvnd, SanXuat) Values (N'" + tMaNhom + "',N'" + tMaHang +
                    "',N'" + tTenHH + "',N'" + tDvt + "',N'" + tDonGia + "',N'" + tSanXuat + "')";
               clsMain.DoSQL(sql);
              addnewFlag = false;
              NapLai();
           }
          
       }

       private void btnIndsNh_Click(object sender, EventArgs e)
       {
           CrystalReport1 rpt = new CrystalReport1();
           sql = "Select MaNhom, MaHH, TenHH, Dvt, DGvnd, SanXuat From tblDMHH where MaNhom= N'" + cbmGiaTri.Text + "'";
           DataTable rpdata = new DataTable();
           rpdata.Clear();
           da = new SqlDataAdapter(sql, conn);
           da.Fill(rpdata);
           rpt.DataDefinition.FormulaFields["thongSo"].Text = "'" + cbmGiaTri.Text + "'";
           rpt.SetDataSource(rpdata);
          frmPreviewReport rp = new frmPreviewReport(rpt);
           rp.Show();

       }

       
    }
}
