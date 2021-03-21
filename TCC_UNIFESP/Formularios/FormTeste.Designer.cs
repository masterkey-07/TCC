namespace TCC_UNIFESP
{
    partial class FormTeste
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvarTodosTestes = new System.Windows.Forms.Button();
            this.btnSalvarSite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTestes = new System.Windows.Forms.ComboBox();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnReescrever = new System.Windows.Forms.Button();
            this.btnDeletarTeste = new System.Windows.Forms.Button();
            this.btnBaixarTeste = new System.Windows.Forms.Button();
            this.btnSalvarTeste = new System.Windows.Forms.Button();
            this.pnTesteDados = new System.Windows.Forms.Panel();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.lblQuantidadeImagens = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblInfoQuantImagens = new System.Windows.Forms.Label();
            this.txtNomeTeste = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskPeriodo = new System.Windows.Forms.MaskedTextBox();
            this.maskQuantGrupos = new System.Windows.Forms.MaskedTextBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeTeste = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnBaixarTexto = new System.Windows.Forms.Button();
            this.btnBaixarDados = new System.Windows.Forms.Button();
            this.btnBaixarGrafico = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkDadosGrafico = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.picboxPontodeMedia = new System.Windows.Forms.PictureBox();
            this.checkPontosMedia = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.picboxLinhaDesvioPadrao = new System.Windows.Forms.PictureBox();
            this.checkLinhaDesvio = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picboxColDesvioPadrao = new System.Windows.Forms.PictureBox();
            this.checkColDesvio = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picboxColMedia = new System.Windows.Forms.PictureBox();
            this.checkColMedia = new System.Windows.Forms.CheckBox();
            this.checkListPeriodo = new System.Windows.Forms.CheckedListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chartGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            this.pnTesteDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPontodeMedia)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLinhaDesvioPadrao)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColDesvioPadrao)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColMedia)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnSalvarTodosTestes);
            this.panel2.Controls.Add(this.btnSalvarSite);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbTestes);
            this.panel2.Controls.Add(this.btnDesfazer);
            this.panel2.Controls.Add(this.btnReescrever);
            this.panel2.Controls.Add(this.btnDeletarTeste);
            this.panel2.Controls.Add(this.btnBaixarTeste);
            this.panel2.Controls.Add(this.btnSalvarTeste);
            this.panel2.Controls.Add(this.pnTesteDados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 762);
            this.panel2.TabIndex = 1;
            this.panel2.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // btnSalvarTodosTestes
            // 
            this.btnSalvarTodosTestes.BackColor = System.Drawing.Color.Silver;
            this.btnSalvarTodosTestes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarTodosTestes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarTodosTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarTodosTestes.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTodosTestes.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarTodosTestes.Location = new System.Drawing.Point(4, 715);
            this.btnSalvarTodosTestes.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarTodosTestes.Name = "btnSalvarTodosTestes";
            this.btnSalvarTodosTestes.Size = new System.Drawing.Size(285, 43);
            this.btnSalvarTodosTestes.TabIndex = 29;
            this.btnSalvarTodosTestes.Text = "Salvar Todos Testes";
            this.btnSalvarTodosTestes.UseVisualStyleBackColor = false;
            this.btnSalvarTodosTestes.Click += new System.EventHandler(this.btnSalvarTodosTestes_Click);
            this.btnSalvarTodosTestes.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // btnSalvarSite
            // 
            this.btnSalvarSite.BackColor = System.Drawing.Color.Silver;
            this.btnSalvarSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarSite.Enabled = false;
            this.btnSalvarSite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarSite.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarSite.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarSite.Location = new System.Drawing.Point(4, 564);
            this.btnSalvarSite.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarSite.Name = "btnSalvarSite";
            this.btnSalvarSite.Size = new System.Drawing.Size(285, 43);
            this.btnSalvarSite.TabIndex = 28;
            this.btnSalvarSite.Text = "Salvar Site Como...";
            this.btnSalvarSite.UseVisualStyleBackColor = false;
            this.btnSalvarSite.Click += new System.EventHandler(this.btnSalvarSite_Click);
            this.btnSalvarSite.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Selecionar Teste";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // cbTestes
            // 
            this.cbTestes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTestes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTestes.BackColor = System.Drawing.Color.Silver;
            this.cbTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTestes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTestes.FormattingEnabled = true;
            this.cbTestes.Location = new System.Drawing.Point(11, 48);
            this.cbTestes.Margin = new System.Windows.Forms.Padding(4);
            this.cbTestes.Name = "cbTestes";
            this.cbTestes.Size = new System.Drawing.Size(233, 32);
            this.cbTestes.TabIndex = 10;
            this.cbTestes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTestes_KeyDown);
            this.cbTestes.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.BackColor = System.Drawing.Color.Silver;
            this.btnDesfazer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesfazer.Enabled = false;
            this.btnDesfazer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesfazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazer.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesfazer.ForeColor = System.Drawing.Color.Black;
            this.btnDesfazer.Location = new System.Drawing.Point(4, 614);
            this.btnDesfazer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(285, 43);
            this.btnDesfazer.TabIndex = 9;
            this.btnDesfazer.Text = "Desfazer Alterações";
            this.btnDesfazer.UseVisualStyleBackColor = false;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            this.btnDesfazer.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // btnReescrever
            // 
            this.btnReescrever.BackColor = System.Drawing.Color.Silver;
            this.btnReescrever.BackgroundImage = global::TCC_UNIFESP.Properties.Resources.Editar;
            this.btnReescrever.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReescrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReescrever.Enabled = false;
            this.btnReescrever.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReescrever.FlatAppearance.BorderSize = 0;
            this.btnReescrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReescrever.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReescrever.ForeColor = System.Drawing.Color.White;
            this.btnReescrever.Location = new System.Drawing.Point(249, 49);
            this.btnReescrever.Margin = new System.Windows.Forms.Padding(4);
            this.btnReescrever.Name = "btnReescrever";
            this.btnReescrever.Size = new System.Drawing.Size(43, 36);
            this.btnReescrever.TabIndex = 7;
            this.btnReescrever.UseVisualStyleBackColor = false;
            this.btnReescrever.Click += new System.EventHandler(this.btnReescrever_Click);
            this.btnReescrever.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // btnDeletarTeste
            // 
            this.btnDeletarTeste.BackColor = System.Drawing.Color.Silver;
            this.btnDeletarTeste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletarTeste.Enabled = false;
            this.btnDeletarTeste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletarTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarTeste.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarTeste.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarTeste.Location = new System.Drawing.Point(4, 665);
            this.btnDeletarTeste.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletarTeste.Name = "btnDeletarTeste";
            this.btnDeletarTeste.Size = new System.Drawing.Size(285, 43);
            this.btnDeletarTeste.TabIndex = 4;
            this.btnDeletarTeste.Text = "Remover Teste";
            this.btnDeletarTeste.UseVisualStyleBackColor = false;
            this.btnDeletarTeste.Click += new System.EventHandler(this.btnDeletarTeste_Click);
            this.btnDeletarTeste.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // btnBaixarTeste
            // 
            this.btnBaixarTeste.BackColor = System.Drawing.Color.Silver;
            this.btnBaixarTeste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixarTeste.Enabled = false;
            this.btnBaixarTeste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaixarTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixarTeste.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarTeste.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarTeste.Location = new System.Drawing.Point(4, 513);
            this.btnBaixarTeste.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarTeste.Name = "btnBaixarTeste";
            this.btnBaixarTeste.Size = new System.Drawing.Size(285, 43);
            this.btnBaixarTeste.TabIndex = 7;
            this.btnBaixarTeste.Text = "Salvar Teste Como...";
            this.btnBaixarTeste.UseVisualStyleBackColor = false;
            this.btnBaixarTeste.Click += new System.EventHandler(this.btnBaixarTeste_Click);
            this.btnBaixarTeste.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // btnSalvarTeste
            // 
            this.btnSalvarTeste.BackColor = System.Drawing.Color.Silver;
            this.btnSalvarTeste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarTeste.Enabled = false;
            this.btnSalvarTeste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarTeste.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTeste.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarTeste.Location = new System.Drawing.Point(4, 463);
            this.btnSalvarTeste.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarTeste.Name = "btnSalvarTeste";
            this.btnSalvarTeste.Size = new System.Drawing.Size(285, 43);
            this.btnSalvarTeste.TabIndex = 5;
            this.btnSalvarTeste.Text = "Salvar Teste";
            this.btnSalvarTeste.UseVisualStyleBackColor = false;
            this.btnSalvarTeste.Click += new System.EventHandler(this.btnSalvarTeste_Click);
            this.btnSalvarTeste.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // pnTesteDados
            // 
            this.pnTesteDados.BackColor = System.Drawing.Color.Silver;
            this.pnTesteDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTesteDados.Controls.Add(this.txtAumento);
            this.pnTesteDados.Controls.Add(this.lblQuantidadeImagens);
            this.pnTesteDados.Controls.Add(this.btnCancelar);
            this.pnTesteDados.Controls.Add(this.lblInfoQuantImagens);
            this.pnTesteDados.Controls.Add(this.txtNomeTeste);
            this.pnTesteDados.Controls.Add(this.btnConfirmar);
            this.pnTesteDados.Controls.Add(this.label1);
            this.pnTesteDados.Controls.Add(this.maskPeriodo);
            this.pnTesteDados.Controls.Add(this.maskQuantGrupos);
            this.pnTesteDados.Controls.Add(this.cbPeriodo);
            this.pnTesteDados.Controls.Add(this.label6);
            this.pnTesteDados.Controls.Add(this.label5);
            this.pnTesteDados.Controls.Add(this.label4);
            this.pnTesteDados.Enabled = false;
            this.pnTesteDados.Location = new System.Drawing.Point(4, 98);
            this.pnTesteDados.Margin = new System.Windows.Forms.Padding(4);
            this.pnTesteDados.Name = "pnTesteDados";
            this.pnTesteDados.Size = new System.Drawing.Size(285, 356);
            this.pnTesteDados.TabIndex = 8;
            this.pnTesteDados.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // txtAumento
            // 
            this.txtAumento.BackColor = System.Drawing.Color.Silver;
            this.txtAumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAumento.Location = new System.Drawing.Point(9, 97);
            this.txtAumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(98, 30);
            this.txtAumento.TabIndex = 34;
            this.txtAumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidadeImagens
            // 
            this.lblQuantidadeImagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantidadeImagens.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeImagens.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidadeImagens.Location = new System.Drawing.Point(9, 314);
            this.lblQuantidadeImagens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidadeImagens.Name = "lblQuantidadeImagens";
            this.lblQuantidadeImagens.Size = new System.Drawing.Size(98, 35);
            this.lblQuantidadeImagens.TabIndex = 33;
            this.lblQuantidadeImagens.Text = "0";
            this.lblQuantidadeImagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(144, 295);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 55);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInfoQuantImagens
            // 
            this.lblInfoQuantImagens.AutoSize = true;
            this.lblInfoQuantImagens.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoQuantImagens.ForeColor = System.Drawing.Color.Black;
            this.lblInfoQuantImagens.Location = new System.Drawing.Point(-1, 278);
            this.lblInfoQuantImagens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoQuantImagens.Name = "lblInfoQuantImagens";
            this.lblInfoQuantImagens.Size = new System.Drawing.Size(233, 24);
            this.lblInfoQuantImagens.TabIndex = 32;
            this.lblInfoQuantImagens.Text = "Quantidade de Imagens\r\n";
            this.lblInfoQuantImagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeTeste
            // 
            this.txtNomeTeste.BackColor = System.Drawing.Color.Silver;
            this.txtNomeTeste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeTeste.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTeste.Location = new System.Drawing.Point(9, 30);
            this.txtNomeTeste.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeTeste.Name = "txtNomeTeste";
            this.txtNomeTeste.Size = new System.Drawing.Size(239, 30);
            this.txtNomeTeste.TabIndex = 29;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Silver;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(4, 295);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(133, 55);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-5, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome do Teste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskPeriodo
            // 
            this.maskPeriodo.BackColor = System.Drawing.Color.Silver;
            this.maskPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskPeriodo.Location = new System.Drawing.Point(9, 240);
            this.maskPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskPeriodo.Mask = "00";
            this.maskPeriodo.Name = "maskPeriodo";
            this.maskPeriodo.Size = new System.Drawing.Size(98, 30);
            this.maskPeriodo.TabIndex = 26;
            this.maskPeriodo.Text = "01";
            this.maskPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskPeriodo.ValidatingType = typeof(int);
            // 
            // maskQuantGrupos
            // 
            this.maskQuantGrupos.BackColor = System.Drawing.Color.Silver;
            this.maskQuantGrupos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskQuantGrupos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskQuantGrupos.Location = new System.Drawing.Point(9, 172);
            this.maskQuantGrupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskQuantGrupos.Mask = "00";
            this.maskQuantGrupos.Name = "maskQuantGrupos";
            this.maskQuantGrupos.Size = new System.Drawing.Size(98, 30);
            this.maskQuantGrupos.TabIndex = 25;
            this.maskQuantGrupos.Text = "03";
            this.maskQuantGrupos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskQuantGrupos.ValidatingType = typeof(int);
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.BackColor = System.Drawing.Color.Silver;
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "Horas",
            "Dias"});
            this.cbPeriodo.Location = new System.Drawing.Point(115, 239);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(96, 32);
            this.cbPeriodo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-1, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Periodo entre os grupos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Aumento das Imagens";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nº Imagens por Grupo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeTeste
            // 
            this.lblNomeTeste.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeTeste.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTeste.ForeColor = System.Drawing.Color.Black;
            this.lblNomeTeste.Location = new System.Drawing.Point(0, 0);
            this.lblNomeTeste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeTeste.Name = "lblNomeTeste";
            this.lblNomeTeste.Size = new System.Drawing.Size(567, 49);
            this.lblNomeTeste.TabIndex = 7;
            this.lblNomeTeste.Text = "Teste Selecionado";
            this.lblNomeTeste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.rtxtTexto);
            this.panel1.Controls.Add(this.btnBaixarTexto);
            this.panel1.Controls.Add(this.btnBaixarDados);
            this.panel1.Controls.Add(this.btnBaixarGrafico);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.checkListPeriodo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(863, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 762);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.BackColor = System.Drawing.Color.White;
            this.rtxtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtTexto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTexto.Location = new System.Drawing.Point(0, 459);
            this.rtxtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.ReadOnly = true;
            this.rtxtTexto.Size = new System.Drawing.Size(368, 303);
            this.rtxtTexto.TabIndex = 59;
            this.rtxtTexto.Text = "";
            // 
            // btnBaixarTexto
            // 
            this.btnBaixarTexto.BackColor = System.Drawing.Color.Silver;
            this.btnBaixarTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixarTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaixarTexto.Enabled = false;
            this.btnBaixarTexto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaixarTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixarTexto.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarTexto.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarTexto.Location = new System.Drawing.Point(0, 419);
            this.btnBaixarTexto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarTexto.Name = "btnBaixarTexto";
            this.btnBaixarTexto.Size = new System.Drawing.Size(368, 40);
            this.btnBaixarTexto.TabIndex = 33;
            this.btnBaixarTexto.Text = "Baixar Diferança dos Dados";
            this.btnBaixarTexto.UseVisualStyleBackColor = false;
            this.btnBaixarTexto.Click += new System.EventHandler(this.btnBaixarTexto_Click);
            // 
            // btnBaixarDados
            // 
            this.btnBaixarDados.BackColor = System.Drawing.Color.Silver;
            this.btnBaixarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixarDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaixarDados.Enabled = false;
            this.btnBaixarDados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaixarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixarDados.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarDados.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarDados.Location = new System.Drawing.Point(0, 379);
            this.btnBaixarDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarDados.Name = "btnBaixarDados";
            this.btnBaixarDados.Size = new System.Drawing.Size(368, 40);
            this.btnBaixarDados.TabIndex = 61;
            this.btnBaixarDados.Text = "Baixar Todos os Dados";
            this.btnBaixarDados.UseVisualStyleBackColor = false;
            this.btnBaixarDados.Click += new System.EventHandler(this.btnBaixarDados_Click);
            // 
            // btnBaixarGrafico
            // 
            this.btnBaixarGrafico.BackColor = System.Drawing.Color.Silver;
            this.btnBaixarGrafico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixarGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaixarGrafico.Enabled = false;
            this.btnBaixarGrafico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBaixarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixarGrafico.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarGrafico.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarGrafico.Location = new System.Drawing.Point(0, 339);
            this.btnBaixarGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarGrafico.Name = "btnBaixarGrafico";
            this.btnBaixarGrafico.Size = new System.Drawing.Size(368, 40);
            this.btnBaixarGrafico.TabIndex = 11;
            this.btnBaixarGrafico.Text = "Baixar Gráfico";
            this.btnBaixarGrafico.UseVisualStyleBackColor = false;
            this.btnBaixarGrafico.Click += new System.EventHandler(this.btnBaixarGrafico_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkDadosGrafico);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 301);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 38);
            this.panel3.TabIndex = 60;
            // 
            // checkDadosGrafico
            // 
            this.checkDadosGrafico.AutoSize = true;
            this.checkDadosGrafico.Checked = true;
            this.checkDadosGrafico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDadosGrafico.Enabled = false;
            this.checkDadosGrafico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDadosGrafico.Location = new System.Drawing.Point(4, 4);
            this.checkDadosGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.checkDadosGrafico.Name = "checkDadosGrafico";
            this.checkDadosGrafico.Size = new System.Drawing.Size(198, 28);
            this.checkDadosGrafico.TabIndex = 52;
            this.checkDadosGrafico.Text = "Dados do Gráfico";
            this.checkDadosGrafico.UseVisualStyleBackColor = true;
            this.checkDadosGrafico.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.picboxPontodeMedia);
            this.panel8.Controls.Add(this.checkPontosMedia);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 263);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(368, 38);
            this.panel8.TabIndex = 58;
            // 
            // picboxPontodeMedia
            // 
            this.picboxPontodeMedia.Location = new System.Drawing.Point(224, 6);
            this.picboxPontodeMedia.Margin = new System.Windows.Forms.Padding(4);
            this.picboxPontodeMedia.Name = "picboxPontodeMedia";
            this.picboxPontodeMedia.Size = new System.Drawing.Size(40, 25);
            this.picboxPontodeMedia.TabIndex = 53;
            this.picboxPontodeMedia.TabStop = false;
            // 
            // checkPontosMedia
            // 
            this.checkPontosMedia.AutoSize = true;
            this.checkPontosMedia.Checked = true;
            this.checkPontosMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPontosMedia.Enabled = false;
            this.checkPontosMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPontosMedia.Location = new System.Drawing.Point(4, 4);
            this.checkPontosMedia.Margin = new System.Windows.Forms.Padding(4);
            this.checkPontosMedia.Name = "checkPontosMedia";
            this.checkPontosMedia.Size = new System.Drawing.Size(203, 28);
            this.checkPontosMedia.TabIndex = 52;
            this.checkPontosMedia.Text = "Pontos da Média -";
            this.checkPontosMedia.UseVisualStyleBackColor = true;
            this.checkPontosMedia.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.picboxLinhaDesvioPadrao);
            this.panel6.Controls.Add(this.checkLinhaDesvio);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 227);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(368, 36);
            this.panel6.TabIndex = 56;
            // 
            // picboxLinhaDesvioPadrao
            // 
            this.picboxLinhaDesvioPadrao.Location = new System.Drawing.Point(211, 14);
            this.picboxLinhaDesvioPadrao.Margin = new System.Windows.Forms.Padding(4);
            this.picboxLinhaDesvioPadrao.Name = "picboxLinhaDesvioPadrao";
            this.picboxLinhaDesvioPadrao.Size = new System.Drawing.Size(40, 12);
            this.picboxLinhaDesvioPadrao.TabIndex = 55;
            this.picboxLinhaDesvioPadrao.TabStop = false;
            // 
            // checkLinhaDesvio
            // 
            this.checkLinhaDesvio.AutoSize = true;
            this.checkLinhaDesvio.Checked = true;
            this.checkLinhaDesvio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLinhaDesvio.Enabled = false;
            this.checkLinhaDesvio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLinhaDesvio.Location = new System.Drawing.Point(4, 4);
            this.checkLinhaDesvio.Margin = new System.Windows.Forms.Padding(4);
            this.checkLinhaDesvio.Name = "checkLinhaDesvio";
            this.checkLinhaDesvio.Size = new System.Drawing.Size(188, 28);
            this.checkLinhaDesvio.TabIndex = 54;
            this.checkLinhaDesvio.Text = "Linha da Média -";
            this.checkLinhaDesvio.UseVisualStyleBackColor = true;
            this.checkLinhaDesvio.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.picboxColDesvioPadrao);
            this.panel5.Controls.Add(this.checkColDesvio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 190);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 37);
            this.panel5.TabIndex = 55;
            // 
            // picboxColDesvioPadrao
            // 
            this.picboxColDesvioPadrao.Location = new System.Drawing.Point(324, 7);
            this.picboxColDesvioPadrao.Margin = new System.Windows.Forms.Padding(4);
            this.picboxColDesvioPadrao.Name = "picboxColDesvioPadrao";
            this.picboxColDesvioPadrao.Size = new System.Drawing.Size(40, 25);
            this.picboxColDesvioPadrao.TabIndex = 54;
            this.picboxColDesvioPadrao.TabStop = false;
            // 
            // checkColDesvio
            // 
            this.checkColDesvio.AutoSize = true;
            this.checkColDesvio.Checked = true;
            this.checkColDesvio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkColDesvio.Enabled = false;
            this.checkColDesvio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkColDesvio.Location = new System.Drawing.Point(4, 4);
            this.checkColDesvio.Margin = new System.Windows.Forms.Padding(4);
            this.checkColDesvio.Name = "checkColDesvio";
            this.checkColDesvio.Size = new System.Drawing.Size(294, 28);
            this.checkColDesvio.TabIndex = 53;
            this.checkColDesvio.Text = "Colunas de Desvio Padrão -";
            this.checkColDesvio.UseVisualStyleBackColor = true;
            this.checkColDesvio.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picboxColMedia);
            this.panel4.Controls.Add(this.checkColMedia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 152);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 38);
            this.panel4.TabIndex = 54;
            // 
            // picboxColMedia
            // 
            this.picboxColMedia.Location = new System.Drawing.Point(237, 7);
            this.picboxColMedia.Margin = new System.Windows.Forms.Padding(4);
            this.picboxColMedia.Name = "picboxColMedia";
            this.picboxColMedia.Size = new System.Drawing.Size(40, 25);
            this.picboxColMedia.TabIndex = 53;
            this.picboxColMedia.TabStop = false;
            // 
            // checkColMedia
            // 
            this.checkColMedia.AutoSize = true;
            this.checkColMedia.Checked = true;
            this.checkColMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkColMedia.Enabled = false;
            this.checkColMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkColMedia.Location = new System.Drawing.Point(4, 4);
            this.checkColMedia.Margin = new System.Windows.Forms.Padding(4);
            this.checkColMedia.Name = "checkColMedia";
            this.checkColMedia.Size = new System.Drawing.Size(213, 28);
            this.checkColMedia.TabIndex = 52;
            this.checkColMedia.Text = "Colunas de Média -";
            this.checkColMedia.UseVisualStyleBackColor = true;
            this.checkColMedia.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // checkListPeriodo
            // 
            this.checkListPeriodo.BackColor = System.Drawing.Color.Silver;
            this.checkListPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkListPeriodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkListPeriodo.Enabled = false;
            this.checkListPeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListPeriodo.FormattingEnabled = true;
            this.checkListPeriodo.Location = new System.Drawing.Point(0, 0);
            this.checkListPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.checkListPeriodo.Name = "checkListPeriodo";
            this.checkListPeriodo.Size = new System.Drawing.Size(368, 152);
            this.checkListPeriodo.TabIndex = 29;
            this.checkListPeriodo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkListPeriodo_MouseUp);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chartGrafico);
            this.panel7.Controls.Add(this.lblNomeTeste);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(296, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(567, 762);
            this.panel7.TabIndex = 5;
            // 
            // chartGrafico
            // 
            this.chartGrafico.BackColor = System.Drawing.Color.Silver;
            chartArea1.Area3DStyle.Inclination = 0;
            chartArea1.Area3DStyle.Rotation = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chartGrafico.ChartAreas.Add(chartArea1);
            this.chartGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGrafico.Location = new System.Drawing.Point(0, 49);
            this.chartGrafico.Margin = new System.Windows.Forms.Padding(0);
            this.chartGrafico.Name = "chartGrafico";
            series1.ChartArea = "ChartArea1";
            series1.MarkerSize = 3;
            series1.Name = "Média";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series2.Name = "Desvio Padrão";
            series2.YValuesPerPoint = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Linha da Média";
            series4.BorderWidth = 1000;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Name = "Pontos da Média";
            series4.YValuesPerPoint = 2;
            this.chartGrafico.Series.Add(series1);
            this.chartGrafico.Series.Add(series2);
            this.chartGrafico.Series.Add(series3);
            this.chartGrafico.Series.Add(series4);
            this.chartGrafico.Size = new System.Drawing.Size(567, 713);
            this.chartGrafico.TabIndex = 8;
            // 
            // FormTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1231, 762);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTeste";
            this.Text = "Form_Teste";
            this.VisibleChanged += new System.EventHandler(this.FormTeste_VisibleChanged);
            this.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnTesteDados.ResumeLayout(false);
            this.pnTesteDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPontodeMedia)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLinhaDesvioPadrao)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColDesvioPadrao)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColMedia)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTesteDados;
        private System.Windows.Forms.Label lblNomeTeste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReescrever;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkListPeriodo;
        private System.Windows.Forms.MaskedTextBox maskQuantGrupos;
        private System.Windows.Forms.MaskedTextBox maskPeriodo;
        private System.Windows.Forms.Button btnBaixarTexto;
        private System.Windows.Forms.Button btnBaixarGrafico;
        private System.Windows.Forms.TextBox txtNomeTeste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picboxColMedia;
        private System.Windows.Forms.CheckBox checkColMedia;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picboxColDesvioPadrao;
        private System.Windows.Forms.CheckBox checkColDesvio;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox picboxLinhaDesvioPadrao;
        private System.Windows.Forms.CheckBox checkLinhaDesvio;
        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox picboxPontodeMedia;
        private System.Windows.Forms.CheckBox checkPontosMedia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkDadosGrafico;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnDeletarTeste;
        private System.Windows.Forms.Button btnBaixarTeste;
        private System.Windows.Forms.Button btnSalvarTeste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico;
        private System.Windows.Forms.Button btnSalvarSite;
        private System.Windows.Forms.Button btnSalvarTodosTestes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBaixarDados;
        private System.Windows.Forms.Label lblQuantidadeImagens;
        private System.Windows.Forms.Label lblInfoQuantImagens;
        public System.Windows.Forms.ComboBox cbTestes;
        private System.Windows.Forms.TextBox txtAumento;
    }
}