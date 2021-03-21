using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace TCC_UNIFESP
{
    public class ProcessadorDados
    {
        #region Funcoes Privadas
        private double CalcularMedia(List<ImagemDados> imagens)
        {
            double media = 0;
            foreach (ImagemDados imagem in imagens)
                media += imagem.Porcentagem;

            return media / imagens.Count;
        }

        private double CalcularDesvioPadrao(List<ImagemDados> imagens, double controle)
        {
            int cont = 0;
            double Media = (100 * CalcularMedia(imagens)) / controle;
            double NovaMedia = 0;
            foreach (ImagemDados imagem in imagens)
            {
                NovaMedia += Math.Pow(((100 * imagem.Porcentagem) / controle) - Media, 2);
                cont++;
            }
            return Math.Sqrt(NovaMedia / cont);
        }

        private Series CriarSeries(string name, Color cor, SeriesChartType Type)
        {
            return new Series() { Name = name, Color = cor, ChartType = Type };
        }

        private double PegarTamanhoGrafico(List<GraficoDados> Dados)
        {
            Dados = Dados.OrderBy(dd => dd.Media).ToList();
            GraficoDados dado = Dados[Dados.Count - 1];
            int valor = (int)(20 + dado.Media + (dado.DesvioPadrao / 2));
            while (valor % 50 != 0)
                valor++;
            return valor;
        }
        #endregion

        #region Funcoes Publicas

        public List<GraficoDados> ProcessarDados(TesteDados Teste)
        {
            List<GraficoDados> Dados = new List<GraficoDados>();
            if (Teste.Imagens.Count() > 0)
            {
                double Controle;
                if (Teste.Imagens.Exists(img => img.Periodo == 0))
                    Controle = CalcularMedia(Teste.Imagens.Where(img => img.Periodo == 0).ToList());
                else
                    Controle = CalcularMedia(Teste.Imagens.Where(img => img.Periodo == Teste.Imagens[0].Periodo).ToList());
                for (int i = 0; i <= Teste.Imagens.Max(img => img.Periodo); i++)
                {
                    List<ImagemDados> Valores = Teste.Imagens.Where(img => img.Periodo == i).ToList();
                    Dados.Add(new GraficoDados()
                    {
                        Media = (100 * CalcularMedia(Valores)) / Controle,
                        DesvioPadrao = CalcularDesvioPadrao(Valores, Controle),
                        Periodo = (i == 0) ? "Controle" : $"{(Teste.TipoPeriodo ? "Dia" : "Hora")} {i * Teste.FrequenciaPeriodo}"
                    });
                }
            }
            return Dados;
        }

        public string ProcessarTexto(List<GraficoDados> Dados)
        {
            StringBuilder Texto = new StringBuilder();

            for (int i = 0; i < Dados.Count - 1; i++)
            {
                for (int j = i + 1; j < Dados.Count; j++)
                {
                    Texto.AppendLine($"{Dados[i].Periodo} vs {Dados[j].Periodo} = {(Dados[i].Media - Dados[j].Media).ToString("0.00")}");
                    Texto.AppendLine($"(Desvio Padrao) {Dados[i].Periodo} vs {Dados[j].Periodo} = {(Dados[i].DesvioPadrao - Dados[j].DesvioPadrao).ToString("0.00")}\n");
                }
            }
            return Texto.ToString();
        }

        public string ProcessarTesteDados(TesteDados Teste)
        {
            StringBuilder Texto = new StringBuilder();

            Texto.AppendLine($"Nome : {Teste.Nome}");
            Texto.AppendLine($"Tipo de Periodo : {(Teste.TipoPeriodo ? "Dia" : "Hora")}");
            Texto.AppendLine($"Frequencia do Periodo : {Teste.FrequenciaPeriodo}");
            Texto.AppendLine($"Tipo Aumento : {Teste.TipoAumento}");
            Texto.AppendLine($"Quantidade de Grupos : {Teste.QuantidadeGrupos}");
            Texto.AppendLine($"Quantidade de Imagens : {Teste.QuantidadeImagens}");
            Texto.AppendLine("");
            Texto.AppendLine("");
            Texto.AppendLine("Dados da Imagens");
            foreach (ImagemDados imagem in Teste.Imagens)
                Texto.AppendLine($"Aumento = {imagem.Aumento} || Grupo = {imagem.Grupo}" +
                    $" || Periodo = {(imagem.Periodo * Teste.FrequenciaPeriodo)} {(Teste.TipoPeriodo ? "Dia" : "Hora")}" +
                    $" || Porcentagem = {imagem.Porcentagem.ToString("0.00")}");

            Texto.AppendLine("");
            Texto.AppendLine("");
            foreach (GraficoDados dado in Teste.Dados)
                Texto.AppendLine($"Coluna {dado.Periodo} Media = {dado.Media.ToString("0.00")} Desvio Padrao = {dado.DesvioPadrao.ToString("0.00")}");

            return Texto.ToString();
        }

        public void ProcessarGrafico(Chart Grafico, List<GraficoDados> Dados, bool[] periodos, bool coluna, bool coluna2, bool linha, bool ponto, bool dado)
        {
            Grafico.Series.Clear();
            if (Dados.Count > 0)
                Grafico.ChartAreas[0].Axes[1].Maximum = PegarTamanhoGrafico(Dados);
            if (coluna)
            {
                Grafico.Series.Add(CriarSeries("Média", Properties.Settings.Default.Coluna, SeriesChartType.Column));
                Grafico.Series["Média"].IsValueShownAsLabel = dado;
                dado = false;
            }
            if (coluna2)
            {
                Grafico.Series.Add(CriarSeries("Desvio Padrão", Properties.Settings.Default.Coluna2, SeriesChartType.ErrorBar));
                Grafico.Series["Desvio Padrão"].BorderWidth = Properties.Settings.Default.Coluna2_Borda;
            }

            if (linha)
            {
                Grafico.Series.Add(CriarSeries("Linha da Média", Properties.Settings.Default.Linha, SeriesChartType.Line));
                Grafico.Series["Linha da Média"].BorderWidth = Properties.Settings.Default.Linha_Borda;
                Grafico.Series["Linha da Média"].IsValueShownAsLabel = dado;
                dado = false;
            }

            if (ponto)
            {
                Grafico.Series.Add(CriarSeries("Pontos da Média", Properties.Settings.Default.Ponto, SeriesChartType.Point));
                Grafico.Series["Pontos da Média"].MarkerSize = Properties.Settings.Default.Ponto_Borda;
                Grafico.Series["Pontos da Média"].IsValueShownAsLabel = dado;
                dado = false;
            }
            for (int i = 0; i < Dados.Count; i++)
            {
                Dados[i].Media = Math.Round(Dados[i].Media, 2);
                if (periodos[i])
                {
                    if (coluna2)
                        Grafico.Series["Desvio Padrão"].Points.AddXY(Dados[i].Periodo, 0, Dados[i].Media - (Dados[i].DesvioPadrao / 2), Dados[i].Media + (Dados[i].DesvioPadrao / 2));

                    if (linha)
                        Grafico.Series["Linha da Média"].Points.AddXY(Dados[i].Periodo, Dados[i].Media);

                    if (ponto)
                        Grafico.Series["Pontos da Média"].Points.AddXY(Dados[i].Periodo, Dados[i].Media);

                    if (coluna)
                        Grafico.Series["Média"].Points.AddXY(Dados[i].Periodo, Dados[i].Media);
                }
            }
        }
        #endregion
    }
}
