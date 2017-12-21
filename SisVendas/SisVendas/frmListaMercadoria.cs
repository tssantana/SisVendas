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
    public partial class frmListaMercadoria : Form
    {
        public frmListaMercadoria()
        {
            InitializeComponent();
        }

        private void frmListaMercadoria_Load(object sender, EventArgs e)
        {
            this.dgvMercadoria.DataSource = Sistema.LMercadoria;
        }

        private void dgvMercadoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        }

        private void dgvMercadoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvMercadoria.Rows[e.RowIndex];

            MessageBox.Show(Convert.ToString(currentRow.Cells[0].Value));
        }


    }
}
