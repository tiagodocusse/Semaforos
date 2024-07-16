namespace Semaforos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contadorRegressivo1 = new ContadorRegressivo();
            luzVermelha = new CirclePanel();
            luzAmarela = new CirclePanel();
            luzVerde = new CirclePanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            button1 = new Button();
            timerVerde = new System.Windows.Forms.Timer(components);
            timerAmarelo = new System.Windows.Forms.Timer(components);
            timerVermelho = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // contadorRegressivo1
            // 
            contadorRegressivo1.BackColor = Color.Transparent;
            contadorRegressivo1.ExibirVerde = true;
            contadorRegressivo1.ExibirVermelho = true;
            contadorRegressivo1.Location = new Point(21, 23);
            contadorRegressivo1.Margin = new Padding(0);
            contadorRegressivo1.Name = "contadorRegressivo1";
            contadorRegressivo1.Size = new Size(190, 134);
            contadorRegressivo1.TabIndex = 0;
            contadorRegressivo1.Tipo = TipoPainel.Siga;
            contadorRegressivo1.Valor = 20;
            // 
            // luzVermelha
            // 
            luzVermelha.Ativo = false;
            luzVermelha.BackColor = Color.Transparent;
            luzVermelha.Cor = TipoCor.Vermelho;
            luzVermelha.Location = new Point(237, 9);
            luzVermelha.Margin = new Padding(0);
            luzVermelha.Name = "luzVermelha";
            luzVermelha.Size = new Size(48, 48);
            luzVermelha.TabIndex = 1;
            // 
            // luzAmarela
            // 
            luzAmarela.Ativo = false;
            luzAmarela.BackColor = Color.Transparent;
            luzAmarela.Cor = TipoCor.Amarelo;
            luzAmarela.Location = new Point(237, 59);
            luzAmarela.Margin = new Padding(0);
            luzAmarela.Name = "luzAmarela";
            luzAmarela.Size = new Size(48, 48);
            luzAmarela.TabIndex = 1;
            // 
            // luzVerde
            // 
            luzVerde.Ativo = false;
            luzVerde.BackColor = Color.Transparent;
            luzVerde.Cor = TipoCor.Verde;
            luzVerde.Location = new Point(237, 109);
            luzVerde.Margin = new Padding(0);
            luzVerde.Name = "luzVerde";
            luzVerde.Size = new Size(48, 48);
            luzVerde.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(314, 9);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Contar no Verde";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(314, 34);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(132, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Contar no Vermelho";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 67);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Tempo de Siga";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(432, 59);
            numericUpDown1.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 96);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 3;
            label2.Text = "Tempo de Amarelo";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(432, 88);
            numericUpDown2.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(71, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 125);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 3;
            label3.Text = "Tempo de Vermelho";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(432, 117);
            numericUpDown3.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(71, 23);
            numericUpDown3.TabIndex = 4;
            numericUpDown3.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(59, 160);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 5;
            button1.Text = "Iniciar / Parar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timerVerde
            // 
            timerVerde.Interval = 1000;
            timerVerde.Tick += timerVerde_Tick;
            // 
            // timerAmarelo
            // 
            timerAmarelo.Interval = 2000;
            timerAmarelo.Tick += timerAmarelo_Tick;
            // 
            // timerVermelho
            // 
            timerVermelho.Interval = 1000;
            timerVermelho.Tick += timerVermelho_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(512, 193);
            Controls.Add(button1);
            Controls.Add(numericUpDown3);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(luzVerde);
            Controls.Add(luzAmarela);
            Controls.Add(luzVermelha);
            Controls.Add(contadorRegressivo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Semáforos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContadorRegressivo contadorRegressivo1;
        private CirclePanel luzVermelha;
        private CirclePanel luzAmarela;
        private CirclePanel luzVerde;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private Button button1;
        private System.Windows.Forms.Timer timerVerde;
        private System.Windows.Forms.Timer timerAmarelo;
        private System.Windows.Forms.Timer timerVermelho;
    }
}
