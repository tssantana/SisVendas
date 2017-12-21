namespace SisVendas
{
    partial class frmListaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPedido));
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.codPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPedido,
            this.Nome,
            this.codMercadoria,
            this.valorUnit,
            this.qtd,
            this.valorTotal});
            this.dgvPedido.Location = new System.Drawing.Point(10, 11);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(696, 278);
            this.dgvPedido.TabIndex = 1;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // codPedido
            // 
            this.codPedido.DataPropertyName = "codPedido";
            this.codPedido.HeaderText = "Código";
            this.codPedido.Name = "codPedido";
            this.codPedido.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nomeCliente";
            this.Nome.HeaderText = "Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // codMercadoria
            // 
            this.codMercadoria.DataPropertyName = "descMercadoria";
            this.codMercadoria.HeaderText = "Mercadoria";
            this.codMercadoria.Name = "codMercadoria";
            this.codMercadoria.ReadOnly = true;
            this.codMercadoria.Width = 150;
            // 
            // valorUnit
            // 
            this.valorUnit.DataPropertyName = "valorUnit";
            this.valorUnit.HeaderText = "Valor Unitário";
            this.valorUnit.Name = "valorUnit";
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "quantidade";
            this.qtd.HeaderText = "Quantidade";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valorTotal";
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            // 
            // frmListaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(706, 289);
            this.Controls.Add(this.dgvPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaPedido";
            this.Text = "MENOSEMAIS - PEDIDOS";
            this.Load += new System.EventHandler(this.frmListaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}