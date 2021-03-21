
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TCC_UNIFESP
{
    public partial class FormMenu : Form
    {
        #region Variaveis

        #region Propriedades

        public string NomeTeste
        {
            get
            {
                return lblNomeTeste.Text;
            }
            set
            {
                lblNomeTeste.Text = value;
            }
        }

        #endregion

        #region variaveis Form
        public FormTeste formTeste = new FormTeste();
        public FormImagens formImagens = new FormImagens();
        private FormComparador formComparador = new FormComparador();
        private FormTelaInicial formTelaInicial;
        private FormConfiguracao formConfiguracao = new FormConfiguracao();
        #endregion

        #region variaveis List
        List<Button> Botoes;
        List<Button> BotoesIcon;
        List<Form> Formularios;
        #endregion

        public bool TemTesteSelecionado = false;
        public bool PodeAcessarFormTeste = true;
        #endregion

        public FormMenu()
        {
            InitializeComponent();
            FormCarregamento tel = new FormCarregamento();
            tel.Show();
           string caminho = GerenciadorTeste.InicializarGerenciador();
            formTelaInicial = new FormTelaInicial(caminho);
            AdicionarFormsNoPnForm();
            Formularios = CriarListaFormulario();
            Botoes = CriarListaBotao();
            BotoesIcon = CriarListaBotaoIcon();
            formTelaInicial.Show();
            this.NomeTeste = "Teste Selecionado";
            tel.Close();
        }

        private void BotaoClick(object sender, EventArgs e)
        {
            int index = Botoes.IndexOf((Button)sender);
            if (index == -1)
                index = BotoesIcon.IndexOf((Button)sender);
            if (index == 1 && !PodeAcessarFormTeste)
            {
                MessageBox.Show("Não é possivel acessar o formulario no momento." + Environment.NewLine + "Acaba a edição no momento.", "MENU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (index == 2 && !TemTesteSelecionado)
            {
                MessageBox.Show("Não é possivel acessar o formulario no momento." + Environment.NewLine + "Selecione um Teste ou acaba a edição no momento.", "MENU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Botoes.ForEach(btn => btn.BackColor = Color.Gray);
            BotoesIcon.ForEach(btn => btn.BackColor = Color.Gray);
            Formularios.ForEach(form => form.Hide());
            Botoes[index].BackColor = Color.Silver;
            BotoesIcon[index].BackColor = Color.Silver;
            Formularios[index].Show();
        }

        public void PermitirFormImagem(bool valor)
        {
            btnImagens.Enabled = valor;
            btnIconImagens.Enabled = valor;
        }

        #region Controle de Paineis
        private void MouseEntrouNoPainel(object sender, EventArgs e)
        {
            pnBtnForms.Width = 217;
        }

        public void MouseSaiuDoPainel(object sender, EventArgs e)
        {
            pnBtnForms.Width = 69;
        }
        #endregion

        #region Button WindowState
        private void IconExit(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.White, 2);
            g.DrawLine(p, 15, 8, 25, 19);
            g.DrawLine(p, 15, 19, 25, 8);
        }

        private void IconMaxNor(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.White, 2);
            SolidBrush b = new SolidBrush(Color.FromArgb(64, 64, 64));
            if (this.WindowState == FormWindowState.Maximized)
            {
                g.DrawRectangle(p, 20, 8, 10, 8);
                g.FillRectangle(b, 15, 13, 10, 8);
                g.DrawRectangle(p, 15, 13, 10, 8);
            }
            else
                g.DrawRectangle(p, 13, 9, 13, 11);
        }

        private void IconMin(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.White);
            g.FillRectangle(b, 15, 20, 10, 4);
        }

        private void ExitForm(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Quer salvar todas as alterações?", "MENU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes || resposta == DialogResult.No)
            {
                if (GerenciadorTeste.TesteSelecionado != null)
                {
                    Properties.Settings.Default.TesteAberto = GerenciadorTeste.TesteSelecionado.Nome;
                    Properties.Settings.Default.Save();
                }
                if (resposta == DialogResult.Yes)
                    GerenciadorTeste.SalvarTestes();
                GerenciadorTeste.FinalizarGerenciador();
                this.Close();
            }
        }

        private void MaxNorForm(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

            btnMaxNormal.Invalidate();
        }

        private void MinForm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Criar Listas
        private List<Button> CriarListaBotao()
        {
            List<Button> botoes = new List<Button>
            {
                btnTelaInicial,
                    btnTeste,
                btnImagens,
                btnComparador,
                btnConfiguracao
            };

            return botoes;
        }

        private List<Button> CriarListaBotaoIcon()
        {
            List<Button> botoesincon = new List<Button>
            {
                btnIconTelaInicial,
                btnIconTeste,
                btnIconImagens,
                btnIconComparador,
                btnIconConfiguracao
            };

            return botoesincon;
        }

        private List<Form> CriarListaFormulario()
        {
            List<Form> formularios = new List<Form>
            {
                formTelaInicial,
                formTeste,
                formImagens,
                formComparador,
                formConfiguracao
            };
            return formularios;
        }

        private void AdicionarFormsNoPnForm()
        {
            pnForm.Controls.Add(formTelaInicial);
            pnForm.Controls.Add(formTeste);
            pnForm.Controls.Add(formImagens);
            pnForm.Controls.Add(formComparador);
            pnForm.Controls.Add(formConfiguracao);
        }
        #endregion

        #region Resize and Drag Windows

        #region varWinform
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private void ChangeFormPosition(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;
            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;
            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }
            if (!handled)
                base.WndProc(ref m);
        }
        #endregion

    }
}
