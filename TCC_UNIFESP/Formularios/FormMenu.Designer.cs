namespace TCC_UNIFESP
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pnBtnForms = new System.Windows.Forms.Panel();
            this.btnComparador = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.btnImagens = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblNomeTeste = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMaxNormal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnForm = new System.Windows.Forms.Panel();
            this.pn_all = new System.Windows.Forms.Panel();
            this.btnIconComparador = new System.Windows.Forms.Button();
            this.btnIconTelaInicial = new System.Windows.Forms.Button();
            this.btnIconConfiguracao = new System.Windows.Forms.Button();
            this.btnIconImagens = new System.Windows.Forms.Button();
            this.btnIconTeste = new System.Windows.Forms.Button();
            this.pnBtnForms.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pn_all.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBtnForms
            // 
            this.pnBtnForms.BackColor = System.Drawing.Color.Gray;
            this.pnBtnForms.Controls.Add(this.btnIconComparador);
            this.pnBtnForms.Controls.Add(this.btnComparador);
            this.pnBtnForms.Controls.Add(this.btnIconTelaInicial);
            this.pnBtnForms.Controls.Add(this.btnTelaInicial);
            this.pnBtnForms.Controls.Add(this.btnIconConfiguracao);
            this.pnBtnForms.Controls.Add(this.btnIconImagens);
            this.pnBtnForms.Controls.Add(this.btnIconTeste);
            this.pnBtnForms.Controls.Add(this.btnConfiguracao);
            this.pnBtnForms.Controls.Add(this.btnImagens);
            this.pnBtnForms.Controls.Add(this.btnTeste);
            this.pnBtnForms.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBtnForms.Location = new System.Drawing.Point(0, 29);
            this.pnBtnForms.Name = "pnBtnForms";
            this.pnBtnForms.Size = new System.Drawing.Size(69, 634);
            this.pnBtnForms.TabIndex = 1;
            this.pnBtnForms.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnComparador
            // 
            this.btnComparador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnComparador.BackColor = System.Drawing.Color.Gray;
            this.btnComparador.FlatAppearance.BorderSize = 0;
            this.btnComparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComparador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparador.ForeColor = System.Drawing.Color.White;
            this.btnComparador.Location = new System.Drawing.Point(3, 502);
            this.btnComparador.Name = "btnComparador";
            this.btnComparador.Size = new System.Drawing.Size(217, 66);
            this.btnComparador.TabIndex = 8;
            this.btnComparador.Text = "COMPARAR";
            this.btnComparador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComparador.UseVisualStyleBackColor = false;
            this.btnComparador.Click += new System.EventHandler(this.BotaoClick);
            this.btnComparador.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.BackColor = System.Drawing.Color.Silver;
            this.btnTelaInicial.FlatAppearance.BorderSize = 0;
            this.btnTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaInicial.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaInicial.ForeColor = System.Drawing.Color.White;
            this.btnTelaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaInicial.Location = new System.Drawing.Point(0, 0);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(220, 66);
            this.btnTelaInicial.TabIndex = 6;
            this.btnTelaInicial.Text = "MENU";
            this.btnTelaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTelaInicial.UseVisualStyleBackColor = false;
            this.btnTelaInicial.Click += new System.EventHandler(this.BotaoClick);
            this.btnTelaInicial.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfiguracao.BackColor = System.Drawing.Color.Gray;
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracao.Location = new System.Drawing.Point(0, 568);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(220, 66);
            this.btnConfiguracao.TabIndex = 2;
            this.btnConfiguracao.Text = "CONFIGURAÇÃO";
            this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.BotaoClick);
            this.btnConfiguracao.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnImagens
            // 
            this.btnImagens.BackColor = System.Drawing.Color.Gray;
            this.btnImagens.FlatAppearance.BorderSize = 0;
            this.btnImagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagens.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagens.ForeColor = System.Drawing.Color.White;
            this.btnImagens.Location = new System.Drawing.Point(0, 132);
            this.btnImagens.Name = "btnImagens";
            this.btnImagens.Size = new System.Drawing.Size(220, 66);
            this.btnImagens.TabIndex = 1;
            this.btnImagens.Text = "IMAGENS";
            this.btnImagens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImagens.UseVisualStyleBackColor = false;
            this.btnImagens.Click += new System.EventHandler(this.BotaoClick);
            this.btnImagens.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.Color.Gray;
            this.btnTeste.FlatAppearance.BorderSize = 0;
            this.btnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeste.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.ForeColor = System.Drawing.Color.White;
            this.btnTeste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeste.Location = new System.Drawing.Point(0, 66);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(220, 66);
            this.btnTeste.TabIndex = 0;
            this.btnTeste.Text = "TESTE";
            this.btnTeste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeste.UseVisualStyleBackColor = false;
            this.btnTeste.Click += new System.EventHandler(this.BotaoClick);
            this.btnTeste.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnMenu.Controls.Add(this.lblNomeTeste);
            this.pnMenu.Controls.Add(this.btnMin);
            this.pnMenu.Controls.Add(this.btnMaxNormal);
            this.pnMenu.Controls.Add(this.btnExit);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(992, 29);
            this.pnMenu.TabIndex = 1;
            this.pnMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeFormPosition);
            this.pnMenu.MouseEnter += new System.EventHandler(this.MouseSaiuDoPainel);
            // 
            // lblNomeTeste
            // 
            this.lblNomeTeste.AutoSize = true;
            this.lblNomeTeste.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTeste.ForeColor = System.Drawing.Color.White;
            this.lblNomeTeste.Location = new System.Drawing.Point(5, 3);
            this.lblNomeTeste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeTeste.Name = "lblNomeTeste";
            this.lblNomeTeste.Size = new System.Drawing.Size(149, 19);
            this.lblNomeTeste.TabIndex = 3;
            this.lblNomeTeste.Text = "Teste Selecionado";
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.Location = new System.Drawing.Point(872, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 29);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.MinForm);
            this.btnMin.Paint += new System.Windows.Forms.PaintEventHandler(this.IconMin);
            // 
            // btnMaxNormal
            // 
            this.btnMaxNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaxNormal.Location = new System.Drawing.Point(912, 0);
            this.btnMaxNormal.Name = "btnMaxNormal";
            this.btnMaxNormal.Size = new System.Drawing.Size(40, 29);
            this.btnMaxNormal.TabIndex = 1;
            this.btnMaxNormal.UseVisualStyleBackColor = true;
            this.btnMaxNormal.Click += new System.EventHandler(this.MaxNorForm);
            this.btnMaxNormal.Paint += new System.Windows.Forms.PaintEventHandler(this.IconMaxNor);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Location = new System.Drawing.Point(952, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ExitForm);
            this.btnExit.Paint += new System.Windows.Forms.PaintEventHandler(this.IconExit);
            // 
            // pnForm
            // 
            this.pnForm.AutoScroll = true;
            this.pnForm.BackColor = System.Drawing.Color.Silver;
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(69, 29);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(923, 634);
            this.pnForm.TabIndex = 0;
            this.pnForm.MouseEnter += new System.EventHandler(this.MouseSaiuDoPainel);
            // 
            // pn_all
            // 
            this.pn_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_all.BackColor = System.Drawing.Color.Silver;
            this.pn_all.Controls.Add(this.pnForm);
            this.pn_all.Controls.Add(this.pnBtnForms);
            this.pn_all.Controls.Add(this.pnMenu);
            this.pn_all.Location = new System.Drawing.Point(4, 4);
            this.pn_all.Name = "pn_all";
            this.pn_all.Size = new System.Drawing.Size(992, 663);
            this.pn_all.TabIndex = 1;
            // 
            // btnIconComparador
            // 
            this.btnIconComparador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIconComparador.BackColor = System.Drawing.Color.Gray;
            this.btnIconComparador.BackgroundImage = global::TCC_UNIFESP.Properties.Resources.Grafico;
            this.btnIconComparador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIconComparador.FlatAppearance.BorderSize = 0;
            this.btnIconComparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconComparador.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconComparador.ForeColor = System.Drawing.Color.White;
            this.btnIconComparador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconComparador.Location = new System.Drawing.Point(13, 512);
            this.btnIconComparador.Name = "btnIconComparador";
            this.btnIconComparador.Size = new System.Drawing.Size(44, 44);
            this.btnIconComparador.TabIndex = 9;
            this.btnIconComparador.UseVisualStyleBackColor = false;
            this.btnIconComparador.Click += new System.EventHandler(this.BotaoClick);
            this.btnIconComparador.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnIconTelaInicial
            // 
            this.btnIconTelaInicial.BackColor = System.Drawing.Color.Silver;
            this.btnIconTelaInicial.BackgroundImage = global::TCC_UNIFESP.Properties.Resources.Menu;
            this.btnIconTelaInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIconTelaInicial.FlatAppearance.BorderSize = 0;
            this.btnIconTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconTelaInicial.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconTelaInicial.ForeColor = System.Drawing.Color.White;
            this.btnIconTelaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconTelaInicial.Location = new System.Drawing.Point(13, 11);
            this.btnIconTelaInicial.Name = "btnIconTelaInicial";
            this.btnIconTelaInicial.Size = new System.Drawing.Size(44, 44);
            this.btnIconTelaInicial.TabIndex = 7;
            this.btnIconTelaInicial.UseVisualStyleBackColor = false;
            this.btnIconTelaInicial.Click += new System.EventHandler(this.BotaoClick);
            this.btnIconTelaInicial.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnIconConfiguracao
            // 
            this.btnIconConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIconConfiguracao.BackColor = System.Drawing.Color.Gray;
            this.btnIconConfiguracao.BackgroundImage = global::TCC_UNIFESP.Properties.Resources.Configuracao;
            this.btnIconConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIconConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnIconConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconConfiguracao.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnIconConfiguracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconConfiguracao.Location = new System.Drawing.Point(13, 576);
            this.btnIconConfiguracao.Name = "btnIconConfiguracao";
            this.btnIconConfiguracao.Size = new System.Drawing.Size(44, 44);
            this.btnIconConfiguracao.TabIndex = 5;
            this.btnIconConfiguracao.UseVisualStyleBackColor = false;
            this.btnIconConfiguracao.Click += new System.EventHandler(this.BotaoClick);
            this.btnIconConfiguracao.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnIconImagens
            // 
            this.btnIconImagens.BackColor = System.Drawing.Color.Gray;
            this.btnIconImagens.BackgroundImage = global::TCC_UNIFESP.Properties.Resources.Imagens;
            this.btnIconImagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIconImagens.FlatAppearance.BorderSize = 0;
            this.btnIconImagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconImagens.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconImagens.ForeColor = System.Drawing.Color.White;
            this.btnIconImagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconImagens.Location = new System.Drawing.Point(13, 143);
            this.btnIconImagens.Name = "btnIconImagens";
            this.btnIconImagens.Size = new System.Drawing.Size(44, 44);
            this.btnIconImagens.TabIndex = 4;
            this.btnIconImagens.UseVisualStyleBackColor = false;
            this.btnIconImagens.Click += new System.EventHandler(this.BotaoClick);
            this.btnIconImagens.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // btnIconTeste
            // 
            this.btnIconTeste.BackColor = System.Drawing.Color.Gray;
            this.btnIconTeste.BackgroundImage = global::TCC_UNIFESP.Properties.Resources.Teste;
            this.btnIconTeste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIconTeste.FlatAppearance.BorderSize = 0;
            this.btnIconTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconTeste.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIconTeste.ForeColor = System.Drawing.Color.White;
            this.btnIconTeste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIconTeste.Location = new System.Drawing.Point(13, 77);
            this.btnIconTeste.Name = "btnIconTeste";
            this.btnIconTeste.Size = new System.Drawing.Size(44, 44);
            this.btnIconTeste.TabIndex = 3;
            this.btnIconTeste.UseVisualStyleBackColor = false;
            this.btnIconTeste.Click += new System.EventHandler(this.BotaoClick);
            this.btnIconTeste.MouseEnter += new System.EventHandler(this.MouseEntrouNoPainel);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 671);
            this.Controls.Add(this.pn_all);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 671);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.MouseEnter += new System.EventHandler(this.MouseSaiuDoPainel);
            this.pnBtnForms.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pn_all.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBtnForms;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMaxNormal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnIconTeste;
        private System.Windows.Forms.Button btnIconConfiguracao;
        private System.Windows.Forms.Button btnIconImagens;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnImagens;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Panel pn_all;
        private System.Windows.Forms.Button btnIconComparador;
        private System.Windows.Forms.Button btnComparador;
        private System.Windows.Forms.Button btnIconTelaInicial;
        private System.Windows.Forms.Button btnTelaInicial;
        private System.Windows.Forms.Label lblNomeTeste;
    }
}

