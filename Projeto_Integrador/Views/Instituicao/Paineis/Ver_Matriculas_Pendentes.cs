using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    public partial class Ver_Matriculas_Pendentes : MaterialSkin.Controls.MaterialForm
    {
        private int instituicaoID;
        private int alunoID;
        private double valorTotal;
        private int numeroParcelas;
        private double juros;
        private string forma_pagamento;

        public Ver_Matriculas_Pendentes(int instituicaoID)
        {
            InitializeComponent();

            this.instituicaoID = instituicaoID;

            this.carregaDados();
        }

        private void carregaDados()
        {
            Controllers.InstituicaoController controller = new Controllers.InstituicaoController();

            controller.listaMatricuasEmAnalise(dataGridView1, this.instituicaoID);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                lbl_aluno_ID.Text = row.Cells[0].Value.ToString();
                lbl_aluno_nome.Text = row.Cells[1].Value.ToString();

                this.alunoID = Convert.ToInt32(row.Cells[0].Value);

                this.valorTotal = Convert.ToDouble(row.Cells[5].Value);
            }
        }

        private void btn_fazer_financiamento_Click(object sender, EventArgs e)
        {
            Controllers.InstituicaoController controller = new Controllers.InstituicaoController();

            this.numeroParcelas = Convert.ToInt32(txb_parcelas.Text);
            this.juros = Convert.ToDouble(txb_juros.Text);

            controller.cadastrarParcelas(this.numeroParcelas, this.juros, this.valorTotal, this.alunoID, this.forma_pagamento);

            txb_juros.Text = "";
            txb_parcelas.Text = "";

            lbl_aluno_ID.Text = "_";
            lbl_aluno_nome.Text = "_";

            this.numeroParcelas = 0;
            this.juros = 0;
            this.valorTotal = 0;
            this.alunoID = 0;
            this.forma_pagamento = "";

            carregaDados();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.carregaDados();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_seta_boleto_CheckedChanged_1(object sender, EventArgs e)
        {
            this.forma_pagamento = "Boleto";
        }

        private void btn_seta_debito_CheckedChanged_1(object sender, EventArgs e)
        {
            this.forma_pagamento = "Cartão de débito";
        }

        private void btn_seta_credito_CheckedChanged_1(object sender, EventArgs e)
        {
            this.forma_pagamento = "Cartão de crédito";
        }
    }
}
