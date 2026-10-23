namespace HelloWindowsForms
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
            label1 = new Label();
            label2 = new Label();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            label3 = new Label();
            lblResultado = new Label();
            txtPeso = new TextBox();
            lblInterpretacao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(280, 36);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Calcular IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(216, 102);
            label2.Name = "label2";
            label2.Size = new Size(84, 37);
            label2.TabIndex = 2;
            label2.Text = "Peso:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(369, 159);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(140, 27);
            txtAltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(367, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(143, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(216, 149);
            label3.Name = "label3";
            label3.Size = new Size(104, 37);
            label3.TabIndex = 6;
            label3.Text = "Altura:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblResultado.Location = new Point(263, 259);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(145, 37);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(370, 112);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(140, 27);
            txtPeso.TabIndex = 8;
            // 
            // lblInterpretacao
            // 
            lblInterpretacao.AutoSize = true;
            lblInterpretacao.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblInterpretacao.Location = new Point(263, 315);
            lblInterpretacao.Name = "lblInterpretacao";
            lblInterpretacao.Size = new Size(293, 37);
            lblInterpretacao.TabIndex = 9;
            lblInterpretacao.Text = "Interpretação do IMC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 385);
            Controls.Add(lblInterpretacao);
            Controls.Add(txtPeso);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label label3;
        private Label lblResultado;
        private TextBox txtPeso;
        private Label lblInterpretacao;
    }
}
