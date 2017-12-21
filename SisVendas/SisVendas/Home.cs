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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente FrmCli = new FrmCliente();

            FrmCli.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedido FrmPed = new FrmPedido();

            FrmPed.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaCliente ListaCliente = new frmListaCliente();

            ListaCliente.Show();   
                        
        }

        private void btnListaMerc_Click(object sender, EventArgs e)
        {
            frmListaMercadoria ListaMerc = new frmListaMercadoria();

            ListaMerc.Show();
        }

        private void btnListPed_Click(object sender, EventArgs e)
        {
            frmListaPedido ListaPed = new frmListaPedido();

            ListaPed.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }       

        private void btnMerc_Click_1(object sender, EventArgs e)
        {
            FrmMercadoria frmMerc = new FrmMercadoria();

            frmMerc.Show();
        }



    }
}