using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC_UNIFESP
{
    public class ProcessadorWeb
    {
        public string GerarHTML(TesteDados Teste)
        {
            StringBuilder HTML = new StringBuilder();
            HTML.AppendLine("<html>");
            HTML.AppendLine(GerarHead(Teste.Nome));
            HTML.AppendLine(@"<body>
                             <center>
                             <table width = '1200'>");

            HTML.AppendLine(GerarInicio(Teste.Nome, Teste.TipoAumento, (Teste.TipoPeriodo) ? "Dias" : "Horas"));

            HTML.AppendLine(GerarTabelaImagens(Teste.Imagens));

            HTML.AppendLine(GerarTabelaImagensConvertidas(Teste.Imagens));

            HTML.AppendLine(GerarTabelaDados(Teste.Dados));

            HTML.AppendLine(@"</table>
                              </center>
                              </body>");
            HTML.AppendLine("</html>");

            return HTML.ToString();
        }

        #region Funcoes Privadas              
        private string GerarTabelaDados(List<GraficoDados> Dados)
        {
            StringBuilder Tabela = new StringBuilder();

            Tabela.AppendLine(@"<tr>
                              <td colspan = '5'>
                              <label class='FundoPreto'>
                              <h2><b>Diferença da Média e Desvio Padrão</b></h2>
                              </label>
                              </td>
                              </tr>
                              <tr>
                              <td colspan='5' width='100%'>
                              <table width='100%' class='w3-table w3-bordered w3-centered'>
                              <tr>
                              <td>
                              <a id='GRAFICO'></a>
                              <label class='FundoTextoDados'><b>Periodo 1</b></label>
                              </td>
                              <td></td>
                              <td>
                              <label class='FundoTextoDados'><b>Periodo 2</b></label>
                              </td>
                              <td>
                              <label class='FundoTextoDados'><b>Diferença da Média</b></label>
                              </td>
                              <td>
                              <label class='FundoTextoDados'><b>Diferença do Desvio Padrão</b></label>
                              </td>
                              </tr>");

            for (int i = 0; i < Dados.Count - 1; i++)
                for (int j = i + 1; j < Dados.Count; j++)
                {
                    Tabela.AppendLine("<tr>");
                    Tabela.AppendLine($"<td><label class='FundoTextoDados'>{Dados[i].Periodo}</label></td>");
                    Tabela.AppendLine($"<td><label class='FundoTextoDados'>vs</label></td>");
                    Tabela.AppendLine($"<td><label class='FundoTextoDados'>{Dados[j].Periodo}</label></td>");
                    Tabela.AppendLine($"<td><label class='FundoTextoDados'>{(Dados[i].Media - Dados[j].Media).ToString("0.00")}</label></td>");
                    Tabela.AppendLine($"<td><label class='FundoTextoDados'>{(Dados[i].DesvioPadrao - Dados[j].DesvioPadrao).ToString("0.00")}</label></td>");
                    Tabela.AppendLine("</tr>");
                }

            Tabela.AppendLine(@"</table>
                                </td>
                                </tr>");

            return Tabela.ToString();
        }

        private string GerarTabelaImagensConvertidas(List<ImagemDados> Imagens)
        {
            StringBuilder Tabela = new StringBuilder();

            Tabela.AppendLine(@"<tr>
                                <td colspan='5'>
                                <label class='FundoPreto'>
                                <h2><b>Imagens Convertidas</b></h2>
                                </label>
                                </td>
                                </tr>");

            for (int i = 0; i <= Imagens.Max(img => img.Periodo); i++)
            {
                Tabela.AppendLine("<tr>");
                foreach (ImagemDados imagem in Imagens.Where(img => img.Periodo == i).OrderBy(img => img.Grupo).ToList())
                {
                    Tabela.AppendLine($@"<td>
                                        <a href = '#LINHA{i}2' id='LINHA{i}'>
                                        <div class='w3-card ImagemEspaço'>");
                    Tabela.AppendLine($@"<img 
                                         src='Imagens/{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}-convertida.{Properties.Settings.Default.FormatoImagem}'
                                         width='100%' alt='Lights'>");
                    Tabela.AppendLine("<div class='w3-container TextoImagem'>");
                    Tabela.AppendLine($"<h5>Porcentagem = {imagem.Porcentagem.ToString("0.00")}</h5>");
                    Tabela.AppendLine("</div></div></td>");
                }
                Tabela.AppendLine("</tr>");
            }

            return Tabela.ToString();
        }

        private string GerarTabelaImagens(List<ImagemDados> Imagens)
        {
            StringBuilder Tabela = new StringBuilder();

            Tabela.AppendLine(@"<tr>
                                <td colspan='5'>
                                <label class='FundoPreto'>
                                <h2><b>Imagens</b></h2>
                                </label>
                                </td>
                                </tr>");

            for (int i = 0; i <= Imagens.Max(img => img.Periodo); i++)
            {
                Tabela.AppendLine("<tr>");
                foreach (ImagemDados imagem in Imagens.Where(img => img.Periodo == i).OrderBy(img => img.Grupo).ToList())
                {
                    Tabela.AppendLine($@"<td>
                                        <a href='#LINHA{i}' id = 'LINHA{i}2'>
                                        <div class='w3-card ImagemEspaço'>");
                    Tabela.AppendLine($@"<img 
                                         src='Imagens/{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}.{Properties.Settings.Default.FormatoImagem}'
                                         width='100%' alt='Lights'>");
                    Tabela.AppendLine("<div class='w3-container TextoImagem'>");
                    Tabela.AppendLine($"<h5>Porcentagem = {imagem.Porcentagem.ToString("0.00")}</h5>");
                    Tabela.AppendLine("</div></div></td>");
                }
                Tabela.AppendLine("</tr>");
            }

            return Tabela.ToString();
        }

        private string GerarInicio(string Nome, string Aumento, string Periodo)
        {
            return @"<tr>
                     <td colspan='5'>
                     <label class='FundoPreto'>
                     <center>
                     <h1><b>" + Nome + @"</b></h1>
                     </center>
                     </label>
                     </td>
                    </tr>

                     <tr>
                     <td colspan='5'>
                     <label class='FundoPreto'>
                     <h2><b>Gráfico</b></h2>
                     </label>
                     <center>
                     <a href='#GRAFICO'>
                     <img src='Grafico." + Properties.Settings.Default.FormatoGrafico +
                     @"' width='50%' class='w3-round-large grafico' alt='Lights'>
                     </a>
                     <label class='FundoPreto'>
                     <h4><b>Periodo entre as Imagens :</b> " + Periodo + @"</h4>
                     </label>
                     <label class='FundoPreto'>
                     <h4><b>Aumento das Imagens :</b> " + Aumento + @"</h4>
                     </label>
                     </center>
                     </td>
                     </tr>";
        }

        private string GerarHead(string Titulo)
        {
            return @"<head>
                     <title>" + Titulo + @"</title>
                     <meta name='viewport' content='width=device-width, initial-scale=1'>
                     <link rel='stylesheet' href='https://www.w3schools.com/w3css/4/w3.css'>

                     <style type='text/css'>
                     body {
                     background-image:  linear-gradient(90deg,
                     rgba(165, 165, 165, 0.03) 0%, rgba(165, 165, 165, 0.03) 8%,
                     rgba(235, 235, 235, 0.03) 8%, rgba(235, 235, 235, 0.03) 9%,
                     rgba(7, 7, 7, 0.03) 9%,  rgba(7, 7, 7, 0.03) 14%,
                     rgba(212, 212, 212, 0.03) 14%,rgba(212, 212, 212, 0.03) 17%,
                     rgba(219, 219, 219, 0.03) 17%, rgba(219, 219, 219, 0.03) 95%,
                     rgba(86, 86, 86, 0.03) 95%,  rgba(86, 86, 86, 0.03) 100%),
                     linear-gradient(67.5deg,rgba(80, 80, 80, 0.03) 0%,
                     rgba(80, 80, 80, 0.03) 11%, rgba(138, 138, 138, 0.03) 11%,
                     rgba(138, 138, 138, 0.03) 17%, rgba(122, 122, 122, 0.03) 17%,
                     rgba(122, 122, 122, 0.03) 24%, rgba(166, 166, 166, 0.03) 24%,
                     rgba(166, 166, 166, 0.03) 27%, rgba(245, 245, 245, 0.03) 27%,
                     rgba(245, 245, 245, 0.03) 89%,rgba(88, 88, 88, 0.03) 89%, 
                     rgba(88, 88, 88, 0.03) 100%), linear-gradient(67.5deg, 
                     rgba(244, 244, 244, 0.03) 0%,rgba(244, 244, 244, 0.03) 4%, 
                     rgba(16, 16, 16, 0.03) 4%,rgba(16, 16, 16, 0.03) 10%,
                     rgba(157, 157, 157, 0.03) 10%,rgba(157, 157, 157, 0.03) 20%,
                     rgba(212, 212, 212, 0.03) 20%,rgba(212, 212, 212, 0.03) 83%,
                     rgba(5, 5, 5, 0.03) 83%, rgba(5, 5, 5, 0.03) 84%,
                     rgba(237, 237, 237, 0.03) 84%, rgba(237, 237, 237, 0.03) 100%),
                     linear-gradient(90deg, #ffffff, #ffffff);
                     }

                     a:link {
                     text-decoration: none;
                     }

                     .TextoImagem {
                     border-style: solid;
                     border-width: 1px;
                     border-color: black;
                     background-color: white;
                     }

                     h5 {
                     font-size: 20px;
                     color: black;
                     font-family: Arial, Helvetica, sans-serif;
                     }

                     .ImagemEspaço {
                     border-style: solid;
                      border-width: 1;
                     border-color: black;

                      margin-top: 7%;
                      margin-bottom: 7%;

                     margin-left: 7%;
                     margin-right: 7%;
                     }

                     .FundoTextoDados {
                     color: black;
                     font-size: 21px;
                     font-family: Arial, Helvetica, sans-serif;
                     }

                     .grafico {
                     border-style: solid;
                     border-color: black;
                     border-width: 1px;
                     }
                     </style>

                     <script 
                     src='https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js'>
                     </script>

                     <script>
                     $(document).ready(function () {

                     $('a').on('click', function (event) {


                     if (this.hash !== '') {

                     event.preventDefault();

                     var hash = this.hash;


                     $('html, body').animate({
                     scrollTop: $(hash).offset().top
                     }, 650, function () {

                     window.location.hash = hash;
                     });
                     }
                     });
                     });
                     </script>
                     </head>";
        }
        #endregion
    }
}
