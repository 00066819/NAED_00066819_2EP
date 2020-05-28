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
    public partial class UsersMaintenance : UserControl
    {
        public UsersMaintenance()
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

        private void UsersMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO APPUSER(fullname, username, password, userType) " +
                        $"VALUES('{txtName.Text}', '{txtUsername.Text}', '{txtUsername.Text}', true);");
                    MessageBox.Show("¡Usuario agregado exitosamente!", "Agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO APPUSER(fullname, username, password, userType) " +
                        $"VALUES('{txtName.Text}', '{txtUsername.Text}', '{txtUsername.Text}', false);");
                    MessageBox.Show("¡Usuario agregado exitosamente!", "Agregar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE " +
                    $"username = '{comboBox1.SelectedItem.ToString()}'");
                var dtt = Convert.ToInt32(dt.Rows[0][0].ToString());

                ConnectionDB.ExecuteNonQuery($"DELETE FROM APPUSER WHERE idUser = {dtt}");

                MessageBox.Show("¡Usuario eliminado exitosamente!", "Eliminar",
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
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idUser";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = AdminDAO.Userslist();
        }

    }
}
