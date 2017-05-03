using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMovimentoCompra : Form
    {
        public double totalCompra = 0;//dado privado
        public String operacao = "";
        public frmMovimentoCompra()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtComCod.Clear();
            txtNFiscal.Clear();
            txtForCod.Clear();
            txtProCod.Clear();
            lblFornecedor.Text = "Informe o Código do Fornecedor ou Clique em Localizar...";
            lblProduto.Text = "Informe o Código do Produto ou Clique em Localizar...";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear();
        }

        public void alteraBotoes(int op)
        {
            pnlDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;

            if (op == 1)//load
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }

            if (op == 2)//inserir
            {
                pnlDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalCompra = 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.alteraBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            /*frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCliCod.Text = modelo.CliCod.ToString();
                if (modelo.CliTipo == 0)
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
                }
                txtCliNome.Text = modelo.CliNome;
                mskTextCPFCNPJ.Text = modelo.CliCPFCNPJ;
                mskTextRGIE.Text = modelo.CliRGIE;
                txtRSocial.Text = modelo.CliRSocial;
                //txtCliTipo.Text = Convert.ToString(modelo.CliTipo);//25.06 por ser int//28.03
                //txtCliCEP.Text = modelo.CliCEP;//mudou para maskedtextbox
                mskdTxtCliCEP.Text = modelo.CliCEP;
                txtCliEndereco.Text = modelo.CliEndereco;
                txtCliBairro.Text = modelo.CliBairro;
                //txtCliFone.Text = modelo.CliFone;
                mskdTxtCliFone.Text = modelo.CliFone;
                //txtCliCel.Text = modelo.CliCel;
                mskdTxtCliCel.Text = modelo.CliCel;
                txtCliEmail.Text = modelo.CliEmail;
                txtCliEndNumero.Text = modelo.CliEndNumero;
                txtCliCidade.Text = modelo.CliCidade;
                txtCliEstado.Text = modelo.CliEstado;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();*/
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            /*try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    bll.Excluir(Convert.ToInt32(txtCliCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.\n\n" + er.Message);
                this.alteraBotoes(3);
            }*/
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dgvParcelas.Rows.Clear();//04/04/2017
            int parcelas = Convert.ToInt32(cbNParcelas.Text);
            //double totalLocal = Convert.ToDouble(txtTotalCompra.Text); ou
            double totalLocal = this.totalCompra;
            double valorParcela = Math.Round((totalLocal / parcelas), 2, MidpointRounding.AwayFromZero); //valor = this.total / parcelas;
            DateTime dt = new DateTime();
            dt = dtpDataInicial.Value;
            double totalParcelado = valorParcela * parcelas;
            lblTotal.Text = totalParcelado.ToString();

            for (int i = 1; i <= parcelas; i++)//definição do mês de pagto da parcela
            {
                String[] k = new String[] { i.ToString(), valorParcela.ToString(), dt.Date.ToShortDateString() };//vetor de String
                this.dgvParcelas.Rows.Add(k);
                if (dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
            }
            pnlFinalizaCompra.Visible = true;
            this.btnCancelar.Enabled = false;
            this.btnSalvar.Enabled = false;
        }

        private void btnLocFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                //chamada para o metodo txtForCod pra passar o codigo,
                //chamar o leave pra lbl receber o nome do fornecedor
                txtForCod_Leave(sender, e);
            }
        }

        private void txtForCod_Leave(object sender, EventArgs e)//qdo sair do campo verifica se codigo do fornecedor esta correto.
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                lblFornecedor.Text = modelo.ForNome;//todas as linhas pra receber o nome do fornecedor
            }
            catch
            {
                lblFornecedor.Text = "Informe o Código do Fornecedor ou Clique em Localizar...";
                txtForCod.Clear();
            }
        }

        private void frmMovimentoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //comboBox
            BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
            cbTipoPagto.DataSource = bll.Localizar("");//combobox
            cbTipoPagto.DisplayMember = "tpa_nome";
            cbTipoPagto.ValueMember = "tpa_cod";
            cbNParcelas.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))//ver se os campos estão vazios
            {
                Double totalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                this.totalCompra = this.totalCompra + totalLocal;
                String[] i = new String[] { txtProCod.Text, lblProduto.Text, txtQtde.Text, txtValor.Text, totalLocal.ToString() };//definindo o que inserir no dgv através de vetor
                this.dgvItens.Rows.Add(i);//inserindo no dgv

                //limpar campos após inserir
                txtProCod.Clear();
                //txtForCod.Clear();<<<<<< anula o valor de fornecedor.text
                lblFornecedor.Text = "Informe o Código do Fornecedor ou Clique em Localizar...";
                lblProduto.Text = "Informe o Código do Produto ou Clique em Localizar...";
                txtQtde.Clear();
                txtValor.Clear();
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }

        private void btnLocProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();
                //chamada para o metodo txtProCod
                txtProCod_Leave(sender, e);
            }
            btnSub.Enabled = true;
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lblProduto.Text = modelo.ProNome;//todas as linhas pra receber o nome do fornecedor

                txtQtde.Text = "1";
                txtValor.Text = modelo.ProValorVenda.ToString();
            }
            catch
            {
                lblProduto.Text = "Informe o Código do Produto ou Clique em Localizar...";
                txtForCod.Clear();
            }
        }



        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//para editar novamente a compra
        {
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                //txtValor.Text = Math.Round(Convert.ToDouble(txtValor.Text), 2).ToString();//<<<<<<<<<<<<
                double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtQtde.Clear();
            txtProCod.Clear();
            lblProduto.Text = "Informe o Código do Produto ou Clique em Localizar...";
            btnSub.Enabled = false;
        }

        private void btnSalvarParcelas_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloCompra modelo = new ModeloCompra();
                modelo.ComData = dtpDataCompra.Value;
                modelo.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modelo.ComNparcelas = Convert.ToInt32(cbNParcelas.Text);
                modelo.ComStatus = 1;
                modelo.ComTotal = this.totalCompra;
                modelo.ForCod = Convert.ToInt32(txtForCod.Text);
                modelo.TpaCod = Convert.ToInt32(cbTipoPagto.SelectedValue);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                if (this.operacao == "inserir")//cadastrar compra
                {
                    bll.Incluir(modelo);
                    //itens da compra e parcelas
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;//pra que o 1o item receba 1
                        mitens.ComCod = modelo.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToInt32(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                    }
                    btnSalvarParcelas.Enabled = false;
                    MessageBox.Show("Compra efetuada.\n Código: " + modelo.ComCod.ToString()+"\n NF: "+modelo.ComNFiscal);

                }
                else//alterar compra
                {

                }
                this.LimpaTela();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void btnCancelarParcelas_Click(object sender, EventArgs e)
        {
            pnlFinalizaCompra.Visible = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}