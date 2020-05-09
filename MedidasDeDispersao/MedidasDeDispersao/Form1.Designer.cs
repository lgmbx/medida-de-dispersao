namespace MedidasDeDispersao {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.lblVariancia = new System.Windows.Forms.Label();
            this.lblDesvio = new System.Windows.Forms.Label();
            this.lblCoeficiente = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(306, 82);
            this.TextBox.TabIndex = 0;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(324, 12);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(71, 46);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amplitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variância:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desvio padrão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coeficiente:";
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Location = new System.Drawing.Point(68, 109);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(0, 13);
            this.lblAmplitude.TabIndex = 6;
            // 
            // lblVariancia
            // 
            this.lblVariancia.AutoSize = true;
            this.lblVariancia.Location = new System.Drawing.Point(68, 140);
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(0, 13);
            this.lblVariancia.TabIndex = 7;
            // 
            // lblDesvio
            // 
            this.lblDesvio.AutoSize = true;
            this.lblDesvio.Location = new System.Drawing.Point(315, 109);
            this.lblDesvio.Name = "lblDesvio";
            this.lblDesvio.Size = new System.Drawing.Size(0, 13);
            this.lblDesvio.TabIndex = 8;
            // 
            // lblCoeficiente
            // 
            this.lblCoeficiente.AutoSize = true;
            this.lblCoeficiente.Location = new System.Drawing.Point(299, 140);
            this.lblCoeficiente.Name = "lblCoeficiente";
            this.lblCoeficiente.Size = new System.Drawing.Size(0, 13);
            this.lblCoeficiente.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ajuda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCoeficiente);
            this.Controls.Add(this.lblDesvio);
            this.Controls.Add(this.lblVariancia);
            this.Controls.Add(this.lblAmplitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.TextBox);
            this.MaximumSize = new System.Drawing.Size(420, 210);
            this.MinimumSize = new System.Drawing.Size(420, 210);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medida de dispersão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.Label lblVariancia;
        private System.Windows.Forms.Label lblDesvio;
        private System.Windows.Forms.Label lblCoeficiente;
        private System.Windows.Forms.Button button2;
    }
}

