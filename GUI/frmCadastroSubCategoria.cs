using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroSubCategoria : Form
    {
        public String operacao = "";
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtSCatCod.Clear();
            txtCatCod.Clear();
            txtSCatNome.Clear();
            //cbCatCod limpar
            //cbCatCod.ResetText();
        }

        public void alteraBotoes(int op)
        {
            pnlDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }

            if (op == 2)
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
        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCatCod.DataSource = bll.Localizar("");//carrega o combobox
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
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
            this.cbCatCod.Enabled = false;
            this.btnNovaCategoria.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura de dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.SCatNome = txtSCatNome.Text;
                //modelo.CatCod = Convert.ToInt32(txtCatCod.Text);//caso codigo informado no textbox
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue);
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código" + modelo.SCatCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.SCatCod = Convert.ToInt32(txtSCatCod.Text);
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
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtSCatCod.Text), Convert.ToInt32(cbCatCod.SelectedValue));//22.03.2017_problema com cadeia de caracteres,txtCatCod->cbCatCod.SelectedValue
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

            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if (f.scatcod != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.scatcod, f.catcod);
                txtSCatCod.Text = modelo.SCatCod.ToString();
                txtSCatNome.Text = modelo.SCatNome;
                txtCatCod.Text = modelo.CatCod.ToString();//????22.03.2017,txtCatCod mudado->excluido qdo deletado o txtCatCod no GUI e colocado de novo pra mostrar o código da categoria
                cbCatCod.SelectedValue = modelo.CatCod;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void cbCatCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCatCod.Text = cbCatCod.Text;
        }

        private void txtSCatNome_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int retorno = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                retorno = bll.VerificaSubCategoria(txtSCatNome.Text);
                if (retorno > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um Registro com esse valor.\nDeseja alterar o Registro Existente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(retorno, 0);//とりあえず , 0????
                        txtSCatCod.Text = modelo.CatCod.ToString();
                        txtSCatNome.Text = modelo.SCatNome;
                        alteraBotoes(3);
                    }
                }
            }
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)//28/03--inserir nova categoria
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCatCod.DataSource = bll.Localizar("");//carrega o combobox
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }
    }
}
