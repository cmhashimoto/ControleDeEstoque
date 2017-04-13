using BLL;
using DAL;
using Modelo;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroProduto : Form//29.03
    {
        public String foto = "";//prop que vai representar foto
        public String operacao = "";
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtValorPago.Text = "";
            txtValorVenda.Text = "";
            txtQtde.Text = "";
            this.foto = "";
            picboxFoto.Image = null;
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


        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);//<<<
            //carregar o combobox
            cboxCategoria.DataSource = bll.Localizar("");//carrega o combobox da categoria 29.03
            cboxCategoria.DisplayMember = "cat_nome";
            cboxCategoria.ValueMember = "cat_cod";
            //auto-completeMode não funciona com dropdown style
            /*cboxCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboxCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;*/
            /////////////////////////////////////////////////////
            /*BLLSubCategoria sbll = new BLLSubCategoria(cx);<<<<<<<<<<<<<<<<Foi pro cboxcategoria selected index changed
            //cboxScategoria.DataSource = sbll.Localizar("");//carrega o combobox da subcategoria 29.03
            cboxSCategoria.DataSource = sbll.LocalizarPorCategoria((int)cboxCategoria.SelectedValue);//carrega o combobox da subcategoria 29.03
            cboxSCategoria.DisplayMember = "scat_nome";
            cboxSCategoria.ValueMember = "scat_cod";*/
            try
            {
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                //cboxScategoria.DataSource = sbll.Localizar("");//carrega o combobox da subcategoria 29.03
                cboxSCategoria.DataSource = sbll.LocalizarPorCategoria((int)cboxCategoria.SelectedValue);//carrega o combobox da subcategoria 29.03
                cboxSCategoria.DisplayMember = "scat_nome";
                cboxSCategoria.ValueMember = "scat_cod";
            }
            catch
            {
            }
            ////////////////////////////////////////////////////
            BLLUnidadeDeMedida umebll = new BLLUnidadeDeMedida(cx);
            cboxUMedida.DataSource = umebll.Localizar("");//carrega o combobox da unidade de medida 29.03
            cboxUMedida.DisplayMember = "umed_nome";
            cboxUMedida.ValueMember = "umed_cod";
        }

        private void cboxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                cboxSCategoria.Text = "";
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cboxSCategoria.DataSource = sbll.LocalizarPorCategoria((int)cboxCategoria.SelectedValue);
                cboxSCategoria.DisplayMember = "scat_nome";
                cboxSCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)//29.03
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))//só aparece uma vez
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)//29.03 insere .00 no final
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)//somente inteiros por isso não tem eventp leave;
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 /*&& e.KeyChar != ',' && e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }
            /*if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQtde.Text.Contains(","))//só aparece uma vez
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }*/
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            /*if (txtQtde.Text.Contains(",") == false)
            {
                txtQtde.Text += ",00";
            }
            else
            {
                if (txtQtde.Text.IndexOf(",") == txtQtde.Text.Length - 1)
                {
                    txtQtde.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtQtde.Text);
            }
            catch
            {
                txtQtde.Text = "0,00";
            }*/
        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!String.IsNullOrEmpty(ofd.FileName))
            {
                this.foto = ofd.FileName;
                picboxFoto.Load(this.foto);
            }
        }

        private void btnRemoveFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            picboxFoto.Image = null;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                //mostrar os dados na tela
                txtCodigo.Text = modelo.ProCod.ToString();
                txtDescricao.Text = modelo.ProDescricao;
                txtNome.Text = modelo.ProNome;
                txtQtde.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString("N2");//txtValorPago = modelo.ProValorPago.ToString("N2"); 2 casas  apos , 
                txtValorVenda.Text = modelo.ProValorVenda.ToString("N2");
                cboxCategoria.SelectedValue = modelo.CatCod;
                cboxSCategoria.SelectedValue = modelo.ScatCod;
                cboxUMedida.SelectedValue = modelo.UmedCod;
                //foto
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    picboxFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch
                {
                }
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
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
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Math.Round(Convert.ToDouble(txtValorPago.Text), 2);
                modelo.ProValorVenda = Math.Round(Convert.ToDouble(txtValorVenda.Text), 2);
                modelo.ProQtde = Convert.ToInt32(txtQtde.Text);
                modelo.UmedCod = Convert.ToInt32(cboxUMedida.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cboxCategoria.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cboxSCategoria.SelectedValue);
                //modelo.CarregaImagem(this.foto);
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um produto
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código" + modelo.ProCod.ToString());
                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                    //alterar um produto
                    if (this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);//modelo temp
                        modelo.ProFoto = mt.ProFoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
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

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }
    }
}

