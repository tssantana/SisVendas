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
    public partial class frmListaCliente : Form
    {
        public frmListaCliente()
        {
            InitializeComponent();

            this.dgvCliente.DataSource = Sistema.LCliente;
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
