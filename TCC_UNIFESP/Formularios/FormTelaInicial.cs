using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TCC_UNIFESP
{
    public partial class FormTelaInicial : Form
    {
        string[] Videos = new string[3];
        string[] Documentos = new string[2];
        public FormTelaInicial(string caminho)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            Videos[0] = $@"{caminho}\Videos\Criação de teste + Incerção de imagens - EDITADO.mp4";
            Videos[1] = $@"{caminho}\Videos\Manipulação do Teste - EDITADO.mp4";
            Videos[2] = $@"{caminho}\Videos\Comparador + Configuração - EDITADO.mp4";
            Documentos[0] = $@"{caminho}\Documentos\Monografia.doc";
            Documentos[1] = $@"{caminho}\Documentos\Manual de Usuario.doc";
        }

        private void Form_MouseEnter(object sender, EventArgs e)
        {
            FormMenu Form_Menu = (FormMenu)this.TopLevelControl;
            Form_Menu.MouseSaiuDoPainel(sender, e);
        }

        private void linkCriacaoTeste_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Videos[0]);
        }

        private void linkManipularTeste_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Videos[1]);
        }

        private void linkConfiguracao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Videos[2]);
        }

        private void linkManualUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Documentos[1]);
        }

        private void linkMonografia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Documentos[0]);
        }
    }
}
