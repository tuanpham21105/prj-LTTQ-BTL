using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using prj_LTTQ_BTL.Data;

namespace prj_LTTQ_BTL.Forms.Student
{
    public partial class Student_CourseCRUDForm : Form
    {
        private DataProcessor dataProcessor = new DataProcessor();

        private readonly Color primaryColor = GlobalData.primaryColor;
        private readonly Color secondaryColor = GlobalData.secondaryColor;
        private readonly Color backgroundColor = GlobalData.backgroundColor;
        private readonly Color cardColor = GlobalData.cardColor;
        private readonly Color textPrimary = GlobalData.textPrimary;
        private readonly Color textSecondary = GlobalData.textSecondary;
        private readonly Color dangerColor = GlobalData.dangerColor;
        private readonly Color borderColor = GlobalData.borderColor;

        private Guna2TextBox txtSearch;
        private Guna2DataGridView dgvCourses;
        private Guna2DataGridView dgvClasses;
        private Guna2TextBox txtId, txtName, txtDesc, txtLessons, txtFee;

        private void FillGunaDgv(Guna2DataGridView dgv, DataTable data)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = data;
        }

        public Student_CourseCRUDForm()
        {
            InitializeComponent();
            InitializeUI();
            InitializeEvent();
        }

        private void InitializeUI()
        {
            this.Text = "Courses Management";
            this.Dock = DockStyle.Fill;
            this.BackColor = backgroundColor;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Layout tổng
            var mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = backgroundColor,
                RowCount = 3,
                ColumnCount = 1,
            };
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));   // Header
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));    // Course list
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));    // Details
            this.Controls.Add(mainLayout);

            // ================== HEADER ==================
            var headerPanel = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                FillColor = cardColor,
                Padding = new Padding(20, 10, 20, 10),
                BorderThickness = 1,
                BorderColor = borderColor,
            };

            var lblTitle = new AntdUI.Label
            {
                Text = "Course",
                Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold),
                ForeColor = textPrimary,
                AutoSize = true,
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            };

            txtSearch = new Guna2TextBox
            {
                PlaceholderText = "Search courses...",
                BorderColor = borderColor,
                BorderRadius = 8,
                FillColor = Color.White,
                Dock = DockStyle.Right,
                Width = 300,
            };

            headerPanel.Controls.Add(txtSearch);
            headerPanel.Controls.Add(lblTitle);
            mainLayout.Controls.Add(headerPanel, 0, 0);

            // ================== COURSE LIST ==================
            dgvCourses = CreateStyledDataGridView();
            dgvCourses.Columns.Add("id", "Course Id");
            dgvCourses.Columns.Add("name", "Course Name");
            dgvCourses.Columns.Add("number_of_lessons", "Lessons");
            dgvCourses.Columns.Add("fee", "Fee");
            dgvCourses.Columns.Add("description", "Description");

            mainLayout.Controls.Add(dgvCourses, 0, 1);

            // ================== DETAILS PANEL ==================
            var detailsPanel = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                FillColor = cardColor,
                BorderColor = borderColor,
                BorderThickness = 1,
                Padding = new Padding(20),
                BackColor = Color.Transparent
            };

            // Thông tin chi tiết
            var tblInfo = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                RowCount = 5,
                ColumnCount = 2,
                AutoSize = true,
            };
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            var lblId = new AntdUI.Label { Text = "Course Id:", Font = new Font("Segoe UI", 10), ForeColor = textPrimary, Dock = DockStyle.Fill };
            var lblName = new AntdUI.Label { Text = "Course Name:", Font = new Font("Segoe UI", 10), ForeColor = textPrimary, Dock = DockStyle.Fill };
            var lblDesc = new AntdUI.Label { Text = "Description:", Font = new Font("Segoe UI", 10), ForeColor = textPrimary, Dock = DockStyle.Fill };
            var lblLessons = new AntdUI.Label { Text = "Number of Lessons:", Font = new Font("Segoe UI", 10), ForeColor = textPrimary, Dock = DockStyle.Fill };
            var lblFee = new AntdUI.Label { Text = "Fee:", Font = new Font("Segoe UI", 10), ForeColor = textPrimary, Dock = DockStyle.Fill };

            txtId = new Guna2TextBox { ReadOnly = true, BorderColor = borderColor, BorderRadius = 6, Dock = DockStyle.Fill };
            txtName = new Guna2TextBox { ReadOnly = true, BorderColor = borderColor, BorderRadius = 6, Dock = DockStyle.Fill };
            txtDesc = new Guna2TextBox { ReadOnly = true, BorderColor = borderColor, BorderRadius = 6, Dock = DockStyle.Fill };
            txtLessons = new Guna2TextBox { ReadOnly = true, BorderColor = borderColor, BorderRadius = 6, Dock = DockStyle.Fill };
            txtFee = new Guna2TextBox { ReadOnly = true, BorderColor = borderColor, BorderRadius = 6, Dock = DockStyle.Fill };

            tblInfo.Controls.Add(lblId, 0, 0);
            tblInfo.Controls.Add(txtId, 1, 0);
            tblInfo.Controls.Add(lblName, 0, 1);
            tblInfo.Controls.Add(txtName, 1, 1);
            tblInfo.Controls.Add(lblDesc, 0, 2);
            tblInfo.Controls.Add(txtDesc, 1, 2);
            tblInfo.Controls.Add(lblLessons, 0, 3);
            tblInfo.Controls.Add(txtLessons, 1, 3);
            tblInfo.Controls.Add(lblFee, 0, 4);
            tblInfo.Controls.Add(txtFee, 1, 4);

            // Danh sách lớp
            var lblClass = new Label
            {
                Text = "Classes of this Course:",
                Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold),
                ForeColor = textPrimary,
                Margin = new Padding(0, 15, 0, 10),
                Dock = DockStyle.Top
            };

            // ✅ DataGridView hiển thị danh sách Class
            dgvClasses = CreateStyledDataGridView();
            dgvClasses.Columns.Add("id", "Class Id");
            dgvClasses.Columns.Add("name", "Class Name");
            dgvClasses.Columns.Add("max_students", "Max Students");
            dgvClasses.Columns.Add("start_date", "Start Date");
            dgvClasses.Columns.Add("teacher_id", "Teacher");

            // Panel chứa thông tin và DataGridView
            var infoContainer = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
            };
            infoContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            infoContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            infoContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            infoContainer.Controls.Add(tblInfo, 0, 0);
            infoContainer.Controls.Add(lblClass, 0, 1);
            infoContainer.Controls.Add(dgvClasses, 0, 2);

            detailsPanel.Controls.Add(infoContainer);
            mainLayout.Controls.Add(detailsPanel, 0, 2);
        }

        private Guna2DataGridView CreateStyledDataGridView()
        {
            var dgv = new Guna2DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = cardColor,
                BorderStyle = BorderStyle.None,
                GridColor = borderColor,
                ColumnHeadersHeight = 35,
                EnableHeadersVisualStyles = false,
            };

            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = primaryColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
            };

            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = textPrimary,
                Font = new Font("Segoe UI", 10),
                SelectionBackColor = secondaryColor,
                SelectionForeColor = Color.White
            };

            return dgv;
        }

        private void InitializeEvent()
        {
            FillGunaDgv(dgvCourses, dataProcessor.GetDataTable("select * from Course"));
            dgvCourses.CellClick += dgvCourses_cell_click;
            txtSearch.TextChanged += txtSearch_text_changed;
        }

        private void FormStudent_CourseCRUD_Load(object sender, EventArgs e)
        {
            dgvCourses.AutoGenerateColumns = false;

            dgvCourses.Columns.Clear();

            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id",
                HeaderText = "Course Id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "name",
                HeaderText = "Course Name",
                DataPropertyName = "name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "number_of_lessons",
                HeaderText = "Lessons",
                DataPropertyName = "number_of_lessons",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "fee",
                HeaderText = "Fee",
                DataPropertyName = "fee",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "description",
                HeaderText = "Description",
                DataPropertyName = "description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.AutoGenerateColumns = false;

            dgvClasses.Columns.Clear();

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Class Id",
                DataPropertyName = "id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Class Name",
                DataPropertyName = "name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Max Students",
                DataPropertyName = "max_students",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Start Date",
                DataPropertyName = "start_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Teacher Id",
                DataPropertyName = "teacher_id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void dgvCourses_cell_click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCourses.CurrentRow;

            txtId.Text = row.Cells["id"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtLessons.Text = row.Cells["number_of_lessons"].Value.ToString();
            txtDesc.Text = row.Cells["description"].Value.ToString();
            txtFee.Text = row.Cells["fee"].Value.ToString();

            FillGunaDgv(dgvClasses, dataProcessor.GetDataTable($"select * from Class where course_id = '{txtId.Text}'"));
        }

        private void txtSearch_text_changed(object sender, EventArgs e)
        {
            List<string> keywords = txtSearch.Text.Split(' ').ToList();

            DataTable searchCourses = new DataTable();
            DataTable sCourses = new DataTable();

            foreach (string keyword in keywords)
            {
                sCourses = dataProcessor.GetDataTable($"select * from Course where name collate Latin1_General_CI_AI like '%{keyword}%'");
                sCourses.PrimaryKey = new DataColumn[] { sCourses.Columns["id"] };
                searchCourses.PrimaryKey = new DataColumn[] { searchCourses.Columns["id"] };
                searchCourses.Merge(sCourses, false);

                sCourses = dataProcessor.GetDataTable($"select * from Course where description collate Latin1_General_CI_AI like '%{keyword}%'");
                searchCourses.Merge(sCourses, false);

                if (int.TryParse(keyword, out int lesson))
                {
                    sCourses = dataProcessor.GetDataTable($"select * from Course where number_of_lessons = {keyword}");
                    searchCourses.Merge(sCourses, false);
                }

                if (double.TryParse(keyword, out double fee))
                {
                    sCourses = dataProcessor.GetDataTable($"select * from Course where fee = {keyword}");
                    searchCourses.Merge(sCourses, false);
                }
            }

            FillGunaDgv(dgvCourses, searchCourses);
        }
    }
}
