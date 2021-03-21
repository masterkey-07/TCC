namespace TCC_UNIFESP
{
    partial class FormImagens
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TreeViewImagens = new System.Windows.Forms.TreeView();
            this.MenuImagens = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrocarImagem = new System.Windows.Forms.Button();
            this.btnReescrever = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBaixarImagem = new System.Windows.Forms.Button();
            this.pnImagemDados = new System.Windows.Forms.Panel();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.maskPeriodo = new System.Windows.Forms.MaskedTextBox();
            this.maskGrupo = new System.Windows.Forms.MaskedTextBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMetodos = new System.Windows.Forms.ComboBox();
            this.btnRemoverImagem = new System.Windows.Forms.Button();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.picboxImagem = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.MenuImagens.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnImagemDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TreeViewImagens);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 780);
            this.panel2.TabIndex = 3;
            // 
            // TreeViewImagens
            // 
            this.TreeViewImagens.BackColor = System.Drawing.Color.Silver;
            this.TreeViewImagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeViewImagens.ContextMenuStrip = this.MenuImagens;
            this.TreeViewImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewImagens.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeViewImagens.Location = new System.Drawing.Point(0, 0);
            this.TreeViewImagens.Margin = new System.Windows.Forms.Padding(4);
            this.TreeViewImagens.Name = "TreeViewImagens";
            this.TreeViewImagens.Size = new System.Drawing.Size(267, 780);
            this.TreeViewImagens.TabIndex = 0;
            this.TreeViewImagens.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewImagens_AfterSelect);
            this.TreeViewImagens.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // MenuImagens
            // 
            this.MenuImagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuImagens.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuImagens.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuImagens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.baixarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.MenuImagens.Name = "MenuImagens";
            this.MenuImagens.Size = new System.Drawing.Size(152, 76);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
            // 
            // baixarToolStripMenuItem
            // 
            this.baixarToolStripMenuItem.Name = "baixarToolStripMenuItem";
            this.baixarToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.baixarToolStripMenuItem.Text = "Baixar";
            this.baixarToolStripMenuItem.Click += new System.EventHandler(this.btnBaixarImagem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.btnRemoverImagem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTrocarImagem);
            this.panel1.Controls.Add(this.btnReescrever);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBaixarImagem);
            this.panel1.Controls.Add(this.pnImagemDados);
            this.panel1.Controls.Add(this.cbMetodos);
            this.panel1.Controls.Add(this.btnRemoverImagem);
            this.panel1.Controls.Add(this.btnAdicionarImagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(267, 534);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 246);
            this.panel1.TabIndex = 4;
            // 
            // btnTrocarImagem
            // 
            this.btnTrocarImagem.BackColor = System.Drawing.Color.Silver;
            this.btnTrocarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrocarImagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrocarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarImagem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarImagem.ForeColor = System.Drawing.Color.Black;
            this.btnTrocarImagem.Location = new System.Drawing.Point(3, 149);
            this.btnTrocarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrocarImagem.Name = "btnTrocarImagem";
            this.btnTrocarImagem.Size = new System.Drawing.Size(204, 89);
            this.btnTrocarImagem.TabIndex = 12;
            this.btnTrocarImagem.Text = "Trocar \r\nImagem";
            this.btnTrocarImagem.UseVisualStyleBackColor = false;
            this.btnTrocarImagem.Click += new System.EventHandler(this.btnTrocarImagem_Click);
            // 
            // btnReescrever
            // 
            this.btnReescrever.BackColor = System.Drawing.Color.Silver;
            this.btnReescrever.BackgroundImage = global::TCC_UNIFESP.Properties.Resources.Editar;
            this.btnReescrever.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReescrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReescrever.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReescrever.FlatAppearance.BorderSize = 0;
            this.btnReescrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReescrever.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReescrever.ForeColor = System.Drawing.Color.White;
            this.btnReescrever.Location = new System.Drawing.Point(653, 18);
            this.btnReescrever.Margin = new System.Windows.Forms.Padding(4);
            this.btnReescrever.Name = "btnReescrever";
            this.btnReescrever.Size = new System.Drawing.Size(47, 43);
            this.btnReescrever.TabIndex = 11;
            this.btnReescrever.UseVisualStyleBackColor = false;
            this.btnReescrever.Click += new System.EventHandler(this.btnReescrever_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Método de Processamento";
            // 
            // btnBaixarImagem
            // 
            this.btnBaixarImagem.BackColor = System.Drawing.Color.Silver;
            this.btnBaixarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixarImagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaixarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixarImagem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarImagem.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarImagem.Location = new System.Drawing.Point(653, 150);
            this.btnBaixarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarImagem.Name = "btnBaixarImagem";
            this.btnBaixarImagem.Size = new System.Drawing.Size(293, 39);
            this.btnBaixarImagem.TabIndex = 10;
            this.btnBaixarImagem.Text = "Baixar Imagem";
            this.btnBaixarImagem.UseVisualStyleBackColor = false;
            this.btnBaixarImagem.Click += new System.EventHandler(this.btnBaixarImagem_Click);
            // 
            // pnImagemDados
            // 
            this.pnImagemDados.BackColor = System.Drawing.Color.Silver;
            this.pnImagemDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnImagemDados.Controls.Add(this.txtAumento);
            this.pnImagemDados.Controls.Add(this.btnCancelar);
            this.pnImagemDados.Controls.Add(this.btnConfirmar);
            this.pnImagemDados.Controls.Add(this.maskPeriodo);
            this.pnImagemDados.Controls.Add(this.maskGrupo);
            this.pnImagemDados.Controls.Add(this.lblPorcentagem);
            this.pnImagemDados.Controls.Add(this.label4);
            this.pnImagemDados.Controls.Add(this.label3);
            this.pnImagemDados.Controls.Add(this.label2);
            this.pnImagemDados.Controls.Add(this.label1);
            this.pnImagemDados.Enabled = false;
            this.pnImagemDados.Location = new System.Drawing.Point(215, 2);
            this.pnImagemDados.Margin = new System.Windows.Forms.Padding(4);
            this.pnImagemDados.Name = "pnImagemDados";
            this.pnImagemDados.Size = new System.Drawing.Size(430, 235);
            this.pnImagemDados.TabIndex = 9;
            // 
            // txtAumento
            // 
            this.txtAumento.BackColor = System.Drawing.Color.Silver;
            this.txtAumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumento.Location = new System.Drawing.Point(8, 39);
            this.txtAumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(98, 30);
            this.txtAumento.TabIndex = 35;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(291, 188);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 42);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Silver;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(291, 123);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(131, 42);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // maskPeriodo
            // 
            this.maskPeriodo.BackColor = System.Drawing.Color.Silver;
            this.maskPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskPeriodo.Location = new System.Drawing.Point(8, 120);
            this.maskPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskPeriodo.Mask = "00";
            this.maskPeriodo.Name = "maskPeriodo";
            this.maskPeriodo.Size = new System.Drawing.Size(98, 30);
            this.maskPeriodo.TabIndex = 31;
            this.maskPeriodo.Text = "00";
            this.maskPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskPeriodo.ValidatingType = typeof(int);
            // 
            // maskGrupo
            // 
            this.maskGrupo.BackColor = System.Drawing.Color.Silver;
            this.maskGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskGrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskGrupo.Location = new System.Drawing.Point(240, 39);
            this.maskGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskGrupo.Mask = "00";
            this.maskGrupo.Name = "maskGrupo";
            this.maskGrupo.Size = new System.Drawing.Size(98, 30);
            this.maskGrupo.TabIndex = 30;
            this.maskGrupo.Text = "00";
            this.maskGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskGrupo.ValidatingType = typeof(int);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.BackColor = System.Drawing.Color.Silver;
            this.lblPorcentagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPorcentagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(8, 197);
            this.lblPorcentagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(267, 33);
            this.lblPorcentagem.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Porcentagem da Imagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "N° Imagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Periodo da Imagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aumento da Imagem";
            // 
            // cbMetodos
            // 
            this.cbMetodos.BackColor = System.Drawing.Color.Silver;
            this.cbMetodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMetodos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodos.FormattingEnabled = true;
            this.cbMetodos.Location = new System.Drawing.Point(708, 31);
            this.cbMetodos.Margin = new System.Windows.Forms.Padding(4);
            this.cbMetodos.Name = "cbMetodos";
            this.cbMetodos.Size = new System.Drawing.Size(248, 27);
            this.cbMetodos.TabIndex = 4;
            this.cbMetodos.SelectedIndexChanged += new System.EventHandler(this.cbMetodos_SelectedIndexChanged);
            // 
            // btnRemoverImagem
            // 
            this.btnRemoverImagem.BackColor = System.Drawing.Color.Silver;
            this.btnRemoverImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverImagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverImagem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverImagem.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverImagem.Location = new System.Drawing.Point(653, 197);
            this.btnRemoverImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverImagem.Name = "btnRemoverImagem";
            this.btnRemoverImagem.Size = new System.Drawing.Size(293, 41);
            this.btnRemoverImagem.TabIndex = 1;
            this.btnRemoverImagem.Text = "Remover Imagem";
            this.btnRemoverImagem.UseVisualStyleBackColor = false;
            this.btnRemoverImagem.Click += new System.EventHandler(this.btnRemoverImagem_Click);
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackColor = System.Drawing.Color.Silver;
            this.btnAdicionarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarImagem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarImagem.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(3, 6);
            this.btnAdicionarImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(204, 89);
            this.btnAdicionarImagem.TabIndex = 0;
            this.btnAdicionarImagem.Text = "Adicionar \r\nImagem";
            this.btnAdicionarImagem.UseVisualStyleBackColor = false;
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
            // 
            // picboxImagem
            // 
            this.picboxImagem.BackColor = System.Drawing.Color.Black;
            this.picboxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxImagem.Location = new System.Drawing.Point(267, 0);
            this.picboxImagem.Margin = new System.Windows.Forms.Padding(4);
            this.picboxImagem.Name = "picboxImagem";
            this.picboxImagem.Size = new System.Drawing.Size(964, 534);
            this.picboxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImagem.TabIndex = 5;
            this.picboxImagem.TabStop = false;
            // 
            // FormImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1231, 780);
            this.Controls.Add(this.picboxImagem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormImagens";
            this.Text = "Form_Imagens";
            this.VisibleChanged += new System.EventHandler(this.FormImagens_VisibleChanged);
            this.panel2.ResumeLayout(false);
            this.MenuImagens.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnImagemDados.ResumeLayout(false);
            this.pnImagemDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView TreeViewImagens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxImagem;
        private System.Windows.Forms.Panel pnImagemDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMetodos;
        private System.Windows.Forms.Button btnRemoverImagem;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.Button btnBaixarImagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.MaskedTextBox maskPeriodo;
        private System.Windows.Forms.MaskedTextBox maskGrupo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnReescrever;
        private System.Windows.Forms.Button btnTrocarImagem;
        private System.Windows.Forms.ContextMenuStrip MenuImagens;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAumento;
    }
}