namespace Semaforos
{
    partial class ContadorRegressivo
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
            dssEsquerdo = new DisplaySeteSegmentos();
            dssDireito = new DisplaySeteSegmentos();
            SuspendLayout();
            // 
            // dssEsquerdo
            // 
            dssEsquerdo.BackColor = Color.Transparent;
            dssEsquerdo.CorFundo = Color.Transparent;
            dssEsquerdo.CorPare = Color.Crimson;
            dssEsquerdo.CorSiga = Color.ForestGreen;
            dssEsquerdo.Location = new Point(0, 0);
            dssEsquerdo.Name = "dssEsquerdo";
            dssEsquerdo.Size = new Size(95, 134);
            dssEsquerdo.TabIndex = 0;
            dssEsquerdo.Tipo = TipoPainel.Siga;
            dssEsquerdo.Valor = null;
            // 
            // dssDireito
            // 
            dssDireito.BackColor = Color.Transparent;
            dssDireito.CorFundo = Color.Transparent;
            dssDireito.CorPare = Color.Crimson;
            dssDireito.CorSiga = Color.ForestGreen;
            dssDireito.Location = new Point(95, 0);
            dssDireito.Name = "dssDireito";
            dssDireito.Size = new Size(95, 134);
            dssDireito.TabIndex = 0;
            dssDireito.Tipo = TipoPainel.Siga;
            dssDireito.Valor = null;
            // 
            // ContadorRegressivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(dssDireito);
            Controls.Add(dssEsquerdo);
            Margin = new Padding(0);
            Name = "ContadorRegressivo";
            Size = new Size(190, 134);
            ResumeLayout(false);
        }

        #endregion

        private DisplaySeteSegmentos dssEsquerdo;
        private DisplaySeteSegmentos dssDireito;
    }
}
