namespace Semaforos
{
    partial class DisplaySeteSegmentos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataTop = new Panel();
            dataLeftTop = new Panel();
            dataRightTop = new Panel();
            dataRightBottom = new Panel();
            dataLeftBottom = new Panel();
            dataMiddle = new Panel();
            dataBottom = new Panel();
            SuspendLayout();
            // 
            // dataTop
            // 
            dataTop.Location = new Point(16, 3);
            dataTop.Name = "dataTop";
            dataTop.Size = new Size(64, 12);
            dataTop.TabIndex = 0;
            // 
            // dataLeftTop
            // 
            dataLeftTop.Location = new Point(3, 3);
            dataLeftTop.Name = "dataLeftTop";
            dataLeftTop.Size = new Size(12, 64);
            dataLeftTop.TabIndex = 3;
            // 
            // dataRightTop
            // 
            dataRightTop.Location = new Point(81, 3);
            dataRightTop.Name = "dataRightTop";
            dataRightTop.Size = new Size(12, 64);
            dataRightTop.TabIndex = 4;
            // 
            // dataRightBottom
            // 
            dataRightBottom.Location = new Point(81, 68);
            dataRightBottom.Name = "dataRightBottom";
            dataRightBottom.Size = new Size(12, 64);
            dataRightBottom.TabIndex = 7;
            // 
            // dataLeftBottom
            // 
            dataLeftBottom.Location = new Point(3, 68);
            dataLeftBottom.Name = "dataLeftBottom";
            dataLeftBottom.Size = new Size(12, 64);
            dataLeftBottom.TabIndex = 6;
            // 
            // dataMiddle
            // 
            dataMiddle.Location = new Point(16, 61);
            dataMiddle.Name = "dataMiddle";
            dataMiddle.Size = new Size(64, 12);
            dataMiddle.TabIndex = 1;
            // 
            // dataBottom
            // 
            dataBottom.Location = new Point(16, 120);
            dataBottom.Name = "dataBottom";
            dataBottom.Size = new Size(64, 12);
            dataBottom.TabIndex = 2;
            // 
            // DisplaySeteSegmentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataBottom);
            Controls.Add(dataMiddle);
            Controls.Add(dataRightBottom);
            Controls.Add(dataRightTop);
            Controls.Add(dataLeftBottom);
            Controls.Add(dataLeftTop);
            Controls.Add(dataTop);
            Name = "DisplaySeteSegmentos";
            Size = new Size(95, 134);
            Load += DisplaySeteSegmentos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel dataTop;
        private Panel dataLeftTop;
        private Panel dataRightTop;
        private Panel dataRightBottom;
        private Panel dataLeftBottom;
        private Panel dataMiddle;
        private Panel dataBottom;
    }
}
