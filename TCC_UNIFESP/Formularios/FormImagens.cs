using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCC_UNIFESP
{
    public partial class FormImagens : Form
    {
        #region Variaveis
        ImagemDados ImagemSelecionada;

        List<string> CaminhosImagem = new List<string>();

        bool ImagemConvertidaEstaSelecionada = true;

        OpenFileDialog AbrirArquivoImagem = new OpenFileDialog
        {
            Filter = "Arquivos Imagem| *.bmp; *.jpg; *.gif; *.png; *.tif",
            Multiselect = true
        };
        #endregion

        public FormImagens()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
        }

        #region Funcoes Event
        private void FormImagens_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
                AtualizarTreeView();

            if (!(cbMetodos.Items.Count > 0))
                cbMetodos.DataSource = GerenciadorTeste.PegarVerificadores();
            cbMetodos.DisplayMember = "Nome";
        }

        private void Form_MouseEnter(object sender, EventArgs e)
        {
            FormMenu Form_Menu = (FormMenu)this.TopLevelControl;
            Form_Menu.MouseSaiuDoPainel(sender, e);
        }

        private void TreeViewImagens_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TreeViewImagens.SelectedNode.Tag != null)
            {
                ImagemSelecionada = (ImagemDados)TreeViewImagens.SelectedNode.Tag;
                PreencherImagemDados();
                picboxImagem.ImageLocation = ImagemSelecionada.IdImagem;
                ImagemConvertidaEstaSelecionada = true;
            }
        }

        private bool VerificarTipoAumento(string Caminho)
        {
            return Caminho.Replace(".", ",").ToLower().Contains(GerenciadorTeste.TesteSelecionado.TipoAumento.Replace(".", ",").ToLower());
        }

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            if (AbrirArquivoImagem.ShowDialog() == DialogResult.OK)
            {
                btnAdicionarImagem.Text = "Adicionando...";
                this.Update();
                Thread.Sleep(10);

                CaminhosImagem.Clear();
                CaminhosImagem.AddRange(AbrirArquivoImagem.FileNames);
                if (!CaminhosImagem.Exists(str => VerificarTipoAumento(Path.GetFileName(str))))
                {
                    if (Perguntar("Tem certeza em prosseguir? Qualquer imagem de aumento diferente do teste será adicionado"))
                        InserirImagensSelecionadas();
                }
                else if (Perguntar("As imagens não estão no tamanho especificado \nDeseja prosseguir"))
                    InserirImagensSelecionadas();

                AtualizarTreeView();
                ImagemConvertidaEstaSelecionada = true;
                btnAdicionarImagem.Text = "Adicionar Imagem";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtAumento.Text.Trim().Length > 0 && int.Parse(maskGrupo.Text) > 0)
            {
                if (CaminhosImagem.Count > 0)
                {
                    bool condicao = true;
                    foreach (ImagemDados imagem in GerenciadorTeste.TesteSelecionado.Imagens)
                    {
                        if (CompararImagemDados(imagem, txtAumento.Text, Byte.Parse(maskGrupo.Text), Byte.Parse(maskPeriodo.Text)))
                        {
                            condicao = false;
                            break;
                        }
                    }
                    if (condicao)
                        GerenciadorTeste.TesteSelecionado.Imagens.Add(new ImagemDados(CaminhosImagem[0], txtAumento.Text, Byte.Parse(maskGrupo.Text), Byte.Parse(maskPeriodo.Text)));
                    else if (Perguntar("Deseja substituir imagem do mesmo tipo?"))
                    {
                        GerenciadorTeste.TesteSelecionado.RemoverImagem(GerenciadorTeste.TesteSelecionado.Imagens.Find(
                        img => CompararImagemDados(img, txtAumento.Text, Byte.Parse(maskGrupo.Text), Byte.Parse(maskPeriodo.Text))));
                        GerenciadorTeste.TesteSelecionado.Imagens.Add(new ImagemDados(CaminhosImagem[0], txtAumento.Text, Byte.Parse(maskGrupo.Text), Byte.Parse(maskPeriodo.Text)));
                    }
                    CaminhosImagem.Remove(CaminhosImagem[0]);
                    EsvaziarImagemDados();
                    PermissaoImagemDados(false);
                    InserirImagensSelecionadas();
                }
                else
                {
                    AtualizarImagemDados();
                    PermissaoImagemDados(false);
                }
                AtualizarTreeView();
            }
            else
                MessageBox.Show("Existem Dados Faltando", "IMAGENS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (CaminhosImagem.Count > 0)
            {
                CaminhosImagem.Remove(CaminhosImagem[0]);
                EsvaziarImagemDados();
                InserirImagensSelecionadas();
            }
            PermissaoImagemDados(false);
        }

        private void btnBaixarImagem_Click(object sender, EventArgs e)
        {
            if (ImagemSelecionada != null)
                GerenciadorTeste.SalvarElemento((Bitmap)picboxImagem.Image);
            else
                MessageBox.Show("Selecione uma Imagem", "Imagens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            if (ImagemSelecionada != null)
            {
                if (Perguntar("Tem certeza em deletar a imagem?"))
                {
                    picboxImagem.Image = null;
                    GerenciadorTeste.TesteSelecionado.RemoverImagem(ImagemSelecionada);
                    AtualizarTreeView();
                }
            }
            else
                MessageBox.Show("Selecione uma Imagem", "Imagens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImagemSelecionada != null)
            {
                picboxImagem.Image = ImagemSelecionada.ProcessarImagem((AbstractVerificadorPixel)cbMetodos.SelectedItem);
                ImagemConvertidaEstaSelecionada = false;
                lblPorcentagem.Text = ImagemSelecionada.Porcentagem.ToString("0.00");
            }
        }

        private void btnReescrever_Click(object sender, EventArgs e)
        {
            if (ImagemSelecionada != null)
                PermissaoImagemDados(true);
        }

        private void btnTrocarImagem_Click(object sender, EventArgs e)
        {
            if (ImagemSelecionada != null)
                if (ImagemConvertidaEstaSelecionada)
                {
                    picboxImagem.Image = ImagemSelecionada.ProcessarImagem((AbstractVerificadorPixel)cbMetodos.SelectedItem);
                    ImagemConvertidaEstaSelecionada = false;
                }
                else
                {
                    picboxImagem.ImageLocation = ImagemSelecionada.IdImagem;
                    ImagemConvertidaEstaSelecionada = true;
                }
        }
        #endregion

        private void InserirImagensSelecionadas()
        {
            while (CaminhosImagem.Count > 0)
            {
                if (Path.GetFileNameWithoutExtension(CaminhosImagem[0]).ToLower().Contains("x-g") && Path.GetFileNameWithoutExtension(CaminhosImagem[0]).ToLower().Contains("-t"))
                {
                    if (!GerenciadorTeste.TesteSelecionado.Imagens.Exists(img => Path.GetFileNameWithoutExtension(img.IdImagem) == Path.GetFileNameWithoutExtension(CaminhosImagem[0])))
                    {
                        GerenciadorTeste.TesteSelecionado.Imagens.Add(new ImagemDados(CaminhosImagem[0]));
                        if (GerenciadorTeste.TesteSelecionado.QuantidadeGrupos < VerificarQuantidadeGrupos())
                        {
                            if (Perguntar("A quantidade de grupos excede ao qual você estipulou." + Environment.NewLine + "Quer aumenta-la?"))
                                GerenciadorTeste.TesteSelecionado.QuantidadeGrupos = VerificarQuantidadeGrupos();
                            else
                                GerenciadorTeste.TesteSelecionado.RemoverImagem(GerenciadorTeste.TesteSelecionado.Imagens.Find(img => img.IdImagem == CaminhosImagem[0]));
                        }
                    }
                    else if (Perguntar("Deseja substituir imagem do mesmo tipo?"))
                    {
                        GerenciadorTeste.TesteSelecionado.RemoverImagem(GerenciadorTeste.TesteSelecionado.Imagens.Find(
                        img => Path.GetFileNameWithoutExtension(img.IdImagem) == Path.GetFileNameWithoutExtension(CaminhosImagem[0])));
                        GerenciadorTeste.TesteSelecionado.Imagens.Add(new ImagemDados(CaminhosImagem[0]));
                        if (GerenciadorTeste.TesteSelecionado.QuantidadeGrupos < VerificarQuantidadeGrupos())
                        {
                            if (Perguntar("A quantidade de grupos excede ao qual você estipulou." + Environment.NewLine + "Quer aumenta-la?"))
                                GerenciadorTeste.TesteSelecionado.QuantidadeGrupos = VerificarQuantidadeGrupos();
                            else
                                GerenciadorTeste.TesteSelecionado.RemoverImagem(GerenciadorTeste.TesteSelecionado.Imagens.Find(img => img.IdImagem == CaminhosImagem[0]));
                        }
                    }
                    CaminhosImagem.Remove(CaminhosImagem[0]);
                }
                else
                {
                    if (!Perguntar($"O Arquivo : {CaminhosImagem[0]} \nNão está no padrão de nomeação.\nInserir dados manualmente?"))
                    {
                        CaminhosImagem.Remove(CaminhosImagem[0]);
                        continue;
                    }
                    else
                    {
                        picboxImagem.ImageLocation = CaminhosImagem[0];
                        PermissaoImagemDados(true);
                        break;
                    }
                }
            }
            if (CaminhosImagem.Count == 0)
                MessageBox.Show("Imagens Processadas", "Imagens", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtualizarTreeView()
        {
            TreeViewImagens.Nodes.Clear();
            if (GerenciadorTeste.TesteSelecionado.Imagens.Count > 0)
                for (int periodo = 0; periodo <= GerenciadorTeste.TesteSelecionado.Imagens.Max(img => img.Periodo); periodo++)
                {
                    TreeNode Node = new TreeNode();
                    Node.Text = (periodo == 0) ? "Controle" : $"{(GerenciadorTeste.TesteSelecionado.TipoPeriodo ? "Dia" : "Hora")} {periodo * GerenciadorTeste.TesteSelecionado.FrequenciaPeriodo}";
                    foreach (ImagemDados imagem in GerenciadorTeste.TesteSelecionado.Imagens.Where(img => img.Periodo == periodo))
                        Node.Nodes.Add(new TreeNode { Text = $"{imagem.Aumento}-G{imagem.Grupo}-T{imagem.Periodo}", Tag = imagem });

                    TreeViewImagens.Nodes.Add(Node);
                }
        }

        #region funcoes Manipular ImagemDados
        private void PreencherImagemDados()
        {
            lblPorcentagem.Text = ImagemSelecionada.Porcentagem.ToString("0.00");
            txtAumento.Text = ImagemSelecionada.Aumento;
            maskGrupo.Text = ImagemSelecionada.Grupo.ToString();
            maskPeriodo.Text = ImagemSelecionada.Periodo.ToString();
            cbMetodos.SelectedIndex = ImagemSelecionada.Metodo;
        }

        private void EsvaziarImagemDados()
        {
            ImagemSelecionada = null;
            LimpandoImagem();
            lblPorcentagem.Text = "";
            txtAumento.Text = "";
            maskGrupo.Text = "00";
            maskPeriodo.Text = "00";
        }

        private void PermissaoImagemDados(bool permitir)
        {
            FormMenu formmenu = (FormMenu)TopLevelControl;
            formmenu.PodeAcessarFormTeste = !permitir;
            pnImagemDados.Enabled = permitir;
            btnConfirmar.Visible = permitir;
            btnCancelar.Visible = permitir;
            btnAdicionarImagem.Enabled = !permitir;
            btnTrocarImagem.Enabled = !permitir;
            btnRemoverImagem.Enabled = !permitir;
            btnReescrever.Enabled = !permitir;
            cbMetodos.Enabled = !permitir;
            btnBaixarImagem.Enabled = !permitir;
        }

        private void AtualizarImagemDados()
        {
            bool condicao = true;
            bool condicao2 = true;
            foreach (ImagemDados imagem in GerenciadorTeste.TesteSelecionado.Imagens)
                if (CompararImagemDados(imagem, txtAumento.Text, Byte.Parse(maskGrupo.Text), Byte.Parse(maskPeriodo.Text)))
                {
                    condicao = false;
                    break;
                }

            if (!condicao)
            {
                MessageBox.Show($"Existe imagem de mesmo tipo que essa.", "Imagens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!GerenciadorTeste.TesteSelecionado.TipoAumento.Replace(".", ",").ToLower().Contains(txtAumento.Text.Replace(".", ",").ToLower()))
                condicao2 = (Perguntar("O tipo de aumento da imagem não corresponde ao do teste atual deseja continuar?")) ? true : false;

            if (condicao2)
            {
                ImagemSelecionada.Aumento = txtAumento.Text;
                ImagemSelecionada.Grupo = byte.Parse(maskGrupo.Text);
                ImagemSelecionada.Periodo = byte.Parse(maskPeriodo.Text);
            }

            if (GerenciadorTeste.TesteSelecionado.QuantidadeGrupos < VerificarQuantidadeGrupos())
                if (Perguntar("A quantidade de grupos excede ao qual você estipulou." + Environment.NewLine + "Quer aumenta-la?"))
                    GerenciadorTeste.TesteSelecionado.QuantidadeGrupos = VerificarQuantidadeGrupos();
        }
        #endregion

        public void LimpandoImagem()
        {
            picboxImagem.ImageLocation = "";
            if (picboxImagem.Image != null)
                picboxImagem.Image.Dispose();
        }

        private byte VerificarQuantidadeGrupos()
        {
            byte QuantGrup = GerenciadorTeste.TesteSelecionado.QuantidadeGrupos;
            for (int i = 0; i < GerenciadorTeste.TesteSelecionado.Imagens.Max(img => img.Periodo); i++)
                if (QuantGrup < GerenciadorTeste.TesteSelecionado.Imagens.Where(img => img.Periodo == i).ToList().Count)
                    return (byte)GerenciadorTeste.TesteSelecionado.Imagens.Where(img => img.Periodo == i).ToList().Count;
            return (byte)0;
        }

        private bool CompararImagemDados(ImagemDados imagem, string Aumento, byte Grupo, byte Periodo)
        {
            return (imagem.Grupo == Grupo && imagem.Periodo == Periodo && imagem.Aumento.Equals(Aumento));
        }

        private bool Perguntar(string Msg)
        {
            return MessageBox.Show(Msg, "IMAGENS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

    }
}
