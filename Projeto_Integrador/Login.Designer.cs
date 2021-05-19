
namespace Projeto_Integrador
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_usuario_senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_usuario_login = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cadastrar_usuario = new System.Windows.Forms.Button();
            this.btn_instituicao_login = new System.Windows.Forms.Button();
            this.btn_usuario_login = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txb_usuario_senha);
            this.groupBox1.Controls.Add(this.txb_usuario_login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // txb_usuario_senha
            // 
            this.txb_usuario_senha.Depth = 0;
            this.txb_usuario_senha.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_usuario_senha.Hint = "";
            this.txb_usuario_senha.Location = new System.Drawing.Point(59, 48);
            this.txb_usuario_senha.MaxLength = 32767;
            this.txb_usuario_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_usuario_senha.Name = "txb_usuario_senha";
            this.txb_usuario_senha.PasswordChar = '\0';
            this.txb_usuario_senha.SelectedText = "";
            this.txb_usuario_senha.SelectionLength = 0;
            this.txb_usuario_senha.SelectionStart = 0;
            this.txb_usuario_senha.Size = new System.Drawing.Size(207, 23);
            this.txb_usuario_senha.TabIndex = 12;
            this.txb_usuario_senha.TabStop = false;
            this.txb_usuario_senha.UseSystemPasswordChar = true;
            // 
            // txb_usuario_login
            // 
            this.txb_usuario_login.Depth = 0;
            this.txb_usuario_login.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_usuario_login.Hint = "";
            this.txb_usuario_login.Location = new System.Drawing.Point(59, 19);
            this.txb_usuario_login.MaxLength = 32767;
            this.txb_usuario_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_usuario_login.Name = "txb_usuario_login";
            this.txb_usuario_login.PasswordChar = '\0';
            this.txb_usuario_login.SelectedText = "";
            this.txb_usuario_login.SelectionLength = 0;
            this.txb_usuario_login.SelectionStart = 0;
            this.txb_usuario_login.Size = new System.Drawing.Size(207, 23);
            this.txb_usuario_login.TabIndex = 11;
            this.txb_usuario_login.TabStop = false;
            this.txb_usuario_login.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 258);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(166, 18);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Não possui uma conta?";
            // 
            // btn_cadastrar_usuario
            // 
            this.btn_cadastrar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_usuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrar_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cadastrar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_usuario.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_usuario.Location = new System.Drawing.Point(202, 253);
            this.btn_cadastrar_usuario.Name = "btn_cadastrar_usuario";
            this.btn_cadastrar_usuario.Size = new System.Drawing.Size(118, 31);
            this.btn_cadastrar_usuario.TabIndex = 8;
            this.btn_cadastrar_usuario.Text = "Cadastrar";
            this.btn_cadastrar_usuario.UseVisualStyleBackColor = true;
            this.btn_cadastrar_usuario.Click += new System.EventHandler(this.btn_cadastrar_usuario_Click);
            // 
            // btn_instituicao_login
            // 
            this.btn_instituicao_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_instituicao_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_instituicao_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_instituicao_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instituicao_login.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instituicao_login.Image = global::Projeto_Integrador.Properties.Resources.Instituicao;
            this.btn_instituicao_login.Location = new System.Drawing.Point(32, 324);
            this.btn_instituicao_login.Name = "btn_instituicao_login";
            this.btn_instituicao_login.Size = new System.Drawing.Size(288, 48);
            this.btn_instituicao_login.TabIndex = 10;
            this.btn_instituicao_login.Text = "Acessar como instituição";
            this.btn_instituicao_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_instituicao_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_instituicao_login.UseVisualStyleBackColor = true;
            this.btn_instituicao_login.Click += new System.EventHandler(this.btn_instituicao_login_Click);
            // 
            // btn_usuario_login
            // 
            this.btn_usuario_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_usuario_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuario_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_usuario_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_usuario_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario_login.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario_login.Image = global::Projeto_Integrador.Properties.Resources.Usuario;
            this.btn_usuario_login.Location = new System.Drawing.Point(32, 177);
            this.btn_usuario_login.Name = "btn_usuario_login";
            this.btn_usuario_login.Size = new System.Drawing.Size(288, 48);
            this.btn_usuario_login.TabIndex = 5;
            this.btn_usuario_login.Text = "Logar como usuário";
            this.btn_usuario_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_usuario_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuario_login.UseVisualStyleBackColor = true;
            this.btn_usuario_login.Click += new System.EventHandler(this.btn_usuario_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 413);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_instituicao_login);
            this.Controls.Add(this.btn_cadastrar_usuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_usuario_login);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_usuario_login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cadastrar_usuario;
        private System.Windows.Forms.Button btn_instituicao_login;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_usuario_login;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_usuario_senha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

