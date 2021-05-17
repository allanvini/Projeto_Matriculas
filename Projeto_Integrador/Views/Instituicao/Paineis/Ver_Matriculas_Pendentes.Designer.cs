
namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    partial class Ver_Matriculas_Pendentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTD_Parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_aluno_ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_aluno_nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_juros = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_parcelas = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_seta_credito = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_seta_debito = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_seta_boleto = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_fazer_financiamento = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Instituicao,
            this.QTD_Parcelas,
            this.Juros,
            this.Valor,
            this.Situacao});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(669, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Instituicao
            // 
            this.Instituicao.HeaderText = "Instituição";
            this.Instituicao.Name = "Instituicao";
            this.Instituicao.ReadOnly = true;
            // 
            // QTD_Parcelas
            // 
            this.QTD_Parcelas.HeaderText = "Parcelas";
            this.QTD_Parcelas.Name = "QTD_Parcelas";
            this.QTD_Parcelas.ReadOnly = true;
            // 
            // Juros
            // 
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            this.Juros.ReadOnly = true;
            this.Juros.Width = 50;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor Total";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbl_aluno_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_aluno_nome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(222, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do aluno";
            // 
            // lbl_aluno_ID
            // 
            this.lbl_aluno_ID.AutoSize = true;
            this.lbl_aluno_ID.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aluno_ID.Location = new System.Drawing.Point(62, 34);
            this.lbl_aluno_ID.Name = "lbl_aluno_ID";
            this.lbl_aluno_ID.Size = new System.Drawing.Size(19, 16);
            this.lbl_aluno_ID.TabIndex = 3;
            this.lbl_aluno_ID.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Matricula";
            // 
            // lbl_aluno_nome
            // 
            this.lbl_aluno_nome.AutoSize = true;
            this.lbl_aluno_nome.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aluno_nome.Location = new System.Drawing.Point(50, 62);
            this.lbl_aluno_nome.Name = "lbl_aluno_nome";
            this.lbl_aluno_nome.Size = new System.Drawing.Size(14, 16);
            this.lbl_aluno_nome.TabIndex = 1;
            this.lbl_aluno_nome.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txb_juros);
            this.groupBox2.Controls.Add(this.txb_parcelas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 377);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(222, 97);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do financiamento";
            // 
            // txb_juros
            // 
            this.txb_juros.Depth = 0;
            this.txb_juros.Hint = "";
            this.txb_juros.Location = new System.Drawing.Point(108, 56);
            this.txb_juros.MaxLength = 32767;
            this.txb_juros.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_juros.Name = "txb_juros";
            this.txb_juros.PasswordChar = '\0';
            this.txb_juros.SelectedText = "";
            this.txb_juros.SelectionLength = 0;
            this.txb_juros.SelectionStart = 0;
            this.txb_juros.Size = new System.Drawing.Size(53, 23);
            this.txb_juros.TabIndex = 10;
            this.txb_juros.TabStop = false;
            this.txb_juros.UseSystemPasswordChar = false;
            // 
            // txb_parcelas
            // 
            this.txb_parcelas.Depth = 0;
            this.txb_parcelas.Hint = "";
            this.txb_parcelas.Location = new System.Drawing.Point(108, 20);
            this.txb_parcelas.MaxLength = 32767;
            this.txb_parcelas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_parcelas.Name = "txb_parcelas";
            this.txb_parcelas.PasswordChar = '\0';
            this.txb_parcelas.SelectedText = "";
            this.txb_parcelas.SelectionLength = 0;
            this.txb_parcelas.SelectionStart = 0;
            this.txb_parcelas.Size = new System.Drawing.Size(53, 23);
            this.txb_parcelas.TabIndex = 9;
            this.txb_parcelas.TabStop = false;
            this.txb_parcelas.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parcelas:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_seta_credito);
            this.groupBox3.Controls.Add(this.btn_seta_debito);
            this.groupBox3.Controls.Add(this.btn_seta_boleto);
            this.groupBox3.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(241, 266);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(162, 208);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forma de pagamento";
            // 
            // btn_seta_credito
            // 
            this.btn_seta_credito.AutoSize = true;
            this.btn_seta_credito.Depth = 0;
            this.btn_seta_credito.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_seta_credito.Location = new System.Drawing.Point(16, 123);
            this.btn_seta_credito.Margin = new System.Windows.Forms.Padding(0);
            this.btn_seta_credito.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_seta_credito.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_seta_credito.Name = "btn_seta_credito";
            this.btn_seta_credito.Ripple = true;
            this.btn_seta_credito.Size = new System.Drawing.Size(135, 30);
            this.btn_seta_credito.TabIndex = 11;
            this.btn_seta_credito.TabStop = true;
            this.btn_seta_credito.Text = "Cartão de crédito";
            this.btn_seta_credito.UseVisualStyleBackColor = true;
            this.btn_seta_credito.CheckedChanged += new System.EventHandler(this.btn_seta_credito_CheckedChanged_1);
            // 
            // btn_seta_debito
            // 
            this.btn_seta_debito.AutoSize = true;
            this.btn_seta_debito.Depth = 0;
            this.btn_seta_debito.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_seta_debito.Location = new System.Drawing.Point(16, 93);
            this.btn_seta_debito.Margin = new System.Windows.Forms.Padding(0);
            this.btn_seta_debito.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_seta_debito.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_seta_debito.Name = "btn_seta_debito";
            this.btn_seta_debito.Ripple = true;
            this.btn_seta_debito.Size = new System.Drawing.Size(131, 30);
            this.btn_seta_debito.TabIndex = 10;
            this.btn_seta_debito.TabStop = true;
            this.btn_seta_debito.Text = "Cartão de débito";
            this.btn_seta_debito.UseVisualStyleBackColor = true;
            this.btn_seta_debito.CheckedChanged += new System.EventHandler(this.btn_seta_debito_CheckedChanged_1);
            // 
            // btn_seta_boleto
            // 
            this.btn_seta_boleto.AutoSize = true;
            this.btn_seta_boleto.Depth = 0;
            this.btn_seta_boleto.Font = new System.Drawing.Font("Roboto", 10F);
            this.btn_seta_boleto.Location = new System.Drawing.Point(16, 65);
            this.btn_seta_boleto.Margin = new System.Windows.Forms.Padding(0);
            this.btn_seta_boleto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btn_seta_boleto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_seta_boleto.Name = "btn_seta_boleto";
            this.btn_seta_boleto.Ripple = true;
            this.btn_seta_boleto.Size = new System.Drawing.Size(69, 30);
            this.btn_seta_boleto.TabIndex = 9;
            this.btn_seta_boleto.TabStop = true;
            this.btn_seta_boleto.Text = "Boleto";
            this.btn_seta_boleto.UseVisualStyleBackColor = true;
            this.btn_seta_boleto.CheckedChanged += new System.EventHandler(this.btn_seta_boleto_CheckedChanged_1);
            // 
            // btn_fazer_financiamento
            // 
            this.btn_fazer_financiamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fazer_financiamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_fazer_financiamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_fazer_financiamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fazer_financiamento.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fazer_financiamento.Location = new System.Drawing.Point(409, 271);
            this.btn_fazer_financiamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fazer_financiamento.Name = "btn_fazer_financiamento";
            this.btn_fazer_financiamento.Size = new System.Drawing.Size(273, 63);
            this.btn_fazer_financiamento.TabIndex = 6;
            this.btn_fazer_financiamento.Text = "Fazer financiamento";
            this.btn_fazer_financiamento.UseVisualStyleBackColor = true;
            this.btn_fazer_financiamento.Click += new System.EventHandler(this.btn_fazer_financiamento_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Location = new System.Drawing.Point(409, 341);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(273, 63);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.Text = "Atualizar lista";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(409, 412);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(273, 63);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Ver_Matriculas_Pendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 489);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_fazer_financiamento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Ver_Matriculas_Pendentes";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriculas pendentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTD_Parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_aluno_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_aluno_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_fazer_financiamento;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_juros;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_parcelas;
        private MaterialSkin.Controls.MaterialRadioButton btn_seta_credito;
        private MaterialSkin.Controls.MaterialRadioButton btn_seta_debito;
        private MaterialSkin.Controls.MaterialRadioButton btn_seta_boleto;
    }
}