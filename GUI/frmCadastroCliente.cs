using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Windows.Forms;
namespace GUI
{
    public partial class frmCadastroCliente : Form
    {
        /*public enum Campo//31/03 formatar cpf cnpj
        {
            CPF = 1,
            CNPJ = 2,
        }

        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;//tamanho máximo do cpf com pontos e traços
                    if (txtTexto.Text.Length == 3)//primeiros 3 digitos coloca um ponto
                    {
                        txtTexto.Text = txtTexto.Text + ".";//coloca um ponto

                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;//3 primeiros digitos + o ponto
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2)//primeiros 2 digitos 
                    {
                        txtTexto.Text = txtTexto.Text + ".";//coloca um ponto

                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;//2 primeiros digitos + o ponto
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }*/
        public String operacao = "";
        public frmCadastroCliente()
        {
            InitializeComponent();
            ValidaCampoCPFCNPJ();
        }

        public void LimpaTela()
        {
            txtCliCod.Clear();
            txtCliNome.Clear();
            //txtCliCPFCNPJ.Clear();
            mskTextCPFCNPJ.Clear();
            //txtCliRGIE.Clear();
            mskTextRGIE.Clear();
            txtRSocial.Clear();
            //txtCliTipo.Clear();//28.03 exclui clitipo txtbox
            //txtCliCEP.Clear();
            mskdTxtCliCEP.Clear();
            txtCliEndereco.Clear();
            txtCliBairro.Clear();
            //txtCliFone.Clear();
            mskdTxtCliFone.Clear();
            //txtCliCel.Clear();
            mskdTxtCliCel.Clear();
            txtCliEmail.Clear();
            txtCliEndNumero.Clear();
            txtCliCidade.Clear();
            txtCliEstado.Clear();
            rbFisica.Checked = true;// 28.03 pra ficar checked padrão
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
                //rbFisica.Enabled = false;//28.03 pra não mudar física pra jurídica
                //rbJuridica.Enabled = false;//28/03
            }

            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }


        private void ValidaCampoCPFCNPJ()
        {
            if (rbFisica.Checked == true)
            {
                mskTextCPFCNPJ.Mask = "000,000,000-00";
                mskTextRGIE.Mask = "99,000,000-0";
            }
            else
            {
                mskTextCPFCNPJ.Mask = "00,000,000/0000-00";
                mskTextRGIE.Mask = "000,000,000,000";
            }
        }
        private void frmCadastroDeCliente_Load(object sender, EventArgs e)
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtCliNome.Text;
                //modelo.CliCPFCNPJ = txtCliCPFCNPJ.Text;
                modelo.CliCPFCNPJ = mskTextCPFCNPJ.Text;
                //modelo.CliRGIE = txtCliRGIE.Text;
                modelo.CliRGIE = mskTextRGIE.Text;
                modelo.CliRSocial = txtRSocial.Text;
                //modelo.CliTipo = Convert.ToInt32(txtCliTipo.Text);//28/03 excluiu clitipotext
                //modelo.CliCEP = txtCliCEP.Text;
                modelo.CliCEP = mskdTxtCliCEP.Text;
                modelo.CliEndereco = txtCliEndereco.Text;
                modelo.CliBairro = txtCliBairro.Text;
                //modelo.CliFone = txtCliFone.Text;
                modelo.CliFone = mskdTxtCliFone.Text;
                //modelo.CliCel = txtCliCel.Text;
                modelo.CliCel = mskdTxtCliCel.Text;
                modelo.CliEmail = txtCliEmail.Text;
                modelo.CliEndNumero = txtCliEndNumero.Text;
                modelo.CliCidade = txtCliCidade.Text;
                modelo.CliEstado = txtCliEstado.Text;

                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = 0;//fisica
                    modelo.CliRSocial = "-";
                }
                else
                {
                    modelo.CliTipo = 1;//juridica
                }

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código" + modelo.CliCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.CliCod = Convert.ToInt32(txtCliCod.Text);
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
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
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
            f.Dispose();
        }

        private void txtCliTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void mskTextCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)//validar  cpf cnpj
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void mskTextRGIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtCliCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtCliEndNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtCliFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtCliCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)//28.03 pra mostrar ou não rsocial dependendo  do radio button cpf cnpj
        {
            if (rbFisica.Checked == true)
            {
                lblRSocial.Visible = false;
                txtRSocial.Visible = false;
                lblCpfCnpj.Text = "CPF";
                lblRgIE.Text = "RG";
                ValidaCampoCPFCNPJ();
            }
            else
            {
                lblRSocial.Visible = true;
                txtRSocial.Visible = true;
                lblCpfCnpj.Text = "CNPJ";
                lblRgIE.Text = "IE";
                ValidaCampoCPFCNPJ();
            }
        }

        private void mskdTxtCliCEP_Leave(object sender, EventArgs e)//28.03
        {
            if (BuscaEndereco.verificaCEP(mskdTxtCliCEP.Text) == true)
            {
                txtCliEstado.Text = BuscaEndereco.estado;
                txtCliCidade.Text = BuscaEndereco.cidade;
                txtCliEndereco.Text = BuscaEndereco.endereco;
                txtCliBairro.Text = BuscaEndereco.bairro;
            }
            else
            {
                //limpa campos
            }
        }

        /*private void txtCliCPFCNPJ_Leave(object sender, EventArgs e)
        {
            lbIncorreto.Visible = false;
            if (rbFisica.Checked == true)//cpf
            {
                if (Validacao.IsCPF(txtCliCPFCNPJ.Text) == false)
                {
                    lbIncorreto.Visible = true;
                }
            }
            else
            {
                if (Validacao.IsCNPJ(txtCliCPFCNPJ.Text) == true)
                {
                    lbIncorreto.Visible = true;
                }
            }
        }*/


    }
}

