using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace prj_LTTQ_BTL.Data
{
    internal static class GlobalData
    {
        public static string Role;
        public static string Id;

        public static readonly Color primaryColor = Color.FromArgb(0, 120, 215);
        public static readonly Color secondaryColor = Color.FromArgb(43, 136, 216);
        public static readonly Color backgroundColor = Color.FromArgb(243, 243, 243);
        public static readonly Color cardColor = Color.White;
        public static readonly Color textPrimary = Color.Black;
        public static readonly Color textSecondary = Color.FromArgb(85, 85, 85);
        public static readonly Color dangerColor = Color.FromArgb(232, 17, 35);
        public static readonly Color borderColor = Color.FromArgb(204, 204, 204);

        public static string LogoImg = Directory.GetParent(Application.StartupPath) + @"\Images\owl.png";
    }
}
