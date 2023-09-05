﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TpSIM.Formularios
{
    public partial class btnVolverG : Form
    {
        float[] listaLocal;

        public btnVolverG(float[] lista)
        {
            InitializeComponent();
            listaLocal = lista;
            rellenarLista();
            graficoValores.Series[0].Label = "Valores";
        }

        private void rellenarLista() //Carga la grilla con los valores de la lista y su repectivo indice (oreden de generacion)
        {
            int longitud = listaLocal.Length;
            for (int i = 0; i < longitud; i++)
            {
                grilla.Rows.Add(i + 1, listaLocal[i]);
            }
        }

        private int cantidadIntervalos() // seleccion de los intervalor por el combo-box
        {
            int num;

            if (rb25.Checked)
            {
                num = 25;
            }
            else if (rb10.Checked)
            {
                num = 10;
            }
            else if (rb15.Checked)
            {
                num = 15;
            }
            else
            {
                num = 20;
            }

            return num;
        }

        private bool verificarSeleccion()
        {
            if (rb25.Checked || rb10.Checked || rb15.Checked || rb20.Checked)
            {
                return true;
            }
            else return false;
        }

        private int[] asignarIntervalos(float[] minMax, int cantIntervalos) // recorre la lista local y cuenta la aparición de los nuemros en los intervalos desde hasta
        {
            int[] posiciones = new int[cantIntervalos];
            //DESCOMENTARIZAR en caso el -1
            float intervalo = (minMax[1] - minMax[0]) / (cantIntervalos); //Calcula la separacion que habra entre cada intervalo
            //float intervalo = (minMax[1] - minMax[0]) / (cantIntervalos -1); //Calcula la distancia que habra entre cada intervalo (desde - hasta)
            float intervaloMax = minMax[0] + intervalo;
            float intervaloMin = minMax[0];
            for (int i = 0; i < cantIntervalos; i++)
            {
                for (int j = 0; j < listaLocal.Length; j++)
                {
                    if (listaLocal[j] < intervaloMax && listaLocal[j] >= intervaloMin)
                    {
                        posiciones[i] += 1;
                    }
                }
                intervaloMin = intervaloMax;
                intervaloMax = intervaloMax + intervalo;
            }
            return posiciones;
        }

        private float[] buscarMinMax() // busca los vaclores minimo y maximo respectivamente de la lista local
        {
            float[] resultados = new float[2];
            float min = listaLocal.Min();
            float max = listaLocal.Max();

            //for (int i = 0; i < listaLocal.Length; i++)
            //{
            //    if (listaLocal[i] > max)
            //    {
            //        max = listaLocal[i];
            //    }
            //    if (listaLocal[i] < min)
            //    {
            //        min = listaLocal[i];
            //    }
            //}

            resultados[0] = min;
            resultados[1] = max;
            return resultados;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (verificarSeleccion())
            {
                
                graficoValores.Series.Clear(); // limpia el grafico
                tablaFrecuencias.Rows.Clear(); // limpia tabla de frecuencias observadas
                graficoValores.Series.Add("Valores");
                graficoValores.Series[0].SetCustomProperty("PointWidth", "1");
                
                graficoValores.Series[0].BorderColor = Color.Black;
                float[] minMax = buscarMinMax(); // llama a la funcion para buscarl los vlores minimos y maximo de la lista local
                int cantIntervalos = cantidadIntervalos(); // devuelve el valor del combo que se a seleccionado
                float intervalo = (minMax[1] - minMax[0]) / (cantIntervalos - 1); //distncia entre intervalos
                int[] valores = asignarIntervalos(minMax, cantIntervalos); // Devuelve la aparicion de los valores de la lista en los intervalos (desde - hasta) que se muetran en la leyenda del grafico

                for (int i = 0; i < cantIntervalos; i++)
                {
                    float min = (float)Math.Round(minMax[0] + (i * intervalo), 4); // valor minimo de la lista local
                    float max = (float)Math.Round(minMax[0] + ((i + 1) * intervalo), 4); // calor max de la lista local
                    string nombreIntervalo = (i + 1).ToString() + ": " + (min).ToString() + "-" + (max).ToString();
                    graficoValores.Series.Add(nombreIntervalo); //Crea los valores de la leyenda del grafico
                    graficoValores.Series[0].Points.AddXY((double)(i + 1), (double)valores[i]); //Asigna los valores del eje x (Intervalos) e y (apricion de los numeros en los intervalos) al grafico 
                    tablaFrecuencias.Rows.Add(nombreIntervalo, (double)(valores[i])); // asigna rango de intervalos y los valores de frecuencia observada en cada intervalo
                }

            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void Grafico_Load(object sender, EventArgs e)
        //{

        //}
    }
}
