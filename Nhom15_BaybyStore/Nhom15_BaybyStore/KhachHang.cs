using FontAwesome.Sharp;
using System.Linq;
using System.Windows.Forms;

namespace Nhom15_BaybyStore
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            HideSubMenu();
        }

        void HideSubMenu()
        {
            foreach (var pnl in pnlMenu.Controls.OfType<Panel>())
                pnl.Height = 50;
        }

        void ShowSubMenu(Panel pnl)
        {
            pnl.Height = pnl.Controls.OfType<IconButton>().Count() * 50 + 15;
        }

        private void btnDanhMuc_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
        }

        private void btnSuaNguCoc_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlSua);
        }

        private void btnThoiTrang_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlThoiTrang);
        }

        private void btnHocTap_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
            ShowSubMenu(pnlHocTap);
        }
    }
}
