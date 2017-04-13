using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroFornecedor : Form
    {
        public String operacao = "";
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtForCod.Clear();
            txtForNome.Clear();
            txtForRSocial.Clear();
            //txtForCNPJ.Clear();
            mskdTxtForCNPJ.Clear();
            //txtForIE.Clear();
            mskdTxtForIE.Clear();
            //txtForCEP.Clear();                        //27.03pra limpar
            mskdTxtForCEP.Clear();
            txtForEstado.Clear();
            txtForCidade.Clear();
            txtForRua.Clear();
            txtForEndNumero.Clear();
            txtForBairro.Clear();
            txtForEmail.Clear();
            //txtForFone.Clear();
            mskdTxtForFone.Clear();
            //txtForCel.Clear();
            mskdTxtForCel.Clear();
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

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
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
                //leitura de dados
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txtForNome.Text;
                modelo.ForRSocial = txtForRSocial.Text;
                //modelo.ForCNPJ = txtForCNPJ.Text;
                modelo.ForCNPJ = mskdTxtForCNPJ.Text;
                //modelo.ForIE = txtForIE.Text;
                modelo.ForIE = mskdTxtForIE.Text;
                //modelo.ForCEP = txtForCEP.Text;                //27.03mudado pra maskedtextbox
                modelo.ForCEP = mskdTxtForCEP.Text;
                modelo.ForEstado = txtForEstado.Text;
                modelo.ForCidade = txtForCidade.Text;
                modelo.ForEndereco = txtForRua.Text;
                modelo.ForEndNumero = txtForEndNumero.Text;
                modelo.ForBairro = txtForBairro.Text;
                modelo.ForEmail = txtForEmail.Text;
                //modelo.ForFone = txtForFone.Text;
                modelo.ForFone = mskdTxtForFone.Text;
                //modelo.ForCel = txtForCel.Text;
                modelo.ForCel = mskdTxtForCel.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código" + modelo.ForCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.ForCod = Convert.ToInt32(txtForCod.Text);
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
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    bll.Excluir(Convert.ToInt32(txtForCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.\n\n" + er.Message);
                this.alteraBotoes(3);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtForCod.Text = modelo.ForCod.ToString();
                txtForNome.Text = modelo.ForNome;
                txtForRSocial.Text = modelo.ForRSocial;
                //txtForCNPJ.Text = modelo.ForCNPJ;
                mskdTxtForCNPJ.Text = modelo.ForCNPJ;
                //txtForIE.Text = modelo.ForIE;
                mskdTxtForIE.Text = modelo.ForIE;
                //txtForCEP.Text = modelo.ForCEP;               //mudado pra masked textbox
                mskdTxtForCEP.Text = modelo.ForCEP;
                txtForEstado.Text = modelo.ForEstado;
                txtForCidade.Text = modelo.ForCidade;
                txtForRua.Text = modelo.ForEndereco;
                txtForEndNumero.Text = modelo.ForEndNumero;
                txtForBairro.Text = modelo.ForBairro;
                txtForEmail.Text = modelo.ForEmail;
                //txtForFone.Text = modelo.ForFone;
                mskdTxtForFone.Text = modelo.ForFone;
                //txtForCel.Text = modelo.ForCel;
                mskdTxtForCel.Text = modelo.ForCel;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        /// <summary>pra inserir só números
        private void txtForIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtForCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtForCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtForEndNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtForFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtForCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void mskdTxtForCEP_Leave(object sender, EventArgs e)//28.03
        {
            if (BuscaEndereco.verificaCEP(mskdTxtForCEP.Text) == true)
            {
                txtForEstado.Text = BuscaEndereco.estado;
                txtForCidade.Text = BuscaEndereco.cidade;
                txtForRua.Text = BuscaEndereco.endereco;
                txtForBairro.Text = BuscaEndereco.bairro;
            }
            else
            {
                //limpa campos
            }
        }
    }
}
