using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace TCC_UNIFESP
{
    public class ProcessadorExcel
    {
        _Application Excel = new _Excel.Application();
        Worksheet worksheet;

        private void EscreverCelula(string Valor, int i, int j)
        {
            worksheet.Cells[j, i] = Valor;
        }

        public void BaixarExcel(string NomeArquivo, string NomeTeste, List<GraficoDados> Dados, string Caminho)
        {
            Workbook workbook = Excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.worksheet = workbook.Worksheets[1];
            int pos;

            EscreverCelula(NomeTeste, 1, 1);
            EscreverCelula("Média 1", 1, 4);
            EscreverCelula("Média 2", 3, 4);
            EscreverCelula("Resultado", 5, 4);
            EscreverCelula("Desvio Padrão 1", 9, 4);
            EscreverCelula("Desvio Padrão 2", 11, 4);
            EscreverCelula("Resultado", 13, 4);
            pos = 5;
            for (int i = 0; i < Dados.Count - 1; i++)
                for (int j = i + 1; j < Dados.Count; j++)
                {
                    EscreverCelula(Dados[i].Periodo, 1, pos);
                    EscreverCelula("vs", 2, pos);
                    EscreverCelula(Dados[j].Periodo, 3, pos);
                    EscreverCelula(" = ", 4, pos);
                    EscreverCelula((Dados[i].Media - Dados[j].Media).ToString("0.00"), 5, pos);
                    EscreverCelula(Dados[i].Periodo, 9, pos);
                    EscreverCelula("vs", 10, pos);
                    EscreverCelula(Dados[j].Periodo, 11, pos);
                    EscreverCelula(" = ", 12, pos);
                    EscreverCelula((Dados[i].DesvioPadrao - Dados[j].DesvioPadrao).ToString("0.00"), 13, pos);
                    pos++;
                }

            workbook.SaveAs($@"{Caminho}{NomeArquivo}");
            workbook.Close();
        }

        public void BaixarExcel(string NomeArquivo, TesteDados Teste, string Caminho)
        {
            Workbook workbook = Excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.worksheet = workbook.Worksheets[1];

            EscreverCelula("Nome", 1, 1);
            EscreverCelula(Teste.Nome, 2, 1);
            EscreverCelula("Tipo de Periodo", 1, 2);
            EscreverCelula((Teste.TipoPeriodo ? "Dia" : "Hora"), 2, 2);
            EscreverCelula("Frequencia do Periodo", 1, 3);
            EscreverCelula(Teste.FrequenciaPeriodo.ToString(), 2, 3);
            EscreverCelula("Tipo Aumento", 1, 4);
            EscreverCelula(Teste.TipoAumento.ToString(), 2, 4);
            EscreverCelula("Quantidade de Grupos", 1, 5);
            EscreverCelula(Teste.QuantidadeGrupos.ToString(), 2, 5);
            EscreverCelula("Quantidade de Imagens", 1, 6);
            EscreverCelula(Teste.QuantidadeImagens.ToString(), 2, 6);

            EscreverCelula("Aumento", 1, 10);
            EscreverCelula("Grupo", 2, 10);
            EscreverCelula("Periodo", 3, 10);
            EscreverCelula("Porcentagem", 4, 10);
            int cont = 11;
            foreach (ImagemDados imagem in Teste.Imagens)
            {
                EscreverCelula(imagem.Aumento, 1, cont);
                EscreverCelula(imagem.Grupo.ToString(), 2, cont);
                EscreverCelula($"{((imagem.Periodo == 0) ? "Controle" : $"{(Teste.TipoPeriodo ? "Dia" : "Hora")} {imagem.Periodo * Teste.FrequenciaPeriodo}")}", 3, cont);
                EscreverCelula(imagem.Porcentagem.ToString("0.00"), 4, cont);
                cont++;
            }

            EscreverCelula("Coluna", 8, 10);
            EscreverCelula("Média", 9, 10);
            EscreverCelula("Desvio Padrão", 10, 10);
            cont = 11;
            foreach (GraficoDados dado in Teste.Dados)
            {
                EscreverCelula(dado.Periodo, 8, cont);
                EscreverCelula(dado.Media.ToString("0.00"), 9, cont);
                EscreverCelula(dado.DesvioPadrao.ToString("0.00"), 10, cont);
                cont++;
            }
            workbook.SaveAs($@"{Caminho}{NomeArquivo}");
            workbook.Close();
        }
    }
}
