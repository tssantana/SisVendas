using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVendas
{
    public partial class frmListaPedido : Form
    {
        public frmListaPedido()
        {
            InitializeComponent();
            this.dgvPedido.DataSource = Sistema.LPedido;            
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
