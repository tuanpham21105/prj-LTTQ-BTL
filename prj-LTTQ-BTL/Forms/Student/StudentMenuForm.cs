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

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class StudentMenuForm : Form
    {
        private readonly Color primaryColor = Color.FromArgb(0, 120, 215);
        private readonly Color secondaryColor = Color.FromArgb(43, 136, 216);
        private readonly Color backgroundColor = Color.FromArgb(243, 243, 243);
        private readonly Color cardColor = Color.White;
        private readonly Color textPrimary = Color.Black;
        private readonly Color textSecondary = Color.FromArgb(85, 85, 85);
        private readonly Color dangerColor = Color.FromArgb(232, 17, 35);
        private readonly Color borderColor = Color.FromArgb(204, 204, 204);

        private Guna2Panel panelSidebar, panelHeader, panelMain;
        private Guna2Button btnTTHV, btnLH, btnDKLH, btnKH, btnDSGV, btnHP;
        private Guna2BorderlessForm borderlessForm;
        private Guna2ControlBox btnMinimize, btnMaximize, btnClose;
        private Label lblTitle;
        private PictureBox logoBox;

        public StudentMenuForm()
        {
            InitializeComponent();
            InitializeUI();
            InitializeEvent();

        }

        private void InitializeUI()
        {
            // 🪟 Form setup
            this.Text = "Student Menu";
            this.Size = new Size(1366, 768);
            this.BackColor = backgroundColor;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            // 🧱 BorderlessForm config
            borderlessForm = new Guna2BorderlessForm();
            borderlessForm.ContainerControl = this;
            borderlessForm.TransparentWhileDrag = true;
            borderlessForm.BorderRadius = 12;
            borderlessForm.ResizeForm = true;

            // 🔹 Sidebar
            panelSidebar = new Guna2Panel
            {
                Dock = DockStyle.Left,
                Width = 280,
                BackColor = primaryColor,
                ShadowDecoration = { Depth = 10, Enabled = true },
                Padding = new Padding(15)
            };
            this.Controls.Add(panelSidebar);

            // 🔹 Header
            panelHeader = new Guna2Panel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                BackColor = cardColor,
                BorderColor = borderColor,
                BorderThickness = 1
            };
            this.Controls.Add(panelHeader);
            panelHeader.BringToFront();

            // 🔹 Main content
            panelMain = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                BackColor = backgroundColor,
                Padding = new Padding(10)
            };
            this.Controls.Add(panelMain);
            panelMain.BringToFront();

            // 🪙 Header Title
            lblTitle = new Label
            {
                Text = "🎓Student Menu",
                Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                ForeColor = textPrimary,
                AutoSize = true,
                Location = new Point(20, 12),
                BackColor = Color.Transparent,
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleLeft
            };
            panelHeader.Controls.Add(lblTitle);

            // 🔘 Custom window buttons
            btnClose = new Guna2ControlBox
            {
                Dock = DockStyle.Right,
                FillColor = Color.Transparent,
                HoverState = { FillColor = dangerColor, IconColor = Color.White },
                IconColor = textPrimary,
                Size = new Size(45, 30),
                Margin = new Padding(0),
                BorderColor = borderColor,
                BorderThickness = 1
                //Location = new Point(this.Width - 55, 10)
            };

            btnMaximize = new Guna2ControlBox
            {
                ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox,
                Dock = DockStyle.Right,
                FillColor = Color.Transparent,
                HoverState = { FillColor = Color.FromArgb(230, 230, 230) },
                IconColor = textPrimary,
                Size = new Size(45, 30),
                BorderColor = borderColor,
                BorderThickness = 1
            };

            btnMinimize = new Guna2ControlBox
            {
                ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox,
                Dock = DockStyle.Right,
                FillColor = Color.Transparent,
                HoverState = { FillColor = Color.FromArgb(230, 230, 230) },
                IconColor = textPrimary,
                Size = new Size(45, 30),
                BorderColor = borderColor,
                BorderThickness = 1
            };
            panelHeader.Controls.Add(btnMinimize);
            panelHeader.Controls.Add(btnMaximize);
            panelHeader.Controls.Add(btnClose);

            var brandPanel = new Guna2Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.Transparent,
                Padding = new Padding(10, 15, 10, 15),
            };

            var lblBrand = new Label
            {
                Text = "OwlEng",
                Font = new Font("Segoe UI Black", 20, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false,
                Width = 150,
                BackColor = Color.Transparent
            };
            brandPanel.Controls.Add(lblBrand);
            var picBrand = new Guna2PictureBox
            {
                Dock = DockStyle.Left,
                Size = new Size(50, 50),
                ImageRotate = 0f,
                FillColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile(Directory.GetParent(Application.StartupPath).Parent.FullName + @"\Images\owl.png"),
                Cursor = Cursors.Default,
                BackColor = Color.Transparent
            };
            brandPanel.Controls.Add(picBrand);


            // 📚 Sidebar buttons
            btnTTHV = CreateSidebarButton("👤Thông tin học viên");
            btnLH = CreateSidebarButton("Lớp học");
            btnDKLH = CreateSidebarButton("Đăng ký lớp học");
            btnKH = CreateSidebarButton("Khóa học");
            btnDSGV = CreateSidebarButton("Danh sách giảng viên");
            btnHP = CreateSidebarButton("Học phí");

            panelSidebar.Controls.Add(btnHP);
            panelSidebar.Controls.Add(btnDSGV);
            panelSidebar.Controls.Add(btnKH);
            panelSidebar.Controls.Add(btnDKLH);
            panelSidebar.Controls.Add(btnLH);
            panelSidebar.Controls.Add(btnTTHV);
            panelSidebar.Controls.Add(brandPanel);

        }

        private Guna2Button CreateSidebarButton(string text)
        {
            var btn = new Guna2Button
            {
                Text = text,
                Dock = DockStyle.Top,
                Height = 50,
                BorderRadius = 8,
                FillColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Left,
                ImageAlign = HorizontalAlignment.Left,
                Padding = new Padding(15, 0, 0, 0),
                HoverState =
                {
                    FillColor = secondaryColor,
                    ForeColor = Color.White
                },
                PressedColor = Color.FromArgb(20, 100, 180),
                Margin = new Padding(0, 10, 0, 0),
                Cursor = Cursors.Hand
            };

            return btn;
        }

        private void InitializeEvent()
        {

            btnTTHV.Click += (s, e) =>
            {
                SidebarBtn_Click(typeof(Form1), btnTTHV);
            };

            btnLH.Click += (s, e) =>
            {
                SidebarBtn_Click(typeof(Form1), btnLH);
            };

            btnDKLH.Click += (s, e) =>
            {
                SidebarBtn_Click(typeof(Form1), btnDKLH);
            };

            btnKH.Click += (s, e) =>
            {
                SidebarBtn_Click(typeof(Form1), btnKH);
            };

            btnDSGV.Click += (s, e) =>
            {
                SidebarBtn_Click(typeof(Form1), btnDSGV);
            };

            btnHP.Click += (s, e) =>
            {
                SidebarBtn_Click(typeof(Form1), btnHP);
            };
        }

        private void StudentMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void SidebarBtn_Click(Type type, Guna2Button btn)
        {
            btnTTHV.BackColor = Color.Transparent;
            btnLH.BackColor = Color.Transparent;
            btnDKLH.BackColor = Color.Transparent;
            btnKH.BackColor = Color.Transparent;
            btnDSGV.BackColor = Color.Transparent;
            btnHP.BackColor = Color.Transparent;

            btn.BackColor = secondaryColor;


        }

    }
}
