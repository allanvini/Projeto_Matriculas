
namespace Projeto_Integrador.Views.Usuario.Paineis
{
    partial class Painel_Matriculas
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
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ver_detalhes = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_aluno_selecionado = new System.Windows.Forms.Label();
            this.btn_remover_matricula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Aluno,
            this.Instituicao,
            this.Responsavel,
            this.Curso});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(509, 229);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 125;
            // 
            // Instituicao
            // 
            this.Instituicao.HeaderText = "Instituição";
            this.Instituicao.Name = "Instituicao";
            this.Instituicao.ReadOnly = true;
            // 
            // Responsavel
            // 
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            this.Responsavel.Width = 115;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // btn_ver_detalhes
            // 
            this.btn_ver_detalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver_detalhes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ver_detalhes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ver_detalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_detalhes.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_detalhes.Location = new System.Drawing.Point(528, 133);
            this.btn_ver_detalhes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ver_detalhes.Name = "btn_ver_detalhes";
            this.btn_ver_detalhes.Size = new System.Drawing.Size(196, 52);
            this.btn_ver_detalhes.TabIndex = 6;
            this.btn_ver_detalhes.Text = "Ver detalhes da matrícula";
            this.btn_ver_detalhes.UseVisualStyleBackColor = true;
            this.btn_ver_detalhes.Click += new System.EventHandler(this.btn_ver_detalhes_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Location = new System.Drawing.Point(528, 193);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(196, 52);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aluno selecionado:";
            // 
            // lbl_aluno_selecionado
            // 
            this.lbl_aluno_selecionado.AutoSize = true;
            this.lbl_aluno_selecionado.BackColor = System.Drawing.Color.White;
            this.lbl_aluno_selecionado.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aluno_selecionado.Location = new System.Drawing.Point(624, 76);
            this.lbl_aluno_selecionado.Name = "lbl_aluno_selecionado";
            this.lbl_aluno_selecionado.Size = new System.Drawing.Size(34, 27);
            this.lbl_aluno_selecionado.TabIndex = 10;
            this.lbl_aluno_selecionado.Text = "ID";
            // 
            // btn_remover_matricula
            // 
            this.btn_remover_matricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remover_matricula.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_remover_matricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_remover_matricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover_matricula.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover_matricula.Location = new System.Drawing.Point(528, 253);
            this.btn_remover_matricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remover_matricula.Name = "btn_remover_matricula";
            this.btn_remover_matricula.Size = new System.Drawing.Size(196, 52);
            this.btn_remover_matricula.TabIndex = 8;
            this.btn_remover_matricula.Text = "Remover matrícula";
            this.btn_remover_matricula.UseVisualStyleBackColor = true;
            this.btn_remover_matricula.Click += new System.EventHandler(this.btn_remover_matricula_Click);
            // 
            // Painel_Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 318);
            this.Controls.Add(this.lbl_aluno_selecionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_remover_matricula);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_ver_detalhes);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Painel_Matriculas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minhas matriculas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ver_detalhes;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_aluno_selecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.Button btn_remover_matricula;
    }
}