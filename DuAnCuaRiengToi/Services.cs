using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DuAnCuaRiengToi
{
   
    internal class Services
    {
        
       

        public void Luu<T>(string path, List<T> doituong)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("File không tồn tại");
            }
            else
            {
                FileStream _fS = new FileStream(path, FileMode.Create);
                BinaryFormatter _bF = new BinaryFormatter();
                _bF.Serialize(_fS, doituong);
                _fS.Close();
            }
        }
        public  List<T> Doc<T>(string path)
        {
            List<T> list = new List<T>();

            FileStream _fS = new FileStream(path, FileMode.Open);
            BinaryFormatter _bF = new BinaryFormatter();
            var data = _bF.Deserialize(_fS);
            list = (List<T>)data;
            _fS.Close();
            return list;
        }
        public  bool IsTextFileEmpty(string fileName)
        {
            var info = new FileInfo(fileName);
            if (info.Length == 0)
                return true;

            // only if your use case can involve files with 1 or a few bytes of content.
            if (info.Length < 1)
            {
                var content = File.ReadAllText(fileName);
                return content.Length == 0;
            }
            return false;
        }
    }
}
