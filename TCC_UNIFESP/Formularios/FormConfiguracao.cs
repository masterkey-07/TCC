using System;
using System.Threading;
using System.Windows.Forms;

namespace TCC_UNIFESP
{
    public partial class FormConfiguracao : Form
    {
        #region Variaveis
        private OpenFileDialog SelecionarBackup = new OpenFileDialog
        {
            Filter = "Pasta Backup|*.zip",
            Title = "Selecione a Pasta onde está o Backup que será Restaurado"
        };

        private FolderBrowserDialog SelecionarTeste = new FolderBrowserDialog
        {
            Description = "Selecione a Pasta onde o Teste será importado"
        };

        private FolderBrowserDialog NavegadorPasta = new FolderBrowserDialog() { Description = "Selecione a Pasta onde o Backup será baixado" };

        private FontDialog SelecionadorFonte = new FontDialog();

        private ColorDialog SelecionadorCor = new ColorDialog();
        #endregion

        public FormConfiguracao()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
        }

        #region Eventos 
        private void FormConfiguracao_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                cbFormatoTexto.Text = Properties.Settings.Default.FormatoTexto;
                cbFormatoGrafico.Text = Properties.Settings.Default.FormatoGrafico;
                cbFormatoImagem.Text = Properties.Settings.Default.FormatoImagem;
                cbFormatoTesteDados.Text = Properties.Settings.Default.FormatoTesteDados;

                picboxColMedia.BackColor = Properties.Settings.Default.Coluna;

                picboxColDesvioPadrao.BackColor = Properties.Settings.Default.Coluna2;
                maskColDesvioPadrao.Text = Properties.Settings.Default.Coluna2_Borda.ToString();

                picboxLinhaMedia.BackColor = Properties.Settings.Default.Linha;
                maskLinhaMedia.Text = Properties.Settings.Default.Linha_Borda.ToString();

                picboxPontoMedia.BackColor = Properties.Settings.Default.Ponto;
                maskPontoMedia.Text = Properties.Settings.Default.Ponto_Borda.ToString();

                picboxFundoGrafico.BackColor = Properties.Settings.Default.CorGrafico;

                lblMensagemBackup.Text = "...";
                lblMensagemImportar.Text = "...";
                lblMensagemRestaurar.Text = "...";

                checkExcelDiferenca.Checked = Properties.Settings.Default.ExcelDiferenca;
                checkExcelDados.Checked = Properties.Settings.Default.ExcelDados;
            }
            else
            {
                rtxtRestaurar.Text = "";
                rtxtBackup.Text = "";
                rtxtTesteImportado.Text = "";
            }

        }

        #region Eventos de Backup/Restore/Importar
        private void btnCaminhoBackup_Click(object sender, EventArgs e)
        {
            if (NavegadorPasta.ShowDialog() == DialogResult.OK)
                rtxtBackup.Text = NavegadorPasta.SelectedPath;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (rtxtBackup.Text.Trim().Length > 0)
            {
                if (MessageBox.Show("Tem Certeza em fazer o Backup?", "Configuração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lblMensagemBackup.Text = "Fazendo Backup...";
                    this.Refresh();
                    Thread.Sleep(10);
                    GerenciadorTeste.SalvarTestes();
                    GerenciadorTeste.Backup(rtxtBackup.Text);
                    MessageBox.Show("Backup Concluído!", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMensagemBackup.Text = "Backup Concluído!";
                }
                else
                    lblMensagemBackup.Text = "...";
            }
            else
                MessageBox.Show("Selecione um Caminho", "Configuracao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCaminhoRestauracao_Click(object sender, EventArgs e)
        {
            if (SelecionarBackup.ShowDialog() == DialogResult.OK)
                rtxtRestaurar.Text = SelecionarBackup.FileName;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (rtxtRestaurar.Text.Trim().Length > 0)
            {
                if (MessageBox.Show("Tem Certeza em fazer a Restauração?", "Configuração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lblMensagemRestaurar.Text = "Fazendo a Restauração...";
                    this.Update();
                    FormMenu Form_Menu = (FormMenu)this.TopLevelControl;
                    Form_Menu.formImagens.LimpandoImagem();
                    Thread.Sleep(10);
                    GerenciadorTeste.Restore(rtxtRestaurar.Text);
                    lblMensagemRestaurar.Text = "Restauração Concluída!";
                    MessageBox.Show("Restauração Concluída!", "Configuracao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Menu.formTeste.cbTestes.DataSource = null;
                    Form_Menu.formTeste.cbTestes.DisplayMember = "";
                    Form_Menu.formTeste.cbTestes.Items.Clear();
                    GerenciadorTeste.SelecionarTeste(null);
                    Form_Menu.formTeste.LimparTeste();
                    Form_Menu.formTeste.AtualizarListaTestes();
                    Form_Menu.formTeste.PermitirManipulacaoDoTeste(false);
                    Form_Menu.formTeste.LimparTesteDados();
                    Form_Menu.TemTesteSelecionado = false;
                    GerenciadorTeste.InicializarGerenciador();
                }
                else
                    lblMensagemRestaurar.Text = "...";

            }
            else
                MessageBox.Show("Selecione um Caminho", "Configuracao", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void btnCaminhoTeste_Click(object sender, EventArgs e)
        {
            if (SelecionarTeste.ShowDialog() == DialogResult.OK)
                rtxtTesteImportado.Text = SelecionarTeste.SelectedPath;
        }

        private void btnImportarTeste_Click(object sender, EventArgs e)
        {
            if (rtxtTesteImportado.Text.Trim().Length > 0)
            {
                if (MessageBox.Show("Tem Certeza em importar o Teste?", "Configuração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lblMensagemImportar.Text = "Importando Teste...";
                    this.Refresh();
                    Thread.Sleep(10);
                    if (GerenciadorTeste.AdicionarTeste(rtxtTesteImportado.Text))
                    {
                        MessageBox.Show("Teste Importado!", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblMensagemImportar.Text = "Teste Importado!";
                    }
                    else
                    {
                        MessageBox.Show("Teste Não Foi Importado!\nTeste com mesmo nome existente!", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblMensagemImportar.Text = "Teste Não Importado!";
                    }
                }
                else
                    lblMensagemImportar.Text = "...";
            }
            else
                MessageBox.Show("Selecione um Caminho", "Configuracao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Eventos Troca de Formato
        #region Evento de Formato de Arquivo
        private void cbFormatoTexto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormatoTexto = cbFormatoTexto.Text;
            Properties.Settings.Default.Save();
        }

        private void cbFormatoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormatoGrafico = cbFormatoGrafico.Text;
            Properties.Settings.Default.Save();
        }

        private void cbFormatoImagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormatoImagem = cbFormatoImagem.Text;
            Properties.Settings.Default.Save();
        }

        private void cbFormatoTesteDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormatoTesteDados = cbFormatoTesteDados.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Eventos de Troca de Cor
        private void btnColMedia_Click(object sender, EventArgs e)
        {
            if (SelecionadorCor.ShowDialog() == DialogResult.OK)
            {
                picboxColMedia.BackColor = SelecionadorCor.Color;
                Properties.Settings.Default.Coluna = SelecionadorCor.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void btnColDesvioPadrao_Click(object sender, EventArgs e)
        {
            if (SelecionadorCor.ShowDialog() == DialogResult.OK)
            {
                picboxColDesvioPadrao.BackColor = SelecionadorCor.Color;
                Properties.Settings.Default.Coluna2 = SelecionadorCor.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void btnLinhaDesvioPadrao_Click(object sender, EventArgs e)
        {
            if (SelecionadorCor.ShowDialog() == DialogResult.OK)
            {
                picboxLinhaMedia.BackColor = SelecionadorCor.Color;
                Properties.Settings.Default.Linha = SelecionadorCor.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void btnPontoMedia_Click(object sender, EventArgs e)
        {
            if (SelecionadorCor.ShowDialog() == DialogResult.OK)
            {
                picboxPontoMedia.BackColor = SelecionadorCor.Color;
                Properties.Settings.Default.Ponto = SelecionadorCor.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void btnFundoGrafico_Click(object sender, EventArgs e)
        {
            if (SelecionadorCor.ShowDialog() == DialogResult.OK)
            {
                picboxFundoGrafico.BackColor = SelecionadorCor.Color;
                Properties.Settings.Default.CorGrafico = SelecionadorCor.Color;
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        #region Eventos de Troca de Borda

        private void maskColDesvioPadrao_TextChanged(object sender, EventArgs e)
        {
            if (maskColDesvioPadrao.Text.Trim().Length > 0)
            {
                Properties.Settings.Default.Coluna2_Borda = byte.Parse(maskColDesvioPadrao.Text);
                Properties.Settings.Default.Save();
            }
        }

        private void maskLinhaMedia_TextChanged(object sender, EventArgs e)
        {
            if (maskLinhaMedia.Text.Trim().Length > 0)
            {
                Properties.Settings.Default.Linha_Borda = byte.Parse(maskLinhaMedia.Text);
                Properties.Settings.Default.Save();
            }
        }

        private void maskPontoMedia_TextChanged(object sender, EventArgs e)
        {
            if (maskPontoMedia.Text.Trim().Length > 0)
            {
                Properties.Settings.Default.Ponto_Borda = byte.Parse(maskPontoMedia.Text);
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        private void checkExcelDiferenca_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ExcelDiferenca = checkExcelDiferenca.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkExcelDados_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ExcelDados = checkExcelDados.Checked;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Eventos de Tema
        private void btnCor1_Click(object sender, EventArgs e)
        {

        }

        private void btnCor2_Click(object sender, EventArgs e)
        {

        }

        private void btnCor3_Click(object sender, EventArgs e)
        {

        }

        private void btnCor4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Form_MouseEnter(object sender, EventArgs e)
        {
            FormMenu Form_Menu = (FormMenu)this.TopLevelControl;
            Form_Menu.MouseSaiuDoPainel(sender, e);
        }

        #endregion

    }
}
