using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga
{
    public partial class Form1 : Form
    {
        Tortuga a = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLevantarPluma_Click(object sender, EventArgs e)
        {
            a.levantarPluma();
        }

        private void btnBajarPluma_Click(object sender, EventArgs e)
        {
            a.bajarPluma();
        }

        private void btnGirarDerecha_Click(object sender, EventArgs e)
        {
            a.girarDer();
        }

        private void btnGirarIzquierda_Click(object sender, EventArgs e)
        {
            a.girarIzq();
        }

        private void btnAvanza_Click(object sender, EventArgs e)
        {
            int pasos = Convert.ToInt32(txtAvanza.Text);
            a.avanzar(pasos);
            txtAvanza.Clear();
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            txtResultado.Text = a.imprimir();
        }
    }
}
