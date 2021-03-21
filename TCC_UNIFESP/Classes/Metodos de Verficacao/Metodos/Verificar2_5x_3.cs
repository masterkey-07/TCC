namespace TCC_UNIFESP
{
    class Verificar2_5x_3 : AbstractVerificadorPixel
    {
        public override string Nome { get; set; } = "Imagem 4";

        public override unsafe byte* ProcessarPixel(byte* dt)
        {
            int Vermelho = dt[2], Verde = dt[1], Azul = dt[0];
            if (Diferenca_Cor(Vermelho, Azul, 15))
                return PintarPixel(Verde <= 70, dt);
            else
                   return PintarPixel(Cor_Maior(Vermelho, Azul, true) && Vermelho > 75 && Cor_em_Parametros(Azul, 40, 100), dt); 
        }
    }
}