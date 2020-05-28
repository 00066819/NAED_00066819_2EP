using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Modelo
{
    class AdminDAO
    { 
        public static List<string> Userslist()
        {
            string dt = $"SELECT username FROM APPUSER";
            var cbn = ConnectionDB.ExecuteQuery(dt);
            List<string> products = new List<string>();
            products.Add(" ");
            foreach (DataRow dr in cbn.Rows)
            {
                products.Add(dr[0].ToString());
            }
            return products;
        }

    }
}
