﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Example
{
    public partial class GiaoVien : Form
    {
        public GiaoVien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithucthi = "admin";
        private void GiaoVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new Database().Select("selectGV '" + int.Parse(mgv) + "'");
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                rbtNam.Checked = r["gioitinh"].ToString() == "1" ? true : false;
                mtbNgaysinh.Text = r["ngaysinh"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDiachi.Text = r["diachi"].ToString();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            string gioitinh = rbtNam.Checked ? "1" : "0";
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;
            if (!long.TryParse(dienthoai, out _))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienthoai.Select();
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Select();
                return;
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();
                return;
            }
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "InsertGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithucthi
                });
            }
            else
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithucthi
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = txtHo.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = txtTendem.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = txtTen.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = rbtNam.Checked ? "1" : "0"
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = txtEmail.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = txtDienthoai.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = txtDiachi.Text
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công ");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
