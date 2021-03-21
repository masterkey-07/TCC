using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TCC_UNIFESP
{
    static class GerenciadorTeste
    {
        #region Variaveis
        private static GerenciadorBancoDeDados BancoDeDados = new GerenciadorBancoDeDados();

        private static GerenciadorDeArquivo Arquivo = new GerenciadorDeArquivo();

        private static List<TesteDados> _Testes = new List<TesteDados>();

        public static List<TesteDados> Testes
        {
            get
            {
                _Testes = _Testes.OrderBy(tst => tst.Nome).ToList();
                return _Testes;
            }
            set
            {
                _Testes = value.OrderBy(tst => tst.Nome).ToList();
            }
        }

        public static TesteDados TesteSelecionado { get; set; }

        private static TesteDados TesteAntigo;

        private readonly static List<AbstractVerificadorPixel> Verificadores = new List<AbstractVerificadorPixel>() { new Verificar2_5x(), new Verificar2_5x_2(), new Verificar2_5x_3() };
        #endregion

        #region Funcoes

        public static string InicializarGerenciador()
        {
            string caminho = Arquivo.InicializarSistema();
            Testes = BancoDeDados.InicializarDados(caminho).OrderBy(tst => tst.Nome).ToList();
            if (Testes.Count == 0)
                Arquivo.LimparTestFolder();
            return Arquivo.PegarCaminhoExecutavel();
        }

        public static void FinalizarGerenciador()
        {
            BancoDeDados.FecharConexao();
        }

        #region Manipular TesteSelecionado
        public static void SelecionarTeste(TesteDados NovoTeste)
        {
            if (NovoTeste != null)
            {

                TesteSelecionado = NovoTeste;
                TesteAntigo = (TesteDados)TesteSelecionado.Clone();
                BancoDeDados.TesteSelecionado = TesteSelecionado;
                Arquivo.TesteSelecionado = TesteSelecionado;
            }
            else
            {
                TesteSelecionado = null;
                TesteAntigo = null;
                BancoDeDados.TesteSelecionado = null;
                Arquivo.TesteSelecionado = null;
            }
        }

        public static void DesfazerMudancas()
        {
            Testes.Remove(TesteSelecionado);
            Testes.Add(TesteAntigo);
            SelecionarTeste(TesteAntigo);
        }
        #endregion

        #region funcoes Armazenamento/Gerenciamento
        public static void SalvarTeste()
        {
            Arquivo.SalvarTeste();
            BancoDeDados.SalvarTeste();
            SelecionarTeste(TesteSelecionado);
        }

        public static void SalvarTestes()
        {
            TesteDados Teste = TesteSelecionado;
            foreach (TesteDados teste in Testes)
            {
                SelecionarTeste(teste);
                SalvarTeste();
            }
            SelecionarTeste(Teste);
        }

        public static bool AdicionarTeste(string Caminho)
        {
            TesteDados Teste = Arquivo.AdicionarTeste(Caminho);
            if (!Testes.Exists(tst => tst.Nome.Trim().Equals(Teste.Nome.Trim())))
            {
                TesteDados TesteAnterior = TesteSelecionado;
                Testes.Add(Teste);
                SelecionarTeste(Teste);
                CriarTeste();
                SalvarTeste();
                SelecionarTeste(TesteAnterior);
                return true;
            }
            else return false;
        }

        public static void CriarTeste()
        {
            //BancoDeDados.CriarTeste();
            Arquivo.CriarTeste();
        }

        public static void DeletarTeste()
        {
            BancoDeDados.DeletarTeste();
            Arquivo.DeletarTeste();
            Testes.Remove(TesteSelecionado);
            TesteSelecionado = null;
            TesteAntigo = null;
        }

        public static bool BaixarTeste(Chart Grafico)
        {
            return Arquivo.BaixarTeste(Grafico);
        }

        public static bool BaixarSite(Chart Grafico)
        {
            return Arquivo.BaixarSite(Grafico);
        }
        #endregion

        public static List<AbstractVerificadorPixel> PegarVerificadores()
        {
            return Verificadores;
        }

        #region funcoes Backup/Restore
        public static void Backup(string CaminhoSelecionado)
        {
            if (System.IO.Directory.Exists(CaminhoSelecionado))
            {
                string caminho = Arquivo.BackupPasta(CaminhoSelecionado);
                BancoDeDados.BackupBancoDeDados(caminho);
                Arquivo.ZipBackup();
            }
            else
                MessageBox.Show("O caminho selecionado é inexistente", "Configuração");
        }

        public static void Restore(string CaminhoSelecionado)
        {
            string caminho = Arquivo.RestorePasta(CaminhoSelecionado);
            BancoDeDados.RestoreBancoDeDados(caminho);
            Arquivo.DeletarBackup(caminho);
        }
        #endregion

        #region SalvarElemento Sobrecargas
        public static bool SalvarElemento(Bitmap imagem)
        {
            return Arquivo.SalvarElemento(imagem);
        }

        public static bool SalvarElemento(string Texto, string Formato)
        {
            return Arquivo.SalvarElemento(Texto, Formato);
        }

        public static bool SalvarElemento(Chart grafico)
        {
            return Arquivo.SalvarElemento(grafico);
        }

        public static bool SalvarElemento(string TesteNome, List<GraficoDados> Dados)
        {
            return Arquivo.SalvarElemento(TesteNome, Dados);
        }

        public static bool SalvarElemento(TesteDados teste)
        {
            return Arquivo.SalvarElemento(teste);
        }
        #endregion

        #endregion
    }
}
