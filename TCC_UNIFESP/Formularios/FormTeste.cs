using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCC_UNIFESP
{
    public partial class FormTeste : Form
    {
        private bool CriandoTeste;

        FormMenu formMenu;

        public FormTeste()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            txtAumento.Text = "";
            cbPeriodo.SelectedIndex = 0;
            cbTestes.Text = Properties.Settings.Default.TesteAberto;
        }

        #region funcoes Event
        private void FormTeste_VisibleChanged(object sender, EventArgs e)
        {
            formMenu = (FormMenu)TopLevelControl;
            if (this.Visible == true)
            {
                AtualizarListaTestes();
                if (GerenciadorTeste.TesteSelecionado != null)
                {
                    AtualizarTeste();
                    cbTestes.Text = GerenciadorTeste.TesteSelecionado.Nome;
                    maskQuantGrupos.Text = GerenciadorTeste.TesteSelecionado.QuantidadeGrupos.ToString();
                    lblQuantidadeImagens.Text = GerenciadorTeste.TesteSelecionado.QuantidadeImagens.ToString();
                }

                picboxColMedia.BackColor = Properties.Settings.Default.Coluna;
                picboxColDesvioPadrao.BackColor = Properties.Settings.Default.Coluna2;
                picboxLinhaDesvioPadrao.BackColor = Properties.Settings.Default.Linha;
                picboxPontodeMedia.BackColor = Properties.Settings.Default.Ponto;
                chartGrafico.ChartAreas[0].BackColor = Properties.Settings.Default.CorGrafico;
            }
        }

        private void cbTestes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (GerenciadorTeste.Testes.Where(tst => tst.Nome == cbTestes.Text).Count() == 0)
                {
                    if (Perguntar("Vai Criar um Novo Teste?"))
                    {
                        ProibirTesteDados(false);
                        PermitirManipulacaoDoTeste(false);
                        txtNomeTeste.Text = cbTestes.Text;
                        CriandoTeste = true;
                        formMenu.TemTesteSelecionado = false;
                    }
                }
                else
                {
                    GerenciadorTeste.SelecionarTeste((TesteDados)cbTestes.SelectedItem);
                    formMenu.TemTesteSelecionado = true;
                    PermitirManipulacaoDoTeste(true);
                    PreencherTesteDados();
                    AtualizarTeste();
                }
            formMenu.formImagens.LimpandoImagem();
        }

        private void btnSalvarTeste_Click(object sender, EventArgs e)
        {
            if (Perguntar("Tem certeza em salvar?"))
            {
                GerenciadorTeste.SalvarTeste();
                Informar("Teste Salvo");
            }
        }

        private void btnSalvarTodosTestes_Click(object sender, EventArgs e)
        {
            if (Perguntar("Tem certeza em salvar todos os testes?"))
            {
                GerenciadorTeste.SalvarTestes();
                Informar("Testes Salvos");
            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            if (Perguntar("Tem certeza em desfazer as alterações?"))
            {
                GerenciadorTeste.DesfazerMudancas();
                AtualizarTeste();
                AtualizarListaTestes();
            }
        }

        #region funcoes Criar/Alterar/Deletar Teste
        #region funcoes Manipular TesteDados
        private void PreencherTesteDados()
        {
            txtNomeTeste.Text = GerenciadorTeste.TesteSelecionado.Nome;
            txtAumento.Text = GerenciadorTeste.TesteSelecionado.TipoAumento;
            maskQuantGrupos.Text = GerenciadorTeste.TesteSelecionado.QuantidadeGrupos.ToString();
            maskPeriodo.Text = GerenciadorTeste.TesteSelecionado.FrequenciaPeriodo.ToString();
            cbPeriodo.SelectedIndex = GerenciadorTeste.TesteSelecionado.TipoPeriodo ? 1 : 0;
            lblQuantidadeImagens.Text = GerenciadorTeste.TesteSelecionado.QuantidadeImagens.ToString();
        }

        private void AdicionarTeste()
        {
            GerenciadorTeste.Testes.Add(new TesteDados()
            {
                Nome = txtNomeTeste.Text,
                TipoAumento = txtAumento.Text,
                QuantidadeGrupos = Byte.Parse(maskQuantGrupos.Text),
                FrequenciaPeriodo = Byte.Parse(maskPeriodo.Text),
                TipoPeriodo = (cbPeriodo.SelectedIndex == 0) ? false : true
            });
        }

        public void LimparTesteDados()
        {
            formMenu = (FormMenu)TopLevelControl;
            txtNomeTeste.Text = "";
            txtAumento.Text = "";
            maskQuantGrupos.Text = "03";
            maskPeriodo.Text = "1";
            cbPeriodo.SelectedIndex = 1;
            lblQuantidadeImagens.Text = "0";
            lblNomeTeste.Text = "Teste Selecionado";
            formMenu.NomeTeste = "Teste Selecionado";
        }

        public void LimparTeste()
        {
            chartGrafico.Series.Clear();
            rtxtTexto.Text = "";
            checkListPeriodo.Items.Clear();
        }

        private bool VerficarTesteDados()
        {
            if (txtNomeTeste.Text.Trim().Length == 0)
                return false;
            if (maskPeriodo.Text.Trim().Length == 0 && Int32.Parse(maskPeriodo.Text) > 0)
                return false;
            if (maskQuantGrupos.Text.Trim().Length == 0 && Int32.Parse(maskQuantGrupos.Text) > 0)
                return false;
            if (txtAumento.Text.Trim().Length == 0)
                return false;
            if (cbPeriodo.Text.Trim().Length == 0)
                return false;

            return true;
        }
        #endregion

        private void btnReescrever_Click(object sender, EventArgs e)
        {
            ProibirTesteDados(false);
            PermitirManipulacaoDoTeste(false);
            formMenu.TemTesteSelecionado = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (VerficarTesteDados())
            {
                if (CriandoTeste)
                {
                    AdicionarTeste();
                    GerenciadorTeste.SelecionarTeste(GerenciadorTeste.Testes.Find(tst => tst.Nome == txtNomeTeste.Text));
                    formMenu.TemTesteSelecionado = true;
                    GerenciadorTeste.CriarTeste();
                    cbTestes.Text = GerenciadorTeste.TesteSelecionado.Nome;
                    CriandoTeste = false;
                    lblQuantidadeImagens.Text = "0";
                }
                else
                    AtualizarTesteDados();

                AtualizarListaTestes();
                cbTestes.Text = GerenciadorTeste.TesteSelecionado.Nome;
                ProibirTesteDados(true);
                PermitirManipulacaoDoTeste(true);
            }
            else
                Avisar("Existem Dados Faltando");
            AtualizarTeste();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (CriandoTeste)
            {
                LimparTesteDados();
                CriandoTeste = false;
                cbTestes.SelectedIndex = -1;
                lblQuantidadeImagens.Text = "0";
                LimparTeste();
                AtualizarListaTestes();
                PermitirManipulacaoDoTeste(false);
                LimparTesteDados();
                formMenu.TemTesteSelecionado = false;
            }
            else
            {
                PreencherTesteDados();
                PermitirManipulacaoDoTeste(true);
                formMenu.TemTesteSelecionado = true;
            }
            ProibirTesteDados(true);
        }

        public void btnDeletarTeste_Click(object sender, EventArgs e)
        {
            if (Perguntar("Tem certeza em deletar o teste?"))
            {
                formMenu.formImagens.LimpandoImagem();
                GerenciadorTeste.DeletarTeste();
                cbTestes.SelectedIndex = -1;
                lblQuantidadeImagens.Text = "0";
                LimparTeste();
                AtualizarListaTestes();
                PermitirManipulacaoDoTeste(false);
                LimparTesteDados();
                Informar("Teste Removido");
                formMenu.TemTesteSelecionado = false;
            }
        }
        #endregion

        #region funcoes Baixar 
        private void btnBaixarTeste_Click(object sender, EventArgs e)
        {
            bool valor = false;
            btnBaixarTeste.Text = "Salvando Teste...";
            this.Update();
            Thread.Sleep(10);
            valor = GerenciadorTeste.BaixarTeste(chartGrafico);
            if (valor)
                Informar("Teste Salvo");
            btnBaixarTeste.Text = "Salvar Teste Como...";
        }

        private void btnSalvarSite_Click(object sender, EventArgs e)
        {
            bool valor = false;
            btnSalvarSite.Text = "Salvando Site...";
            this.Update();
            Thread.Sleep(10);
            valor = GerenciadorTeste.BaixarSite(chartGrafico);
            if (valor)
                Informar("Site Salvo");
            btnSalvarSite.Text = "Salvar Site Como...";
        }

        private void btnBaixarTexto_Click(object sender, EventArgs e)
        {
            bool valor = false;
            btnBaixarTexto.Text = "Baixando...";
            this.Update();
            Thread.Sleep(10);
            if (Perguntar("Baixar Versão Excel?\nSe não, será baixado a versão de arquivo texto."))
                valor = GerenciadorTeste.SalvarElemento(GerenciadorTeste.TesteSelecionado.Nome, GerenciadorTeste.TesteSelecionado.Dados);
            else
                valor = GerenciadorTeste.SalvarElemento(rtxtTexto.Text, Properties.Settings.Default.FormatoTexto);

            btnBaixarTexto.Text = "Baixar Texto";
        }

        private void btnBaixarDados_Click(object sender, EventArgs e)
        {
            bool valor = false;
            btnBaixarDados.Text = "Baixando...";
            this.Update();
            Thread.Sleep(10);
            if (Perguntar("Baixar Versão Excel?\nSe não, será baixado a versão de arquivo texto."))
                valor = GerenciadorTeste.SalvarElemento(GerenciadorTeste.TesteSelecionado);
            else
                valor = GerenciadorTeste.SalvarElemento(GerenciadorTeste.TesteSelecionado.PegarTesteDados(), Properties.Settings.Default.FormatoTesteDados);
            if (valor)
                Informar("Texto Salvos");
            btnBaixarDados.Text = "Baixar Dados";
        }

        private void btnBaixarGrafico_Click(object sender, EventArgs e)
        {
            bool valor = false;
            valor = GerenciadorTeste.SalvarElemento(chartGrafico);
            if (valor)
                Informar("Grafico Salvo");
        }
        #endregion

        #region Manipulação do Grafico
        private void checkListPeriodo_MouseUp(object sender, MouseEventArgs e)
        {
            AtualizarGrafico();
        }

        private void checkColMedia_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrafico();
        }
        #endregion

        private void Form_MouseEnter(object sender, EventArgs e)
        {
            formMenu.MouseSaiuDoPainel(sender, e);
        }
        #endregion

        #region funcoes de Acessibilidade ao TesteDados
        private void ProibirTesteDados(bool valor)
        {
            btnConfirmar.Visible = !valor;
            btnCancelar.Visible = !valor;
            pnTesteDados.Enabled = !valor;
            cbTestes.Enabled = valor;
            lblInfoQuantImagens.Visible = valor;
            lblQuantidadeImagens.Visible = valor;
        }

        public void PermitirManipulacaoDoTeste(bool valor)
        {
            btnReescrever.Enabled = valor;
            btnSalvarTeste.Enabled = valor;
            btnDesfazer.Enabled = valor;
            btnBaixarTeste.Enabled = valor;
            btnDeletarTeste.Enabled = valor;
            btnBaixarGrafico.Enabled = valor;
            btnBaixarTexto.Enabled = valor;
            checkColDesvio.Enabled = valor;
            checkColMedia.Enabled = valor;
            checkLinhaDesvio.Enabled = valor;
            checkPontosMedia.Enabled = valor;
            checkDadosGrafico.Enabled = valor;
            checkListPeriodo.Enabled = valor;
            btnSalvarSite.Enabled = valor;
            btnBaixarDados.Enabled = valor;
        }

        #endregion

        #region funcoes Atualizar
        private void AtualizarTeste()
        {
            if (GerenciadorTeste.TesteSelecionado != null)
            {
                GerenciadorTeste.TesteSelecionado.GerarDados();
                lblNomeTeste.Text = GerenciadorTeste.TesteSelecionado.Nome;
                formMenu.NomeTeste = GerenciadorTeste.TesteSelecionado.Nome;
            }
            else
            {
                lblNomeTeste.Text = "Teste Selecionado";
                formMenu.NomeTeste = "Teste Selecionado";
            }

            AtualizarCheckList();
            AtualizarGrafico();
            AtualizarTexto();
        }

        private void AtualizarCheckList()
        {
            checkListPeriodo.Items.Clear();
            if (GerenciadorTeste.TesteSelecionado != null)
                foreach (GraficoDados dado in GerenciadorTeste.TesteSelecionado.Dados)
                    checkListPeriodo.Items.Add(dado.Periodo, CheckState.Checked);
        }

        public void AtualizarListaTestes()
        {
            cbTestes.DataSource = GerenciadorTeste.Testes.ToList();
            cbTestes.DisplayMember = "Nome";
        }

        private void AtualizarGrafico()
        {
            if (GerenciadorTeste.TesteSelecionado != null)
            {
                bool[] periodos = new bool[checkListPeriodo.Items.Count];
                for (int i = 0; i < checkListPeriodo.Items.Count; i++)
                    periodos[i] = checkListPeriodo.GetItemChecked(i);
                GerenciadorTeste.TesteSelecionado.PegarGrafico(chartGrafico, periodos, checkColMedia.Checked,
                    checkColDesvio.Checked, checkLinhaDesvio.Checked, checkPontosMedia.Checked, checkDadosGrafico.Checked);
            }
            else
                Avisar("Tem que selecionar um Teste");
        }

        private void AtualizarTexto()
        {
            if (GerenciadorTeste.TesteSelecionado != null)
                rtxtTexto.Text = GerenciadorTeste.TesteSelecionado.PegarDiferencaPadrao();
        }

        private void AtualizarTesteDados()
        {
            GerenciadorTeste.TesteSelecionado.Nome = txtNomeTeste.Text;
            GerenciadorTeste.TesteSelecionado.TipoAumento = txtAumento.Text;
            GerenciadorTeste.TesteSelecionado.QuantidadeGrupos = Byte.Parse(maskQuantGrupos.Text);
            GerenciadorTeste.TesteSelecionado.FrequenciaPeriodo = Byte.Parse(maskPeriodo.Text);
            GerenciadorTeste.TesteSelecionado.TipoPeriodo = (cbPeriodo.SelectedIndex == 1) ? true : false;
        }
        #endregion

        #region funcoes Mensagem
        private bool Perguntar(string Msg)
        {
            return MessageBox.Show(Msg, "TESTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void Avisar(string Msg)
        {
            MessageBox.Show(Msg, "TESTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Informar(string Msg)
        {
            MessageBox.Show(Msg, "TESTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

    }
}
