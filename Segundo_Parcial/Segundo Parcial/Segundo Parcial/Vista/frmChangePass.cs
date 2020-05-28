using Segundo_Parcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial.Vista
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string un = txtUsername.Text;
            string op = txtOldPass.Text;
            string np = txtNewPass.Text;

            if (txtUsername.Text == "" || txtOldPass.Text == "" || txtNewPass.Text == "")
            {
                MessageBox.Show("¡No pueden quedar espacios en blanco!", "Error de inicio de sesion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UsuarioDAO.ChangePass(un, op, np);
                txtNewPass.Clear();
                txtOldPass.Clear();
                txtUsername.Clear();
                
            }
        }
    }
}
