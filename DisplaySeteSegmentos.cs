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
    public partial class DisplaySeteSegmentos : UserControl
    {
        public DisplaySeteSegmentos()
        {
            InitializeComponent();
        }


        private void DisplaySeteSegmentos_Load(object sender, EventArgs e)
        {

        }

        private int? valor = null;

        public TipoPainel Tipo { get; set; }

        public Color CorFundo
        {
            get
            {
                return BackColor;
            }
            set
            {
                BackColor = value;
            }
        }

        public Color CorSiga { get; set; } = Color.ForestGreen;

        public Color CorPare { get; set; } = Color.Crimson;

        public int? Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;

                Desativar(dataTop);
                Desativar(dataMiddle);
                Desativar(dataBottom);
                Desativar(dataLeftTop);
                Desativar(dataLeftBottom);
                Desativar(dataRightTop);
                Desativar(dataRightBottom);
                Desativar(dataBottom);

                if(valor == null)
                {
                    Ativar(dataMiddle);
                }

                else if (valor == 0)
                {
                    Ativar(dataTop);
                    Ativar(dataLeftTop);
                    Ativar(dataLeftBottom);
                    Ativar(dataRightTop);
                    Ativar(dataRightBottom);
                    Ativar(dataBottom);
                }
                else if (valor == 1)
                {
                    Ativar(dataRightTop);
                    Ativar(dataRightBottom);
                }
                else if (valor == 2)
                {
                    Ativar(dataTop);
                    Ativar(dataMiddle);
                    Ativar(dataBottom);
                    Ativar(dataLeftBottom);
                    Ativar(dataRightTop);
                    Ativar(dataBottom);
                }
                else if (valor == 3)
                {
                    Ativar(dataTop);
                    Ativar(dataMiddle);
                    Ativar(dataBottom);
                    Ativar(dataRightTop);
                    Ativar(dataRightBottom);
                    Ativar(dataBottom);
                }
                else if (valor == 4)
                {
                    Ativar(dataMiddle);
                    Ativar(dataLeftTop);
                    Ativar(dataRightBottom);
                    Ativar(dataRightTop);
                }
                else if (valor == 5)
                {
                    Ativar(dataTop);
                    Ativar(dataMiddle);
                    Ativar(dataBottom);
                    Ativar(dataLeftTop);
                    Ativar(dataRightBottom);
                    Ativar(dataBottom);
                }
                else if (valor == 6)
                {
                    Ativar(dataTop);
                    Ativar(dataMiddle);
                    Ativar(dataBottom);
                    Ativar(dataLeftTop);
                    Ativar(dataLeftBottom);
                    Ativar(dataRightBottom);
                    Ativar(dataBottom);
                }
                else if (valor == 7)
                {
                    Ativar(dataTop);
                    Ativar(dataRightTop);
                    Ativar(dataRightBottom);
                }
                else if (valor == 8)
                {
                    Ativar(dataTop);
                    Ativar(dataMiddle);
                    Ativar(dataBottom);
                    Ativar(dataLeftTop);
                    Ativar(dataLeftBottom);
                    Ativar(dataRightTop);
                    Ativar(dataRightBottom);
                    Ativar(dataBottom);
                }
                else if (valor == 9)
                {
                    Ativar(dataTop);
                    Ativar(dataMiddle);
                    Ativar(dataBottom);
                    Ativar(dataLeftTop);
                    Ativar(dataRightBottom);
                    Ativar(dataRightTop);
                }
            }
        }

        private void Ativar(Panel data)
        {
            if (Tipo == TipoPainel.Siga)
                data.BackColor = CorSiga;
            else if (Tipo == TipoPainel.Pare)
                data.BackColor = CorPare;
            else if (Tipo == TipoPainel.Amarelo)
                data.BackColor = Color.Goldenrod;
            else
                Desativar(data);
        }

        private void Desativar(Panel data)
        {
            data.BackColor = Color.Transparent;
        }
    }
}
