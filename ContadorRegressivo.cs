using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforos
{
    public partial class ContadorRegressivo : UserControl
    {
        public ContadorRegressivo()
        {
            InitializeComponent();
        }

        private int valor = 0;

        private TipoPainel tipo = TipoPainel.Siga;

        public TipoPainel Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
                dssEsquerdo.Tipo = value;
                dssDireito.Tipo = value;
            }
        }

        public bool ExibirVerde { get; set; } = true;
        public bool ExibirVermelho { get; set; } = true;
        public bool ExibirAmarelo { get; set; } = false;

        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;

                if(Tipo == TipoPainel.Siga)
                {
                    if(valor >= 0 && ExibirVerde)
                    {
                        int leftDigit = (int)(valor / 10);
                        int rightDigit = valor - leftDigit * 10;

                        dssEsquerdo.Valor = leftDigit;
                        dssDireito.Valor = rightDigit;
                    }
                    else
                    {
                        dssEsquerdo.Valor = null;
                        dssDireito.Valor = null;
                    }
                }
                else if(Tipo == TipoPainel.Pare)
                {
                    if (valor >= 0 && ExibirVermelho)
                    {
                        int leftDigit = (int)(valor / 10);
                        int rightDigit = valor - leftDigit * 10;

                        dssEsquerdo.Valor = leftDigit;
                        dssDireito.Valor = rightDigit;
                    }
                    else
                    {
                        dssEsquerdo.Valor = null;
                        dssDireito.Valor = null;
                    }
                }
                else if(Tipo == TipoPainel.Amarelo)
                {
                    if (valor >= 0 && ExibirAmarelo)
                    {
                        int leftDigit = (int)(valor / 10);
                        int rightDigit = valor - leftDigit * 10;

                        dssEsquerdo.Valor = leftDigit;
                        dssDireito.Valor = rightDigit;
                    }
                    else
                    {
                        dssEsquerdo.Valor = null;
                        dssDireito.Valor = null;
                    }
                }
            }
        }
    }
}
