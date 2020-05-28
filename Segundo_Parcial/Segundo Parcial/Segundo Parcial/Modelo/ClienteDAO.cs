using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial.Modelo
{
    class ClienteDAO
    {
        public static List<string> Addresslist(int id)
        {
            string dt = $"SELECT ad.address FROM ADDRESS ad" +
                $" WHERE idUser = {id}";
            var cbn = ConnectionDB.ExecuteQuery(dt);
            List<string> products = new List<string>();
            products.Add(" ");
            foreach (DataRow dr in cbn.Rows)
            {
                products.Add(dr[0].ToString());
            }
            return products;
        }

        public static List<int> Orders(int id)
        {
            var dt = ConnectionDB.ExecuteQuery($"SELECT ao.idOrder " +
                $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                $"WHERE ao.idProduct = pr.idProduct " +
                $"AND ao.idAddress = ad.idAddress " +
                $"AND ad.idUser = au.idUser " +
                $"AND au.idUser = {id};");
            List<int> orders = new List<int>();
            foreach(DataRow dr in dt.Rows)
            {   
                orders.Add(Convert.ToInt32(dr[0].ToString()));
            }
            return orders;
        }

    }
}
