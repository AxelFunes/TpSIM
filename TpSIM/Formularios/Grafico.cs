using System;
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
        double[] listaLocal;

        public btnVolverG(double[] lista)
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

        private int cantidadIntervalos() // seleccion de los intervalos por el combo-box
        {
            int num;


            if (rb10.Checked)
            {
                num = 10;
            }
            else if (rb15.Checked)
            {
                num = 15;
            }
            else if (rb20.Checked)
            {
                num = 20;
            }
            else
            {
                num = 25;
            }

            return num;
        }

        private bool verificarSeleccion() //controla las cantidades de intervalos
        {

            if (rb10.Checked || rb15.Checked || rb20.Checked || rb25.Checked)

            {
                return true;
            }
            else return false;
        }

        private int[] asignarIntervalos(double[] minMax, int cantIntervalos) // recorre la lista local y cuenta la aparición de los numeros en los intervalos desde hasta (FO)
        {
            int[] posiciones = new int[cantIntervalos];
            //DESCOMENTARIZAR en caso el -1
            double intervalo = Math.Round(((minMax[1] - minMax[0]) / (double)(cantIntervalos)),4); //Calcula la separacion que habra entre cada intervalo, ancho
            //double intervalo = (minMax[1] - minMax[0]) / (cantIntervalos -1); //Calcula la distancia que habra entre cada intervalo (desde - hasta)
            double intervaloMax = minMax[0] + intervalo;
            double intervaloMin = minMax[0];
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
        
        private double[] buscarMinMax() // busca los valores minimo y maximo respectivamente de la lista local
        {
            double[] resultados = new double[2];
            double min = listaLocal[0];
            double max = listaLocal[0];

            for (int i = 0; i < listaLocal.Length; i++)
            {
                if (listaLocal[i] > max && listaLocal[i] != double.PositiveInfinity) //controla que el valor en la lista sea distinto de infinito positivo
                {
                    max = listaLocal[i];
                }
                if (listaLocal[i] < min)
                {
                    min = listaLocal[i];
                }
            }

            resultados[0] = min;
            resultados[1] = max;
            return resultados;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        { labelFO.Visible = true;
          labelInt.Visible = true;


            if (verificarSeleccion())
            {
                
                graficoValores.Series.Clear(); // limpia el grafico
                tablaFrecuencias.Rows.Clear(); // limpia tabla de frecuencias observadas
                graficoValores.Series.Add("Valores");

                graficoValores.Series[0].SetCustomProperty("PointWidth", "1");//ancho de columnas
                graficoValores.Series[0].BorderColor = Color.Black;
                double[] minMax = buscarMinMax(); // llama a la funcion para buscarl los vlores minimos y maximo de la lista local

                int cantIntervalos = cantidadIntervalos(); // devuelve el valor del combo que se a seleccionado
                double intervalo = (minMax[1] - minMax[0]) / (double)cantIntervalos; //distncia entre intervalos
                int[] valores = asignarIntervalos(minMax, cantIntervalos); // Devuelve la aparicion de los valores de la lista en los intervalos (desde - hasta) que se muetran en la leyenda del grafico

                for (int i = 0; i < cantIntervalos; i++)
                {
                    double minimo = (double)Math.Round(minMax[0] + (i * Math.Abs(intervalo)), 4); // valor minimo de la lista local
                    double maximo = (double)Math.Round(minMax[0] + ((i + 1) * Math.Abs(intervalo)), 4); // valor max de la lista local
                    string nombreIntervalo = (i + 1).ToString() + ": " + (minimo).ToString() + "-" + (maximo).ToString(); // cadena que se va a utilizar para cargar en el grafico
                    graficoValores.Series.Add(nombreIntervalo); //Crea los valores de la leyenda del grafico
                    graficoValores.Series[0].Points.AddXY((double)(i + 1), valores[i]); //Asigna los valores del eje x (Intervalos) e y (apricion de los numeros en los intervalos) al grafico 
                    tablaFrecuencias.Rows.Add(nombreIntervalo, (valores[i])); // asigna rango de intervalos y los valores de frecuencia observada en cada intervalo

                }
                
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
