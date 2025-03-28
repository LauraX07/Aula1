using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1bi
{
    public partial class frmex2: Form
    {    
        double[] notas = new double[4];

        public frmex2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double media;
            int i;
            for (i=0; i<4; i++) {
                media += notas[i];
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            double nota;

            for (int i=0; i<4; i++) {
                nota = Convert.ToDouble(txtNota.Text);
                notas[i] = nota;
            }
        }
    }
}
