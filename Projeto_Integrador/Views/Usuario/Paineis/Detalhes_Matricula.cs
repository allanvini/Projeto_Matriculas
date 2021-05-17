using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Usuario.Paineis
{
    public partial class Detalhes_Matricula : MaterialSkin.Controls.MaterialForm
    {
        private int alunoID;
        private float valorParcela;
        private int parcelaID;

        private float valorTotal = 0;
        private float valorPago = 0;
        private float valorRestante = 0;

        Models.Aluno aluno;

        public Detalhes_Matricula(int alunoID)
        {
            InitializeComponent();
            this.alunoID = alunoID;

            this.pegaDadosAluno();
            this.preencheDadosAluno();
            this.preencheParcelasPagas();
            this.preencheParcelasPendentes();
            this.preencheDadosGerais();
        }

        private void pegaDadosAluno()
        {
            Controllers.CommonController controller = new Controllers.CommonController();
            this.aluno = controller.pegaDadosAluno(this.alunoID);
        }

        private void preencheParcelasPendentes()
        {
            Controllers.CommonController controller = new Controllers.CommonController();
            controller.listarParcelasPendentes(dataGridView2, this.alunoID);
        }

        private void preencheParcelasPagas()
        {
            Controllers.CommonController controller = new Controllers.CommonController();
            controller.listarParcelasPagas(dataGridView1, this.alunoID);
        }

        private void preencheDadosAluno()
        {
            txb_nome.Text = aluno.Nome;
            txb_idade.Text = aluno.Idade.ToString();
            txb_email.Text = aluno.Email;
            txb_telefone.Text = aluno.Telefone;
            txb_endereco.Text = aluno.Endereco;
        }

        private void preencheDadosGerais()
        {
            lbl_aluno_ID.Text = this.alunoID.ToString();

            for (int row = 0; row < dataGridView2.Rows.Count; row++)
            {
                this.valorRestante += (float)dataGridView2.Rows[row].Cells[3].Value;
            }

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                this.valorPago += (float)dataGridView1.Rows[row].Cells[3].Value;
            }

            this.valorTotal = this.valorPago + this.valorRestante;

            lbl_valor_curso.Text = this.valorTotal.ToString();
            lbl_valor_pago.Text = this.valorPago.ToString();
            lbl_valor_restante.Text = this.valorRestante.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.parcelaID = Convert.ToInt32(row.Cells[0].Value);
                this.valorParcela = (float)row.Cells[3].Value;
            }

            lbl_parcela_selecionada.Text = $"{this.parcelaID}";
            lbl_valor_parcela_selecionada.Text = $"R$ {this.valorParcela}";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                this.parcelaID = Convert.ToInt32(row.Cells[0].Value);
                this.valorParcela = (float)row.Cells[3].Value;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_paga_parcela_Click(object sender, EventArgs e)
        {
            Controllers.CommonController controller = new Controllers.CommonController();

            controller.pagaParcela(this.parcelaID);

            this.preencheParcelasPagas();
            this.preencheParcelasPendentes();
            this.preencheDadosGerais();
        }

        private void btn_salvar_alteracoes_Click(object sender, EventArgs e)
        {
            aluno.Nome = txb_nome.Text;
            aluno.Idade = Convert.ToInt32(txb_idade.Text);
            aluno.Email = txb_email.Text;
            aluno.Telefone = txb_telefone.Text;
            aluno.Endereco = txb_endereco.Text;

            Controllers.CommonController controller = new Controllers.CommonController();

            controller.atualizaDadosAluno(this.aluno);

            this.pegaDadosAluno();
            this.preencheDadosAluno();
        }
    }
}
