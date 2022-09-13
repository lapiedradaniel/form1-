namespace aula5
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.Label();
            this.textPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(19, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(55, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(105, 32);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(666, 20);
            this.textNome.TabIndex = 1;
            // 
            // txtPais
            // 
            this.txtPais.AutoSize = true;
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(19, 78);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(43, 20);
            this.txtPais.TabIndex = 2;
            this.txtPais.Text = "Pais";
            // 
            // textPais
            // 
            this.textPais.Location = new System.Drawing.Point(105, 78);
            this.textPais.Name = "textPais";
            this.textPais.Size = new System.Drawing.Size(666, 20);
            this.textPais.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(19, 136);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(66, 20);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Text = "Estado";
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(106, 136);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(665, 20);
            this.textEstado.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(23, 190);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(53, 20);
            this.txtTitulo.TabIndex = 6;
            this.txtTitulo.Text = "Titulo";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(106, 189);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(665, 20);
            this.textTitulo.TabIndex = 7;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(121, 270);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(166, 52);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(405, 270);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(246, 52);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.textPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label txtPais;
        private System.Windows.Forms.TextBox textPais;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

