namespace ProcessamentoImagens
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.pictBoxImg2 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLuminanciaSemDMA = new System.Windows.Forms.Button();
            this.btnLuminanciaComDMA = new System.Windows.Forms.Button();
            this.btnNegativoComDMA = new System.Windows.Forms.Button();
            this.btnNegativoSemDMA = new System.Windows.Forms.Button();
            this.btnEspelhoVerticalSemDMA = new System.Windows.Forms.Button();
            this.btnEspelhoVerticalComDMA = new System.Windows.Forms.Button();
            this.btnEspelhoHorizontalSemDMA = new System.Windows.Forms.Button();
            this.btnEspelhohorizontalcomDMA = new System.Windows.Forms.Button();
            this.btnSepararBsemDMA = new System.Windows.Forms.Button();
            this.btnPretoBrancoSemDMA = new System.Windows.Forms.Button();
            this.btnRotacao90SemDMA = new System.Windows.Forms.Button();
            this.btnInverteRcomBsemDMA = new System.Windows.Forms.Button();
            this.btnEspelhoDiagonalPrincipalSemDMA = new System.Windows.Forms.Button();
            this.btnDivisaoCentroSemDMA = new System.Windows.Forms.Button();
            this.btnPretoBrancoComDMA = new System.Windows.Forms.Button();
            this.btnInverteRcomBcomDMA = new System.Windows.Forms.Button();
            this.btnEspelhoDiagonalPrincipalComDMA = new System.Windows.Forms.Button();
            this.btnRotacao90ComDMA = new System.Windows.Forms.Button();
            this.btnSepararGsemDMA = new System.Windows.Forms.Button();
            this.btnSepararRsemDMA = new System.Windows.Forms.Button();
            this.btnSepararBcomDMA = new System.Windows.Forms.Button();
            this.btnSepararGcomDMA = new System.Windows.Forms.Button();
            this.btnSepararRcomDMA = new System.Windows.Forms.Button();
            this.btnDivisaoCentroComDMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(5, 6);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            this.pictBoxImg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg2.Location = new System.Drawing.Point(611, 6);
            this.pictBoxImg2.Name = "pictBoxImg2";
            this.pictBoxImg2.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg2.TabIndex = 105;
            this.pictBoxImg2.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(5, 512);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(112, 512);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLuminanciaSemDMA
            // 
            this.btnLuminanciaSemDMA.Location = new System.Drawing.Point(219, 512);
            this.btnLuminanciaSemDMA.Name = "btnLuminanciaSemDMA";
            this.btnLuminanciaSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnLuminanciaSemDMA.TabIndex = 108;
            this.btnLuminanciaSemDMA.Text = "Luminância sem DMA";
            this.btnLuminanciaSemDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaSemDMA.Click += new System.EventHandler(this.btnLuminanciaSemDMA_Click);
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(219, 541);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnLuminanciaComDMA.TabIndex = 109;
            this.btnLuminanciaComDMA.Text = "Luminância com DMA";
            this.btnLuminanciaComDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaComDMA.Click += new System.EventHandler(this.btnLuminanciaComDMA_Click);
            // 
            // btnNegativoComDMA
            // 
            this.btnNegativoComDMA.Location = new System.Drawing.Point(433, 541);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = true;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // btnNegativoSemDMA
            // 
            this.btnNegativoSemDMA.Location = new System.Drawing.Point(433, 512);
            this.btnNegativoSemDMA.Name = "btnNegativoSemDMA";
            this.btnNegativoSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnNegativoSemDMA.TabIndex = 110;
            this.btnNegativoSemDMA.Text = "Negativo sem DMA";
            this.btnNegativoSemDMA.UseVisualStyleBackColor = true;
            this.btnNegativoSemDMA.Click += new System.EventHandler(this.btnNegativoSemDMA_Click);
            // 
            // btnEspelhoVerticalSemDMA
            // 
            this.btnEspelhoVerticalSemDMA.Location = new System.Drawing.Point(219, 570);
            this.btnEspelhoVerticalSemDMA.Name = "btnEspelhoVerticalSemDMA";
            this.btnEspelhoVerticalSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnEspelhoVerticalSemDMA.TabIndex = 112;
            this.btnEspelhoVerticalSemDMA.Text = "Espelho vertical sem DMA";
            this.btnEspelhoVerticalSemDMA.UseVisualStyleBackColor = true;
            this.btnEspelhoVerticalSemDMA.Click += new System.EventHandler(this.btnEspelhoVertivalSemDMA_Click);
            // 
            // btnEspelhoVerticalComDMA
            // 
            this.btnEspelhoVerticalComDMA.Location = new System.Drawing.Point(219, 599);
            this.btnEspelhoVerticalComDMA.Name = "btnEspelhoVerticalComDMA";
            this.btnEspelhoVerticalComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnEspelhoVerticalComDMA.TabIndex = 113;
            this.btnEspelhoVerticalComDMA.Text = "Espelho vertical com DMA";
            this.btnEspelhoVerticalComDMA.UseVisualStyleBackColor = true;
            this.btnEspelhoVerticalComDMA.Click += new System.EventHandler(this.btnEspelhoVerticalComDMA_Click);
            // 
            // btnEspelhoHorizontalSemDMA
            // 
            this.btnEspelhoHorizontalSemDMA.Location = new System.Drawing.Point(433, 570);
            this.btnEspelhoHorizontalSemDMA.Name = "btnEspelhoHorizontalSemDMA";
            this.btnEspelhoHorizontalSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnEspelhoHorizontalSemDMA.TabIndex = 114;
            this.btnEspelhoHorizontalSemDMA.Text = "Espelho horizontal sem DMA";
            this.btnEspelhoHorizontalSemDMA.UseVisualStyleBackColor = true;
            this.btnEspelhoHorizontalSemDMA.Click += new System.EventHandler(this.btnEspelhoHorizontalSemDMA_Click);
            // 
            // btnEspelhohorizontalcomDMA
            // 
            this.btnEspelhohorizontalcomDMA.Location = new System.Drawing.Point(433, 599);
            this.btnEspelhohorizontalcomDMA.Name = "btnEspelhohorizontalcomDMA";
            this.btnEspelhohorizontalcomDMA.Size = new System.Drawing.Size(208, 23);
            this.btnEspelhohorizontalcomDMA.TabIndex = 115;
            this.btnEspelhohorizontalcomDMA.Text = "Espelho horizontal com DMA";
            this.btnEspelhohorizontalcomDMA.UseVisualStyleBackColor = true;
            this.btnEspelhohorizontalcomDMA.Click += new System.EventHandler(this.btnEspelhoHorizontalComDMA_Click);
            // 
            // btnSepararBsemDMA
            // 
            this.btnSepararBsemDMA.Location = new System.Drawing.Point(861, 512);
            this.btnSepararBsemDMA.Name = "btnSepararBsemDMA";
            this.btnSepararBsemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnSepararBsemDMA.TabIndex = 116;
            this.btnSepararBsemDMA.Text = "Separar canal B sem DMA";
            this.btnSepararBsemDMA.UseVisualStyleBackColor = true;
            this.btnSepararBsemDMA.Click += new System.EventHandler(this.btnSepararBsemDMA_Click);
            // 
            // btnPretoBrancoSemDMA
            // 
            this.btnPretoBrancoSemDMA.Location = new System.Drawing.Point(647, 570);
            this.btnPretoBrancoSemDMA.Name = "btnPretoBrancoSemDMA";
            this.btnPretoBrancoSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnPretoBrancoSemDMA.TabIndex = 117;
            this.btnPretoBrancoSemDMA.Text = "Preto e branco sem DMA";
            this.btnPretoBrancoSemDMA.UseVisualStyleBackColor = true;
            this.btnPretoBrancoSemDMA.Click += new System.EventHandler(this.btnPretoBrancoSemDMA_Click);
            // 
            // btnRotacao90SemDMA
            // 
            this.btnRotacao90SemDMA.Location = new System.Drawing.Point(647, 628);
            this.btnRotacao90SemDMA.Name = "btnRotacao90SemDMA";
            this.btnRotacao90SemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnRotacao90SemDMA.TabIndex = 118;
            this.btnRotacao90SemDMA.Text = "Rotação 90° sem DMA";
            this.btnRotacao90SemDMA.UseVisualStyleBackColor = true;
            this.btnRotacao90SemDMA.Click += new System.EventHandler(this.btnRotacao90SemDMA_Click);
            // 
            // btnInverteRcomBsemDMA
            // 
            this.btnInverteRcomBsemDMA.Location = new System.Drawing.Point(647, 512);
            this.btnInverteRcomBsemDMA.Name = "btnInverteRcomBsemDMA";
            this.btnInverteRcomBsemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnInverteRcomBsemDMA.TabIndex = 119;
            this.btnInverteRcomBsemDMA.Text = "Inverte R com B sem DMA";
            this.btnInverteRcomBsemDMA.UseVisualStyleBackColor = true;
            this.btnInverteRcomBsemDMA.Click += new System.EventHandler(this.btnInverteRcomBsemDMA_Click);
            // 
            // btnEspelhoDiagonalPrincipalSemDMA
            // 
            this.btnEspelhoDiagonalPrincipalSemDMA.Location = new System.Drawing.Point(219, 628);
            this.btnEspelhoDiagonalPrincipalSemDMA.Name = "btnEspelhoDiagonalPrincipalSemDMA";
            this.btnEspelhoDiagonalPrincipalSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnEspelhoDiagonalPrincipalSemDMA.TabIndex = 120;
            this.btnEspelhoDiagonalPrincipalSemDMA.Text = "Espelho diagonal principal sem DMA";
            this.btnEspelhoDiagonalPrincipalSemDMA.UseVisualStyleBackColor = true;
            this.btnEspelhoDiagonalPrincipalSemDMA.Click += new System.EventHandler(this.btnEspelhoDiagonalPrincipalSemDMA_Click);
            // 
            // btnDivisaoCentroSemDMA
            // 
            this.btnDivisaoCentroSemDMA.Location = new System.Drawing.Point(433, 628);
            this.btnDivisaoCentroSemDMA.Name = "btnDivisaoCentroSemDMA";
            this.btnDivisaoCentroSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnDivisaoCentroSemDMA.TabIndex = 121;
            this.btnDivisaoCentroSemDMA.Text = "Divisão centro sem DMA";
            this.btnDivisaoCentroSemDMA.UseVisualStyleBackColor = true;
            this.btnDivisaoCentroSemDMA.Click += new System.EventHandler(this.btnDivisaoCentroSemDMA_Click);
            // 
            // btnPretoBrancoComDMA
            // 
            this.btnPretoBrancoComDMA.Location = new System.Drawing.Point(647, 599);
            this.btnPretoBrancoComDMA.Name = "btnPretoBrancoComDMA";
            this.btnPretoBrancoComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnPretoBrancoComDMA.TabIndex = 122;
            this.btnPretoBrancoComDMA.Text = "Preto e branco com DMA";
            this.btnPretoBrancoComDMA.UseVisualStyleBackColor = true;
            this.btnPretoBrancoComDMA.Click += new System.EventHandler(this.btnPretoBrancoComDMA_Click);
            // 
            // btnInverteRcomBcomDMA
            // 
            this.btnInverteRcomBcomDMA.Location = new System.Drawing.Point(647, 541);
            this.btnInverteRcomBcomDMA.Name = "btnInverteRcomBcomDMA";
            this.btnInverteRcomBcomDMA.Size = new System.Drawing.Size(208, 23);
            this.btnInverteRcomBcomDMA.TabIndex = 123;
            this.btnInverteRcomBcomDMA.Text = "Inverte R com B com DMA";
            this.btnInverteRcomBcomDMA.UseVisualStyleBackColor = true;
            this.btnInverteRcomBcomDMA.Click += new System.EventHandler(this.btnInverteRcomBcomDMA_Click);
            // 
            // btnEspelhoDiagonalPrincipalComDMA
            // 
            this.btnEspelhoDiagonalPrincipalComDMA.Location = new System.Drawing.Point(219, 657);
            this.btnEspelhoDiagonalPrincipalComDMA.Name = "btnEspelhoDiagonalPrincipalComDMA";
            this.btnEspelhoDiagonalPrincipalComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnEspelhoDiagonalPrincipalComDMA.TabIndex = 124;
            this.btnEspelhoDiagonalPrincipalComDMA.Text = "Espelho diagonal principal com DMA";
            this.btnEspelhoDiagonalPrincipalComDMA.UseVisualStyleBackColor = true;
            this.btnEspelhoDiagonalPrincipalComDMA.Click += new System.EventHandler(this.btnEspelhoDiagonalPrincipalComDMA_Click);
            // 
            // btnRotacao90ComDMA
            // 
            this.btnRotacao90ComDMA.Location = new System.Drawing.Point(647, 657);
            this.btnRotacao90ComDMA.Name = "btnRotacao90ComDMA";
            this.btnRotacao90ComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnRotacao90ComDMA.TabIndex = 125;
            this.btnRotacao90ComDMA.Text = "Rotação 90° com DMA";
            this.btnRotacao90ComDMA.UseVisualStyleBackColor = true;
            this.btnRotacao90ComDMA.Click += new System.EventHandler(this.btnRotacao90ComDMA_Click);
            // 
            // btnSepararGsemDMA
            // 
            this.btnSepararGsemDMA.Location = new System.Drawing.Point(861, 570);
            this.btnSepararGsemDMA.Name = "btnSepararGsemDMA";
            this.btnSepararGsemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnSepararGsemDMA.TabIndex = 126;
            this.btnSepararGsemDMA.Text = "Separar canal G sem DMA";
            this.btnSepararGsemDMA.UseVisualStyleBackColor = true;
            this.btnSepararGsemDMA.Click += new System.EventHandler(this.btnSepararGsemDMA_Click);
            // 
            // btnSepararRsemDMA
            // 
            this.btnSepararRsemDMA.Location = new System.Drawing.Point(861, 628);
            this.btnSepararRsemDMA.Name = "btnSepararRsemDMA";
            this.btnSepararRsemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnSepararRsemDMA.TabIndex = 127;
            this.btnSepararRsemDMA.Text = "Separar canal R sem DMA";
            this.btnSepararRsemDMA.UseVisualStyleBackColor = true;
            this.btnSepararRsemDMA.Click += new System.EventHandler(this.btnSepararRsemDMA_Click);
            // 
            // btnSepararBcomDMA
            // 
            this.btnSepararBcomDMA.Location = new System.Drawing.Point(861, 541);
            this.btnSepararBcomDMA.Name = "btnSepararBcomDMA";
            this.btnSepararBcomDMA.Size = new System.Drawing.Size(208, 23);
            this.btnSepararBcomDMA.TabIndex = 128;
            this.btnSepararBcomDMA.Text = "Separar canal B com DMA";
            this.btnSepararBcomDMA.UseVisualStyleBackColor = true;
            this.btnSepararBcomDMA.Click += new System.EventHandler(this.btnSepararBcomDMA_Click);
            // 
            // btnSepararGcomDMA
            // 
            this.btnSepararGcomDMA.Location = new System.Drawing.Point(861, 599);
            this.btnSepararGcomDMA.Name = "btnSepararGcomDMA";
            this.btnSepararGcomDMA.Size = new System.Drawing.Size(208, 23);
            this.btnSepararGcomDMA.TabIndex = 129;
            this.btnSepararGcomDMA.Text = "Separar canal G com DMA";
            this.btnSepararGcomDMA.UseVisualStyleBackColor = true;
            this.btnSepararGcomDMA.Click += new System.EventHandler(this.btnSepararGcomDMA_Click);
            // 
            // btnSepararRcomDMA
            // 
            this.btnSepararRcomDMA.Location = new System.Drawing.Point(861, 657);
            this.btnSepararRcomDMA.Name = "btnSepararRcomDMA";
            this.btnSepararRcomDMA.Size = new System.Drawing.Size(208, 23);
            this.btnSepararRcomDMA.TabIndex = 130;
            this.btnSepararRcomDMA.Text = "Separar canal R com DMA";
            this.btnSepararRcomDMA.UseVisualStyleBackColor = true;
            this.btnSepararRcomDMA.Click += new System.EventHandler(this.btnSepararRcomDMA_Click);
            // 
            // btnDivisaoCentroComDMA
            // 
            this.btnDivisaoCentroComDMA.Location = new System.Drawing.Point(433, 657);
            this.btnDivisaoCentroComDMA.Name = "btnDivisaoCentroComDMA";
            this.btnDivisaoCentroComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnDivisaoCentroComDMA.TabIndex = 131;
            this.btnDivisaoCentroComDMA.Text = "Divisão centro com DMA";
            this.btnDivisaoCentroComDMA.UseVisualStyleBackColor = true;
            this.btnDivisaoCentroComDMA.Click += new System.EventHandler(this.btnDivisaoCentroComDMA_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 686);
            this.Controls.Add(this.btnDivisaoCentroComDMA);
            this.Controls.Add(this.btnSepararRcomDMA);
            this.Controls.Add(this.btnSepararGcomDMA);
            this.Controls.Add(this.btnSepararBcomDMA);
            this.Controls.Add(this.btnSepararRsemDMA);
            this.Controls.Add(this.btnSepararGsemDMA);
            this.Controls.Add(this.btnRotacao90ComDMA);
            this.Controls.Add(this.btnEspelhoDiagonalPrincipalComDMA);
            this.Controls.Add(this.btnInverteRcomBcomDMA);
            this.Controls.Add(this.btnPretoBrancoComDMA);
            this.Controls.Add(this.btnDivisaoCentroSemDMA);
            this.Controls.Add(this.btnEspelhoDiagonalPrincipalSemDMA);
            this.Controls.Add(this.btnInverteRcomBsemDMA);
            this.Controls.Add(this.btnRotacao90SemDMA);
            this.Controls.Add(this.btnPretoBrancoSemDMA);
            this.Controls.Add(this.btnSepararBsemDMA);
            this.Controls.Add(this.btnEspelhohorizontalcomDMA);
            this.Controls.Add(this.btnEspelhoHorizontalSemDMA);
            this.Controls.Add(this.btnEspelhoVerticalComDMA);
            this.Controls.Add(this.btnEspelhoVerticalSemDMA);
            this.Controls.Add(this.btnNegativoComDMA);
            this.Controls.Add(this.btnNegativoSemDMA);
            this.Controls.Add(this.btnLuminanciaComDMA);
            this.Controls.Add(this.btnLuminanciaSemDMA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg2);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLuminanciaSemDMA;
        private System.Windows.Forms.Button btnLuminanciaComDMA;
        private System.Windows.Forms.Button btnNegativoComDMA;
        private System.Windows.Forms.Button btnNegativoSemDMA;
        private System.Windows.Forms.Button btnEspelhoVerticalSemDMA;
        private System.Windows.Forms.Button btnEspelhoVerticalComDMA;
        private System.Windows.Forms.Button btnEspelhoHorizontalSemDMA;
        private System.Windows.Forms.Button btnEspelhohorizontalcomDMA;
        private System.Windows.Forms.Button btnSepararBsemDMA;
        private System.Windows.Forms.Button btnPretoBrancoSemDMA;
        private System.Windows.Forms.Button btnRotacao90SemDMA;
        private System.Windows.Forms.Button btnInverteRcomBsemDMA;
        private System.Windows.Forms.Button btnEspelhoDiagonalPrincipalSemDMA;
        private System.Windows.Forms.Button btnDivisaoCentroSemDMA;
        private System.Windows.Forms.Button btnPretoBrancoComDMA;
        private System.Windows.Forms.Button btnInverteRcomBcomDMA;
        private System.Windows.Forms.Button btnEspelhoDiagonalPrincipalComDMA;
        private System.Windows.Forms.Button btnRotacao90ComDMA;
        private System.Windows.Forms.Button btnSepararGsemDMA;
        private System.Windows.Forms.Button btnSepararRsemDMA;
        private System.Windows.Forms.Button btnSepararBcomDMA;
        private System.Windows.Forms.Button btnSepararGcomDMA;
        private System.Windows.Forms.Button btnSepararRcomDMA;
        private System.Windows.Forms.Button btnDivisaoCentroComDMA;
    }
}

