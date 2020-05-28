using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Segundo_Parcial.Modelo;
using System.Windows.Forms;

namespace Segundo_Parcial.Vista
{
    public partial class DirectionsMaintenance : UserControl
    {
        public DirectionsMaintenance()
        {
            InitializeComponent();
        }

        private void Comboload(int id)
        {
            // Actualizar ComboBox
            cmbAllAdress2.DataSource = null;
            cmbAllAdress2.ValueMember = "idAddress";
            cmbAllAdress2.DisplayMember = "address";
            cmbAllAdress2.DataSource = ClienteDAO.Addresslist(id);
        }

        private void btnAddAdress_Click(object sender, EventArgs e)
        {
            try
            {
                var id = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username " +
                    $"= '{txtUsername.Text}'");
                var idd = Convert.ToInt32(id.Rows[0][0].ToString());

                ConnectionDB.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                    $"VALUES({idd}, '{txtNewAdress.Text}'); ");

                MessageBox.Show("¡Dirección agregada!", "Dirección agregada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                var ip = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username = " +
                    $"'{txtUsername3.Text}'");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());

                Comboload(id);
            }
            catch(Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteAdress_Click(object sender, EventArgs e)
        {
            try
            {
                var ip = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username = " +
                    $"'{txtUsername3.Text}'");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());
                var ida = ConnectionDB.ExecuteQuery($"SELECT idAddress FROM ADDRESS WHERE idUser = " +
                    $"{id} AND address = '{cmbAllAdress2.SelectedItem.ToString()}'");
                var idaa = Convert.ToInt32(ida.Rows[0][0].ToString());
                ConnectionDB.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idAddress = {idaa}");

                MessageBox.Show("¡Dirección eliminada!", "Dirección eliminada",
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
