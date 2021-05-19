
namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    partial class Listar_Disciplinas_Cadastradas
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
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_cadastrar_curso = new System.Windows.Forms.Button();
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
            this.Nome,
            this.Valor});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 185);
            this.dataGridView1.TabIndex = 0;
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
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = global::Projeto_Integrador.Properties.Resources.Voltar;
            this.btn_voltar.Location = new System.Drawing.Point(12, 347);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(318, 57);
            this.btn_voltar.TabIndex = 6;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Image = global::Projeto_Integrador.Properties.Resources.Atualizar;
            this.btn_atualizar.Location = new System.Drawing.Point(174, 283);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(156, 57);
            this.btn_atualizar.TabIndex = 5;
            this.btn_atualizar.Text = "Atualizar lista";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cadastrar_curso
            // 
            this.btn_cadastrar_curso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_curso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrar_curso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cadastrar_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_curso.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_curso.Image = global::Projeto_Integrador.Properties.Resources.Cadastrar_novo;
            this.btn_cadastrar_curso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar_curso.Location = new System.Drawing.Point(12, 283);
            this.btn_cadastrar_curso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cadastrar_curso.Name = "btn_cadastrar_curso";
            this.btn_cadastrar_curso.Size = new System.Drawing.Size(156, 57);
            this.btn_cadastrar_curso.TabIndex = 4;
            this.btn_cadastrar_curso.Text = "Cadastrar curso";
            this.btn_cadastrar_curso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar_curso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cadastrar_curso.UseVisualStyleBackColor = true;
            this.btn_cadastrar_curso.Click += new System.EventHandler(this.btn_cadastrar_curso_Click);
            // 
            // Listar_Disciplinas_Cadastradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_cadastrar_curso);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Listar_Disciplinas_Cadastradas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus cursos cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button btn_cadastrar_curso;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_voltar;
    }
}