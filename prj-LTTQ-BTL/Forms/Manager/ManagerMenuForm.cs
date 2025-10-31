using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Forms.Manager
{
    public partial class ManagerMenuForm : Form
    {
        private readonly Color primaryColor = Color.FromArgb(0, 120, 215);
        private readonly Color secondaryColor = Color.FromArgb(43, 136, 216);
        private readonly Color backgroundColor = Color.FromArgb(243, 243, 243);
        private readonly Color cardColor = Color.White;
        private readonly Color textPrimary = Color.Black;
        private readonly Color textSecondary = Color.FromArgb(85, 85, 85);
        private readonly Color dangerColor = Color.FromArgb(232, 17, 35);
        private readonly Color borderColor = Color.FromArgb(204, 204, 204);
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
