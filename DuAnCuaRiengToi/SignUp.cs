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
    [Serializable]
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
       
        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            string path = @"E:\C#\DuAnCuaRiengToi\DuAnCuaRiengToi\X.xml";
            TaiKhoan tk = new TaiKhoan(tb_user.Text, tb_pass.Text, tb_email.Text, cb_gender.Text, ptc_avt.ImageLocation);
            List<TaiKhoan> lstk = new List<TaiKhoan>();
            Services sv = new Services();
           
            bool check = sv.IsTextFileEmpty(path);
            if(check == false)
            {
               lstk = sv.Doc<TaiKhoan>(path);
                lstk.Add(tk);
                sv.Luu<TaiKhoan>(path, lstk);
            }
            else
            {
                lstk.Add(tk);
                sv.Luu<TaiKhoan>(path, lstk);
            }
          
           
        }
     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_avt_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.tif;...)|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";        
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Thay đổi thành công");
                ptc_avt.Image = Image.FromFile(ofd.FileName);
                ptc_avt.ImageLocation = ofd.FileName;
            }
            else 
            {
                MessageBox.Show("Hủy chọn avt");
            }
         
            
        }
      
    }
}
