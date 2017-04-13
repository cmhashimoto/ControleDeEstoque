namespace GUI
{
    partial class frmCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedor));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.mskdTxtForIE = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxtForCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxtForCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxtForCel = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxtForFone = new System.Windows.Forms.MaskedTextBox();
            this.txtForNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForEmail = new System.Windows.Forms.TextBox();
            this.txtForBairro = new System.Windows.Forms.TextBox();
            this.txtForEndNumero = new System.Windows.Forms.TextBox();
            this.txtForRua = new System.Windows.Forms.TextBox();
            this.txtForCidade = new System.Windows.Forms.TextBox();
            this.txtForEstado = new System.Windows.Forms.TextBox();
            this.txtForRSocial = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 438);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(760, 111);
            this.pnlBotoes.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(404, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 81);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(534, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 81);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(664, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 81);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.Image")));
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocalizar.Location = new System.Drawing.Point(144, 12);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(81, 81);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(274, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 81);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(14, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(81, 81);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.mskdTxtForIE);
            this.pnlDados.Controls.Add(this.mskdTxtForCNPJ);
            this.pnlDados.Controls.Add(this.mskdTxtForCEP);
            this.pnlDados.Controls.Add(this.mskdTxtForCel);
            this.pnlDados.Controls.Add(this.mskdTxtForFone);
            this.pnlDados.Controls.Add(this.txtForNome);
            this.pnlDados.Controls.Add(this.label12);
            this.pnlDados.Controls.Add(this.label11);
            this.pnlDados.Controls.Add(this.label10);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.label8);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txtForEmail);
            this.pnlDados.Controls.Add(this.txtForBairro);
            this.pnlDados.Controls.Add(this.txtForEndNumero);
            this.pnlDados.Controls.Add(this.txtForRua);
            this.pnlDados.Controls.Add(this.txtForCidade);
            this.pnlDados.Controls.Add(this.txtForEstado);
            this.pnlDados.Controls.Add(this.txtForRSocial);
            this.pnlDados.Controls.Add(this.lblDescricao);
            this.pnlDados.Controls.Add(this.txtForCod);
            this.pnlDados.Controls.Add(this.lblCodigo);
            this.pnlDados.Location = new System.Drawing.Point(12, 17);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(760, 415);
            this.pnlDados.TabIndex = 4;
            // 
            // mskdTxtForIE
            // 
            this.mskdTxtForIE.Location = new System.Drawing.Point(172, 135);
            this.mskdTxtForIE.Mask = "000.000.000.000";
            this.mskdTxtForIE.Name = "mskdTxtForIE";
            this.mskdTxtForIE.Size = new System.Drawing.Size(94, 20);
            this.mskdTxtForIE.TabIndex = 33;
            // 
            // mskdTxtForCNPJ
            // 
            this.mskdTxtForCNPJ.Location = new System.Drawing.Point(17, 136);
            this.mskdTxtForCNPJ.Mask = "00.000.000/0000-00";
            this.mskdTxtForCNPJ.Name = "mskdTxtForCNPJ";
            this.mskdTxtForCNPJ.Size = new System.Drawing.Size(117, 20);
            this.mskdTxtForCNPJ.TabIndex = 32;
            // 
            // mskdTxtForCEP
            // 
            this.mskdTxtForCEP.Location = new System.Drawing.Point(15, 198);
            this.mskdTxtForCEP.Mask = "00000-000";
            this.mskdTxtForCEP.Name = "mskdTxtForCEP";
            this.mskdTxtForCEP.Size = new System.Drawing.Size(65, 20);
            this.mskdTxtForCEP.TabIndex = 31;
            this.mskdTxtForCEP.Leave += new System.EventHandler(this.mskdTxtForCEP_Leave);
            // 
            // mskdTxtForCel
            // 
            this.mskdTxtForCel.Location = new System.Drawing.Point(397, 374);
            this.mskdTxtForCel.Mask = "(99) 00000-0000";
            this.mskdTxtForCel.Name = "mskdTxtForCel";
            this.mskdTxtForCel.Size = new System.Drawing.Size(89, 20);
            this.mskdTxtForCel.TabIndex = 30;
            // 
            // mskdTxtForFone
            // 
            this.mskdTxtForFone.Location = new System.Drawing.Point(14, 374);
            this.mskdTxtForFone.Mask = "(99) 0000-0000";
            this.mskdTxtForFone.Name = "mskdTxtForFone";
            this.mskdTxtForFone.Size = new System.Drawing.Size(82, 20);
            this.mskdTxtForFone.TabIndex = 29;
            // 
            // txtForNome
            // 
            this.txtForNome.Location = new System.Drawing.Point(185, 35);
            this.txtForNome.Name = "txtForNome";
            this.txtForNome.Size = new System.Drawing.Size(560, 20);
            this.txtForNome.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(184, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "Nome do Fornecedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(395, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(12, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(12, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(12, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(643, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(160, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(98, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(170, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Inscrição Estadual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "CNPJ";
            // 
            // txtForEmail
            // 
            this.txtForEmail.Location = new System.Drawing.Point(14, 331);
            this.txtForEmail.Name = "txtForEmail";
            this.txtForEmail.Size = new System.Drawing.Size(731, 20);
            this.txtForEmail.TabIndex = 12;
            // 
            // txtForBairro
            // 
            this.txtForBairro.Location = new System.Drawing.Point(14, 287);
            this.txtForBairro.Name = "txtForBairro";
            this.txtForBairro.Size = new System.Drawing.Size(731, 20);
            this.txtForBairro.TabIndex = 11;
            // 
            // txtForEndNumero
            // 
            this.txtForEndNumero.Location = new System.Drawing.Point(645, 242);
            this.txtForEndNumero.Name = "txtForEndNumero";
            this.txtForEndNumero.Size = new System.Drawing.Size(100, 20);
            this.txtForEndNumero.TabIndex = 10;
            this.txtForEndNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForEndNumero_KeyPress);
            // 
            // txtForRua
            // 
            this.txtForRua.Location = new System.Drawing.Point(14, 242);
            this.txtForRua.Name = "txtForRua";
            this.txtForRua.Size = new System.Drawing.Size(601, 20);
            this.txtForRua.TabIndex = 9;
            // 
            // txtForCidade
            // 
            this.txtForCidade.Location = new System.Drawing.Point(162, 198);
            this.txtForCidade.Name = "txtForCidade";
            this.txtForCidade.Size = new System.Drawing.Size(583, 20);
            this.txtForCidade.TabIndex = 8;
            // 
            // txtForEstado
            // 
            this.txtForEstado.Location = new System.Drawing.Point(100, 198);
            this.txtForEstado.Name = "txtForEstado";
            this.txtForEstado.Size = new System.Drawing.Size(44, 20);
            this.txtForEstado.TabIndex = 7;
            // 
            // txtForRSocial
            // 
            this.txtForRSocial.Location = new System.Drawing.Point(14, 87);
            this.txtForRSocial.Name = "txtForRSocial";
            this.txtForRSocial.Size = new System.Drawing.Size(731, 20);
            this.txtForRSocial.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(11, 69);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(168, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Razão Social do Fornecedor";
            // 
            // txtForCod
            // 
            this.txtForCod.Enabled = false;
            this.txtForCod.Location = new System.Drawing.Point(14, 35);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(100, 20);
            this.txtForCod.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(11, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(132, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Fornecedor";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmCadastroFornecedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.TextBox txtForRSocial;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForEmail;
        private System.Windows.Forms.TextBox txtForBairro;
        private System.Windows.Forms.TextBox txtForEndNumero;
        private System.Windows.Forms.TextBox txtForRua;
        private System.Windows.Forms.TextBox txtForCidade;
        private System.Windows.Forms.TextBox txtForEstado;
        private System.Windows.Forms.TextBox txtForNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskdTxtForFone;
        private System.Windows.Forms.MaskedTextBox mskdTxtForCel;
        private System.Windows.Forms.MaskedTextBox mskdTxtForCEP;
        private System.Windows.Forms.MaskedTextBox mskdTxtForCNPJ;
        private System.Windows.Forms.MaskedTextBox mskdTxtForIE;
    }
}