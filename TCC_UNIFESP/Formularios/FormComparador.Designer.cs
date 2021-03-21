namespace TCC_UNIFESP
{
    partial class FormComparador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartGrafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtTexto1 = new System.Windows.Forms.RichTextBox();
            this.listTestes1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartGrafico2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxtTexto2 = new System.Windows.Forms.RichTextBox();
            this.listTestes2 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkDadosGrafico = new System.Windows.Forms.CheckBox();
            this.picboxPontodeMedia = new System.Windows.Forms.PictureBox();
            this.checkPontosMedia = new System.Windows.Forms.CheckBox();
            this.picboxLinhaDesvioPadrao = new System.Windows.Forms.PictureBox();
            this.picboxColDesvio = new System.Windows.Forms.PictureBox();
            this.picboxColMedia = new System.Windows.Forms.PictureBox();
            this.checkLinhaDesvio = new System.Windows.Forms.CheckBox();
            this.checkColDesvio = new System.Windows.Forms.CheckBox();
            this.checkColMedia = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPontodeMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLinhaDesvioPadrao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColDesvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.chartGrafico1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 715);
            this.panel1.TabIndex = 0;
            // 
            // chartGrafico1
            // 
            this.chartGrafico1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Area3DStyle.Inclination = 0;
            chartArea1.Area3DStyle.Rotation = 0;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.Name = "ChartArea1";
            this.chartGrafico1.ChartAreas.Add(chartArea1);
            this.chartGrafico1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGrafico1.Location = new System.Drawing.Point(0, 0);
            this.chartGrafico1.Margin = new System.Windows.Forms.Padding(0);
            this.chartGrafico1.Name = "chartGrafico1";
            series1.ChartArea = "ChartArea1";
            series1.MarkerSize = 3;
            series1.Name = "Média";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series2.Name = "Desvio Padrão";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Linha Desvio Padrão";
            this.chartGrafico1.Series.Add(series1);
            this.chartGrafico1.Series.Add(series2);
            this.chartGrafico1.Series.Add(series3);
            this.chartGrafico1.Size = new System.Drawing.Size(613, 353);
            this.chartGrafico1.TabIndex = 6;
            this.chartGrafico1.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtTexto1);
            this.panel2.Controls.Add(this.listTestes1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 362);
            this.panel2.TabIndex = 3;
            // 
            // rtxtTexto1
            // 
            this.rtxtTexto1.BackColor = System.Drawing.Color.White;
            this.rtxtTexto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtTexto1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTexto1.Location = new System.Drawing.Point(213, 0);
            this.rtxtTexto1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtTexto1.Name = "rtxtTexto1";
            this.rtxtTexto1.ReadOnly = true;
            this.rtxtTexto1.Size = new System.Drawing.Size(400, 362);
            this.rtxtTexto1.TabIndex = 35;
            this.rtxtTexto1.Text = "";
            this.rtxtTexto1.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // listTestes1
            // 
            this.listTestes1.BackColor = System.Drawing.Color.Silver;
            this.listTestes1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTestes1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listTestes1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTestes1.FormattingEnabled = true;
            this.listTestes1.ItemHeight = 23;
            this.listTestes1.Location = new System.Drawing.Point(0, 0);
            this.listTestes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listTestes1.Name = "listTestes1";
            this.listTestes1.Size = new System.Drawing.Size(213, 362);
            this.listTestes1.TabIndex = 4;
            this.listTestes1.SelectedIndexChanged += new System.EventHandler(this.listTestes1_SelectedIndexChanged);
            this.listTestes1.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.chartGrafico2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(618, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 715);
            this.panel3.TabIndex = 1;
            // 
            // chartGrafico2
            // 
            this.chartGrafico2.BackColor = System.Drawing.Color.Silver;
            chartArea2.Area3DStyle.Inclination = 0;
            chartArea2.Area3DStyle.Rotation = 0;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.Name = "ChartArea1";
            this.chartGrafico2.ChartAreas.Add(chartArea2);
            this.chartGrafico2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGrafico2.Location = new System.Drawing.Point(0, 0);
            this.chartGrafico2.Margin = new System.Windows.Forms.Padding(0);
            this.chartGrafico2.Name = "chartGrafico2";
            series4.ChartArea = "ChartArea1";
            series4.MarkerSize = 3;
            series4.Name = "Média";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series5.Name = "Desvio Padrão";
            series5.YValuesPerPoint = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Linha Desvio Padrão";
            this.chartGrafico2.Series.Add(series4);
            this.chartGrafico2.Series.Add(series5);
            this.chartGrafico2.Series.Add(series6);
            this.chartGrafico2.Size = new System.Drawing.Size(613, 353);
            this.chartGrafico2.TabIndex = 6;
            this.chartGrafico2.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtxtTexto2);
            this.panel4.Controls.Add(this.listTestes2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 353);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 362);
            this.panel4.TabIndex = 5;
            // 
            // rtxtTexto2
            // 
            this.rtxtTexto2.BackColor = System.Drawing.Color.White;
            this.rtxtTexto2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtTexto2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTexto2.Location = new System.Drawing.Point(0, 0);
            this.rtxtTexto2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtTexto2.Name = "rtxtTexto2";
            this.rtxtTexto2.ReadOnly = true;
            this.rtxtTexto2.Size = new System.Drawing.Size(400, 362);
            this.rtxtTexto2.TabIndex = 35;
            this.rtxtTexto2.Text = "";
            this.rtxtTexto2.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // listTestes2
            // 
            this.listTestes2.BackColor = System.Drawing.Color.Silver;
            this.listTestes2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTestes2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listTestes2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTestes2.FormattingEnabled = true;
            this.listTestes2.ItemHeight = 23;
            this.listTestes2.Location = new System.Drawing.Point(400, 0);
            this.listTestes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listTestes2.Name = "listTestes2";
            this.listTestes2.Size = new System.Drawing.Size(213, 362);
            this.listTestes2.TabIndex = 4;
            this.listTestes2.SelectedIndexChanged += new System.EventHandler(this.listTestes2_SelectedIndexChanged);
            this.listTestes2.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.checkDadosGrafico);
            this.panel5.Controls.Add(this.picboxPontodeMedia);
            this.panel5.Controls.Add(this.checkPontosMedia);
            this.panel5.Controls.Add(this.picboxLinhaDesvioPadrao);
            this.panel5.Controls.Add(this.picboxColDesvio);
            this.panel5.Controls.Add(this.picboxColMedia);
            this.panel5.Controls.Add(this.checkLinhaDesvio);
            this.panel5.Controls.Add(this.checkColDesvio);
            this.panel5.Controls.Add(this.checkColMedia);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 715);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1231, 65);
            this.panel5.TabIndex = 2;
            // 
            // checkDadosGrafico
            // 
            this.checkDadosGrafico.AutoSize = true;
            this.checkDadosGrafico.Checked = true;
            this.checkDadosGrafico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDadosGrafico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDadosGrafico.Location = new System.Drawing.Point(304, 28);
            this.checkDadosGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDadosGrafico.Name = "checkDadosGrafico";
            this.checkDadosGrafico.Size = new System.Drawing.Size(198, 28);
            this.checkDadosGrafico.TabIndex = 56;
            this.checkDadosGrafico.Text = "Dados do Grafico";
            this.checkDadosGrafico.UseVisualStyleBackColor = true;
            this.checkDadosGrafico.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // picboxPontodeMedia
            // 
            this.picboxPontodeMedia.Location = new System.Drawing.Point(224, 36);
            this.picboxPontodeMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxPontodeMedia.Name = "picboxPontodeMedia";
            this.picboxPontodeMedia.Size = new System.Drawing.Size(40, 25);
            this.picboxPontodeMedia.TabIndex = 55;
            this.picboxPontodeMedia.TabStop = false;
            // 
            // checkPontosMedia
            // 
            this.checkPontosMedia.AutoSize = true;
            this.checkPontosMedia.Checked = true;
            this.checkPontosMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPontosMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPontosMedia.Location = new System.Drawing.Point(4, 33);
            this.checkPontosMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkPontosMedia.Name = "checkPontosMedia";
            this.checkPontosMedia.Size = new System.Drawing.Size(203, 28);
            this.checkPontosMedia.TabIndex = 54;
            this.checkPontosMedia.Text = "Pontos da Média -";
            this.checkPontosMedia.UseVisualStyleBackColor = true;
            this.checkPontosMedia.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            this.checkPontosMedia.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // picboxLinhaDesvioPadrao
            // 
            this.picboxLinhaDesvioPadrao.Location = new System.Drawing.Point(992, 10);
            this.picboxLinhaDesvioPadrao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxLinhaDesvioPadrao.Name = "picboxLinhaDesvioPadrao";
            this.picboxLinhaDesvioPadrao.Size = new System.Drawing.Size(40, 12);
            this.picboxLinhaDesvioPadrao.TabIndex = 53;
            this.picboxLinhaDesvioPadrao.TabStop = false;
            // 
            // picboxColDesvio
            // 
            this.picboxColDesvio.Location = new System.Drawing.Point(624, 5);
            this.picboxColDesvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxColDesvio.Name = "picboxColDesvio";
            this.picboxColDesvio.Size = new System.Drawing.Size(40, 25);
            this.picboxColDesvio.TabIndex = 52;
            this.picboxColDesvio.TabStop = false;
            // 
            // picboxColMedia
            // 
            this.picboxColMedia.Location = new System.Drawing.Point(237, 5);
            this.picboxColMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxColMedia.Name = "picboxColMedia";
            this.picboxColMedia.Size = new System.Drawing.Size(40, 25);
            this.picboxColMedia.TabIndex = 51;
            this.picboxColMedia.TabStop = false;
            // 
            // checkLinhaDesvio
            // 
            this.checkLinhaDesvio.AutoSize = true;
            this.checkLinhaDesvio.Checked = true;
            this.checkLinhaDesvio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLinhaDesvio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLinhaDesvio.Location = new System.Drawing.Point(699, -1);
            this.checkLinhaDesvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLinhaDesvio.Name = "checkLinhaDesvio";
            this.checkLinhaDesvio.Size = new System.Drawing.Size(270, 28);
            this.checkLinhaDesvio.TabIndex = 35;
            this.checkLinhaDesvio.Text = "Linha do Desvio Padrão -";
            this.checkLinhaDesvio.UseVisualStyleBackColor = true;
            this.checkLinhaDesvio.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // checkColDesvio
            // 
            this.checkColDesvio.AutoSize = true;
            this.checkColDesvio.Checked = true;
            this.checkColDesvio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkColDesvio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkColDesvio.Location = new System.Drawing.Point(304, -1);
            this.checkColDesvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkColDesvio.Name = "checkColDesvio";
            this.checkColDesvio.Size = new System.Drawing.Size(294, 28);
            this.checkColDesvio.TabIndex = 34;
            this.checkColDesvio.Text = "Colunas de Desvio Padrão -";
            this.checkColDesvio.UseVisualStyleBackColor = true;
            this.checkColDesvio.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            // 
            // checkColMedia
            // 
            this.checkColMedia.AutoSize = true;
            this.checkColMedia.Checked = true;
            this.checkColMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkColMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkColMedia.Location = new System.Drawing.Point(4, -1);
            this.checkColMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkColMedia.Name = "checkColMedia";
            this.checkColMedia.Size = new System.Drawing.Size(213, 28);
            this.checkColMedia.TabIndex = 33;
            this.checkColMedia.Text = "Colunas de Media -";
            this.checkColMedia.UseVisualStyleBackColor = true;
            this.checkColMedia.CheckedChanged += new System.EventHandler(this.checkColMedia_CheckedChanged);
            this.checkColMedia.MouseEnter += new System.EventHandler(this.Form_MouseEnter);
            // 
            // FormComparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1231, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComparador";
            this.Text = "Form_Comparador";
            this.SizeChanged += new System.EventHandler(this.Form_Comparador_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.FormComparador_VisibleChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPontodeMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLinhaDesvioPadrao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColDesvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listTestes1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listTestes2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkLinhaDesvio;
        private System.Windows.Forms.CheckBox checkColDesvio;
        private System.Windows.Forms.RichTextBox rtxtTexto2;
        private System.Windows.Forms.RichTextBox rtxtTexto1;
        private System.Windows.Forms.PictureBox picboxLinhaDesvioPadrao;
        private System.Windows.Forms.PictureBox picboxColDesvio;
        private System.Windows.Forms.PictureBox picboxColMedia;
        private System.Windows.Forms.CheckBox checkColMedia;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico2;
        private System.Windows.Forms.PictureBox picboxPontodeMedia;
        private System.Windows.Forms.CheckBox checkPontosMedia;
        private System.Windows.Forms.CheckBox checkDadosGrafico;
    }
}