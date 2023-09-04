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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void bExponencial_Click(object sender, EventArgs e)
        {
            Exponencial exponencial = new Exponencial();
            exponencial.Show();
        }

        private void bUniforme_Click(object sender, EventArgs e)
        {
            Uniforme uniforme = new Uniforme();
            uniforme.Show();
        }

        private void bNormal_Click(object sender, EventArgs e)
        {
            Normal normal = new Normal();
            normal.Show();
        }
    }
}
