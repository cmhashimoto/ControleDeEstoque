using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.Localizar(txtValor.Text);
            }
            else if (rbDescricao.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorDescricao(txtValor.Text);
            }
            else if (rbNomeCategoria.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNomeCat(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCodigo(txtValor.Text);
            }

            //dgvDados.DataSource = bll.Localizar(txtValor.Text);

            /* dgvDados.Columns[0].HeaderText = "Código";
             //dgvDados.Columns[0].Width = 53;
             dgvDados.Columns[1].HeaderText = "Produto";
             //dgvDados.Columns[1].Width = 660;
             dgvDados.Columns[2].HeaderText = "Descrição";
             //dgvDados.Columns[2].Width = 53;
             dgvDados.Columns[3].HeaderText = "Foto";
             //dgvDados.Columns[3].Width = 60;
             dgvDados.Columns[4].HeaderText = "Valor Pago";
             //dgvDados.Columns[4].Width = 10;
             dgvDados.Columns[5].HeaderText = "Valor de Venda";
             //dgvDados.Columns[5].Width = 660;
             dgvDados.Columns[6].HeaderText = "Quantidade";
             //dgvDados.Columns[6].Width = 53;
             dgvDados.Columns[7].HeaderText = "Unidade de Medida";
             //dgvDados.Columns[7].Width = 660;
             dgvDados.Columns[8].HeaderText = "Categoria";
             //dgvDados.Columns[8].Width = 660;
             dgvDados.Columns[9].HeaderText = "SubCategoria";
             //dgvDados.Columns[9].Width = 660;
             dgvDados.Columns[10].HeaderText = "Unidade de Medida";
             //dgvDados.Columns[10].Width = 660;
             dgvDados.Columns[11].HeaderText = "Categoria";
             //dgvDados.Columns[11].Width = 660;
             dgvDados.Columns[12].HeaderText = "SubCategoria";
             //dgvDados.Columns[12].Width = 53;

             //ocultar colunas
             dgvDados.Columns["cat_cod"].Visible = false;
             dgvDados.Columns["pro_foto"].Visible = false;
             dgvDados.Columns["pro_valorpago"].Visible = false;
             dgvDados.Columns["scat_cod"].Visible = false;
             dgvDados.Columns["umed_cod"].Visible = false;*/
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            //dgvDados.Columns[0].Width = 53;
            dgvDados.Columns[1].HeaderText = "Produto";
            //dgvDados.Columns[1].Width = 660;
            dgvDados.Columns[2].HeaderText = "Descrição";
            //dgvDados.Columns[2].Width = 53;
            dgvDados.Columns[3].HeaderText = "Foto";
            //dgvDados.Columns[3].Width = 60;
            dgvDados.Columns[4].HeaderText = "Valor Pago";
            //dgvDados.Columns[4].Width = 10;
            //dgvDados.Columns[4].DefaultCellStyle.Format = "c";//01/04
            dgvDados.Columns[5].HeaderText = "Valor de Venda";
            //dgvDados.Columns[5].Width = 660;
            dgvDados.Columns[5].DefaultCellStyle.Format = "c";
            dgvDados.Columns[6].HeaderText = "Quantidade";
            //dgvDados.Columns[6].Width = 53;
            dgvDados.Columns[7].HeaderText = "Unidade de Medida";
            //dgvDados.Columns[7].Width = 660;
            dgvDados.Columns[8].HeaderText = "Categoria";
            //dgvDados.Columns[8].Width = 660;
            dgvDados.Columns[9].HeaderText = "SubCategoria";
            //dgvDados.Columns[9].Width = 660;
            dgvDados.Columns[10].HeaderText = "Unidade de Medida";
            //dgvDados.Columns[10].Width = 660;
            dgvDados.Columns[11].HeaderText = "Categoria";
            //dgvDados.Columns[11].Width = 660;
            dgvDados.Columns[12].HeaderText = "SubCategoria";
            //dgvDados.Columns[12].Width = 53;

            //ocultar colunas
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["pro_foto"].Visible = false;
            dgvDados.Columns["pro_valorpago"].Visible = false;
            dgvDados.Columns["scat_cod"].Visible = false;
            dgvDados.Columns["umed_cod"].Visible = false;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            btnLocalizar_Click(sender, e);
        }
    }
}
