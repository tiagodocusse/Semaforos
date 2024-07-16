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
    public partial class CirclePanel : UserControl
    {
        public CirclePanel()
        {
            InitializeComponent();
        }

        private void CirclePanel_Load(object sender, EventArgs e)
        {

        }

        private void CirclePanel_Paint(object sender, PaintEventArgs e)
        {
            if (Ativo)
            {
                if (cor == TipoCor.Verde)
                    e.Graphics.FillEllipse(new SolidBrush(Color.SeaGreen), 0, 0, 48, 48);
                else if (cor == TipoCor.Amarelo)
                    e.Graphics.FillEllipse(new SolidBrush(Color.Goldenrod), 0, 0, 48, 48);
                else if (cor == TipoCor.Vermelho)
                    e.Graphics.FillEllipse(new SolidBrush(Color.PaleVioletRed), 0, 0, 48, 48);
            }
            else
            {
                if (cor == TipoCor.Verde)
                    e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(16, Color.SeaGreen)), 0, 0, 48, 48);
                else if (cor == TipoCor.Amarelo)
                    e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(16, Color.Goldenrod)), 0, 0, 48, 48);
                else if (cor == TipoCor.Vermelho)
                    e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(16, Color.PaleVioletRed)), 0, 0, 48, 48);
            }
        }

        public bool Ativo { get; set; } = false;

        private TipoCor cor = TipoCor.Vermelho;

        public TipoCor Cor
        {
            get
            {
                return cor;
            }
            set
            {
                cor = value;
                Refresh();
            }
        }


    }
}
