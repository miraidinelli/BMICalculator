namespace Calculadora_IMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbIMC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura (m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso (Kg)";
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(83, 30);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(64, 23);
            this.txbAltura.TabIndex = 2;
            this.txbAltura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(83, 66);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(64, 23);
            this.txbPeso.TabIndex = 3;
            // 
            // txbIMC
            // 
            this.txbIMC.Location = new System.Drawing.Point(192, 49);
            this.txbIMC.Name = "txbIMC";
            this.txbIMC.ReadOnly = true;
            this.txbIMC.Size = new System.Drawing.Size(100, 23);
            this.txbIMC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "IMC";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(153, 49);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(30, 23);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "=";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 123);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbIMC);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbAltura;
        private TextBox txbPeso;
        private TextBox txbIMC;
        private Label label3;
        private Button btnCalculo;
    }
}