using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DuAnCuaRiengToi
{
    [Serializable]
    internal class TaiKhoan
    {
        public string user { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string sex { get; set; }
        public string avatar { get; set; }
        public TaiKhoan()
        {

        }

        public TaiKhoan(string user, string pass, string email, string sex, string avatar)
        {
            this.user = user;
            this.pass = pass;
            this.email = email;
            this.sex = sex;
            this.avatar = avatar;
        }
       

    }
}
