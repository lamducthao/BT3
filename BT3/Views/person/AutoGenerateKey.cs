using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BT3.Views.person
{
    public class AutoGenerateKey
    {
        public string GenerateKey(string id)
        {
            string strkey = "";
            string numPart = "", strPart = "", strPhanso = "";
            //tach phan so 0 de kich thuoc bang phan so => 1+1=2
            int phanso = (Convert.ToInt32(numPart) + 1);
            for (int i = 0; i < numPart.Length - 1; i++) 
            {
                strPhanso += "0";
            }
            strPhanso += phanso;
            //tach phan chu
            strkey = strPart + strPhanso;
            return strkey;
                
        }
    }
}