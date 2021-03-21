namespace TCC_UNIFESP
{
    public abstract class AbstractVerificadorPixel
    {
        #region Funcoes Protegidas
        protected bool Diferenca_Cor(int CorA, int CorB, int Valor)
        {
            int Comparativo = CorA - CorB;
            return (Comparativo >= -Valor && Comparativo <= Valor);
        }

        protected bool Cor_Maior(int CorA, int CorB, bool Executar)
        {
            if (Executar)
                return (CorA >= CorB);
            else
                return true;
        }

        protected bool Cor_em_Parametros(int Cor, int Min, int Max)
        {
            return (Cor <= Max && Min < Cor);
        }
        
        protected unsafe byte* PintarPixel(bool Condicao, byte* dt)
        {
            int Vermelho = dt[2], Azul = dt[1], Verde = dt[0];
            if (Condicao)
            {
                dt[0] = dt[2];
                dt[1] = dt[2];
            }
            else
            {
                dt[0] = 255;
                dt[1] = 255;
                dt[2] = 255;
            }
            return dt;
        }

        #endregion

        #region Abstratas

        public unsafe abstract byte* ProcessarPixel(byte* dt);

        public abstract string Nome { get; set; }

        #endregion
    }
}
