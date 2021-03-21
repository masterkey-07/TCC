namespace TCC_UNIFESP
{
    class Verificar2_5x_2 : AbstractVerificadorPixel
    {

        public override string Nome { get; set; } = "Imagem 3";

        public override unsafe byte* ProcessarPixel(byte* dt)
        {
            int Vermelho = dt[2], Verde = dt[1], Azul = dt[0];
            if (Verde <= 1)
                return PintarPixel(Diferenca_Cor(Vermelho, Azul, 100) && Cor_Maior(Vermelho, Azul, true), dt);
            else
                return PintarPixel(Diferenca_Cor(Vermelho, Azul, 10) && Cor_em_Parametros(Verde, 80, 100), dt);
        }
    }
}
