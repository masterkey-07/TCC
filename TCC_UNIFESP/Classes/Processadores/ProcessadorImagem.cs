using System;
using System.Drawing;
using System.Drawing.Imaging;


namespace TCC_UNIFESP
{
    public class ProcessadorImagem
    {
        #region Criacao_de_Variaveis

        private double QuantTotal = 0;
        private double QuantInfec = 0;

        #endregion

        #region Funcoes_Privadas
        private byte GetBitsPerPixel(PixelFormat pixelFormat)
        {
            if (pixelFormat == PixelFormat.Format24bppRgb)
                return 24;
            else if (pixelFormat == PixelFormat.Format32bppArgb || pixelFormat == PixelFormat.Format32bppPArgb || pixelFormat == PixelFormat.Format32bppRgb)
                return 32;
            else
                throw new ArgumentException("Only 24 and 32 bit images are supported");
        }
        #endregion

        #region Funcoes_Protegidas

        public unsafe Bitmap ConverterImagem(Bitmap _image, AbstractVerificadorPixel Pixel)
        {
            #region Criacao_de_Variaveis_da_Funcao

            int LimiteInfeccao = 10;
            QuantTotal = 0;
            QuantInfec = 0;
            Bitmap b = _image;
            BitmapData bData = b.LockBits(new Rectangle(0, 0, _image.Width, _image.Height), ImageLockMode.ReadWrite, b.PixelFormat);
            byte bitsPerPixel = GetBitsPerPixel(bData.PixelFormat);
            byte* scan0 = (byte*)bData.Scan0.ToPointer();

            #endregion

            #region Deteccao_de_Pixels

            for (int y = 0; y < bData.Height; ++y)
            {
                for (int x = 0; x < bData.Width; ++x)
                {
                    byte* data = scan0 + y * bData.Stride + x * bitsPerPixel / 8;
                    data = Pixel.ProcessarPixel(data);
                }
            }
            #endregion

            #region Otimizacao_da_Imagem
            for (int y = 0; y < bData.Height; y++)
            {
                for (int x = 0; x < bData.Width; x++)
                {
                    byte* data = scan0 + y * bData.Stride + x * bitsPerPixel / 8;
                    byte Vermelho = data[2], Azul = data[1], Verde = data[0];

                    if (!(Vermelho == 255 && Verde == 255 && Azul == 255))
                    {
                        int VerificacaoInfeccao = 0;
                        for (int y2 = -2; y2 < 3; y2++)
                        {
                            for (int x2 = -2; x2 < 3; x2++)
                            {
                                if ((x2 + x) < bData.Width && (y2 + y) < bData.Height && (x2 + x) >= 0 && (y2 + y) >= 0)
                                {
                                    byte* data2 = scan0 + (y2 + y) * bData.Stride + (x2 + x) * bitsPerPixel / 8;
                                    byte Vermelho2 = data2[2], Azul2 = data2[1], Verde2 = data2[0];
                                    if (!(Vermelho2 == 255 && Verde2 == 255 && Azul2 == 255))
                                        VerificacaoInfeccao++;
                                }
                            }
                        }
                        if (VerificacaoInfeccao >= LimiteInfeccao)
                            QuantInfec++;
                        else
                        {
                            data[0] = 255;
                            data[1] = 255;
                            data[2] = 255;
                        }
                    }
                }
            }
            #endregion

            QuantTotal = bData.Height * bData.Width;

            b.UnlockBits(bData);

            return b;
        }

        public double CalcularPorcentagem()
        {
            return (QuantInfec / QuantTotal) * 100;
        }

        #endregion
    }
}