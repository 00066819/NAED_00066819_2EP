using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial.Modelo
{
    public static class NegocioDAO
    {

        public static List<string> Userslist()
        {
            string dt = $"SELECT name FROM BUSINESS";
            var cbn = ConnectionDB.ExecuteQuery(dt);
            List<string> names = new List<string>();
            names.Add(" ");
            foreach (DataRow dr in cbn.Rows)
            {
                names.Add(dr[0].ToString());
            }
            return names;

        }

        public static List<string> Productslist(int id)
        {
            string dt = $"SELECT name FROM product WHERE idBusiness = {id}";
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

