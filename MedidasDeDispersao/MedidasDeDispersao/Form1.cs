using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedidasDeDispersao {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        List<double> numeros = new List<double>();

        bool calc = false;

        private void Calcular_Click(object sender, EventArgs e) {

            if (calc == false) {

                string aux = TextBox.Text.Trim();
                string[] txt = aux.Split(' ');

                foreach (string x in txt) {
                    numeros.Add(double.Parse(x));
                }

                numeros.Sort();

                StringBuilder sb = new StringBuilder();
                foreach (double x in numeros) {
                    sb.Append(x.ToString() + " ");
                }
                TextBox.Text = sb.ToString();

                lblAmplitude.Text = Amplitude(numeros);

                lblVariancia.Text = Variancia(numeros);

                lblDesvio.Text = Desvio(lblVariancia);

                lblCoeficiente.Text = Coeficiente(lblDesvio, numeros);
                calc = true;
            }
            else {
                numeros.Clear();
                calc = false;
            }
        }

        private string Amplitude(List<double> num) {
            double max = num.Max();
            double min = num.Min();
            double res = max - min;
            return res.ToString() ;
        }
        
        private string Variancia(List<double> num) {
            
            double soma = num.Sum();
            double somaQ = num.Sum(x => x * x);

            double qtd = num.Count();

            double res = (somaQ - ((soma * soma) / qtd)) / (qtd - 1);
            
            return res.ToString("F4");
        }
    
        private string Desvio(Label lbl) {

            double res = Math.Sqrt(double.Parse(lbl.Text));

            return res.ToString("F4");
        }

        private string Coeficiente(Label lbl, List<double> num) {

            double desvio = double.Parse(lbl.Text);
            double media = num.Sum() / num.Count();

            double res = (desvio / media) * 100;

            return res.ToString("F2") + "%";
        
        }

        private void button2_Click(object sender, EventArgs e) {
            MessageBox.Show("As amostras devem ser separadas por apenas um espaçamento\n" +
                "Apenas numeros e virgula devem ser digitados no campo\n" +
                "Ex: 1,3 3 2 6 7,6\n" +
                "Os numeros da amostra serão organizados em ROL automanticamente", "Instruções");
        }
    }
}
