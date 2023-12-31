﻿using System;
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
    public partial class Uniforme : Form
    {
        double[] lista;
        double[] minMax = new double[2];

        public Uniforme()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarCantidadIngresada())
                {
                    double nroRandom = 0;
                    if (verificarEntradas())
                    {
                        Random rand = new Random();
                        int cantidad = int.Parse(txtCantidad.Text);
                        lista = new double[cantidad]; //Crea una lista con la cantidad de numeros que se van a generar

                        grilla.Rows.Clear();
                        for (int i = 0; i < cantidad; i++)
                        {
                            int limiteA = int.Parse(txtLimiteA.Text);
                            int limiteB = int.Parse(txtLimiteB.Text);
                            nroRandom = Math.Round(rand.NextDouble(), 4); // Genera un numero random que se utilizara para generar una distribucion uniforme
                            double x = (double)(limiteA + nroRandom * (limiteB - limiteA)); // Genera un numero aleatorio con distribucion uniforme usando la formula 𝑋 = 𝐴 + 𝑅𝑁𝐷(𝐵 − 𝐴)
                            x = (double)Math.Round(x, 4);

                            lista[i] = x;
                            grilla.Rows.Add(i + 1, nroRandom, x); // Agrega una fila a la grilla con los valores de la iteracion, RND y el valor de la ditribusion uniforme
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

                MessageBox.Show("Error al generar los numeros aleatorios con distribucion uniforme. -" + ex.Message);
            }
            
        }

        private bool verificarCantidadIngresada() // controla que la cantidad de numeros aleatorios a crear no superen los 1.000.000
        {
            if (Convert.ToInt64(txtCantidad.Text) < 1000000)
            {
                return true;
            }
            else { return false; }
        }

        private bool verificarEntradas() //Controla que los datos ingresados por el usuario sean los correctos
        {
            if (!double.TryParse(txtLimiteA.Text, out double resultado1))
            {
                MessageBox.Show("Ingrese correctamente el Limite A");
                return false;
            }

            if (!double.TryParse(txtLimiteB.Text, out double resultado2))
            {
                MessageBox.Show("Ingrese correctamente el Limite B");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int resultado3) || resultado3 <= 0)
            {
                MessageBox.Show("Ingrese correctamente la cantidad de variables aleatorias");
                return false;
            }

            int A = int.Parse(txtLimiteA.Text);
            int B = int.Parse(txtLimiteB.Text);

            if (A >= B)
            {
                MessageBox.Show("El valor de A tiene que ser menor y distinto al valor de B");
                return false;
            }

            if (A == 0 && B == 1)
            {
                MessageBox.Show("Los valores A y B no pueden ser 0 y 1 respectivamente");
                return false;
            }
            // se obtiene de los valores generados el minimos y maximos que se usaran para Chi
            //minMax[0] = A;
            //minMax[1] = B;
            return true;
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
                MessageBox.Show("Error al migrar al grafico de distribucion uniforme. - "+ex.Message);
            }
            
        }


        // los métodos "KeyPress" sirven solo para que el usuario no ingrese letras o simbolos
        private void txtLimiteA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar floats
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLimiteB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar floats
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

            // solo permite un punto para representar floats
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
