using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCategoria : Form
    {
        public int codigo = 0;
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            if (rbNome.Checked == true)//28/03 pra localizar por nome ou cnpj
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCodigo(txtValor.Text);
            }
            //dgvDados.DataSource = bll.Localizar(txtValor.Text);
            /*dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 53;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 660;*/
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)//pra não carregar no load
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 53;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 660;
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
