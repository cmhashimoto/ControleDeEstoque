using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroTipoDePagamento : Form
    {
        public String operacao = "";
        public frmCadastroTipoDePagamento()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtTpaCod.Clear();
            txtTpaNome.Clear();
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

            if (op == 3)//alterar
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        private void frmCadastroTipoDePagamento_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoDePagamento f = new frmConsultaTipoDePagamento();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
                ModeloTipoDePagamento modelo = bll.CarregaModeloTipoDePagamento(f.codigo);
                txtTpaCod.Text = modelo.TpaCod.ToString();
                txtTpaNome.Text = modelo.TpaNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.txtTpaCod.Enabled = false;//24.03.2017 pra não mudar código;
            this.alteraBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
                    bll.Excluir(Convert.ToInt32(txtTpaCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.\n\n" + erro.Message);
                this.alteraBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloTipoDePagamento modelo = new ModeloTipoDePagamento();
                modelo.TpaNome = txtTpaNome.Text;
                modelo.TpaCod = Convert.ToInt32(txtTpaCod.Text);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código" + modelo.TpaCod.ToString());
                }
                else
                {
                    modelo.TpaCod = Convert.ToInt32(txtTpaCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado.");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch //(Exception erro)
            {
                MessageBox.Show("O Código informado já existe. Informe outro.\n\n\n" /*+ erro.Message*/);//27/03 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void txtTpaNome_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int retorno = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
                retorno = bll.VerificaTipoDePagamento(txtTpaNome.Text);
                if (retorno > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um Registro com esse valor.\nDeseja alterar o Registro Existente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloTipoDePagamento modelo = bll.CarregaModeloTipoDePagamento(retorno);
                        txtTpaCod.Text = modelo.TpaCod.ToString();
                        this.txtTpaCod.Enabled = false;
                        txtTpaNome.Text = modelo.TpaNome;
                        //alteraBotoes(3);
                    }
                }
            }
        }
    }
}
