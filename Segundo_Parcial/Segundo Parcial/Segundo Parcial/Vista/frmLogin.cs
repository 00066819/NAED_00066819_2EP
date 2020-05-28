using Segundo_Parcial.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAdmin fa = new frmAdmin();
            frmClient fc = new frmClient();

            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("¡Los espacios no pueden quedar en blanco!", "Error de inicio de sesion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string Uquery = $"SELECT userType FROM APPUSER WHERE" +
                                    $" username = '{txtUser.Text}' AND " +
                                    $"password = '{txtPass.Text}'";

                    var dt = ConnectionDB.ExecuteQuery(Uquery);
                    var dr = dt.Rows[0];
                    var admin = Convert.ToString(dr[0].ToString());

                    if (admin.Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Hide();
                        fa.Show();
                    }
                    else
                    {
                        this.Hide();
                        fc.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Usuario no registrado o los datos ingresados incorrectos!", "Error de inicio de sesion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            var cp = new frmChangePass();
            cp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
