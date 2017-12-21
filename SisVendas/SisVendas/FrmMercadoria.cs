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
    public partial class FrmMercadoria : Form
    {
        public FrmMercadoria()
        {
            InitializeComponent();
            txtCodMerc.Text = (Sistema.LMercadoria.Count() + 1).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try { 
                Mercadoria Mercadoria = new Mercadoria();

                Mercadoria.codMercadoria = int.Parse(txtCodMerc.Text);
                Mercadoria.descricao = txtDesc.Text;
                Mercadoria.quantidade = int.Parse(txtQuantidade.Text);
                Mercadoria.valor = double.Parse(txtValor.Text);

                Sistema.LMercadoria.Add(Mercadoria);

                MessageBox.Show("Cadastro Realizado com sucesso!", "MENOSEMAIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Informe os valores corretos!", "MENOSEMAIS - ERRO CONVERSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
