using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnCuaRiengToi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Services sv = new Services();
            TaiKhoan tk = new TaiKhoan();
            List<TaiKhoan> lstk = new List<TaiKhoan>();
            string path = @"E:\C#\DuAnCuaRiengToi\DuAnCuaRiengToi\X.xml";
            if (!sv.IsTextFileEmpty(path)) {
                lstk = sv.Doc<TaiKhoan>(path);
                int n = lstk.Count;
                tb_user.Text = lstk[n - 1].user;
                ptc_avt.ImageLocation = lstk[n - 1].avatar;
            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_rememberpass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

        }

        private void ptc_avt_Click(object sender, EventArgs e)
        {

        }
    }
}
