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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
            txtCodPed.Text = (Sistema.LPedido.Count() + 1).ToString();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            if (this.txtCodCli.Text == "" ||
                this.txtCodMerc.Text == "")
            {
                MessageBox.Show("Informe todos os campos!", "MENOSEMAIS - CAMPOS NÃO INFORMADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(this.txtCodCli.Text) > Sistema.LCliente.Count)
            {
                MessageBox.Show("Este Cliente não existe! Por favor, volte a página inicial e cadastre-o...", "MENOSEMAIS - CLIENTE NÃO CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(this.txtCodMerc.Text) > Sistema.LMercadoria.Count)
            {
                MessageBox.Show("Esta mercadoria não existe! Por favor, volte a página inicial para cadastrá-la...", "MENOSEMAIS - CLIENTE NÃO CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {
                    Pedido Pedido = new Pedido();

                    string nomeCliente = Sistema.LCliente[int.Parse(this.txtCodCli.Text) - 1].nome;

                    string desc = Sistema.LMercadoria[int.Parse(this.txtCodMerc.Text) - 1].descricao;
                    double valorUnit = Sistema.LMercadoria[int.Parse(this.txtCodMerc.Text) - 1].valor;

                    Pedido.codPedido = int.Parse(txtCodPed.Text);
                    Pedido.nomeCliente = nomeCliente;
                    Pedido.descMercadoria = desc;
                    Pedido.quantidade = int.Parse(txtQuantidade.Text);
                    Pedido.valorTotal = Double.Parse(txtVlTot.Text);
                    Pedido.valorUnit = valorUnit;

                    Sistema.LPedido.Add(Pedido);

                    MessageBox.Show("Cadastro Realizado com sucesso!", "MENOSEMAIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Os valores informados não estão corretos!", "MENOSEMAIS - ERRO CONVERSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtVlTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodCli_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!(txtQuantidade.Text == "" || txtCodMerc.Text == ""))
            {
                try
                {
                    double vlMerc = Sistema.LMercadoria[int.Parse(txtCodMerc.Text) - 1].valor;
                    int qtd = int.Parse(this.txtQuantidade.Text);

                    txtVlTot.Text = (vlMerc * qtd).ToString();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Valores informados inválidos!","MAISEMENOS - ERRO DE CONVERSÃO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }            
        }
    }
}
