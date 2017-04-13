using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaFornecedor : Form
    {
        public int codigo;
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)//mudei pra não carregar no load
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 80;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "Razão Social";
            dgvDados.Columns[2].Width = 200;
            dgvDados.Columns[3].HeaderText = "CNPJ";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "I.E.";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "CEP";
            dgvDados.Columns[5].Width = 80;
            dgvDados.Columns[6].HeaderText = "Estado";
            dgvDados.Columns[6].Width = 80;
            dgvDados.Columns[7].HeaderText = "Cidade";
            dgvDados.Columns[7].Width = 200;
            dgvDados.Columns[8].HeaderText = "Rua";
            dgvDados.Columns[8].Width = 200;
            dgvDados.Columns[9].HeaderText = "Número";
            dgvDados.Columns[9].Width = 80;
            dgvDados.Columns[10].HeaderText = "Bairro";
            dgvDados.Columns[10].Width = 200;
            dgvDados.Columns[11].HeaderText = "Email";
            dgvDados.Columns[11].Width = 200;
            dgvDados.Columns[12].HeaderText = "Telefone";
            dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[13].HeaderText = "Celular";
            dgvDados.Columns[13].Width = 100;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            if (rbNome.Checked == true)//28/03 pra localizar por nome ou cnpj
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCNPJ(txtValor.Text);
            }

            /*dgvDados.Columns[0].HeaderText = "Código";
            //dgvDados.Columns[0].Width = 80;
            dgvDados.Columns[1].HeaderText = "Nome";
            //dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "Razão Social";
            //dgvDados.Columns[2].Width = 200;
            dgvDados.Columns[3].HeaderText = "CNPJ";
            //dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "I.E.";
            //dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "CEP";
            //dgvDados.Columns[5].Width = 80;
            dgvDados.Columns[6].HeaderText = "Estado";
            //dgvDados.Columns[6].Width = 80;
            dgvDados.Columns[7].HeaderText = "Cidade";
            //dgvDados.Columns[7].Width = 200;
            dgvDados.Columns[8].HeaderText = "Rua";
            //dgvDados.Columns[8].Width = 200;
            dgvDados.Columns[9].HeaderText = "Número";
            //dgvDados.Columns[9].Width = 80;
            dgvDados.Columns[10].HeaderText = "Bairro";
            //dgvDados.Columns[10].Width = 200;
            dgvDados.Columns[11].HeaderText = "Email";
            //dgvDados.Columns[11].Width = 200;
            dgvDados.Columns[12].HeaderText = "Telefone";
            //dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[13].HeaderText = "Celular";
            //dgvDados.Columns[13].Width = 100;*/
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
