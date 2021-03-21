using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace TCC_UNIFESP
{
    public class GerenciadorDeArquivo
    {
        #region Variaveis

        #region Variaveis Dialogo
        private SaveFileDialog SalvarArquivoGrafico = new SaveFileDialog { Filter = "Arquivo de Imagens|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*" };

        private SaveFileDialog SalvarArquivoExcel = new SaveFileDialog { Filter = "Arquivo Excel|*.xlsx; |All files|*.*" };

        private SaveFileDialog SalvarArquivoTexto = new SaveFileDialog { Filter = "Arquivo Texto|*.txt;*.doc;*.docx;*.odt|Todos Arquivos|*.*" };

        private FolderBrowserDialog NavegadorPasta = new FolderBrowserDialog() { Description = "Selecione a Pasta onde o Backup será baixado" };
        #endregion

        public TesteDados TesteSelecionado { get; set; }

        private string PastaPrincipal;

        private string CaminhoBackup = "";

        private ProcessadorExcel Excel = new ProcessadorExcel();

        private ProcessadorWeb Web = new ProcessadorWeb();

        #endregion

        #region Funcoes
        private string CaminhoTesteSelecionado() { return $@"{PastaPrincipal}\TESTFOLDER\{ TesteSelecionado.Id }\"; }

        #region SalverElemento Sobrecargas
        public bool SalvarElemento(Bitmap image)
        {
            if (SalvarArquivoGrafico.ShowDialog() == DialogResult.OK)
            {
                string ExtensaoVelha = Path.GetExtension(SalvarArquivoGrafico.FileName);
                SalvarImagem(SalvarArquivoGrafico.FileName.Replace(ExtensaoVelha, $".{ Properties.Settings.Default.FormatoImagem}"), image);
                return true;
            }
            return false;
        }

        internal void LimparTestFolder()
        {
            Directory.Delete($@"{PastaPrincipal}\TESTFOLDER", true);
            Directory.CreateDirectory($@"{PastaPrincipal}\TESTFOLDER\");
        }

        public bool SalvarElemento(string Texto, string Formato)
        {
            if (SalvarArquivoTexto.ShowDialog() == DialogResult.OK)
            {
                string ExtensaoVelha = Path.GetExtension(SalvarArquivoTexto.FileName);
                File.WriteAllText(SalvarArquivoTexto.FileName.Replace(ExtensaoVelha, "." + Formato), Texto);
                return true;
            }
            return false;
        }

        public bool SalvarElemento(Chart Grafico)
        {
            if (SalvarArquivoGrafico.ShowDialog() == DialogResult.OK)
            {
                string ExtensaoVelha = Path.GetExtension(SalvarArquivoGrafico.FileName);
                Bitmap ImgGrafico = new Bitmap(Grafico.Size.Width, Grafico.Size.Height);
                Grafico.DrawToBitmap(ImgGrafico, new Rectangle(0, 0, Grafico.Size.Width, Grafico.Size.Height));
                SalvarImagem(SalvarArquivoGrafico.FileName.Replace(ExtensaoVelha, "." + Properties.Settings.Default.FormatoGrafico), ImgGrafico);
                return true;
            }
            return false;
        }

        public bool SalvarElemento(TesteDados Teste)
        {
            if (SalvarArquivoExcel.ShowDialog() == DialogResult.OK)
            {
                string Nome = Path.GetFileNameWithoutExtension(SalvarArquivoExcel.FileName);
                string caminho = Path.GetDirectoryName(SalvarArquivoExcel.FileName) + @"\";
                Excel.BaixarExcel(Nome, Teste, caminho);
                return true;
            }
            return false;
        }

        public bool SalvarElemento(string NomeTeste, List<GraficoDados> Dados)
        {
            if (SalvarArquivoExcel.ShowDialog() == DialogResult.OK)
            {
                string Nome = Path.GetFileNameWithoutExtension(SalvarArquivoExcel.FileName);
                string caminho = Path.GetDirectoryName(SalvarArquivoExcel.FileName) + @"\";
                Excel.BaixarExcel(Nome, NomeTeste, Dados, caminho);
                return true;
            }
            return false;
        }
        #endregion

        private void SalvarImagem(string Caminho, Bitmap image)
        {
            image.Save(Caminho);
        }

        public string InicializarSistema()
        {
            PastaPrincipal = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists($@"{PastaPrincipal}\Data Tcc\TESTFOLDER"))
                Directory.CreateDirectory($@"{PastaPrincipal}\Data Tcc\TESTFOLDER");
            PastaPrincipal += @"\Data Tcc";
            return PastaPrincipal;
        }

        public string PegarCaminhoExecutavel()
        {
            return Application.StartupPath;
        }

        #region funcoes do Teste
        public void CriarTeste()
        {
            if (!Directory.Exists(CaminhoTesteSelecionado()))
                Directory.CreateDirectory(CaminhoTesteSelecionado());
        }

        public void SalvarTeste()
        {
            CriarTeste();
            foreach (ImagemDados imagem in TesteSelecionado.Imagens.Where(img => img.Novo == true))
            {
                string NovoId = $"{ CaminhoTesteSelecionado() }{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}.{Properties.Settings.Default.FormatoImagem}";
                File.Copy(imagem.IdImagem, NovoId);
                imagem.IdImagem = NovoId;
                imagem.Novo = false;
            }

            foreach (ImagemDados imagem in TesteSelecionado.ImagensRemovidas.Where(img => img.Novo == false).ToList())
            {
                File.Delete(imagem.IdImagem);
                TesteSelecionado.ImagensRemovidas.Clear();
            }
        }

        #region funcao Adicionar Teste
        #region funcoes auxiliar
        private byte PegarFrequenciaPeriodo(List<string> Caminhos)
        {
            string str;
            List<byte> Valores = new List<byte>();
            foreach (string cam in Caminhos)
            {
                str = cam.Substring(cam.LastIndexOf(@"\") + 1);
                Valores.Add(byte.Parse(str.Replace("Hora", "").Replace("Dia", "").Replace("Controle", "200").Trim()));
            }
            return Valores.Min(val => val);
        }

        private bool PegarTipoPeriodo(List<string> Caminhos)
        {
            return Caminhos.Exists(cam => cam.Contains("Dia"));
        }

        private string PegarTipoAumento(List<string> Caminhos)
        {
            string[] caminhos = Directory.GetFiles(Caminhos[0]);
            return caminhos[0].Substring(caminhos[0].LastIndexOf(@"\") + 1, caminhos[0].IndexOf("-") - caminhos[0].LastIndexOf(@"\")).Replace("-", "");
        }

        private byte PegarQuantidadeGrupos(List<string> Caminhos)
        {
            return (byte)(Directory.GetFiles(Caminhos[0]).Count() / 2);
        }

        #endregion

        private TesteDados PegarTeste(string Nome, List<string> Caminhos)
        {
            TesteDados Teste = new TesteDados
            {
                Nome = Nome,
                FrequenciaPeriodo = PegarFrequenciaPeriodo(Caminhos),
                TipoPeriodo = PegarTipoPeriodo(Caminhos),
                TipoAumento = PegarTipoAumento(Caminhos),
                QuantidadeGrupos = PegarQuantidadeGrupos(Caminhos)
            };
            return Teste;
        }

        private List<ImagemDados> PegarImagem(List<string> Caminhos)
        {
            List<ImagemDados> Imagens = new List<ImagemDados>();

            foreach (string caminho in Caminhos)
                foreach (string caminho2 in Directory.GetFiles(caminho))
                    if (!Path.GetFileName(caminho2).Contains("convertida"))
                        Imagens.Add(new ImagemDados(caminho2));

            return Imagens;
        }

        public TesteDados AdicionarTeste(string Caminho)
        {
            List<string> Caminhos = new List<string>();
            Caminhos.AddRange(Directory.GetDirectories(Caminho));
            TesteDados Teste = PegarTeste(Caminho.Substring(Caminho.LastIndexOf(@"\") + 1), Caminhos);
            Teste.Imagens = PegarImagem(Caminhos);
            Teste.GerarDados();
            return Teste;
        }
        #endregion

        public bool BaixarTeste(Chart Grafico)
        {
            NavegadorPasta.Description = "Selecione a Pasta onde o Teste será baixado";

            if (NavegadorPasta.ShowDialog() == DialogResult.OK)
            {
                string CaminhoEscolhido = $@"{NavegadorPasta.SelectedPath}\{TesteSelecionado.Nome}\";

                if (MessageBox.Show($"Tem Certeza em Baixar o Teste no Caminho : {CaminhoEscolhido}", "Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;

                CaminhoEscolhido = CriarPasta(CaminhoEscolhido, false);

                byte periodo = 0;

                foreach (GraficoDados dado in TesteSelecionado.Dados)
                {
                    string CaminhoImagem = $@"{CaminhoEscolhido}{dado.Periodo}\";

                    Directory.CreateDirectory(CaminhoImagem);

                    foreach (ImagemDados imagem in TesteSelecionado.Imagens.Where(img => img.Periodo == periodo).ToList())
                    {
                        SalvarImagem(
                            $"{CaminhoImagem}{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}.{Properties.Settings.Default.FormatoImagem}",
                            new Bitmap(imagem.IdImagem));
                        SalvarImagem(
                            $"{CaminhoImagem}{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}-convertida.{Properties.Settings.Default.FormatoImagem}",
                            new Bitmap(imagem.ProcessarImagem(GerenciadorTeste.PegarVerificadores()[imagem.Metodo])));

                    }
                    periodo++;
                }

                if (Properties.Settings.Default.ExcelDiferenca)
                    Excel.BaixarExcel("Dados-de-Diferencas-do-Teste", TesteSelecionado.Nome, TesteSelecionado.Dados, CaminhoEscolhido);

                File.WriteAllText(
                    $"{CaminhoEscolhido}Dados-de-Diferencas-do-Teste.{Properties.Settings.Default.FormatoTexto}",
                    TesteSelecionado.PegarDiferencaPadrao());

                if (Properties.Settings.Default.ExcelDados)
                    Excel.BaixarExcel("Dados-do-Teste", TesteSelecionado, CaminhoEscolhido);

                File.WriteAllText($"{CaminhoEscolhido}Dados-do-Teste.{Properties.Settings.Default.FormatoTesteDados}", TesteSelecionado.PegarTesteDados());

                Bitmap ImgGrafico = new Bitmap(Grafico.Size.Width, Grafico.Size.Height);
                Grafico.DrawToBitmap(ImgGrafico, new Rectangle(0, 0, Grafico.Size.Width, Grafico.Size.Height));
                SalvarImagem($"{CaminhoEscolhido}Grafico.{Properties.Settings.Default.FormatoGrafico}", ImgGrafico);
            }
            else
                return false;
            return true;

        }

        public bool BaixarSite(Chart Grafico)
        {
            NavegadorPasta.Description = "Selecione a Pasta onde o Teste será baixado";
            if (NavegadorPasta.ShowDialog() == DialogResult.OK)
            {
                string CaminhoEscolhido = $@"{NavegadorPasta.SelectedPath}\{TesteSelecionado.Nome}_Site\";

                if (MessageBox.Show($"Tem Certeza em Baixar o Teste no Caminho : {CaminhoEscolhido}", "Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;

                CaminhoEscolhido = CriarPasta(CaminhoEscolhido, false);

                string CaminhoImagem = $@"{CaminhoEscolhido}Imagens\";

                Directory.CreateDirectory(CaminhoImagem);

                foreach (ImagemDados imagem in TesteSelecionado.Imagens)
                {
                    SalvarImagem($"{CaminhoImagem}{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}.{Properties.Settings.Default.FormatoImagem}", new Bitmap(imagem.IdImagem));
                    SalvarImagem($"{CaminhoImagem}{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}-convertida.{Properties.Settings.Default.FormatoImagem}", new Bitmap(imagem.ProcessarImagem(GerenciadorTeste.PegarVerificadores()[imagem.Metodo])));
                }

                Bitmap ImgGrafico = new Bitmap(Grafico.Size.Width, Grafico.Size.Height);
                Grafico.DrawToBitmap(ImgGrafico, new Rectangle(0, 0, Grafico.Size.Width, Grafico.Size.Height));
                SalvarImagem($"{CaminhoEscolhido}Grafico.{Properties.Settings.Default.FormatoGrafico}", ImgGrafico);

                File.WriteAllText($"{CaminhoEscolhido}Site.html", Web.GerarHTML(this.TesteSelecionado));
            }
            else
                return false;

            return true;
        }

        public void DeletarTeste()
        {
            if (Directory.Exists(CaminhoTesteSelecionado()))
                Directory.Delete(CaminhoTesteSelecionado(), true);
        }
        #endregion

        private string CriarPasta(string Caminho, bool ComZip)
        {
            if (File.Exists($"{Caminho}{(ComZip ? ".zip" : "")}"))
                for (int i = 1; i <= 100; i++)
                    if (!File.Exists($"{Caminho}({i}){(ComZip ? ".zip" : "")}"))
                    {
                        Caminho = $"{Caminho}({i})";
                        Directory.CreateDirectory($"{Caminho}");
                        return $@"{Caminho}";
                    }

            Directory.CreateDirectory(Caminho);
            return $@"{Caminho}";
        }

        #region funcoes Backup/Restore
        public string BackupPasta(string CaminhoSelecionado)
        {
            CaminhoBackup = $@"{CaminhoSelecionado}\BACKUP-{DateTime.Today.ToString("dd-MM-yyyy")}";
            CaminhoBackup = CriarPasta(CaminhoBackup, true);
            ZipFile.CreateFromDirectory($@"{PastaPrincipal}\TESTFOLDER", $@"{CaminhoBackup}\TESTFOLDER.zip");
            return CaminhoBackup;
        }

        public void ZipBackup()
        {
            ZipFile.CreateFromDirectory($"{CaminhoBackup}", $@"{CaminhoBackup}.zip");
            Directory.Delete(CaminhoBackup, true);
        }

        public string RestorePasta(string CaminhoSelecionado)
        {
            if (Directory.Exists($@"{PastaPrincipal}\TESTFOLDER\"))
                Directory.Delete($@"{PastaPrincipal}\TESTFOLDER\", true);
            ZipFile.ExtractToDirectory($@"{CaminhoSelecionado}", $@"{PastaPrincipal}\BACKUP\");
            ZipFile.ExtractToDirectory($@"{PastaPrincipal}\BACKUP\TESTFOLDER.zip", $@"{PastaPrincipal}\TESTFOLDER\");
            return PastaPrincipal;
        }

        public void DeletarBackup(string caminho)
        {
            Directory.Delete($@"{caminho}\BACKUP", true);
        }

        #endregion

        #endregion
    }
}