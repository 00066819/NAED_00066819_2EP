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

namespace Segundo_Parcial.Vista
{
    public partial class ProductMaintenance : UserControl
    {
        public ProductMaintenance()
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

        private void ProductMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var ip = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS WHERE name = " +
                        $"'{cmbCommerces.SelectedItem.ToString()}'");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());

                ConnectionDB.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness, name)" +
                    $"VALUES({id}, '{txtProductName.Text}');");

                MessageBox.Show("¡Producto agregado con éxito!", "Agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var ipp = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS WHERE name = " +
                            $"'{cmbCommerces2.SelectedItem.ToString()}'");
                var idd = Convert.ToInt32(ipp.Rows[0][0].ToString());

                var ip = ConnectionDB.ExecuteQuery($"SELECT idProduct FROM product WHERE name = " +
                            $"'{cmbProducts.SelectedItem.ToString()}' AND idBusiness = {idd}");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());

                ConnectionDB.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idProduct = {id}");

                MessageBox.Show("¡Producto eliminado con éxito!", "Agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
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

            cmbCommerces2.DataSource = null;
            cmbCommerces2.ValueMember = "idBusiness";
            cmbCommerces2.DisplayMember = "name";
            cmbCommerces2.DataSource = NegocioDAO.Userslist();
        }
        private void Comboload1(int id)
        {
            // Actualizar ComboBox
            cmbProducts.DataSource = null;
            cmbProducts.ValueMember = "idProduct";
            cmbProducts.DisplayMember = "name";
            cmbProducts.DataSource = NegocioDAO.Productslist(id);
        }

        private void cmbCommerces2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCommerces2.SelectionLength > 0)
            {
                var ip = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS WHERE name = " +
                    $"'{cmbCommerces2.SelectedItem.ToString()}'");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());
                Comboload1(id);
            }
        }
    }
}
