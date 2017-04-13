using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaTipoDePagamento : Form
    {
        public int codigo = 0;
        public frmConsultaTipoDePagamento()
        {
            InitializeComponent();
        }

        private void frmConsultaTipoDePagamento_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 53;
            dgvDados.Columns[1].HeaderText = "Tipo de Pagamento";
            dgvDados.Columns[1].Width = 660;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.Localizar(txtTipoDePagamento.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCodigo(txtTipoDePagamento.Text);
            }

            //dgvDados.DataSource = bll.Localizar(txtTipoDePagamento.Text);
            /*dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 53;
            dgvDados.Columns[1].HeaderText = "Tipo de Pagamento";
            dgvDados.Columns[1].Width = 660;*/
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
            txtTipoDePagamento.Clear();
            btnLocalizar_Click(sender, e);
        }
    }
}
