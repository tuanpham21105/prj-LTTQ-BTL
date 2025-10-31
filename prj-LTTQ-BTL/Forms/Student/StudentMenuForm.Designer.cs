using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AntdUI;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using prj_LTTQ_BTL.Data;
using static System.Net.Mime.MediaTypeNames;
using Label = AntdUI.Label;

namespace prj_LTTQ_BTL.Forms.Student
{
    partial class StudentMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private readonly Color primaryColor = GlobalData.primaryColor;
        private readonly Color secondaryColor = GlobalData.secondaryColor;
        private readonly Color backgroundColor = GlobalData.backgroundColor;
        private readonly Color cardColor = GlobalData.cardColor;
        private readonly Color textPrimary = GlobalData.textPrimary;
        private readonly Color textSecondary = GlobalData.textSecondary;
        private readonly Color dangerColor = GlobalData.dangerColor;
        private readonly Color borderColor = GlobalData.borderColor;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenuForm));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new AntdUI.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLH = new Guna.UI2.WinForms.Guna2Button();
            this.btnDKLH = new Guna.UI2.WinForms.Guna2Button();
            this.btnKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnDSGV = new Guna.UI2.WinForms.Guna2Button();
            this.btnHP = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTHV = new Guna.UI2.WinForms.Guna2Button();
            this.brandPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBrand = new AntdUI.Label();
            this.picBrand = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.brandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // borderlessForm
            // 
            this.borderlessForm.BorderRadius = 12;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(280, 32);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1086, 736);
            this.panelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSize = true;
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnMaximize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(280, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1086, 32);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " Student Menu";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMinimize.BorderThickness = 1;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(951, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 32);
            this.btnMinimize.TabIndex = 1;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMaximize.BorderThickness = 1;
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.Location = new System.Drawing.Point(996, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 32);
            this.btnMaximize.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.BorderThickness = 1;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1041, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 32);
            this.btnClose.TabIndex = 3;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelSidebar.Controls.Add(this.btnLH);
            this.panelSidebar.Controls.Add(this.btnDKLH);
            this.panelSidebar.Controls.Add(this.btnKH);
            this.panelSidebar.Controls.Add(this.btnDSGV);
            this.panelSidebar.Controls.Add(this.btnHP);
            this.panelSidebar.Controls.Add(this.btnTTHV);
            this.panelSidebar.Controls.Add(this.brandPanel);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(15);
            this.panelSidebar.ShadowDecoration.Depth = 10;
            this.panelSidebar.ShadowDecoration.Enabled = true;
            this.panelSidebar.Size = new System.Drawing.Size(280, 768);
            this.panelSidebar.TabIndex = 2;
            // 
            // btnLH
            // 
            this.btnLH.BorderRadius = 8;
            this.btnLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLH.FillColor = System.Drawing.Color.Transparent;
            this.btnLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLH.ForeColor = System.Drawing.Color.White;
            this.btnLH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnLH.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLH.Location = new System.Drawing.Point(15, 345);
            this.btnLH.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnLH.Name = "btnLH";
            this.btnLH.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLH.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnLH.Size = new System.Drawing.Size(250, 50);
            this.btnLH.TabIndex = 18;
            this.btnLH.Text = "Lớp học của học viên";
            this.btnLH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDKLH
            // 
            this.btnDKLH.BorderRadius = 8;
            this.btnDKLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDKLH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDKLH.FillColor = System.Drawing.Color.Transparent;
            this.btnDKLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDKLH.ForeColor = System.Drawing.Color.White;
            this.btnDKLH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnDKLH.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDKLH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDKLH.Location = new System.Drawing.Point(15, 295);
            this.btnDKLH.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnDKLH.Name = "btnDKLH";
            this.btnDKLH.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDKLH.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnDKLH.Size = new System.Drawing.Size(250, 50);
            this.btnDKLH.TabIndex = 17;
            this.btnDKLH.Text = "Đăng ký lớp học";
            this.btnDKLH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnKH
            // 
            this.btnKH.BorderRadius = 8;
            this.btnKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKH.FillColor = System.Drawing.Color.Transparent;
            this.btnKH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKH.ForeColor = System.Drawing.Color.White;
            this.btnKH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnKH.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnKH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKH.Location = new System.Drawing.Point(15, 245);
            this.btnKH.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnKH.Name = "btnKH";
            this.btnKH.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKH.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnKH.Size = new System.Drawing.Size(250, 50);
            this.btnKH.TabIndex = 16;
            this.btnKH.Text = "Khóa học";
            this.btnKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDSGV
            // 
            this.btnDSGV.BorderRadius = 8;
            this.btnDSGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSGV.FillColor = System.Drawing.Color.Transparent;
            this.btnDSGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDSGV.ForeColor = System.Drawing.Color.White;
            this.btnDSGV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnDSGV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDSGV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDSGV.Location = new System.Drawing.Point(15, 195);
            this.btnDSGV.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnDSGV.Name = "btnDSGV";
            this.btnDSGV.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDSGV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnDSGV.Size = new System.Drawing.Size(250, 50);
            this.btnDSGV.TabIndex = 15;
            this.btnDSGV.Text = "Danh sách giảng viên";
            this.btnDSGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHP
            // 
            this.btnHP.BorderRadius = 8;
            this.btnHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHP.FillColor = System.Drawing.Color.Transparent;
            this.btnHP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHP.ForeColor = System.Drawing.Color.White;
            this.btnHP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnHP.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHP.Location = new System.Drawing.Point(15, 145);
            this.btnHP.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnHP.Name = "btnHP";
            this.btnHP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHP.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnHP.Size = new System.Drawing.Size(250, 50);
            this.btnHP.TabIndex = 14;
            this.btnHP.Text = "Học phí";
            this.btnHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTTHV
            // 
            this.btnTTHV.BorderRadius = 8;
            this.btnTTHV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTHV.FillColor = System.Drawing.Color.Transparent;
            this.btnTTHV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTTHV.ForeColor = System.Drawing.Color.White;
            this.btnTTHV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(136)))), ((int)(((byte)(216)))));
            this.btnTTHV.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTTHV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTHV.Location = new System.Drawing.Point(15, 95);
            this.btnTTHV.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnTTHV.Name = "btnTTHV";
            this.btnTTHV.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTTHV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnTTHV.Size = new System.Drawing.Size(250, 50);
            this.btnTTHV.TabIndex = 8;
            this.btnTTHV.Text = "Thông tin học viên";
            this.btnTTHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // brandPanel
            // 
            this.brandPanel.BackColor = System.Drawing.Color.Transparent;
            this.brandPanel.Controls.Add(this.lblBrand);
            this.brandPanel.Controls.Add(this.picBrand);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandPanel.Location = new System.Drawing.Point(15, 15);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.brandPanel.Size = new System.Drawing.Size(250, 80);
            this.brandPanel.TabIndex = 7;
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(60, 15);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(180, 50);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "OwlEng";
            // 
            // picBrand
            // 
            this.picBrand.BackColor = System.Drawing.Color.Transparent;
            this.picBrand.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBrand.FillColor = System.Drawing.Color.Transparent;
            this.picBrand.Image = ((System.Drawing.Image)(resources.GetObject("picBrand.Image")));
            this.picBrand.ImageRotate = 0F;
            this.picBrand.Location = new System.Drawing.Point(10, 15);
            this.picBrand.Name = "picBrand";
            this.picBrand.Size = new System.Drawing.Size(50, 50);
            this.picBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrand.TabIndex = 1;
            this.picBrand.TabStop = false;
            // 
            // StudentMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Menu";
            this.Load += new System.EventHandler(this.StudentMenuForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.brandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna2BorderlessForm borderlessForm;
        private Guna2Panel panelSidebar, panelHeader, panelMain;
        private Guna2ControlBox btnMinimize, btnMaximize, btnClose;
        private Label lblTitle;
        private PictureBox logoBox;
        private Guna2Button btnLH;
        private Guna2Button btnDKLH;
        private Guna2Button btnKH;
        private Guna2Button btnDSGV;
        private Guna2Button btnHP;
        private Guna2Button btnTTHV;
        private Guna2Panel brandPanel;
        private Label lblBrand;
        private Guna2PictureBox picBrand;
    }
}