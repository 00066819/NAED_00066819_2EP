using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Segundo_Parcial.Modelo;
using System.Drawing.Text;

namespace Segundo_Parcial.Vista
{
    public partial class OrdersMaintenance : UserControl
    {
        public OrdersMaintenance()
        {
            InitializeComponent();
            try
            {
                Comboload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            try
            {

                var il = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS WHERE name = " +
                        $"'{cmbCommerces.SelectedItem.ToString()}'");
                var ill = Convert.ToInt32(il.Rows[0][0].ToString());

                var idp = ConnectionDB.ExecuteQuery($"SELECT idProduct FROM product WHERE name = " +
                    $"'{cmbProducts.SelectedItem.ToString()}' AND idBusiness = {ill}");
                var idpp = Convert.ToString(idp.Rows[0][0].ToString());

                var ip = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username = " +
                    $"'{txtUsername.Text}'");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());
                var ia = ConnectionDB.ExecuteQuery($"SELECT ad.idAddress FROM ADDRESS ad" +
                    $" WHERE address = '{cmbAddress.SelectedItem.ToString()}' AND idUser = {id}");
                var iaa = Convert.ToInt32(ia.Rows[0][0].ToString());

                var dat = DateTime.Now.ToString("yyyy/MM/dd");
                ConnectionDB.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                    $"VALUES('{dat}', {idpp}, {iaa});");

                MessageBox.Show("¡Pedido realizado con éxito!", "Pedido realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("¡Error al realizar el pedido!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Comboload()
        {
            // Actualizar ComboBox
            cmbCommerces.DataSource = null;
            cmbCommerces.ValueMember = "idBusiness";
            cmbCommerces.DisplayMember = "name";
            cmbCommerces.DataSource = NegocioDAO.Userslist();
        }
        private void Comboload1(int id)
        {
            // Actualizar ComboBox
            cmbProducts.DataSource = null;
            cmbProducts.ValueMember = "idProduct";
            cmbProducts.DisplayMember = "name";
            cmbProducts.DataSource = NegocioDAO.Productslist(id);
        }
        private void Comboload2(int id)
        {
            // Actualizar ComboBox
            cmbAddress.DataSource = null;
            cmbAddress.ValueMember = "idAddress";
            cmbAddress.DisplayMember = "address";
            cmbAddress.DataSource = ClienteDAO.Addresslist(id);
        }

        private void Comboload3()
        {
            var ip = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username = " +
                    $"'{txtUsername.Text}'");
            var id = Convert.ToInt32(ip.Rows[0][0].ToString());
            // Actualizar ComboBox
            cmbOrders.DataSource = null;
            cmbOrders.ValueMember = "idOrder";
            cmbOrders.DisplayMember = "order";
            cmbOrders.DataSource = ClienteDAO.Orders(id);
        }

        private void cmbCommerces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCommerces.SelectionLength > 0)
            {
                var ip = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS WHERE name = " +
                    $"'{cmbCommerces.SelectedItem.ToString()}'");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());
                Comboload1(id);
            }
        }

        private void cmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            var ip = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username = " +
                    $"'{txtUsername.Text}'");
            var ik = Convert.ToString(ip.Rows[0][0].ToString());
            var id = Convert.ToInt32(ik);
            Comboload2(id);
            Comboload3();

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToInt32(cmbOrders.SelectedItem);
                ConnectionDB.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idOrder = {a}");
                MessageBox.Show("¡Pedido eliminado con éxito!", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
