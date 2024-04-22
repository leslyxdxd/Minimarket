using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_ADO
{
    internal class ConexionADO
    {

        public string GetCnx()
        {
            string strCnx =
                   ConfigurationManager.ConnectionStrings["Minimarket"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }


        }

    }
}
