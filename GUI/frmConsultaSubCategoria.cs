using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaSubCategoria : Form
    {
        public int scatcod = 0;
        public int catcod = 0;
        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else if (rbCatCod.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorCatNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorSubCod(txtValor.Text);
            }
            //dgvDados.DataSource = bll.Localizar(txtValor.Text);
            /*dgvDados.Columns[0].HeaderText = "Código da SubCategoria";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "Descrição da SubCategoria";
            dgvDados.Columns[1].Width = 260;
            dgvDados.Columns[2].HeaderText = "Código da Categoria";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Descrição da Categoria";
            dgvDados.Columns[3].Width = 260;*/
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código da SubCategoria";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "Descrição da SubCategoria";
            dgvDados.Columns[1].Width = 260;
            dgvDados.Columns[2].HeaderText = "Código da Categoria";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Descrição da Categoria";
            dgvDados.Columns[3].Width = 260;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.scatcod = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.catcod = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[2].Value);
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
