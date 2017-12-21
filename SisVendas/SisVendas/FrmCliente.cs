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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            txtCodCli.Text = (Sistema.LCliente.Count() + 1).ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();

            if ( txtCodCli.TextLength == 0 ||
                txtNome.TextLength == 0 ||
                txtEmail.TextLength == 0 ||
                txtNasc.TextLength == 0 ||
                txtRg.TextLength == 0 ||
                txtCpf.TextLength == 0 ||
                txtTelefone.TextLength == 0 ||
                txtEndereco.TextLength == 0 ) {

                MessageBox.Show("Informe todos os valores!", "MENOSEMAIS - CAMPOS VAZIOS !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            try
            {
                Cliente.codCliente = int.Parse(txtCodCli.Text);
                Cliente.nome = txtNome.Text;
                Cliente.email = txtEmail.Text;
                Cliente.dataNascimento = txtNasc.Text;
                Cliente.rg = txtRg.Text;
                Cliente.cpf = txtCpf.Text;
                Cliente.telefone = txtTelefone.Text;
                Cliente.endereco = txtEndereco.Text;

                Sistema.LCliente.Add(Cliente);

                MessageBox.Show("Cadastro Realizado com sucesso!","MENOSEMAIS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Informe os valores corretos!", "MENOSEMAIS - ERRO CONVERSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNasc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
