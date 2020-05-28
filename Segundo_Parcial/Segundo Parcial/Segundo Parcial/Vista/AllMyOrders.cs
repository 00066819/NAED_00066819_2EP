using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial.Vista
{
    public partial class AllMyOrders : UserControl
    {
        public AllMyOrders()
        {
            InitializeComponent();
        }

        private void AllMyOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnAllMyOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var ip = ConnectionDB.ExecuteQuery($"SELECT idUser FROM APPUSER WHERE username = " +
                        $"'{txtUsername.Text}'");
                var id = Convert.ToInt32(ip.Rows[0][0].ToString());

                var dt = ConnectionDB.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                    $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                    $"WHERE ao.idProduct = pr.idProduct " +
                    $"AND ao.idAddress = ad.idAddress " +
                    $"AND ad.idUser = au.idUser " +
                    $"AND au.idUser = {id}; ");

                dataGridView1.DataSource = dt;
                MessageBox.Show("¡Cargado con éxito!", "Actualizar",
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
