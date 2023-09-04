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
    public partial class Exponencial : Form
    {
        decimal[] lista;
        decimal[] minMax = new decimal[2];
        decimal param;

        public Exponencial()
        {
            InitializeComponent();
        }

        enum Parametro
        {
            Lambda,
            Media,
            Varianza
        }

        private void Exponencial_Load(object sender, EventArgs e)
        {
            cmbParametro.Items.Add(Parametro.Lambda.ToString());
            cmbParametro.Items.Add(Parametro.Media.ToString());
            cmbParametro.Items.Add(Parametro.Varianza.ToString());
        }

        private bool verificarEntradas()
        {
            if (!double.TryParse(txtParametro.Text, out double resultado1))
            {
                MessageBox.Show("Ingrese correctamente el parametro");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int resultado2) || resultado2 <= 0)
            {
                MessageBox.Show("Ingrese correctamente la cantidad de variables aleatorias");
                return false;
            }
            return true;
        }

        private double completarExponencial(double numero) //Calcula el valor de Lambda
        {
            double lambda;
            if (cmbParametro.Text == Parametro.Lambda.ToString())
            {
                lambda = numero;
            }
            else if (cmbParametro.Text == Parametro.Media.ToString())
            {
                lambda = 1 / numero;
            }
            else
            {
                lambda = Math.Pow(1 / Math.Sqrt(numero), 2);
            }
            param = (decimal)lambda;
            return lambda;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            double nroRandom = 0;

            if (verificarEntradas())
            {
                Random rand = new Random();
                int cantidad = int.Parse(txtCantidad.Text);
                double lambda = completarExponencial(double.Parse(txtParametro.Text));
                lista = new decimal[cantidad];
                grilla.Rows.Clear();

                for (int i = 0; i < cantidad; i++)
                {
                    nroRandom = Math.Round(rand.NextDouble(), 4); // genera un numero RND para calcular el de la distribucion
                    decimal xTxt = (decimal)(-(1 / lambda) * Math.Log(1 - nroRandom));  // Genera un numero con distribucion exponencial negativa

                    xTxt = decimal.Round(xTxt, 4);

                    lista[i] = xTxt;

                    // se obtiene de los valores generados el minimos y maximos que se usaran para Chi
                    if (i == 0)
                    {
                        minMax[0] = xTxt;
                        minMax[1] = xTxt;
                    }
                    else
                    {
                        if (xTxt < minMax[0]) minMax[0] = xTxt;
                        if (xTxt > minMax[1]) minMax[1] = xTxt;
                    }

                    grilla.Rows.Add(i + 1, nroRandom, xTxt); // carga a la grilla los valores de la iteracion, el RND usado y el valor generado de la distribucion exponencial
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Grafico grafico = new Grafico(lista);
            grafico.Show();
        }

        

        // los métodos "KeyPress" sirven solo para que el usuario no ingrese letras o simbolos
        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto para representar decimales
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

            // solo permite un punto para representar decimales
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
