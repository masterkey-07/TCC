namespace TCC_UNIFESP
{
    class Verificar2_5x : AbstractVerificadorPixel
    {

        public override string Nome { get; set; } = "Imagem 1 e 2";
        
        public override unsafe byte* ProcessarPixel(byte* dt)
        {
            int Vermelho = dt[2], Verde = dt[1], Azul = dt[0];
            if (Verde <= 50)
            {
                if (Cor_Maior(Vermelho, Azul, true))
                    return PintarPixel(Diferenca_Cor(Vermelho, Azul, 40), dt);
                else
                    return PintarPixel(Diferenca_Cor(Vermelho, Azul, 20), dt);
            }
            else
                return PintarPixel(false, dt);
        }
    }
}
