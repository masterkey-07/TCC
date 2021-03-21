using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace TCC_UNIFESP
{
    public class GerenciadorBancoDeDados
    {
        #region Variaveis
        private SqlConnection conexao = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Data Tcc", "BD_TCC.mdf")};MultipleActiveResultSets=True;Integrated Security=True;Database=BD_TCC");

        public TesteDados TesteSelecionado { get; set; }
        #endregion

        #region Funcoes

        #region Funcoes Primarias
        private SqlDataReader SelecionarDados(string codigo)
        {

            SqlCommand comando = new SqlCommand($" {codigo}", conexao);
            conexao.Open();
            return comando.ExecuteReader();
        }

        private void AcabarSelecao(SqlDataReader dados)
        {
            dados.Close();
            conexao.Close();
        }

        private bool ExecutarCodigo(string codigo)
        {
            try
            {
                int Modificacoes = 0;
                conexao.Open();
                SqlCommand comando = new SqlCommand($" {codigo}", conexao);
                Modificacoes = comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();
                return Modificacoes > 0;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
        #endregion

        #region Funcoes CarregarTeste
        public List<TesteDados> InicializarDados(string caminho)
        {
            List<TesteDados> Testes = carregarTestes();
            carregarImagens(Testes, caminho);
            carregarDados(Testes);
            return Testes;
        }

        private List<TesteDados> carregarTestes()
        {
            List<TesteDados> Testes = new List<TesteDados>();
            SqlDataReader Dados = SelecionarDados("SELECT * FROM teste");
            while (Dados.Read())
            {
                TesteDados Teste = new TesteDados
                {
                    Id = (short)Dados["Id"],
                    Nome = Dados["Nome"].ToString(),
                    TipoPeriodo = (bool)Dados["Tipo_Periodo"],
                    FrequenciaPeriodo = (byte)Dados["Frequencia_Periodo"],
                    TipoAumento = Dados["Tipo_Aumento"].ToString(),
                    QuantidadeGrupos = (byte)Dados["Quantidade_Grupos"]
                };

                Testes.Add(Teste);
            }
            AcabarSelecao(Dados);
            return Testes;
        }

        private string AdaptarCaminho(string caminhoImagem, string caminho)
        {
            string caminhoAnterior = caminhoImagem.Substring(0, caminhoImagem.IndexOf(@"\TESTFOLDER"));
            return caminhoImagem.Replace(caminhoAnterior, caminho);
        }

        private void carregarImagens(List<TesteDados> testes, string caminho)
        {
            foreach (TesteDados teste in testes)
            {
                SqlDataReader Dados = SelecionarDados($"SELECT * FROM imagem where Id = {teste.Id}");
                while (Dados.Read())
                {
                    teste.Imagens.Add(new ImagemDados()
                    {
                        IdImagem = AdaptarCaminho(Dados["Id_imagem"].ToString(), caminho),
                        Aumento = teste.TipoAumento,
                        Grupo = (byte)Dados["Grupo"],
                        Periodo = (byte)Dados["Periodo"],
                        Metodo = (byte)Dados["Metodo"],
                        Porcentagem = (double)Dados["Porcentagem"],
                        Novo = false,
                    });
                }
                AcabarSelecao(Dados);
            }
        }

        private void carregarDados(List<TesteDados> testes)
        {
            foreach (TesteDados teste in testes)
            {
                SqlDataReader Dados = SelecionarDados($"SELECT * FROM grafico where id = {teste.Id}");
                List<GraficoDados> graficoDados = new List<GraficoDados>();
                while (Dados.Read())
                {
                    GraficoDados graficodado = new GraficoDados()
                    {
                        Periodo = Dados["Periodo"].ToString(),
                        Media = (double)Dados["Media"],
                        DesvioPadrao = (double)Dados["Desvio_Padrao"]
                    };
                    graficoDados.Add(graficodado);
                }
                teste.Dados = graficoDados;
                AcabarSelecao(Dados);
            }
        }
        #endregion

        #region Funcoes Salvar
        public void SalvarTeste()
        {
            SalvarImagens();
            SalvarDados();
            AtualizarTeste();
        }

        private void SalvarImagens()
        {
            ExecutarCodigo($"DELETE FROM imagem where Id = {TesteSelecionado.Id};");

            foreach (ImagemDados imagem in TesteSelecionado.Imagens)
                ExecutarCodigo($"INSERT INTO imagem VALUES({TesteSelecionado.Id},'{imagem.IdImagem}',{imagem.Grupo},{imagem.Periodo},{imagem.Metodo},{imagem.Porcentagem.ToString().Replace(",", ".")});");
        }

        private void SalvarDados()
        {
            ExecutarCodigo($"DELETE FROM grafico WHERE id = {TesteSelecionado.Id};");

            foreach (GraficoDados dados in TesteSelecionado.Dados)
                ExecutarCodigo($"INSERT INTO grafico VALUES({TesteSelecionado.Id},'{dados.Periodo}',{dados.Media.ToString().Replace(",", ".")},{dados.DesvioPadrao.ToString().Replace(",", ".")});");
        }

        private void AtualizarTeste()
        {
            ExecutarCodigo($"UPDATE teste SET Nome = '{ TesteSelecionado.Nome }' WHERE Id = { TesteSelecionado.Id };");
            ExecutarCodigo($"UPDATE teste SET Tipo_Periodo = { ((TesteSelecionado.TipoPeriodo == true) ? 1 : 0) } WHERE Id = { TesteSelecionado.Id };");
            ExecutarCodigo($"UPDATE teste SET Frequencia_Periodo = { TesteSelecionado.FrequenciaPeriodo } WHERE Id = { TesteSelecionado.Id };");
            ExecutarCodigo($"UPDATE teste SET Tipo_Aumento = '{ TesteSelecionado.TipoAumento }' WHERE Id = { TesteSelecionado.Id };");
            ExecutarCodigo($"UPDATE teste SET Quantidade_Grupos = { TesteSelecionado.QuantidadeGrupos } WHERE Id = { TesteSelecionado.Id };");
        }
        #endregion

        #region funcoes Criar/Deletar Teste
        public void CriarTeste()
        {
            ExecutarCodigo($"INSERT INTO teste (Nome,Tipo_Periodo,Frequencia_Periodo,Tipo_Aumento,Quantidade_Grupos) VALUES" +
                            $"('{TesteSelecionado.Nome}',{(TesteSelecionado.TipoPeriodo ? 1 : 0)},{TesteSelecionado.FrequenciaPeriodo},'{TesteSelecionado.TipoAumento}',{TesteSelecionado.QuantidadeGrupos})");
            SqlDataReader Dados = SelecionarDados($"SELECT Id FROM teste WHERE Nome = '{TesteSelecionado.Nome}'");
            Dados.Read();
            TesteSelecionado.Id = (short)Dados["Id"];
            AcabarSelecao(Dados);
        }

        public void DeletarTeste()
        {
            ExecutarCodigo($"DELETE FROM imagem WHERE Id = {TesteSelecionado.Id}");
            ExecutarCodigo($"DELETE FROM grafico WHERE id = {TesteSelecionado.Id}");
            ExecutarCodigo($"DELETE FROM teste WHERE Id = {TesteSelecionado.Id}");
        }
        #endregion

        #region funcoes Backup/Restore
        public void BackupBancoDeDados(string caminho)
        {
            ExecutarCodigo($@"BACKUP DATABASE BD_TCC TO DISK = '{caminho}\BD-BACKUP.bak'");
        }

        public void RestoreBancoDeDados(string caminho)
        {
            ExecutarCodigo($@"ALTER DATABASE BD_TCC SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            ExecutarCodigo($@"USE MASTER RESTORE DATABASE BD_TCC FROM DISK = '{caminho}\BACKUP\BD-BACKUP.bak'");
            ExecutarCodigo($@"ALTER DATABASE BD_TCC SET MULTI_USER");
        }
        #endregion

        #endregion
    }
}