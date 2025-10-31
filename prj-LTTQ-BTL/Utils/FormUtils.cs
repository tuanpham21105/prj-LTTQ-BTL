using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Utils
{
    internal class FormUtils
    {
        public static void OpenChildForm(Guna2Panel parentPanel, Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(childForm);
            parentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
