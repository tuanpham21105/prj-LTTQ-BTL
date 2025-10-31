using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI.Svg;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;
using prj_LTTQ_BTL.Services;
using prj_LTTQ_BTL.Utils;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class StudentMenuForm : Form
    {
        private Form activeForm = null;

        public StudentMenuForm()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {

            btnTTHV.Click += (s, e) =>
            {
                SidebarBtn_Click(btnTTHV, "Thông tin học viên");
            };

            btnLH.Click += (s, e) =>
            {
                SidebarBtn_Click(btnLH, "Lớp học");
            };

            btnDKLH.Click += (s, e) =>
            {
                SidebarBtn_Click(btnDKLH, "Đăng ký lớp học");
            };

            btnKH.Click += (s, e) =>
            {
                SidebarBtn_Click(btnKH, "Khóa học");
            };

            btnDSGV.Click += (s, e) =>
            {
                SidebarBtn_Click(btnDSGV, "Danh sách giảng viên");
            };

            btnHP.Click += (s, e) =>
            {
                SidebarBtn_Click(btnHP, "Học phí");
            };
        }

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void SidebarBtn_Click(Guna2Button btn, string formType)
        {
            btnTTHV.BackColor = Color.Transparent;
            btnLH.BackColor = Color.Transparent;
            btnDKLH.BackColor = Color.Transparent;
            btnKH.BackColor = Color.Transparent;
            btnDSGV.BackColor = Color.Transparent;
            btnHP.BackColor = Color.Transparent;

            btn.BackColor = secondaryColor;

            if (activeForm != null)
            {
                activeForm.Close();
            }

            switch (formType)
            {
                case "Thông tin học viên":
                    break;
                case "Lớp học":
                    break;
                case "Đăng ký lớp học":
                    break;
                case "Khóa học":
                    activeForm = new Student_CourseCRUDForm();
                    break;
                case "Danh sách giảng viên":
                    break;
                case "Học phí":
                    break;
            }

            FormUtils.OpenChildForm(panelMain, activeForm);
        }
    }
}
