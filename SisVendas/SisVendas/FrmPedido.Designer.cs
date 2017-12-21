namespace SisVendas
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtCodMerc = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtVlTot = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mercadoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Total";
            // 
            // txtCodPed
            // 
            this.txtCodPed.Enabled = false;
            this.txtCodPed.Location = new System.Drawing.Point(296, 52);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.ReadOnly = true;
            this.txtCodPed.Size = new System.Drawing.Size(100, 20);
            this.txtCodPed.TabIndex = 5;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(296, 88);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 0;
            this.txtCodCli.TextChanged += new System.EventHandler(this.txtCodCli_TextChanged);
            // 
            // txtCodMerc
            // 
            this.txtCodMerc.Location = new System.Drawing.Point(296, 123);
            this.txtCodMerc.Name = "txtCodMerc";
            this.txtCodMerc.Size = new System.Drawing.Size(100, 20);
            this.txtCodMerc.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(296, 162);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // txtVlTot
            // 
            this.txtVlTot.Enabled = false;
            this.txtVlTot.Location = new System.Drawing.Point(377, 201);
            this.txtVlTot.Name = "txtVlTot";
            this.txtVlTot.ReadOnly = true;
            this.txtVlTot.Size = new System.Drawing.Size(100, 20);
            this.txtVlTot.TabIndex = 9;
            this.txtVlTot.TextChanged += new System.EventHandler(this.txtVlTot_TextChanged);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(232, 258);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(113, 23);
            this.BtnCadastrar.TabIndex = 11;
            this.BtnCadastrar.Text = "Cadastrar Pedido";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "MENOSEMAIS INDÚSTRIA E COMÉRCIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisVendas.Properties.Resources.imgPedidos;
            this.pictureBox1.Location = new System.Drawing.Point(16, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 142);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(489, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.txtVlTot);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtCodMerc);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.txtCodPed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(12, 17);
            this.Name = "FrmPedido";
            this.Text = "Cadastro de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtCodMerc;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtVlTot;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}