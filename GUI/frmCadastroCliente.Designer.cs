namespace GUI
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.grpbTipo = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.mskdTxtCliCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxtCliCel = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxtCliFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCliNome = new System.Windows.Forms.TextBox();
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
            this.lblRgIE = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtCliEmail = new System.Windows.Forms.TextBox();
            this.txtCliBairro = new System.Windows.Forms.TextBox();
            this.txtCliEndNumero = new System.Windows.Forms.TextBox();
            this.txtCliEndereco = new System.Windows.Forms.TextBox();
            this.txtCliCidade = new System.Windows.Forms.TextBox();
            this.txtCliEstado = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lblRSocial = new System.Windows.Forms.Label();
            this.txtCliCod = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mskTextCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskTextRGIE = new System.Windows.Forms.MaskedTextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.grpbTipo.SuspendLayout();
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
            this.pnlBotoes.TabIndex = 7;
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
            this.pnlDados.Controls.Add(this.mskTextRGIE);
            this.pnlDados.Controls.Add(this.mskTextCPFCNPJ);
            this.pnlDados.Controls.Add(this.grpbTipo);
            this.pnlDados.Controls.Add(this.mskdTxtCliCEP);
            this.pnlDados.Controls.Add(this.mskdTxtCliCel);
            this.pnlDados.Controls.Add(this.mskdTxtCliFone);
            this.pnlDados.Controls.Add(this.txtCliNome);
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
            this.pnlDados.Controls.Add(this.lblRgIE);
            this.pnlDados.Controls.Add(this.lblCpfCnpj);
            this.pnlDados.Controls.Add(this.txtCliEmail);
            this.pnlDados.Controls.Add(this.txtCliBairro);
            this.pnlDados.Controls.Add(this.txtCliEndNumero);
            this.pnlDados.Controls.Add(this.txtCliEndereco);
            this.pnlDados.Controls.Add(this.txtCliCidade);
            this.pnlDados.Controls.Add(this.txtCliEstado);
            this.pnlDados.Controls.Add(this.txtRSocial);
            this.pnlDados.Controls.Add(this.lblRSocial);
            this.pnlDados.Controls.Add(this.txtCliCod);
            this.pnlDados.Controls.Add(this.lblCodigo);
            this.pnlDados.Location = new System.Drawing.Point(12, 13);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(760, 419);
            this.pnlDados.TabIndex = 6;
            // 
            // grpbTipo
            // 
            this.grpbTipo.Controls.Add(this.rbJuridica);
            this.grpbTipo.Controls.Add(this.rbFisica);
            this.grpbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpbTipo.Location = new System.Drawing.Point(144, 17);
            this.grpbTipo.Name = "grpbTipo";
            this.grpbTipo.Size = new System.Drawing.Size(192, 43);
            this.grpbTipo.TabIndex = 34;
            this.grpbTipo.TabStop = false;
            this.grpbTipo.Text = "Tipo do Cliente";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbJuridica.Location = new System.Drawing.Point(113, 20);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbFisica.Location = new System.Drawing.Point(7, 20);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // mskdTxtCliCEP
            // 
            this.mskdTxtCliCEP.Location = new System.Drawing.Point(14, 216);
            this.mskdTxtCliCEP.Mask = "00000-000";
            this.mskdTxtCliCEP.Name = "mskdTxtCliCEP";
            this.mskdTxtCliCEP.Size = new System.Drawing.Size(64, 20);
            this.mskdTxtCliCEP.TabIndex = 33;
            this.mskdTxtCliCEP.Leave += new System.EventHandler(this.mskdTxtCliCEP_Leave);
            // 
            // mskdTxtCliCel
            // 
            this.mskdTxtCliCel.Location = new System.Drawing.Point(397, 395);
            this.mskdTxtCliCel.Mask = "(00)00000-0000";
            this.mskdTxtCliCel.Name = "mskdTxtCliCel";
            this.mskdTxtCliCel.Size = new System.Drawing.Size(100, 20);
            this.mskdTxtCliCel.TabIndex = 32;
            // 
            // mskdTxtCliFone
            // 
            this.mskdTxtCliFone.Location = new System.Drawing.Point(14, 396);
            this.mskdTxtCliFone.Mask = "(99)0000-0000";
            this.mskdTxtCliFone.Name = "mskdTxtCliFone";
            this.mskdTxtCliFone.Size = new System.Drawing.Size(81, 20);
            this.mskdTxtCliFone.TabIndex = 31;
            // 
            // txtCliNome
            // 
            this.txtCliNome.Location = new System.Drawing.Point(14, 81);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.Size = new System.Drawing.Size(731, 20);
            this.txtCliNome.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(13, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "Nome do Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(395, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(12, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(12, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(12, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(643, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(188, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(109, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "CEP";
            // 
            // lblRgIE
            // 
            this.lblRgIE.AutoSize = true;
            this.lblRgIE.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRgIE.Location = new System.Drawing.Point(395, 155);
            this.lblRgIE.Name = "lblRgIE";
            this.lblRgIE.Size = new System.Drawing.Size(23, 12);
            this.lblRgIE.TabIndex = 16;
            this.lblRgIE.Text = "RG";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(12, 155);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(30, 12);
            this.lblCpfCnpj.TabIndex = 15;
            this.lblCpfCnpj.Text = "CPF";
            // 
            // txtCliEmail
            // 
            this.txtCliEmail.Location = new System.Drawing.Point(14, 349);
            this.txtCliEmail.Name = "txtCliEmail";
            this.txtCliEmail.Size = new System.Drawing.Size(731, 20);
            this.txtCliEmail.TabIndex = 12;
            // 
            // txtCliBairro
            // 
            this.txtCliBairro.Location = new System.Drawing.Point(14, 305);
            this.txtCliBairro.Name = "txtCliBairro";
            this.txtCliBairro.Size = new System.Drawing.Size(731, 20);
            this.txtCliBairro.TabIndex = 11;
            // 
            // txtCliEndNumero
            // 
            this.txtCliEndNumero.Location = new System.Drawing.Point(645, 261);
            this.txtCliEndNumero.Name = "txtCliEndNumero";
            this.txtCliEndNumero.Size = new System.Drawing.Size(100, 20);
            this.txtCliEndNumero.TabIndex = 10;
            this.txtCliEndNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliEndNumero_KeyPress);
            // 
            // txtCliEndereco
            // 
            this.txtCliEndereco.Location = new System.Drawing.Point(14, 261);
            this.txtCliEndereco.Name = "txtCliEndereco";
            this.txtCliEndereco.Size = new System.Drawing.Size(601, 20);
            this.txtCliEndereco.TabIndex = 9;
            // 
            // txtCliCidade
            // 
            this.txtCliCidade.Location = new System.Drawing.Point(190, 216);
            this.txtCliCidade.Name = "txtCliCidade";
            this.txtCliCidade.Size = new System.Drawing.Size(555, 20);
            this.txtCliCidade.TabIndex = 8;
            // 
            // txtCliEstado
            // 
            this.txtCliEstado.Location = new System.Drawing.Point(111, 215);
            this.txtCliEstado.Name = "txtCliEstado";
            this.txtCliEstado.Size = new System.Drawing.Size(44, 20);
            this.txtCliEstado.TabIndex = 7;
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(15, 127);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(730, 20);
            this.txtRSocial.TabIndex = 3;
            this.txtRSocial.Visible = false;
            this.txtRSocial.WordWrap = false;
            // 
            // lblRSocial
            // 
            this.lblRSocial.AutoSize = true;
            this.lblRSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSocial.Location = new System.Drawing.Point(12, 109);
            this.lblRSocial.Name = "lblRSocial";
            this.lblRSocial.Size = new System.Drawing.Size(143, 13);
            this.lblRSocial.TabIndex = 2;
            this.lblRSocial.Text = "Razão Social do Cliente";
            this.lblRSocial.Visible = false;
            // 
            // txtCliCod
            // 
            this.txtCliCod.Enabled = false;
            this.txtCliCod.Location = new System.Drawing.Point(14, 35);
            this.txtCliCod.Name = "txtCliCod";
            this.txtCliCod.Size = new System.Drawing.Size(100, 20);
            this.txtCliCod.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(11, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(107, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Cliente";
            // 
            // mskTextCPFCNPJ
            // 
            this.mskTextCPFCNPJ.Location = new System.Drawing.Point(15, 172);
            this.mskTextCPFCNPJ.Name = "mskTextCPFCNPJ";
            this.mskTextCPFCNPJ.Size = new System.Drawing.Size(109, 20);
            this.mskTextCPFCNPJ.TabIndex = 35;
            // 
            // mskTextRGIE
            // 
            this.mskTextRGIE.Location = new System.Drawing.Point(397, 172);
            this.mskTextRGIE.Name = "mskTextRGIE";
            this.mskTextRGIE.Size = new System.Drawing.Size(106, 20);
            this.mskTextRGIE.TabIndex = 36;
            this.mskTextRGIE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTextRGIE_KeyPress);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmCadastroCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Cliente";
            this.Load += new System.EventHandler(this.frmCadastroDeCliente_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.grpbTipo.ResumeLayout(false);
            this.grpbTipo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRgIE;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtCliEmail;
        private System.Windows.Forms.TextBox txtCliBairro;
        private System.Windows.Forms.TextBox txtCliEndNumero;
        private System.Windows.Forms.TextBox txtCliEndereco;
        private System.Windows.Forms.TextBox txtCliCidade;
        private System.Windows.Forms.TextBox txtCliEstado;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label lblRSocial;
        private System.Windows.Forms.TextBox txtCliCod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mskdTxtCliFone;
        private System.Windows.Forms.MaskedTextBox mskdTxtCliCel;
        private System.Windows.Forms.MaskedTextBox mskdTxtCliCEP;
        private System.Windows.Forms.GroupBox grpbTipo;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.MaskedTextBox mskTextCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox mskTextRGIE;
    }
}