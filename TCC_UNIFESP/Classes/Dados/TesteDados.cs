using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace TCC_UNIFESP
{

    public class TesteDados : ICloneable
    {
        ProcessadorDados Processador = new ProcessadorDados();

        #region Variaveis Basicos
        public short Id { get; set; }

        public string Nome { get; set; }

        public bool TipoPeriodo { get; set; }

        public byte FrequenciaPeriodo { get; set; }

        public string TipoAumento { get; set; }

        public byte QuantidadeGrupos { get; set; }
        #endregion

        #region Metodos/Atributo dos Dados
        private List<GraficoDados> _Dados = new List<GraficoDados>();

        public List<GraficoDados> Dados
        {
            get
            {
                _Dados = _Dados.OrderBy(dado => OrdenarDado(dado.Periodo)).ToList();
                return _Dados;
            }
            set
            {
                _Dados = value.OrderBy(d => d.Periodo).ToList();
            }
        }

        private int OrdenarDado(string periodo)
        {
            if (periodo.Contains("Controle"))
                return 0;
            else
                return Int32.Parse(periodo.Replace("Hora", "").Replace("Dia", "").Trim());
        }

        public void GerarDados()
        {
            this._Dados = Processador.ProcessarDados(this);
        }

        public void PegarGrafico(Chart grafico, bool[] periodos, bool coluna, bool coluna2, bool linha, bool ponto, bool dado)
        {
            Processador.ProcessarGrafico(grafico, this._Dados, periodos, coluna, coluna2, linha, ponto, dado);
        }

        public string PegarDiferencaPadrao() { return Processador.ProcessarTexto(_Dados); }

        public string PegarTesteDados() { return Processador.ProcessarTesteDados(this); }
        #endregion

        #region Metodos/Atributo das Imagens
        private List<ImagemDados> _Imagens = new List<ImagemDados>();

        public List<ImagemDados> Imagens
        {
            get
            {
                _Imagens = _Imagens.OrderBy(img => img.Periodo).ThenBy(img => img.Grupo).ToList();
                return _Imagens;
            }
            set
            {
                _Imagens = value.OrderBy(img => img.Periodo).ThenBy(img => img.Grupo).ToList();
            }
        }

        public byte QuantidadeImagens { get { return (byte)_Imagens.Count; } private set { } }

        public List<ImagemDados> ImagensRemovidas { get; set; } = new List<ImagemDados>();

        public void RemoverImagem(ImagemDados Img)
        {
            this.ImagensRemovidas.Add(Img);
            this._Imagens.Remove(Img);
            _Imagens = _Imagens.OrderBy(img => img.Periodo).ThenBy(img => img.Grupo).ToList();
        }
        #endregion

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
