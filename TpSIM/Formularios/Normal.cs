using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpSIM.Formularios
{
    public partial class Normal : Form
    {
        double[] lista;
        double[] minMax = new double[2];
        double desviacion;

        public Normal()
        {
            InitializeComponent();
        }

        private bool verificarCantidadIngresada()
        {
            if (Convert.ToInt64(txtCantidad.Text) < 1000000)
            {
                return true;
            }
            else { return false; }
        }

        private bool verificarEntradas()
        {
            if (!double.TryParse(txtMedia.Text, out double resultado1))
            {
                MessageBox.Show("Ingrese correctamente el parametro Cantidad");
                return false;
            }

            if (!double.TryParse(txtVarianza.Text, out double resultado2) || resultado2 <= 0)
            {
                MessageBox.Show("Ingrese correctamente el parametro Varianza");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int resultado3) || resultado3 <= 0)
            {
                MessageBox.Show("Ingrese correctamente la cantidad de variables aleatorias");
                return false;
            }
            return true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCantidadIngresada())
                {
                    if (verificarEntradas())
                    {
                        Random random = new Random();
                        int cantidad = int.Parse(txtCantidad.Text);
                        double media = double.Parse(txtMedia.Text);
                        desviacion = (double)double.Parse(Math.Sqrt(double.Parse(txtVarianza.Text)).ToString());
                        lista = new double[cantidad];

                        grilla.Rows.Clear();

                        //Box-Muller

                        // se generan los primeros dos random para Box-Muller
                        double random1 = random.NextDouble();
                        double random2 = random.NextDouble();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (i % 2 == 0)
                            {
                                string n1s = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Cos(2 * Math.PI * random2) * desviacion + media).ToString(); //Genera un nuemero con distribucion normal usando la 1ra formula de box-muller
                                double n1 = (double)Math.Round(double.Parse(n1s), 4);
                                lista[i] = n1; //Inserta el numero generado de la distribucionen la lista

                                // se obtiene los valores minimos y maximos generados para Chi
                                if (i == 0)
                                {
                                    minMax[0] = n1;
                                    minMax[1] = n1;
                                }
                                else
                                {
                                    if (n1 < minMax[0]) minMax[0] = n1;
                                    if (n1 > minMax[1]) minMax[1] = n1;
                                }

                                grilla.Rows.Add(i + 1, Math.Round(random1, 4) + "  -  " + Math.Round(random2, 4), n1);
                            }
                            else
                            {
                                string n2s = (Math.Sqrt(-2 * Math.Log(random1)) * Math.Sin(2 * Math.PI * random2) * desviacion + media).ToString(); //Genera otro nuemero con distribucion normal usando la 2da formula de box-muller
                                double n2 = (double)Math.Round(double.Parse(n2s), 4);
                                lista[i] = n2; //Inserta el numero generado de la distribucion en en la lista

                                // se obtiene los valores minimos y maximos generados para Chi
                                if (i == 0)
                                {
                                    minMax[0] = n2;
                                    minMax[1] = n2;
                                }
                                else
                                {
                                    if (n2 < minMax[0]) minMax[0] = n2;
                                    if (n2 > minMax[1]) minMax[1] = n2;
                                }

                                grilla.Rows.Add(i + 1, Math.Round(random1, 4) + "  -  " + Math.Round(random2, 4), n2);

                                // Genera los siguientes dos numeros rnd que se usaran para la distribucion normal con box-muller
                                random1 = random.NextDouble();
                                random2 = random.NextDouble();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad ingresada mayor a la permitida, ingrese un valor menor a 1.000.000");
                    txtCantidad.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar los numeros aleatorios con distribucion normal. - "+ex.Message);
            }
            
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolverG grafico = new btnVolverG(lista);
                grafico.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al migrar al grafico de distribucion normal. - " + ex.Message);
            }
        }


        // los métodos "KeyPress" sirven solo para que el usuario no ingrese letras o simbolos
        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar doubles
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVarianza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar doublees
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar doublees
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
