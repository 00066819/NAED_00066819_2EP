using Segundo_Parcial.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial.Modelo
{
    public static class UsuarioDAO
    {
        public static void ChangePass(string user, string opass, string npass)
        {
            try
            {
                string Uquery = $"SELECT idUser FROM APPUSER WHERE" +
                                $" username = '{user}' AND " +
                                $"password = '{opass}'";
                var search = ConnectionDB.ExecuteQuery(Uquery);
                var idaux = Convert.ToString(search.Rows[0][0].ToString());
                var id = Convert.ToInt32(idaux);

                string cp = $"UPDATE APPUSER SET password = '{npass}' WHERE idUser = {id}";
                ConnectionDB.ExecuteNonQuery(cp);

                MessageBox.Show("¡Contraseña actualizada con éxito!", "Acción realizada con éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Usuario no registrado o los datos ingresados incorrectos!", "Error de cambio de contraseña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

