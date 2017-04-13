using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUnidadeDeMedida : Form
    {
        public String operacao = "";
        public frmCadastroUnidadeDeMedida()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtUmedCod.Clear();
            txtUmedNome.Clear();
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

        private void frmUnidadeDeMedidas_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUnidadeDeMedidas modelo = new ModeloUnidadeDeMedidas();
                modelo.UmedNome = txtUmedNome.Text;
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código" + modelo.UmedCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.UmedCod = Convert.ToInt32(txtUmedCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado.");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtUmedCod.Text));
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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                ModeloUnidadeDeMedidas modelo = bll.CarregaModeloUnidadeDeMedidas(f.codigo);
                txtUmedCod.Text = modelo.UmedCod.ToString();
                txtUmedNome.Text = modelo.UmedNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void txtUmedNome_Leave(object sender, EventArgs e)//27.03 pra ver se und de medida existe
        {
            if (this.operacao == "inserir")
            {
                int retorno = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                retorno = bll.VerificaUnidadeDeMedida(txtUmedNome.Text);
                if (retorno > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um Registro com esse valor.\nDeseja alterar o Registro Existente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUnidadeDeMedidas modelo = bll.CarregaModeloUnidadeDeMedidas(retorno);
                        txtUmedCod.Text = modelo.UmedCod.ToString();
                        txtUmedNome.Text = modelo.UmedNome;
                        //alteraBotoes(3);
                    }
                }
            }
        }
    }
}
