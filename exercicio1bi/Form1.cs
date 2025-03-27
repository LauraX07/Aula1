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
    public partial class frmex1 : Form
    {
        public frmex1()
        {
            InitializeComponent();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            int [] vetor = new int[15];
            int i, y;
            Random num = new Random();
            for (i = 0; i<15; i++)
            {              
                y = num.Next(1,100);
                vetor[i] = y;
            }
            for (i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                {
                    int x = vetor[i];
                    txtnota.Text = x.ToString()+"\t"+txtnota.Text + Environment.NewLine;
                }
            }

        }

        private void txtnota_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
