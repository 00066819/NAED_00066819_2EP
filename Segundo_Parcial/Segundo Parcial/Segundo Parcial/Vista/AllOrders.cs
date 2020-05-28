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
    public partial class AllOrders : UserControl
    {
        public AllOrders()
        {
            InitializeComponent();
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                    $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                    $"WHERE ao.idProduct = pr.idProduct " +
                    $"AND ao.idAddress = ad.idAddress " +
                    $"AND ad.idUser = au.idUser;");
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
