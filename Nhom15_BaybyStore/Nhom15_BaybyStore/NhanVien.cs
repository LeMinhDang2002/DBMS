using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom15_BaybyStore
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            CaLam caLam = new CaLam();
            caLam.Show();
        }
    }
}
