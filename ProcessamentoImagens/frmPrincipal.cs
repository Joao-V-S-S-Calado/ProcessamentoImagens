using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg1.Image = image;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg1.Image = null;
            pictBoxImg2.Image = null;
        }

        private void btnLuminanciaSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_gray(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnLuminanciaComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_grayDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativo(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoVerticalComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_verticalDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoHorizontalSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_horizontal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoHorizontalComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_horizontalDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoVertivalSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_vertical(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnPretoBrancoSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.preto_branco(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnRotacao90SemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image, new Size(image.Height, image.Width));
            imageBitmap = (Bitmap)image;
            Filtros.rotacao90(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnInverteRcomBsemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.inverteRB(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoDiagonalPrincipalSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_diagona_principal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnDivisaoCentroSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.divisao_centro(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnPretoBrancoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.preto_brancoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnInverteRcomBcomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.inverteRB_DMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelhoDiagonalPrincipalComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelho_diagonal_principalDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnRotacao90ComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image, new Size(image.Height, image.Width));
            imageBitmap = (Bitmap)image;
            Filtros.rotacao90DMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararBsemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separar_b(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararGsemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separar_g(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararRsemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separar_r(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararBcomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarB_DMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararGcomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarG_DMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararRcomDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarR_DMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnDivisaoCentroComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.divisao_centroDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }
    }
}
