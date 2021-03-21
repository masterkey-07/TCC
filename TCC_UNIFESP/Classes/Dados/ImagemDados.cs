using System;
using System.Drawing;
using System.IO;

namespace TCC_UNIFESP
{
    public class ImagemDados
    {
        private ProcessadorImagem Processador = new ProcessadorImagem();

        #region Variaveis Basicas
        public bool Novo { get; set; }

        public string IdImagem { get; set; }

        public string Aumento { get; set; }

        public byte Grupo { get; set; }

        public byte Periodo { get; set; }

        public byte Metodo { get; set; }

        public double Porcentagem { get; set; }
        #endregion

        #region Funcoes

        #region Contrutores
        public ImagemDados(string Id)
        {
            this.IdImagem = Id;
            this.Novo = true;
            string name = Path.GetFileNameWithoutExtension(Id).ToLower();
            this.Aumento = name.Substring(0, name.IndexOf("x") + 1);
            this.Grupo = Byte.Parse(name.Substring(name.IndexOf("g") + 1, 2).Replace("-", "").Trim());
            this.Periodo = Byte.Parse(name.Substring(name.IndexOf("t") + 1).Replace("-", "").Trim());
            this.Metodo = 0;
            Processador.ConverterImagem(new Bitmap(this.IdImagem), GerenciadorTeste.PegarVerificadores()[this.Metodo]);
            this.Porcentagem = Processador.CalcularPorcentagem();
        }

        public ImagemDados(string Id, string Aumento, byte Grupo, byte Periodo)
        {
            this.IdImagem = Id;
            this.Novo = true;
            this.Aumento = Aumento;
            this.Grupo = Grupo;
            this.Periodo = Periodo;
            this.Metodo = 0;
            Processador.ConverterImagem(new Bitmap(this.IdImagem), GerenciadorTeste.PegarVerificadores()[this.Metodo]);
            this.Porcentagem = Processador.CalcularPorcentagem();
        }

        public ImagemDados() { }
        #endregion

        public Bitmap ProcessarImagem(AbstractVerificadorPixel Verificar)
        {
            Bitmap img;
            this.Metodo = (byte)GerenciadorTeste.PegarVerificadores().IndexOf(Verificar);
            img = Processador.ConverterImagem(new Bitmap(this.IdImagem), Verificar);
            this.Porcentagem = Processador.CalcularPorcentagem();
            return img;
        }
        #endregion
    }
}