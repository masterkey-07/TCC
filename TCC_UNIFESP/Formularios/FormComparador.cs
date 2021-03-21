using System;
using System.Linq;
using System.Windows.Forms;

namespace TCC_UNIFESP
{
    public partial class FormComparador : Form
    {
        public FormComparador()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
        }

        private void FormComparador_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (GerenciadorTeste.TesteSelecionado != null)
                    GerenciadorTeste.TesteSelecionado.GerarDados();
                listTestes1.DataSource = GerenciadorTeste.Testes.ToList();
                listTestes1.DisplayMember = "Nome";
                listTestes2.DataSource = GerenciadorTeste.Testes.ToList();
                listTestes2.DisplayMember = "Nome";
                picboxColMedia.BackColor = Properties.Settings.Default.Coluna;
                picboxColDesvio.BackColor = Properties.Settings.Default.Coluna2;
                picboxLinhaDesvioPadrao.BackColor = Properties.Settings.Default.Linha;
                chartGrafico1.ChartAreas[0].BackColor = Properties.Settings.Default.CorGrafico;
                chartGrafico2.ChartAreas[0].BackColor = Properties.Settings.Default.CorGrafico;
            }
        }

        private void Form_MouseEnter(object sender, EventArgs e)
        {
            FormMenu Form_Menu = (FormMenu)this.TopLevelControl;
            Form_Menu.MouseSaiuDoPainel(sender, e);
        }

        private void Form_Comparador_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = (this.Width / 2) - 2;
            panel3.Width = (this.Width / 2) - 2;
        }

        private void listTestes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InserirGrafico1();
        }

        private void listTestes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InserirGrafico2();
        }

        private void checkColMedia_CheckedChanged(object sender, EventArgs e)
        {
            InserirGrafico1();
            InserirGrafico2();
        }

        private void InserirGrafico1()
        {
            if (listTestes1.SelectedIndex >= 0)
            {
                TesteDados Teste1 = (TesteDados)listTestes1.SelectedItem;
                bool[] valores = new bool[Teste1.Dados.Count];
                for (int i = 0; i < valores.Length; i++)
                    valores[i] = true;
                Teste1.PegarGrafico(chartGrafico1, valores, checkColMedia.Checked, checkColDesvio.Checked,
                    checkLinhaDesvio.Checked, checkPontosMedia.Checked, checkDadosGrafico.Checked);
                rtxtTexto1.Text = Teste1.PegarDiferencaPadrao();
            }
        }

        private void InserirGrafico2()
        {
            if (listTestes2.SelectedIndex >= 0)
            {
                TesteDados Teste2 = (TesteDados)listTestes2.SelectedItem;
                bool[] valores = new bool[Teste2.Dados.Count];
                for (int i = 0; i < valores.Length; i++)
                    valores[i] = true;
                Teste2.PegarGrafico(chartGrafico2, valores, checkColMedia.Checked, checkColDesvio.Checked,
                    checkLinhaDesvio.Checked, checkPontosMedia.Checked, checkDadosGrafico.Checked);
                rtxtTexto2.Text = Teste2.PegarDiferencaPadrao();
            }
        }
    }
}
