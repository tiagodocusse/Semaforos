namespace Semaforos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int tempoVerde = 20;
        private int tempoVermelho = 10;
        private int tempoAmarelo = 2;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            contadorRegressivo1.Valor = (int)numericUpDown1.Value;
            tempoVerde = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tempoAmarelo = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            tempoVermelho = (int)numericUpDown3.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio = !Inicio;

            numericUpDown1.Enabled = !Inicio;
            numericUpDown2.Enabled = !Inicio;
            numericUpDown3.Enabled = !Inicio;

            checkBox1.Enabled = !Inicio;
            checkBox2.Enabled = !Inicio;
            checkBox3.Enabled = !Inicio;

            if (Inicio)
            {
                timerAmarelo.Stop();
                timerVermelho.Stop();
                timerVerde.Start();
                contadorRegressivo1.Tipo = TipoPainel.Siga;
                AcenderLuz(TipoCor.Verde);
            }
            else
            {
                contadorRegressivo1.Tipo = TipoPainel.Siga;
                AcenderLuz(TipoCor.Nenhuma);

                timerAmarelo.Stop();
                timerVermelho.Stop();
                timerVerde.Stop();

                contadorRegressivo1.Valor = (int)numericUpDown1.Value;
                tempoVerde = (int)numericUpDown1.Value;
                tempoAmarelo = (int)numericUpDown2.Value;
                tempoVermelho = (int)numericUpDown3.Value;
            }
        }

        private void AcenderLuz(TipoCor tipo)
        {

            luzVerde.Ativo = false;
            luzAmarela.Ativo = false;
            luzVermelha.Ativo = false;

            switch (tipo)
            {
                case TipoCor.Amarelo:
                    luzAmarela.Ativo = true;
                    break;
                case TipoCor.Vermelho:
                    luzVermelha.Ativo = true;
                    break;
                case TipoCor.Verde:
                    luzVerde.Ativo = true;
                    break;
            }

            luzVerde.Refresh();
            luzAmarela.Refresh();
            luzVermelha.Refresh();
        }

        private bool Inicio = false;

        private void timerVerde_Tick(object sender, EventArgs e)
        {
            if (contadorRegressivo1.Valor > 1)
            {
                contadorRegressivo1.Valor--;
            }
            else
            {
                contadorRegressivo1.Tipo = TipoPainel.Amarelo;
                contadorRegressivo1.Valor = tempoAmarelo;

                AcenderLuz(TipoCor.Amarelo);

                timerVerde.Stop();
                timerAmarelo.Start();
            }
        }

        private void timerAmarelo_Tick(object sender, EventArgs e)
        {
            if (contadorRegressivo1.Valor > 1)
            {
                contadorRegressivo1.Valor--;
            }
            else
            {
                contadorRegressivo1.Tipo = TipoPainel.Pare;
                contadorRegressivo1.Valor = tempoVermelho;

                AcenderLuz(TipoCor.Vermelho);
                timerAmarelo.Stop();
                timerVermelho.Start();
            }
        }

        private void timerVermelho_Tick(object sender, EventArgs e)
        {
            if (contadorRegressivo1.Valor > 1)
            {
                contadorRegressivo1.Valor--;
            }
            else
            {
                contadorRegressivo1.Tipo = TipoPainel.Siga;
                contadorRegressivo1.Valor = tempoVerde;

                AcenderLuz(TipoCor.Verde);
                timerVermelho.Stop();
                timerVerde.Start();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            contadorRegressivo1.ExibirVerde = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            contadorRegressivo1.ExibirVermelho = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            contadorRegressivo1.ExibirAmarelo = checkBox3.Checked;
        }
    }
}
