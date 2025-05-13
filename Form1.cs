using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraErika
{
    public partial class Form1 : Form
    {

        // — Estado interno —
        private double _primerOperando = 0;
        private string _operador = "";
        private bool _nuevaEntrada = true;
        private bool _shiftActivo = false;
        private bool _usarRadianes = true;
        private int _currentBase = 10;

        public Form1()
        {
            InitializeComponent();

            // Inicializo el menú de Convert (grados/radianes)
            var itemRad = new ToolStripMenuItem("Radianes") { Checked = true };
            var itemDeg = new ToolStripMenuItem("Grados");
            itemRad.Click += (s, e) => CambiarModoAngulos(true, itemRad, itemDeg);
            itemDeg.Click += (s, e) => CambiarModoAngulos(false, itemRad, itemDeg);
            contextMenuStrip1.Items.Add(itemRad);
            contextMenuStrip1.Items.Add(itemDeg);

            cmbInputBase.Items.AddRange(new object[] {
                new { Name = "Decimal (10)", Value = 10 },
                new { Name = "Hexadecimal (16)", Value = 16 },
                new { Name = "Binario (2)", Value = 2 }
            });
            cmbInputBase.DisplayMember = "Name";
            cmbInputBase.ValueMember = "Value";
            cmbInputBase.SelectedValue = 10;  // por defecto decimal

        }

        private void CambiarModoAngulos(bool radianes, ToolStripMenuItem rad, ToolStripMenuItem deg)
        {
            _usarRadianes = radianes;
            rad.Checked = radianes;
            deg.Checked = !radianes;
        }

        private void EscribirDigito(string d)
        {
            if (_nuevaEntrada || textBoxResult.Text == "0")
            {
                textBoxResult.Text = d;
                _nuevaEntrada = false;
            }
            else
            {
                textBoxResult.Text += d;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Show(this.btnConvert, new Point(0, this.btnConvert.Height));
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            AplicarUnaria(x => Math.Log(x));
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            _primerOperando = 0;
            _operador = "";
            _nuevaEntrada = true;
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            _shiftActivo = !_shiftActivo;
            btnSin.Text = _shiftActivo ? "Sin⁻¹" : "Sin";
            btnCos.Text = _shiftActivo ? "Cos⁻¹" : "Cos";
            btnTan.Text = _shiftActivo ? "Tan⁻¹" : "Tan";
        }

        private void AplicarUnaria(Func<double, double> f)
        {
            double x = double.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);
            double res = f(x);
            textBoxResult.Text = res.ToString();
            _nuevaEntrada = true;
        }

        private void AplicarTrig(Func<double, double> directo, Func<double, double> inverso)
        {
            // 1) parsear con invariant, asume punto decimal:
            double x = double.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);

            double res;

            if (!_shiftActivo)
            {
                // — función directa —
                double inputParaTrig = _usarRadianes
                    ? x
                    : (x * Math.PI / 180.0);   // grados→radianes

                res = directo(inputParaTrig);
            }
            else
            {
                // — función inversa —
                // asin, acos, atan esperan ratio→devuelven radianes
                double anguloRad = inverso(x);

                res = _usarRadianes
                    ? anguloRad
                    : (anguloRad * 180.0 / Math.PI);  // radianes→grados
            }

            // 3) mostrar con invariant (usa punto)
            textBoxResult.Text = res
                .ToString("G", CultureInfo.InvariantCulture);

            _nuevaEntrada = true;
        }

        private double ConvertirSiGrados(double v)
        {
            return _usarRadianes? v : v* Math.PI / 180.0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Si ya estamos en una nueva entrada o solo queda un carácter,
            // reseteamos a "0". Si no, quitamos el último carácter con Substring:
            if (!_nuevaEntrada && textBoxResult.Text.Length > 1)
                textBoxResult.Text = textBoxResult.Text.Substring(
                                         0,
                                         textBoxResult.Text.Length - 1
                                     );
            else
                textBoxResult.Text = "0";
        }

        private void btnSquare2_Click(object sender, EventArgs e)
        {
            AplicarUnaria(x => Math.Sqrt(x));
        }

        private void btnLogX_Click(object sender, EventArgs e)
        {
            AplicarUnaria(x => Math.Log10(x));
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            AplicarUnaria(x => Math.Exp(x));
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            PrepararOperador("÷");
        }

        private void btnPow3_Click(object sender, EventArgs e)
        {
            AplicarUnaria(x => Math.Pow(x, 3));
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EscribirDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EscribirDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EscribirDigito("9");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PrepararOperador("X");
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            AplicarTrig(Math.Sin, Math.Asin);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EscribirDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EscribirDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EscribirDigito("6");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            PrepararOperador("-");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            AplicarTrig(Math.Cos, Math.Acos);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EscribirDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EscribirDigito("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EscribirDigito("3");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            PrepararOperador("+");
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            AplicarTrig(Math.Tan, Math.Atan);
        }

        private void btnInvertSign_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textBoxResult.Text, CultureInfo.InvariantCulture) * -1;
            textBoxResult.Text = val.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EscribirDigito("0");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (_nuevaEntrada)
            {
                textBoxResult.Text = "0.";
                _nuevaEntrada = false;
            }
            else if (!textBoxResult.Text.Contains("."))
            {
                textBoxResult.Text += ".";
            }

        }

        private void PrepararOperador(string op)
        {
            _primerOperando = double.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);
            _operador = op;
            _nuevaEntrada = true;
        }

        private void bntEquals_Click(object sender, EventArgs e)
        {
            double segundo = double.Parse(textBoxResult.Text, CultureInfo.InvariantCulture);
            double resultado;

            switch (_operador)
            {
                case "+":
                    resultado = _primerOperando + segundo;
                    break;
                case "-":
                    resultado = _primerOperando - segundo;
                    break;
                case "X":
                    resultado = _primerOperando * segundo;
                    break;
                case "÷":
                    resultado = _primerOperando / segundo;
                    break;
                default:
                    resultado = segundo;
                    break;
            }
            Console.WriteLine($"Primer operando: {_primerOperando}");
            Console.WriteLine($"Segundo operando: {segundo}");
            // Print the result on console
            Console.WriteLine($"Resultado: {resultado}");

            textBoxResult.Text = resultado.ToString("G", CultureInfo.InvariantCulture);
            _nuevaEntrada = true;
        }

        private void btnPorc_Click(object sender, EventArgs e)
        {
            AplicarUnaria(x => (_primerOperando * x) / 100.0);
        }

        private void hexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long val = ParseCurrentAsLong();
            textBoxResult.Text = val.ToString("X");  // muestra en hex
            _nuevaEntrada = true;
        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long val = ParseCurrentAsLong();
            textBoxResult.Text = Convert.ToString(val, 2);  // muestra en binario
            _nuevaEntrada = true;
        }

        private void decimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long val = ParseCurrentAsLong();
            textBoxResult.Text = val.ToString(CultureInfo.InvariantCulture);  // de vuelta a decimal
            _nuevaEntrada = true;
        }

        private long ParseCurrentAsLong()
        {

            string txt = textBoxResult.Text.Trim();

            // Averiguar la base de entrada leyendo SelectedItem.Value
            int baseOrigen = 10;            
            if (cmbInputBase.SelectedItem != null)
            {
                dynamic sel = cmbInputBase.SelectedItem;
                try
                {
                    baseOrigen = (int)sel.Value;
                }
                catch
                {
                    baseOrigen = 10;
                }
            }

            long val;
            switch (baseOrigen)
            {
                case 16:
                    if (txt.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                        txt = txt.Substring(2);
                    val = Convert.ToInt64(txt, 16);
                    break;

                case 2:
                    val = Convert.ToInt64(txt, 2);
                    break;

                default: // decimal
                    if (txt.Contains("."))
                        txt = txt.Substring(0, txt.IndexOf(".", StringComparison.Ordinal));
                    val = long.Parse(txt, CultureInfo.InvariantCulture);
                    break;
            }

            return val;

        }
    }
}
