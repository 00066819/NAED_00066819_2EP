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
    public partial class CommerceMaintenance : UserControl
    {
        public CommerceMaintenance()
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

        private void Comboload()
        {
            // Actualizar ComboBox
            cmbDeleteCommerce.DataSource = null;
            cmbDeleteCommerce.ValueMember = "idBusiness";
            cmbDeleteCommerce.DisplayMember = "name";
            cmbDeleteCommerce.DataSource = NegocioDAO.Userslist();
        }

        private void btnAddCommerce_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionDB.ExecuteNonQuery($"INSERT INTO BUSINESS(name, description) " +
                    $"VALUES('{txtCommerceName.Text}', '{txtCommerceDescription.Text}');");
                MessageBox.Show("¡Negocio agregado con éxito!", "Agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT idBusiness FROM BUSINESS WHERE " +
                    $"name = '{cmbDeleteCommerce.SelectedItem.ToString()}'");
                var dtt = Convert.ToInt32(dt.Rows[0][0].ToString());

                ConnectionDB.ExecuteNonQuery($"DELETE FROM BUSINESS WHERE idBusiness = {dtt}");

                MessageBox.Show("¡Negocio eliminado con éxito!", "Eliminar",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbDeleteCommerce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
