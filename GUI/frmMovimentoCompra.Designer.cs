namespace GUI
{
    partial class frmMovimentoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentoCompra));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.pnlFinalizaCompra = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvarParcelas = new System.Windows.Forms.Button();
            this.btnCancelarParcelas = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLocProduto = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnLocFornecedor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proVUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.cbTipoPagto = new System.Windows.Forms.ComboBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.txtComCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 451);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(760, 106);
            this.pnlBotoes.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(540, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 81);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(411, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 81);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(669, 16);
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
            this.btnLocalizar.Location = new System.Drawing.Point(153, 16);
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
            this.btnAlterar.Location = new System.Drawing.Point(282, 16);
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
            this.btnInserir.Location = new System.Drawing.Point(24, 16);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(81, 81);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Incluir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.pnlFinalizaCompra);
            this.pnlDados.Controls.Add(this.label16);
            this.pnlDados.Controls.Add(this.label15);
            this.pnlDados.Controls.Add(this.btnSub);
            this.pnlDados.Controls.Add(this.label11);
            this.pnlDados.Controls.Add(this.btnAdd);
            this.pnlDados.Controls.Add(this.label14);
            this.pnlDados.Controls.Add(this.txtValor);
            this.pnlDados.Controls.Add(this.txtQtde);
            this.pnlDados.Controls.Add(this.label13);
            this.pnlDados.Controls.Add(this.label12);
            this.pnlDados.Controls.Add(this.btnLocProduto);
            this.pnlDados.Controls.Add(this.lblProduto);
            this.pnlDados.Controls.Add(this.label10);
            this.pnlDados.Controls.Add(this.txtProCod);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.lblFornecedor);
            this.pnlDados.Controls.Add(this.btnLocFornecedor);
            this.pnlDados.Controls.Add(this.label8);
            this.pnlDados.Controls.Add(this.txtForCod);
            this.pnlDados.Controls.Add(this.dgvItens);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.dtpDataInicial);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.cbNParcelas);
            this.pnlDados.Controls.Add(this.cbTipoPagto);
            this.pnlDados.Controls.Add(this.txtTotalCompra);
            this.pnlDados.Controls.Add(this.dtpDataCompra);
            this.pnlDados.Controls.Add(this.txtNFiscal);
            this.pnlDados.Controls.Add(this.txtComCod);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDados.Location = new System.Drawing.Point(12, 3);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(760, 442);
            this.pnlDados.TabIndex = 2;
            // 
            // pnlFinalizaCompra
            // 
            this.pnlFinalizaCompra.Controls.Add(this.lblTotal);
            this.pnlFinalizaCompra.Controls.Add(this.label20);
            this.pnlFinalizaCompra.Controls.Add(this.btnSalvarParcelas);
            this.pnlFinalizaCompra.Controls.Add(this.btnCancelarParcelas);
            this.pnlFinalizaCompra.Controls.Add(this.label18);
            this.pnlFinalizaCompra.Controls.Add(this.label19);
            this.pnlFinalizaCompra.Controls.Add(this.label17);
            this.pnlFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnlFinalizaCompra.Location = new System.Drawing.Point(0, 0);
            this.pnlFinalizaCompra.Name = "pnlFinalizaCompra";
            this.pnlFinalizaCompra.Size = new System.Drawing.Size(760, 554);
            this.pnlFinalizaCompra.TabIndex = 4;
            this.pnlFinalizaCompra.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotal.Location = new System.Drawing.Point(489, 396);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 14);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(354, 396);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 14);
            this.label20.TabIndex = 5;
            this.label20.Text = "Total da Compra R$";
            // 
            // btnSalvarParcelas
            // 
            this.btnSalvarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarParcelas.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarParcelas.Image")));
            this.btnSalvarParcelas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvarParcelas.Location = new System.Drawing.Point(610, 104);
            this.btnSalvarParcelas.Name = "btnSalvarParcelas";
            this.btnSalvarParcelas.Size = new System.Drawing.Size(81, 81);
            this.btnSalvarParcelas.TabIndex = 22;
            this.btnSalvarParcelas.Text = "Salvar";
            this.btnSalvarParcelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarParcelas.UseVisualStyleBackColor = true;
            this.btnSalvarParcelas.Click += new System.EventHandler(this.btnSalvarParcelas_Click);
            // 
            // btnCancelarParcelas
            // 
            this.btnCancelarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarParcelas.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarParcelas.Image")));
            this.btnCancelarParcelas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarParcelas.Location = new System.Drawing.Point(610, 257);
            this.btnCancelarParcelas.Name = "btnCancelarParcelas";
            this.btnCancelarParcelas.Size = new System.Drawing.Size(81, 81);
            this.btnCancelarParcelas.TabIndex = 21;
            this.btnCancelarParcelas.Text = "Voltar";
            this.btnCancelarParcelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarParcelas.UseVisualStyleBackColor = true;
            this.btnCancelarParcelas.Click += new System.EventHandler(this.btnCancelarParcelas_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(3, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(749, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "_________________________________________________________________________________" +
    "_________________________\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(3, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Parcelas da Compra";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(3, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Dados do Pagamento";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(3, 67);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(601, 325);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da Parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data do Vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(549, 415);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "R$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(511, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "R$";
            // 
            // btnSub
            // 
            this.btnSub.Enabled = false;
            this.btnSub.Image = global::GUI.Properties.Resources.shoppingCart___Copy;
            this.btnSub.Location = new System.Drawing.Point(697, 114);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(53, 36);
            this.btnSub.TabIndex = 34;
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(127, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Duplo clique na linha do Produto para Editar...";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::GUI.Properties.Resources.shoppingCart1;
            this.btnAdd.Location = new System.Drawing.Point(697, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 36);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Itens da Compra";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(540, 169);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 20);
            this.txtValor.TabIndex = 27;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(336, 169);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(156, 20);
            this.txtQtde.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(565, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Valor Unitário";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Quantidade";
            // 
            // btnLocProduto
            // 
            this.btnLocProduto.Location = new System.Drawing.Point(192, 166);
            this.btnLocProduto.Name = "btnLocProduto";
            this.btnLocProduto.Size = new System.Drawing.Size(75, 23);
            this.btnLocProduto.TabIndex = 23;
            this.btnLocProduto.Text = "Localizar";
            this.btnLocProduto.UseVisualStyleBackColor = true;
            this.btnLocProduto.Click += new System.EventHandler(this.btnLocProduto_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProduto.Location = new System.Drawing.Point(5, 153);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(313, 13);
            this.lblProduto.TabIndex = 22;
            this.lblProduto.Text = "Informe o Código do Produto ou Clique em Localizar...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Código do Produto";
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(5, 169);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(178, 20);
            this.txtProCod.TabIndex = 20;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(5, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(630, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "_________________________________________________________________________________" +
    "________\r\n";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFornecedor.Location = new System.Drawing.Point(3, 76);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(333, 13);
            this.lblFornecedor.TabIndex = 18;
            this.lblFornecedor.Text = "Informe o Código do Fornecedor ou Clique em Localizar...";
            // 
            // btnLocFornecedor
            // 
            this.btnLocFornecedor.Location = new System.Drawing.Point(192, 90);
            this.btnLocFornecedor.Name = "btnLocFornecedor";
            this.btnLocFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnLocFornecedor.TabIndex = 17;
            this.btnLocFornecedor.Text = "Localizar";
            this.btnLocFornecedor.UseVisualStyleBackColor = true;
            this.btnLocFornecedor.Click += new System.EventHandler(this.btnLocFornecedor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Código do Fornecedor";
            // 
            // txtForCod
            // 
            this.txtForCod.Location = new System.Drawing.Point(5, 92);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(181, 20);
            this.txtForCod.TabIndex = 15;
            this.txtForCod.Leave += new System.EventHandler(this.txtForCod_Leave);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.proNome,
            this.proQtde,
            this.proVUnit,
            this.proVTotal});
            this.dgvItens.Location = new System.Drawing.Point(3, 227);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(754, 165);
            this.dgvItens.TabIndex = 14;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Código";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 60;
            // 
            // proNome
            // 
            this.proNome.HeaderText = "Nome do Produto";
            this.proNome.Name = "proNome";
            this.proNome.ReadOnly = true;
            this.proNome.Width = 350;
            // 
            // proQtde
            // 
            this.proQtde.HeaderText = "Quantidade";
            this.proQtde.Name = "proQtde";
            this.proQtde.ReadOnly = true;
            // 
            // proVUnit
            // 
            this.proVUnit.HeaderText = "Valor Unitário";
            this.proVUnit.Name = "proVUnit";
            this.proVUnit.ReadOnly = true;
            // 
            // proVTotal
            // 
            this.proVTotal.HeaderText = "Valor Total";
            this.proVTotal.Name = "proVTotal";
            this.proVTotal.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data Inicial do Pagamento";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(302, 412);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(114, 20);
            this.dtpDataInicial.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Número de Parcelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total da Compra";
            // 
            // cbNParcelas
            // 
            this.cbNParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNParcelas.FormattingEnabled = true;
            this.cbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcelas.Location = new System.Drawing.Point(3, 411);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 8;
            // 
            // cbTipoPagto
            // 
            this.cbTipoPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPagto.FormattingEnabled = true;
            this.cbTipoPagto.Location = new System.Drawing.Point(133, 411);
            this.cbTipoPagto.Name = "cbTipoPagto";
            this.cbTipoPagto.Size = new System.Drawing.Size(146, 21);
            this.cbTipoPagto.TabIndex = 7;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(578, 412);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(172, 20);
            this.txtTotalCompra.TabIndex = 6;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(568, 22);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(114, 20);
            this.dtpDataCompra.TabIndex = 5;
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.Location = new System.Drawing.Point(192, 22);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(335, 20);
            this.txtNFiscal.TabIndex = 4;
            // 
            // txtComCod
            // 
            this.txtComCod.Enabled = false;
            this.txtComCod.Location = new System.Drawing.Point(3, 22);
            this.txtComCod.Name = "txtComCod";
            this.txtComCod.Size = new System.Drawing.Size(183, 20);
            this.txtComCod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "購入日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número da NF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "コード";
            // 
            // frmMovimentoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMovimentoCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação - Formulário de Compra";
            this.Load += new System.EventHandler(this.frmMovimentoCompra_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlFinalizaCompra.ResumeLayout(false);
            this.pnlFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Button btnLocFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.ComboBox cbTipoPagto;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.TextBox txtComCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLocProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn proVUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn proVTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlFinalizaCompra;
        private System.Windows.Forms.Button btnSalvarParcelas;
        private System.Windows.Forms.Button btnCancelarParcelas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label lblTotal;
    }
}