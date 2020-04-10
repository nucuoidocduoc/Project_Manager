using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH2019
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDaySo.Text))
            {
                MessageBox.Show("Chưa nhập thông tin");
                txtDaySo.Focus();
            }
            txtDaySo.Text = " ";
            txtMax.Text = " ";
            txtHonTB.Text = " ";
            txtSapXep.Text = " ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
             if(string.IsNullOrEmpty(txtDaySo.Text))
            {
                MessageBox.Show("Chưa nhập thông tin");
                txtDaySo.Focus();
            }
            else
             {
              
                 string chuoi = txtDaySo.Text.Trim();
                
                 string[] ptu = chuoi.Split(',');
                  int n = ptu.Count();

                //Tìm số lớn nhất:
                 double temp1 = 0;                              
                 for(int i=0;i<n;i++)
                 {
                   if(Convert.ToDouble(ptu[i])>temp1)                     
                         temp1 = Convert.ToDouble(ptu[i]);                   
                 }
                 txtMax.Text = Convert.ToString(temp1);

                 //Số các số lớn hơn trung binh
                 double tong = 0;
                 for (int i = 0; i <n; i++)
                 {   
                     tong += Convert.ToDouble(ptu[i]);          
                 }
                 double tb= tong/n;
                 int dem= 0 ;
                 for (int i = 0; i <n; i++)
                 {
                     if (Convert.ToDouble(ptu[i])> tb)
                     {
                        dem += 1;
                     }
                 }
                 txtHonTB.Text= Convert.ToString(dem);

                 //sắp xếp
                for(int i=0; i<n;i++)
                {
                    for(int j=i+1;j<n; j++)
                    {
                        if(Convert.ToDouble(ptu[i])>Convert.ToDouble(ptu[j]))
                        {
                            string temp2;
                            temp2 = ptu[i];
                            ptu[i] = ptu[j];
                            ptu[j] = temp2;
                        }
                    }
                }
                StringBuilder output = new StringBuilder();
                 foreach (string s in ptu)
                 {
                     output.AppendFormat("{0},", s);
                 }
                 txtSapXep.Text = output.ToString().TrimEnd(',');




               /*  int[] so = new int[100];                 phần thầy chữa
                 int n = ptu.Count();
                 int max = 0;
                 for (int i = 1; i < n; i++)
                 {
                     so[i] = Convert.ToInt32(ptu[i]);
                     if (so[i] > max)
                         max = so[i];
                 }
                 txtMax.Text = Convert.ToString(max);*/

             }
        }
    }
} 
